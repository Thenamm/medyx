// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_Truc
// Kieu doi tuong  :	Luong_Truc
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
	/// This is a base generated class of <see cref="Luong_Truc" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_Truc : BusinessBase<Luong_Truc>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _makhoa = String.Empty;
        private Decimal _ngayThuongHSCC = 0;
        private Decimal _donGiaNTHSCC = 0;
        private Decimal _TTNTHSCC = 0;

        private Decimal _ngayNghiHSCC = 0;
        private Decimal _donGiaNNHSCC = 0;
        private Decimal _TTNNHSCC = 0;

        private Decimal _ngayLeHSCC = 0;
        private Decimal _donGiaNLHSCC = 0;
        private Decimal _TTNLHSCC = 0;

        private Decimal _qCCTNBHSCC = 0;
        private Decimal _donGiaQCCTNBHSCC = 0;
        private Decimal _TTQCCTNBHSCC = 0;

        private Decimal _cocIHSCC = 0;
        private Decimal _donGiaCocIHSCC = 0;
        private Decimal _TTCocIHSCC = 0;

        private Decimal _cocIIHSCC = 0;
        private Decimal _donGiaCocIIHSCC = 0;
        private Decimal _TTCocIIHSCC = 0;

        private Decimal _dDHSCC = 0;
        private Decimal _donGiaDDHSCC = 0;
        private Decimal _TTDDHSCC = 0;

        private Decimal _nD1142002HSCC = 0;
        private Decimal _donGiaND1142002HSCC = 0;
        private Decimal _TTND1142002HSCC = 0;

        private Decimal _ngayThuongCM = 0;
        private Decimal _donGiaNTCM = 0;
        private Decimal _TTNTCM = 0;

        private Decimal _ngayNghiCM = 0;
        private Decimal _donGiaNNCM = 0;
        private Decimal _TTNNCM = 0;

        private Decimal _ngayLeCM = 0;
        private Decimal _donGiaNLCM = 0;
        private Decimal _TTNLCM = 0;

        private Decimal _qCCTNBCM = 0;
        private Decimal _donGiaQCCTNBCM = 0;
        private Decimal _TTQCCTNBCM = 0;

        private Decimal _cocICM = 0;
        private Decimal _donGiaCocICM = 0;
        private Decimal _TTCocICM = 0;

        private Decimal _cocIICM = 0;
        private Decimal _donGiaCocIICM = 0;
        private Decimal _TTCocIICM = 0;

        private Decimal _dDCM = 0;
        private Decimal _donGiaDDCM = 0;
        private Decimal _TTDDCM = 0;

        private Decimal _ngayThuongLD = 0;
        private Decimal _donGiaNTLD = 0;
        private Decimal _TTNTLD = 0;

        private Decimal _ngayNghiLD = 0;
        private Decimal _donGiaNNLD = 0;
        private Decimal _TTNNLD = 0;

        private Decimal _ngayLeLD = 0;
        private Decimal _donGiaNLLD = 0;
        private Decimal _TTNLLD = 0;

		private String _maMay = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private Boolean _huy = false;
        private Decimal _tong = 0;
        private Decimal _heso = 0;
        private String _hoten = String.Empty;
        private String _tenChuyenMon = String.Empty;
        private String _tenLoaiHD = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
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
        public String NgayThuongHSCC
        {
            get
            {
                CanReadProperty("NgayThuongHSCC", true);
                if (_ngayThuongHSCC == 0)
                {
                    return "";
                }
               
                else if (_ngayThuongHSCC - (int)(_ngayThuongHSCC) != 0)
                    return _ngayThuongHSCC.ToString("###,##0.##");
                else
                    return _ngayThuongHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayThuongHSCC", true);
                if (_ngayThuongHSCC.ToString() != value)
                {
                    if (value == "")
                        _ngayThuongHSCC = 0;
                    else
                        _ngayThuongHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayThuongHSCC");
                }
            }
        }

        public String DonGiaNTHSCC
        {
            get
            {
                CanReadProperty("DonGiaNTHSCC", true);
                if (_donGiaNTHSCC == 0)
                {
                    return "";
                }
                
                else if (_donGiaNTHSCC - (int)(_donGiaNTHSCC) != 0)
                    return _donGiaNTHSCC.ToString("###,##0.##");
                else
                    return _donGiaNTHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNTHSCC", true);
                if (_donGiaNTHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaNTHSCC = 0;
                    else
                        _donGiaNTHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTHSCC");
                }
            }
        }

        public String TTNTHSCC
        {
            get
            {
                CanReadProperty("TTNTHSCC", true);
                _TTNTHSCC = _ngayThuongHSCC * _donGiaNTHSCC;
                if (_TTNTHSCC == 0)
                {
                    return "";
                }
               
                else if (_TTNTHSCC - (int)(_TTNTHSCC) != 0)
                    return _TTNTHSCC.ToString("###,##0.##");
                else
                    return _TTNTHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTNTHSCC", true);
                if (_TTNTHSCC.ToString() != value)
                {
                    if (value == "")
                        _TTNTHSCC = 0;
                    else
                        _TTNTHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTNTHSCC");
                }
            }
        }

        public String NgayNghiHSCC
        {
            get
            {
                CanReadProperty("NgayNghiHSCC", true);
                if (_ngayNghiHSCC == 0)
                {
                    return "";
                }
                else if (_ngayNghiHSCC - (int)(_ngayNghiHSCC) != 0)
                    return _ngayNghiHSCC.ToString("###,##0.##");
                else
                    return _ngayNghiHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayNghiHSCC", true);
                if (_ngayNghiHSCC.ToString() != value)
                {
                    if (value == "")
                        _ngayNghiHSCC = 0;
                    else
                        _ngayNghiHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayNghiHSCC");
                }
            }
        }

        public String DonGiaNNHSCC
        {
            get
            {
                CanReadProperty("DonGiaNNHSCC", true);
                if (_donGiaNNHSCC == 0)
                {
                    return "";
                }
                else if (_donGiaNNHSCC - (int)(_donGiaNNHSCC) != 0)
                    return _donGiaNNHSCC.ToString("###,##0.##");
                else
                    return _donGiaNNHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNNHSCC", true);
                if (_donGiaNNHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaNNHSCC = 0;
                    else
                        _donGiaNNHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNNHSCC");
                }
            }
        }

        public String TTNNHSCC
        {
            get
            {
                CanReadProperty("TTNNHSCC", true);
                _TTNNHSCC = _ngayNghiHSCC * _donGiaNNHSCC;

                if (_TTNNHSCC == 0)
                {
                    return "";
                }
                else if (_TTNNHSCC - (int)(_TTNNHSCC) != 0)
                    return _TTNNHSCC.ToString("###,##0.##");
                else
                    return _TTNNHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTNNHSCC", true);
                if (_TTNNHSCC.ToString() != value)
                {
                    if (value == "")
                        _TTNNHSCC = 0;
                    else
                        _TTNNHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTNNHSCC");
                }
            }
        }

        public String NgayLeHSCC
        {
            get
            {
                CanReadProperty("NgayLeHSCC", true);
                if (_ngayLeHSCC == 0)
                {
                    return "";
                }
                else if (_ngayLeHSCC - (int)(_ngayLeHSCC) != 0)
                    return _ngayLeHSCC.ToString("###,##0.##");
                else
                    return _ngayLeHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayLeHSCC", true);
                if (_ngayLeHSCC.ToString() != value)
                {
                    if (value == "")
                        _ngayLeHSCC = 0;
                    else
                        _ngayLeHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayLeHSCC");
                }
            }
        }

        public String DonGiaNLHSCC
        {
            get
            {
                CanReadProperty("DonGiaNLHSCC", true);
                if (_donGiaNLHSCC == 0)
                {
                    return "";
                }
                else if (_donGiaNLHSCC - (int)(_donGiaNLHSCC) != 0)
                    return _donGiaNLHSCC.ToString("###,##0.##");
                else
                    return _donGiaNLHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNLHSCC", true);
                if (_donGiaNLHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaNLHSCC = 0;
                    else
                        _donGiaNLHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNLHSCC");
                }
            }
        }

        public String TTNLHSCC
        {
            get
            {
                CanReadProperty("TTNLHSCC", true);
                _TTNLHSCC = _ngayLeHSCC * _donGiaNLHSCC;

                if (_TTNLHSCC == 0)
                {
                    return "";
                }
                else if (_TTNLHSCC - (int)(_TTNLHSCC) != 0)
                    return _TTNLHSCC.ToString("###,##0.##");
                else
                    return _TTNLHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTNLHSCC", true);
                if (_TTNLHSCC.ToString() != value)
                {
                    if (value == "")
                        _TTNLHSCC = 0;
                    else
                        _TTNLHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTNLHSCC");
                }
            }
        }

        public String QCCTNBHSCC
        {
            get
            {
                CanReadProperty("QCCTNBHSCC", true);
                if (_qCCTNBHSCC == 0)
                {
                    return "";
                }
                else if (_qCCTNBHSCC - (int)(_qCCTNBHSCC) != 0)
                    return _qCCTNBHSCC.ToString("###,##0.##");
                else
                    return _qCCTNBHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("QCCTNBHSCC", true);
                if (_qCCTNBHSCC.ToString() != value)
                {
                    if (value == "")
                        _qCCTNBHSCC = 0;
                    else
                        _qCCTNBHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("QCCTNBHSCC");
                }
            }
        }

        public String DonGiaQCCTNBHSCC
        {
            get
            {
                CanReadProperty("DonGiaQCCTNBHSCC", true);
                if (_donGiaQCCTNBHSCC == 0)
                {
                    return "";
                }
                else if (_donGiaQCCTNBHSCC - (int)(_donGiaQCCTNBHSCC) != 0)
                    return _donGiaQCCTNBHSCC.ToString("###,##0.##");
                else
                    return _donGiaQCCTNBHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaQCCTNBHSCC", true);
                if (_donGiaQCCTNBHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaQCCTNBHSCC = 0;
                    else
                        _donGiaQCCTNBHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaQCCTNBHSCC");
                }
            }
        }

        public String TTQCCTNBHSCC
        {
            get
            {
                CanReadProperty("TTQCCTNBHSCC", true);
                _TTQCCTNBHSCC = _qCCTNBHSCC * _donGiaQCCTNBHSCC;

                if (_TTQCCTNBHSCC == 0)
                {
                    return "";
                }
                else if (_TTQCCTNBHSCC - (int)(_TTQCCTNBHSCC) != 0)
                    return _TTQCCTNBHSCC.ToString("###,##0.##");
                else
                    return _TTQCCTNBHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTQCCTNBHSCC", true);
                if (_TTQCCTNBHSCC.ToString() != value)
                {
                    if (value == "")
                        _TTQCCTNBHSCC = 0;
                    else
                        _TTQCCTNBHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTQCCTNBHSCC");
                }
            }
        }

        public String CocIHSCC
        {
            get
            {
                CanReadProperty("CocIHSCC", true);
                if (_cocIHSCC == 0)
                {
                    return "";
                }
                else if (_cocIHSCC - (int)(_cocIHSCC) != 0)
                    return _cocIHSCC.ToString("###,##0.##");
                else
                    return _cocIHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("CocIHSCC", true);
                if (_cocIHSCC.ToString() != value)
                {
                    if (value == "")
                        _cocIHSCC = 0;
                    else
                        _cocIHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CocIHSCC");
                }
            }
        }

        public String DonGiaCocIHSCC
        {
            get
            {
                CanReadProperty("DonGiaCocIHSCC", true);
                if (_donGiaCocIHSCC == 0)
                {
                    return "";
                }
                else if (_donGiaCocIHSCC - (int)(_donGiaCocIHSCC) != 0)
                    return _donGiaCocIHSCC.ToString("###,##0.##");
                else
                    return _donGiaCocIHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaCocIHSCC", true);
                if (_donGiaCocIHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaCocIHSCC = 0;
                    else
                        _donGiaCocIHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaCocIHSCC");
                }
            }
        }

        public String TTCocIHSCC
        {
            get
            {
                CanReadProperty("DonGiaCocIHSCC", true);
                _TTCocIHSCC = _cocIHSCC * _donGiaCocIHSCC;

                if (_TTCocIHSCC == 0)
                {
                    return "";
                }
                else if (_TTCocIHSCC - (int)(_TTCocIHSCC) != 0)
                    return _TTCocIHSCC.ToString("###,##0.##");
                else
                    return _TTCocIHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaCocIHSCC", true);
                if (_TTCocIHSCC.ToString() != value)
                {
                    if (value == "")
                        _TTCocIHSCC = 0;
                    else
                        _TTCocIHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaCocIHSCC");
                }
            }
        }

        public String CocIIHSCC
        {
            get
            {
                CanReadProperty("CocIIHSCC", true);
                if (_cocIIHSCC == 0)
                {
                    return "";
                }
                else if (_cocIIHSCC - (int)(_cocIIHSCC) != 0)
                    return _cocIIHSCC.ToString("###,##0.##");
                else
                    return _cocIIHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("CocIIHSCC", true);
                if (_cocIIHSCC.ToString() != value)
                {
                    if (value == "")
                        _cocIIHSCC = 0;
                    else
                        _cocIIHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CocIIHSCC");
                }
            }
        }

        public String DonGiaCocIIHSCC
        {
            get
            {
                CanReadProperty("DonGiaCocIIHSCC", true);
                if (_donGiaCocIIHSCC == 0)
                {
                    return "";
                }
                else if (_donGiaCocIIHSCC - (int)(_donGiaCocIIHSCC) != 0)
                    return _donGiaCocIIHSCC.ToString("###,##0.##");
                else
                    return _donGiaCocIIHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaCocIIHSCC", true);
                if (_donGiaCocIIHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaCocIIHSCC = 0;
                    else
                        _donGiaCocIIHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaCocIIHSCC");
                }
            }
        }

        public String TTCocIIHSCC
        {
            get
            {
                CanReadProperty("TTCocIIHSCC", true);
                _TTCocIIHSCC = _cocIIHSCC * _donGiaCocIIHSCC;

                if (_TTCocIIHSCC == 0)
                {
                    return "";
                }
                else if (_TTCocIIHSCC - (int)(_TTCocIIHSCC) != 0)
                    return _TTCocIIHSCC.ToString("###,##0.##");
                else
                    return _TTCocIIHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTCocIIHSCC", true);
                if (_TTCocIIHSCC.ToString() != value)
                {
                    if (value == "")
                        _TTCocIIHSCC = 0;
                    else
                        _TTCocIIHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTCocIIHSCC");
                }
            }
        }

        public String DDHSCC
        {
            get
            {
                CanReadProperty("DDHSCC", true);
                if (_dDHSCC == 0)
                {
                    return "";
                }
                else if (_dDHSCC - (int)(_dDHSCC) != 0)
                    return _dDHSCC.ToString("###,##0.##");
                else
                    return _dDHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DDHSCC", true);
                if (_dDHSCC.ToString() != value)
                {
                    if (value == "")
                        _dDHSCC = 0;
                    else
                        _dDHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DDHSCC");
                }
            }
        }

        public String DonGiaDDHSCC
        {
            get
            {
                CanReadProperty("DonGiaDDHSCC", true);
                if (_donGiaDDHSCC == 0)
                {
                    return "";
                }
                else if (_donGiaDDHSCC - (int)(_donGiaDDHSCC) != 0)
                    return _donGiaDDHSCC.ToString("###,##0.##");
                else
                    return _donGiaDDHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaDDHSCC", true);
                if (_donGiaDDHSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaDDHSCC = 0;
                    else
                        _donGiaDDHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaDDHSCC");
                }
            }
        }

        public String TTDDHSCC
        {
            get
            {
                CanReadProperty("TTDDHSCC", true);
                _TTDDHSCC = _dDHSCC * _donGiaDDHSCC;

                if (_TTDDHSCC == 0)
                {
                    return "";
                }
                else if (_TTDDHSCC - (int)(_TTDDHSCC) != 0)
                    return _TTDDHSCC.ToString("###,##0.##");
                else
                    return _TTDDHSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTDDHSCC", true);
                if (_TTDDHSCC.ToString() != value)
                {
                    if (value == "")
                        _TTDDHSCC = 0;
                    else
                        _TTDDHSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTDDHSCC");
                }
            }
        }

        public String ND1142002HSCC
        {
            get
            {
                CanReadProperty("ND1142002HSCC", true);
                if (_nD1142002HSCC == 0)
                {
                    return "";
                }
                else if (_nD1142002HSCC - (int)(_nD1142002HSCC) != 0)
                    return _nD1142002HSCC.ToString("###,##0.##");
                else
                    return _nD1142002HSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("ND1142002HSCC", true);
                if (_nD1142002HSCC.ToString() != value)
                {
                    if (value == "")
                        _nD1142002HSCC = 0;
                    else
                        _nD1142002HSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("ND1142002HSCC");
                }
            }
        }

        public String DonGiaND1142002HSCC
        {
            get
            {
                CanReadProperty("DonGiaND1142002HSCC", true);
                if (_donGiaND1142002HSCC == 0)
                {
                    return "";
                }
                else if (_donGiaND1142002HSCC - (int)(_donGiaND1142002HSCC) != 0)
                    return _donGiaND1142002HSCC.ToString("###,##0.##");
                else
                    return _donGiaND1142002HSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaND1142002HSCC", true);
                if (_donGiaND1142002HSCC.ToString() != value)
                {
                    if (value == "")
                        _donGiaND1142002HSCC = 0;
                    else
                        _donGiaND1142002HSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaND1142002HSCC");
                }
            }
        }

        public String TTND1142002HSCC
        {
            get
            {
                CanReadProperty("TTND1142002HSCC", true);
                _TTND1142002HSCC = _nD1142002HSCC * _donGiaND1142002HSCC;

                if (_TTND1142002HSCC == 0)
                {
                    return "";
                }
                else if (_TTND1142002HSCC - (int)(_TTND1142002HSCC) != 0)
                    return _TTND1142002HSCC.ToString("###,##0.##");
                else
                    return _TTND1142002HSCC.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTND1142002HSCC", true);
                if (_TTND1142002HSCC.ToString() != value)
                {
                    if (value == "")
                        _TTND1142002HSCC = 0;
                    else
                        _TTND1142002HSCC = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTND1142002HSCC");
                }
            }
        }

        public String NgayThuongCM
        {
            get
            {
                CanReadProperty("NgayThuongCM", true);
                if (_ngayThuongCM == 0)
                {
                    return "";
                }
                else if (_ngayThuongCM - (int)(_ngayThuongCM) != 0)
                    return _ngayThuongCM.ToString("###,##0.##");
                else
                    return _ngayThuongCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayThuongCM", true);
                if (_ngayThuongCM.ToString() != value)
                {
                    if (value == "")
                        _ngayThuongCM = 0;
                    else
                        _ngayThuongCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayThuongCM");
                }
            }
        }

        public String DonGiaNTCM
        {
            get
            {
                CanReadProperty("DonGiaNTCM", true);
                if (_donGiaNTCM == 0)
                {
                    return "";
                }
                else if (_donGiaNTCM - (int)(_donGiaNTCM) != 0)
                    return _donGiaNTCM.ToString("###,##0.##");
                else
                    return _donGiaNTCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNTCM", true);
                if (_donGiaNTCM.ToString() != value)
                {
                    if (value == "")
                        _donGiaNTCM = 0;
                    else
                        _donGiaNTCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTCM");
                }
            }
        }

        public String TTNTCM
        {
            get
            {
                CanReadProperty("TTNTCM", true);
                _TTNTCM = _ngayThuongCM * _donGiaNTCM;

                if (_TTNTCM == 0)
                {
                    return "";
                }
                else if (_TTNTCM - (int)(_TTNTCM) != 0)
                    return _TTNTCM.ToString("###,##0.##");
                else
                    return _TTNTCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTNTCM", true);
                if (_TTNTCM.ToString() != value)
                {
                    if (value == "")
                        _TTNTCM = 0;
                    else
                        _TTNTCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTNTCM");
                }
            }
        }

        public String NgayNghiCM
        {
            get
            {
                CanReadProperty("NgayNghiCM", true);
                if (_ngayNghiCM == 0)
                {
                    return "";
                }
                else if (_ngayNghiCM - (int)(_ngayNghiCM) != 0)
                    return _ngayNghiCM.ToString("###,##0.##");
                else
                    return _ngayNghiCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayNghiCM", true);
                if (_ngayNghiCM.ToString() != value)
                {
                    if (value == "")
                        _ngayNghiCM = 0;
                    else
                        _ngayNghiCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayNghiCM");
                }
            }
        }

        public String DonGiaNNCM
        {
            get
            {
                CanReadProperty("DonGiaNNCM", true);
                if (_donGiaNNCM == 0)
                {
                    return "";
                }
                else if (_donGiaNNCM - (int)(_donGiaNNCM) != 0)
                    return _donGiaNNCM.ToString("###,##0.##");
                else
                    return _donGiaNNCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNNCM", true);
                if (_donGiaNNCM.ToString() != value)
                {
                    if (value == "")
                        _donGiaNNCM = 0;
                    else
                        _donGiaNNCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNNCM");
                }
            }
        }

        public String TTNNCM
        {
            get
            {
                CanReadProperty("TTNNCM", true);
                _TTNNCM = _ngayNghiCM * _donGiaNNCM;

                if (_TTNNCM == 0)
                {
                    return "";
                }
                else if (_TTNNCM - (int)(_TTNNCM) != 0)
                    return _TTNNCM.ToString("###,##0.##");
                else
                    return _TTNNCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTNNCM", true);
                if (_TTNNCM.ToString() != value)
                {
                    if (value == "")
                        _TTNNCM = 0;
                    else
                        _TTNNCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTNNCM");
                }
            }
        }

        public String NgayLeCM
        {
            get
            {
                CanReadProperty("NgayLeCM", true);
                if (_ngayLeCM == 0)
                {
                    return "";
                }
                else if (_ngayLeCM - (int)(_ngayLeCM) != 0)
                    return _ngayLeCM.ToString("###,##0.##");
                else
                    return _ngayLeCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayLeCM", true);
                if (_ngayLeCM.ToString() != value)
                {
                    if (value == "")
                        _ngayLeCM = 0;
                    else
                        _ngayLeCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayLeCM");
                }
            }
        }

        public String DonGiaNLCM
        {
            get
            {
                CanReadProperty("DonGiaNLCM", true);
                if (_donGiaNLCM == 0)
                {
                    return "";
                }
                else if (_donGiaNLCM - (int)(_donGiaNLCM) != 0)
                    return _donGiaNLCM.ToString("###,##0.##");
                else
                    return _donGiaNLCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNLCM", true);
                if (_donGiaNLCM.ToString() != value)
                {
                    if (value == "")
                        _donGiaNLCM = 0;
                    else
                        _donGiaNLCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNLCM");
                }
            }
        }

        public String TTNLCM
        {
            get
            {
                CanReadProperty("TTNLCM", true);
                _TTNLCM = _ngayLeCM * _donGiaNLCM;

                if (_TTNLCM == 0)
                {
                    return "";
                }
                else if (_TTNLCM - (int)(_TTNLCM) != 0)
                    return _TTNLCM.ToString("###,##0.##");
                else
                    return _TTNLCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTNLCM", true);
                if (_TTNLCM.ToString() != value)
                {
                    if (value == "")
                        _TTNLCM = 0;
                    else
                        _TTNLCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTNLCM");
                }
            }
        }

        public String QCCTNBCM
        {
            get
            {
                CanReadProperty("QCCTNBCM", true);
                if (_qCCTNBCM == 0)
                {
                    return "";
                }
                else if (_qCCTNBCM - (int)(_qCCTNBCM) != 0)
                    return _qCCTNBCM.ToString("###,##0.##");
                else
                    return _qCCTNBCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("QCCTNBCM", true);
                if (_qCCTNBCM.ToString() != value)
                {
                    if (value == "")
                        _qCCTNBCM = 0;
                    else
                        _qCCTNBCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("QCCTNBCM");
                }
            }
        }

        public String DonGiaQCCTNBCM
        {
            get
            {
                CanReadProperty("DonGiaQCCTNBCM", true);
                if (_donGiaQCCTNBCM == 0)
                {
                    return "";
                }
                else if (_donGiaQCCTNBCM - (int)(_donGiaQCCTNBCM) != 0)
                    return _donGiaQCCTNBCM.ToString("###,##0.##");
                else
                    return _donGiaQCCTNBCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaQCCTNBCM", true);
                if (_donGiaQCCTNBCM.ToString() != value)
                {
                    if (value == "")
                        _donGiaQCCTNBCM = 0;
                    else
                        _donGiaQCCTNBCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaQCCTNBCM");
                }
            }
        }

        public String TTQCCTNBCM
        {
            get
            {
                CanReadProperty("TTQCCTNBCM", true);
                _TTQCCTNBCM = _qCCTNBCM * _donGiaQCCTNBCM;

                if (_TTQCCTNBCM == 0)
                {
                    return "";
                }
                else if (_TTQCCTNBCM - (int)(_TTQCCTNBCM) != 0)
                    return _TTQCCTNBCM.ToString("###,##0.##");
                else
                    return _TTQCCTNBCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTQCCTNBCM", true);
                if (_TTQCCTNBCM.ToString() != value)
                {
                    if (value == "")
                        _TTQCCTNBCM = 0;
                    else
                        _TTQCCTNBCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTQCCTNBCM");
                }
            }
        }

        public String CocICM
        {
            get
            {
                CanReadProperty("CocICM", true);
                if (_cocICM == 0)
                {
                    return "";
                }
                else if (_cocICM - (int)(_cocICM) != 0)
                    return _cocICM.ToString("###,##0.##");
                else
                    return _cocICM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("CocICM", true);
                if (_cocICM.ToString() != value)
                {
                    if (value == "")
                        _cocICM = 0;
                    else
                        _cocICM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CocICM");
                }
            }
        }

        public String DonGiaCocICM
        {
            get
            {
                CanReadProperty("DonGiaCocICM", true);
                if (_donGiaCocICM == 0)
                {
                    return "";
                }
                else if (_donGiaCocICM - (int)(_donGiaCocICM) != 0)
                    return _donGiaCocICM.ToString("###,##0.##");
                else
                    return _donGiaCocICM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaCocICM", true);
                if (_donGiaCocICM.ToString() != value)
                {
                    if (value == "")
                        _donGiaCocICM = 0;
                    else
                        _donGiaCocICM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaCocICM");
                }
            }
        }

        public String TTCocICM
        {
            get
            {
                CanReadProperty("TTCocICM", true);
                _TTCocICM = _cocICM * _donGiaCocICM;

                if (_TTCocICM == 0)
                {
                    return "";
                }
                else if (_TTCocICM - (int)(_TTCocICM) != 0)
                    return _TTCocICM.ToString("###,##0.##");
                else
                    return _TTCocICM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTCocICM", true);
                if (_TTCocICM.ToString() != value)
                {
                    if (value == "")
                        _TTCocICM = 0;
                    else
                        _TTCocICM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTCocICM");
                }
            }
        }

        public String CocIICM
        {
            get
            {
                CanReadProperty("CocIICM", true);
                if (_cocIICM == 0)
                {
                    return "";
                }
                else if (_cocIICM - (int)(_cocIICM) != 0)
                    return _cocIICM.ToString("###,##0.##");
                else
                    return _cocIICM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("CocIICM", true);
                if (_cocIICM.ToString() != value)
                {
                    if (value == "")
                        _cocIICM = 0;
                    else
                        _cocIICM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("CocIICM");
                }
            }
        }

        public String DonGiaCocIICM
        {
            get
            {
                CanReadProperty("DonGiaCocIICM", true);
                if (_donGiaCocIICM == 0)
                {
                    return "";
                }
                else if (_donGiaCocIICM - (int)(_donGiaCocIICM) != 0)
                    return _donGiaCocIICM.ToString("###,##0.##");
                else
                    return _donGiaCocIICM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaCocIICM", true);
                if (_donGiaCocIICM.ToString() != value)
                {
                    if (value == "")
                        _donGiaCocIICM = 0;
                    else
                        _donGiaCocIICM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaCocIICM");
                }
            }
        }

        public String TTCocIICM
        {
            get
            {
                CanReadProperty("TTCocIICM", true);
                _TTCocIICM = _cocIICM * _donGiaCocIICM;

                if (_TTCocIICM == 0)
                {
                    return "";
                }
                else if (_TTCocIICM - (int)(_TTCocIICM) != 0)
                    return _TTCocIICM.ToString("###,##0.##");
                else
                    return _TTCocIICM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTCocIICM", true);
                if (_TTCocIICM.ToString() != value)
                {
                    if (value == "")
                        _TTCocIICM = 0;
                    else
                        _TTCocIICM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTCocIICM");
                }
            }
        }

        public String DDCM
        {
            get
            {
                CanReadProperty("DDCM", true);
                if (_dDCM == 0)
                {
                    return "";
                }
                else if (_dDCM - (int)(_dDCM) != 0)
                    return _dDCM.ToString("###,##0.##");
                else
                    return _dDCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DDCM", true);
                if (_dDCM.ToString() != value)
                {
                    if (value == "")
                        _dDCM = 0;
                    else
                        _dDCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DDCM");
                }
            }
        }

        public String DonGiaDDCM
        {
            get
            {
                CanReadProperty("DonGiaDDCM", true);
                if (_donGiaDDCM == 0)
                {
                    return "";
                }
                else if (_donGiaDDCM - (int)(_donGiaDDCM) != 0)
                    return _donGiaDDCM.ToString("###,##0.##");
                else
                    return _donGiaDDCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaDDCM", true);
                if (_donGiaDDCM.ToString() != value)
                {
                    if (value == "")
                        _donGiaDDCM = 0;
                    else
                        _donGiaDDCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaDDCM");
                }
            }
        }

        public String TTDDCM
        {
            get
            {
                CanReadProperty("TTDDCM", true);
                _TTDDCM = _dDCM * _donGiaDDCM;

                if (_TTDDCM == 0)
                {
                    return "";
                }
                else if (_TTDDCM - (int)(_TTDDCM) != 0)
                    return _TTDDCM.ToString("###,##0.##");
                else
                    return _TTDDCM.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTDDCM", true);
                if (_TTDDCM.ToString() != value)
                {
                    if (value == "")
                        _TTDDCM = 0;
                    else
                        _TTDDCM = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTDDCM");
                }
            }
        }

        public String NgayThuongLD
        {
            get
            {
                CanReadProperty("NgayThuongLD", true);
                if (_ngayThuongLD == 0)
                {
                    return "";
                }
                else if (_ngayThuongLD - (int)(_ngayThuongLD) != 0)
                    return _ngayThuongLD.ToString("###,##0.##");
                else
                    return _ngayThuongLD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayThuongLD", true);
                if (_ngayThuongLD.ToString() != value)
                {
                    if (value == "")
                        _ngayThuongLD = 0;
                    else
                        _ngayThuongLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayThuongLD");
                }
            }
        }

        public String DonGiaNTLD
        {
            get
            {
                CanReadProperty("DonGiaNTLD", true);
                if (_donGiaNTLD == 0)
                {
                    return "";
                }
                else if (_donGiaNTLD - (int)(_donGiaNTLD) != 0)
                    return _donGiaNTLD.ToString("###,##0.##");
                else
                    return _donGiaNTLD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNTLD", true);
                if (_donGiaNTLD.ToString() != value)
                {
                    if (value == "")
                        _donGiaNTLD = 0;
                    else
                        _donGiaNTLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNTLD");
                }
            }
        }

        public String TTNTLD
        {
            get
            {
                CanReadProperty("TTNTLD", true);
                _TTNTLD = _ngayThuongLD * _donGiaNTLD;

                if (_TTNTLD == 0)
                {
                    return "";
                }
                else if (_TTNTLD - (int)(_TTNTLD) != 0)
                    return _TTNTLD.ToString("###,##0.##");
                else
                    return _TTNTLD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTNTLD", true);
                if (_TTNTLD.ToString() != value)
                {
                    if (value == "")
                        _TTNTLD = 0;
                    else
                        _TTNTLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTNTLD");
                }
            }
        }

        public String NgayNghiLD
        {
            get
            {
                CanReadProperty("NgayNghiLD", true);
                if (_ngayNghiLD == 0)
                {
                    return "";
                }
                else if (_ngayNghiLD - (int)(_ngayNghiLD) != 0)
                    return _ngayNghiLD.ToString("###,##0.##");
                else
                    return _ngayNghiLD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayNghiLD", true);
                if (_ngayNghiLD.ToString() != value)
                {
                    if (value == "")
                        _ngayNghiLD = 0;
                    else
                        _ngayNghiLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayNghiLD");
                }
            }
        }

        public String DonGiaNNLD
        {
            get
            {
                CanReadProperty("DonGiaNNLD", true);
                if (_donGiaNNLD == 0)
                {
                    return "";
                }
                else if (_donGiaNNLD - (int)(_donGiaNNLD) != 0)
                    return _donGiaNNLD.ToString("###,##0.##");
                else
                    return _donGiaNNLD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNNLD", true);
                if (_donGiaNNLD.ToString() != value)
                {
                    if (value == "")
                        _donGiaNNLD = 0;
                    else
                        _donGiaNNLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNNLD");
                }
            }
        }

        public String TTNNLD
        {
            get
            {
                CanReadProperty("TTNNLD", true);
                _TTNNLD = _ngayNghiLD * _donGiaNNLD;

                if (_TTNNLD == 0)
                {
                    return "";
                }
                else if (_TTNNLD - (int)(_TTNNLD) != 0)
                    return _TTNNLD.ToString("###,##0.##");
                else
                    return _TTNNLD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTNNLD", true);
                if (_TTNNLD.ToString() != value)
                {
                    if (value == "")
                        _TTNNLD = 0;
                    else
                        _TTNNLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTNNLD");
                }
            }
        }

        public String NgayLeLD
        {
            get
            {
                CanReadProperty("NgayLeLD", true);
                if (_ngayLeLD == 0)
                {
                    return "";
                }
                else if (_ngayLeLD - (int)(_ngayLeLD) != 0)
                    return _ngayLeLD.ToString("###,##0.##");
                else
                    return _ngayLeLD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("NgayLeLD", true);
                if (_ngayLeLD.ToString() != value)
                {
                    if (value == "")
                        _ngayLeLD = 0;
                    else
                        _ngayLeLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayLeLD");
                }
            }
        }

        public String DonGiaNLLD
        {
            get
            {
                CanReadProperty("DonGiaNLLD", true);
                if (_donGiaNLLD == 0)
                {
                    return "";
                }
                else if (_donGiaNLLD - (int)(_donGiaNLLD) != 0)
                    return _donGiaNLLD.ToString("###,##0.##");
                else
                    return _donGiaNLLD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("DonGiaNLLD", true);
                if (_donGiaNLLD.ToString() != value)
                {
                    if (value == "")
                        _donGiaNLLD = 0;
                    else
                        _donGiaNLLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DonGiaNLLD");
                }
            }
        }

        public String TTNLLD
        {
            get
            {
                CanReadProperty("TTNLLD", true);
                _TTNLLD = _ngayLeLD * _donGiaNLLD;

                if (_TTNLLD == 0)
                {
                    return "";
                }
                else if (_TTNLLD - (int)(_TTNLLD) != 0)
                    return _TTNLLD.ToString("###,##0.##");
                else
                    return _TTNLLD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("TTNLLD", true);
                if (_TTNLLD.ToString() != value)
                {
                    if (value == "")
                        _TTNLLD = 0;
                    else
                        _TTNLLD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TTNLLD");
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
        public String Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                _tong = _TTNTHSCC + _TTNNHSCC + _TTNLHSCC + _TTCocIHSCC + _TTCocIIHSCC + _TTDDHSCC + _TTQCCTNBHSCC + _TTND1142002HSCC + _TTNTCM + _TTNNCM + _TTNLCM + _TTCocICM + _TTCocIICM + _TTDDCM + _TTQCCTNBCM + _TTNTLD + _TTNNLD + _TTNLLD;
                if (_tong == 0)
                {
                    return "";
                }
                else if (_tong - (int)(_tong) != 0)
                    return _tong.ToString("###,##0.##");
                else
                    return _tong.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Tong", true);
                if (_tong.ToString() != value)
                {
                    if (value == "")
                        _tong = 0;
                    else
                        _tong = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tong");
                }
            }
        }
        public String HeSo
        {
            get
            {
                CanReadProperty("HeSo", true);
                if (_heso == 0)
                {
                    return "";
                }
                else if (_heso - (int)(_heso) != 0)
                    return _heso.ToString("###,##0.##");
                else
                    return _heso.ToString("###,###");
            }
            set
            {
                CanWriteProperty("HeSo", true);
                if (_heso.ToString() != value)
                {
                    if (value == "")
                        _heso = 0;
                    else
                        _heso = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("HeSo");
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
		/// Factory method. New <see cref="Luong_Truc" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_Truc NewLuong_Truc()
        {
            return new Luong_Truc();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static Luong_Truc GetLuong_Truc(SafeDataReader dr, int i)
        {
            return new Luong_Truc(dr, i);
        }
        //public static Luong_Truc GetLuong_Truc(Int32 sTT, SmartDate thang)
        //{
        //    return DataPortal.Fetch<Luong_Truc>(new Criteria(sTT, thang));
        //}
        public Luong_Truc()
        {
            MarkAsChild();
        }
		/// <summary>
		/// Marks the <see cref="Luong_Truc" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteLuong_Truc(Int32 sTT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(sTT, thang));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal Luong_Truc()
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
					Criteria c = (Criteria) obj;
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
		/// Retrieve an existing <see cref="Luong_Truc" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong_Truc(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong_Truc(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_Truc(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="Luong_Truc" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        //    if (dr.GetDecimal("MucLuong_TrucCB") != null) _mucLuong_TrucCB = dr.GetDecimal("MucLuong_TrucCB");
        //    if (dr.GetDecimal("HeSoLuong_Truc") != null) _heSoLuong_Truc = dr.GetDecimal("HeSoLuong_Truc");
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
        private Luong_Truc(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("MaKhoa") != null) _makhoa = dr.GetString("MaKhoa");
            if (dr.GetDecimal("NgayThuongHSCC") != null) _ngayThuongHSCC = dr.GetDecimal("NgayThuongHSCC");
            if (dr.GetDecimal("DonGiaNTHSCC") != null) _donGiaNTHSCC = dr.GetDecimal("DonGiaNTHSCC");
            if (dr.GetDecimal("NgayNghiHSCC") != null) _ngayNghiHSCC = dr.GetDecimal("NgayNghiHSCC");
            if (dr.GetDecimal("DonGiaNNHSCC") != null) _donGiaNNHSCC = dr.GetDecimal("DonGiaNNHSCC");
            if (dr.GetDecimal("NgayLeHSCC") != null) _ngayLeHSCC = dr.GetDecimal("NgayLeHSCC");
            if (dr.GetDecimal("DonGiaNLHSCC") != null) _donGiaNLHSCC = dr.GetDecimal("DonGiaNLHSCC");
            if (dr.GetDecimal("QCCTNBHSCC") != null) _qCCTNBHSCC = dr.GetDecimal("QCCTNBHSCC");
            if (dr.GetDecimal("DonGiaQCCTNBHSCC") != null) _donGiaQCCTNBHSCC = dr.GetDecimal("DonGiaQCCTNBHSCC");
            if (dr.GetDecimal("CocIHSCC") != null) _cocIHSCC = dr.GetDecimal("CocIHSCC");
            if (dr.GetDecimal("DonGiaCocIHSCC") != null) _donGiaCocIHSCC = dr.GetDecimal("DonGiaCocIHSCC");
            if (dr.GetDecimal("CocIIHSCC") != null) _cocIIHSCC = dr.GetDecimal("CocIIHSCC");
            if (dr.GetDecimal("DonGiaCocIIHSCC") != null) _donGiaCocIIHSCC = dr.GetDecimal("DonGiaCocIIHSCC");
            if (dr.GetDecimal("DDHSCC") != null) _dDHSCC = dr.GetDecimal("DDHSCC");
            if (dr.GetDecimal("DonGiaDDHSCC") != null) _donGiaDDHSCC = dr.GetDecimal("DonGiaDDHSCC");
            if (dr.GetDecimal("ND1142002HSCC") != null) _nD1142002HSCC = dr.GetDecimal("ND1142002HSCC");
            if (dr.GetDecimal("DonGiaND1142002HSCC") != null) _donGiaND1142002HSCC = dr.GetDecimal("DonGiaND1142002HSCC");
            if (dr.GetDecimal("NgayThuongCM") != null) _ngayThuongCM = dr.GetDecimal("NgayThuongCM");
            if (dr.GetDecimal("DonGiaNTCM") != null) _donGiaNTCM = dr.GetDecimal("DonGiaNTCM");
            if (dr.GetDecimal("NgayNghiCM") != null) _ngayNghiCM = dr.GetDecimal("NgayNghiCM");
            if (dr.GetDecimal("DonGiaNNCM") != null) _donGiaNNCM = dr.GetDecimal("DonGiaNNCM");
            if (dr.GetDecimal("NgayLeCM") != null) _ngayLeCM = dr.GetDecimal("NgayLeCM");
            if (dr.GetDecimal("DonGiaNLCM") != null) _donGiaNLCM = dr.GetDecimal("DonGiaNLCM");
            if (dr.GetDecimal("QCCTNBCM") != null) _qCCTNBCM = dr.GetDecimal("QCCTNBCM");
            if (dr.GetDecimal("DonGiaQCCTNBCM") != null) _donGiaQCCTNBCM = dr.GetDecimal("DonGiaQCCTNBCM");
            if (dr.GetDecimal("CocICM") != null) _cocICM = dr.GetDecimal("CocICM");
            if (dr.GetDecimal("DonGiaCocICM") != null) _donGiaCocICM = dr.GetDecimal("DonGiaCocICM");
            if (dr.GetDecimal("CocIICM") != null) _cocIICM = dr.GetDecimal("CocIICM");
            if (dr.GetDecimal("DonGiaCocIICM") != null) _donGiaCocIICM = dr.GetDecimal("DonGiaCocIICM");
            if (dr.GetDecimal("DDCM") != null) _dDCM = dr.GetDecimal("DDCM");
            if (dr.GetDecimal("DonGiaDDCM") != null) _donGiaDDCM = dr.GetDecimal("DonGiaDDCM");
            if (dr.GetDecimal("NgayThuongLD") != null) _ngayThuongLD = dr.GetDecimal("NgayThuongLD");
            if (dr.GetDecimal("DonGiaNTLD") != null) _donGiaNTLD = dr.GetDecimal("DonGiaNTLD");
            if (dr.GetDecimal("NgayNghiLD") != null) _ngayNghiLD = dr.GetDecimal("NgayNghiLD");
            if (dr.GetDecimal("DonGiaNNLD") != null) _donGiaNNLD = dr.GetDecimal("DonGiaNNLD");
            if (dr.GetDecimal("NgayLeLD") != null) _ngayLeLD = dr.GetDecimal("NgayLeLD");
            if (dr.GetDecimal("DonGiaNLLD") != null) _donGiaNLLD = dr.GetDecimal("DonGiaNLLD");
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
            if (dr.GetDecimal("Tong") != null) _tong = dr.GetDecimal("Tong");
            if (dr.GetDecimal("HeSo") != null) _heso = dr.GetDecimal("HeSo");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
            if (dr.GetString("TenChuyenMon") != null) _tenChuyenMon = dr.GetString("TenChuyenMon");
            if (dr.GetString("TenLoaiHD") != null) _tenLoaiHD = dr.GetString("TenLoaiHD");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="Luong_Truc" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _sTT = DataProvider.Instance().InsertLuong_Truc(_thang, 
                _maNV, 
                _makhoa, 
                _ngayThuongHSCC, 
                _donGiaNTHSCC, 
                _ngayNghiHSCC, 
                _donGiaNNHSCC, 
                _ngayLeHSCC, 
                _donGiaNLHSCC, 
                _qCCTNBHSCC, 
                _donGiaQCCTNBHSCC, 
                _cocIHSCC, 
                _donGiaCocIHSCC, 
                _cocIIHSCC, 
                _donGiaCocIIHSCC, 
                _dDHSCC, 
                _donGiaDDHSCC, 
                _nD1142002HSCC, 
                _donGiaND1142002HSCC, 
                _ngayThuongCM, 
                _donGiaNTCM, 
                _ngayNghiCM, 
                _donGiaNNCM, 
                _ngayLeCM, 
                _donGiaNLCM, 
                _qCCTNBCM, 
                _donGiaQCCTNBCM, 
                _cocICM, 
                _donGiaCocICM, 
                _cocIICM, 
                _donGiaCocIICM, 
                _dDCM, 
                _donGiaDDCM, 
                _ngayThuongLD, 
                _donGiaNTLD, 
                _ngayNghiLD, 
                _donGiaNNLD, 
                _ngayLeLD, 
                _donGiaNLLD, 
                _maMay, 
                _nguoiLap, 
                _tong);
            // public abstract Int32 InsertLuong_Truc(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _ngayThuongHSCC, Decimal _donGiaNTHSCC, Decimal _ngayNghiHSCC, Decimal _donGiaNNHSCC, Decimal _ngayLeHSCC, Decimal _donGiaNLHSCC, Decimal _qCCTNBHSCC, Decimal _donGiaQCCTNBHSCC, Decimal _nD1142002HSCC, Decimal _donGiaND1142002HSCC, Decimal _ngayThuongCM, Decimal _donGiaNTCM, Decimal _ngayNghiCM, Decimal _donGiaNNCM, Decimal _ngayLeCM, Decimal _donGiaNLCM, Decimal _qCCTNBCM, Decimal _donGiaQCCTNBCM, Decimal _ngayThuongLD, Decimal _donGiaNTLD, Decimal _ngayNghiLD, Decimal _donGiaNNLD, Decimal _ngayLeLD, Decimal _donGiaNLLD, String _maMay, String _nguoiLap);
            // public override Int32 InsertLuong_Truc(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _ngayThuongHSCC, Decimal _donGiaNTHSCC, Decimal _ngayNghiHSCC, Decimal _donGiaNNHSCC, Decimal _ngayLeHSCC, Decimal _donGiaNLHSCC, Decimal _qCCTNBHSCC, Decimal _donGiaQCCTNBHSCC, Decimal _nD1142002HSCC, Decimal _donGiaND1142002HSCC, Decimal _ngayThuongCM, Decimal _donGiaNTCM, Decimal _ngayNghiCM, Decimal _donGiaNNCM, Decimal _ngayLeCM, Decimal _donGiaNLCM, Decimal _qCCTNBCM, Decimal _donGiaQCCTNBCM, Decimal _ngayThuongLD, Decimal _donGiaNTLD, Decimal _ngayNghiLD, Decimal _donGiaNNLD, Decimal _ngayLeLD, Decimal _donGiaNLLD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_Truc_CREATE", _sTT, _thang.DBValue, _maNV, _makhoa, _ngayThuongHSCC, _donGiaNTHSCC, _ngayNghiHSCC, _donGiaNNHSCC, _ngayLeHSCC, _donGiaNLHSCC, _qCCTNBHSCC, _donGiaQCCTNBHSCC, _cocIHSCC, _donGiaCocIHSCC, _cocIIHSCC, _donGiaCocIIHSCC, _dDHSCC, _donGiaDDHSCC, _nD1142002HSCC, _donGiaND1142002HSCC, _ngayThuongCM, _donGiaNTCM, _ngayNghiCM, _donGiaNNCM, _ngayLeCM, _donGiaNLCM, _qCCTNBCM, _donGiaQCCTNBCM, _cocICM, _donGiaCocICM, _cocIICM, _donGiaCocIICM, _dDCM, _donGiaDDCM, _ngayThuongLD, _donGiaNTLD, _ngayNghiLD, _donGiaNNLD, _ngayLeLD, _donGiaNLLD, _maMay, _nguoiSD , _tong);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_Truc" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
                DataProvider.Instance().UpdateLuong_Truc(_sTT, 
                    _thang, 
                    _maNV, 
                _makhoa, 
                _ngayThuongHSCC, 
                _donGiaNTHSCC, 
                _ngayNghiHSCC, 
                _donGiaNNHSCC, 
                _ngayLeHSCC, 
                _donGiaNLHSCC, 
                _qCCTNBHSCC, 
                _donGiaQCCTNBHSCC, 
                _cocIHSCC, 
                _donGiaCocIHSCC, 
                _cocIIHSCC, 
                _donGiaCocIIHSCC, 
                _dDHSCC, 
                _donGiaDDHSCC, 
                _nD1142002HSCC, 
                _donGiaND1142002HSCC, 
                _ngayThuongCM, 
                _donGiaNTCM, 
                _ngayNghiCM, 
                _donGiaNNCM, 
                _ngayLeCM, 
                _donGiaNLCM, 
                _qCCTNBCM, 
                _donGiaQCCTNBCM, 
                _cocICM, 
                _donGiaCocICM, 
                _cocIICM, 
                _donGiaCocIICM, 
                _dDCM, 
                _donGiaDDCM, 
                _ngayThuongLD, 
                _donGiaNTLD, 
                _ngayNghiLD, 
                _donGiaNNLD, 
                _ngayLeLD, 
                _donGiaNLLD, 
                _maMay, 
                _nguoiSD, 
                _huy, 
                _tong);
                // public abstract void UpdateLuong_Truc(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _ngayThuongHSCC, Decimal _donGiaNTHSCC, Decimal _ngayNghiHSCC, Decimal _donGiaNNHSCC, Decimal _ngayLeHSCC, Decimal _donGiaNLHSCC, Decimal _qCCTNBHSCC, Decimal _donGiaQCCTNBHSCC, Decimal _nD1142002HSCC, Decimal _donGiaND1142002HSCC, Decimal _ngayThuongCM, Decimal _donGiaNTCM, Decimal _ngayNghiCM, Decimal _donGiaNNCM, Decimal _ngayLeCM, Decimal _donGiaNLCM, Decimal _qCCTNBCM, Decimal _donGiaQCCTNBCM, Decimal _ngayThuongLD, Decimal _donGiaNTLD, Decimal _ngayNghiLD, Decimal _donGiaNNLD, Decimal _ngayLeLD, Decimal _donGiaNLLD, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong_Truc(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _ngayThuongHSCC, Decimal _donGiaNTHSCC, Decimal _ngayNghiHSCC, Decimal _donGiaNNHSCC, Decimal _ngayLeHSCC, Decimal _donGiaNLHSCC, Decimal _qCCTNBHSCC, Decimal _donGiaQCCTNBHSCC, Decimal _nD1142002HSCC, Decimal _donGiaND1142002HSCC, Decimal _ngayThuongCM, Decimal _donGiaNTCM, Decimal _ngayNghiCM, Decimal _donGiaNNCM, Decimal _ngayLeCM, Decimal _donGiaNLCM, Decimal _qCCTNBCM, Decimal _donGiaQCCTNBCM, Decimal _ngayThuongLD, Decimal _donGiaNTLD, Decimal _ngayNghiLD, Decimal _donGiaNNLD, Decimal _ngayLeLD, Decimal _donGiaNLLD, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_Truc_UPDATE", _sTT, _thang.DBValue, _maNV, _makhoa, _ngayThuongHSCC, _donGiaNTHSCC, _ngayNghiHSCC, _donGiaNNHSCC, _ngayLeHSCC, _donGiaNLHSCC, _qCCTNBHSCC, _donGiaQCCTNBHSCC, _cocIHSCC, _donGiaCocIHSCC, _cocIIHSCC, _donGiaCocIIHSCC, _dDHSCC, _donGiaDDHSCC, _nD1142002HSCC, _donGiaND1142002HSCC, _ngayThuongCM, _donGiaNTCM, _ngayNghiCM, _donGiaNNCM, _ngayLeCM, _donGiaNLCM, _qCCTNBCM, _donGiaQCCTNBCM, _cocICM, _donGiaCocICM, _cocIICM, _donGiaCocIICM, _dDCM, _donGiaDDCM, _ngayThuongLD, _donGiaNTLD, _ngayNghiLD, _donGiaNNLD, _ngayLeLD, _donGiaNLLD, _maMay, _nguoiSD , _huy, _tong);
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
		/// Delete the <see cref="Luong_Truc" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_Truc
            DataProvider.Instance().DeleteLuong_Truc(crit.MaMay, crit.NguoiSD, crit.STT, crit.Thang);
			// public abstract void DeleteLuong_Truc(Int32 _sTT, SmartDate _thang);
			// public override void DeleteLuong_Truc(Int32 _sTT, SmartDate _thang);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_Truc_DELETED", _sTT, _thang);
			// }
		}

		#endregion
	}

}
