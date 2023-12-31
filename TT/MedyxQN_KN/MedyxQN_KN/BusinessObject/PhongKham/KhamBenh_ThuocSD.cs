// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_ThuocSD
// Kieu doi tuong  :	KhamBenh_ThuocSD
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/1/2009 4:12:27 PM
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
using HTC.Business.CategoryList; 

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_ThuocSD" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_ThuocSD : BusinessBase<KhamBenh_ThuocSD>
	{
		#region Business Methods
		
		#region State Fields

        private String _duongdung = String.Empty;
        private String _hamluong = String.Empty;
        private String _sovisa = String.Empty;
        private String _matduong = String.Empty;

        private String _dvt = String.Empty;
        private String _lieuluong = String.Empty;
        private String _cachdungtt = String.Empty;
        private String _sothuoc = String.Empty;
      
        private String _maPX = String.Empty;
      
		private String _maSoKham = String.Empty;
        private Int32 _sTT = 0;
		private String _mathuoc = String.Empty;
        private String _tendvt = String.Empty;
		private String _maBN = String.Empty;
		private SmartDate _ngayDK = new SmartDate(true);
		private Decimal _sLKeDon = 0;
		private Decimal _sLMua = 0;
        private String _makhoa = String.Empty;
		private Decimal _dongiaTT = 0;
		private Decimal _donGiaBH = 0;
		private Decimal _giaChenhLech = 0;
		private String _soHD = String.Empty;
		private String _soSoHD = String.Empty;
        private String _soHDTra = String.Empty;
        private String _soSoHDTra = String.Empty;
		private Int32 _sophieu = 0;
		private Decimal _ck = 0;
		private String _bSChiDinh = String.Empty;
		private String _lieuDung = String.Empty;
		private String _cachDung = String.Empty;
        private String _sang = String.Empty;
        private String _trua = String.Empty;
        private String _chieu = String.Empty;
        private String _tenGoc = String.Empty;
        private String _toi = String.Empty;
		private Boolean _tinhtien = false;
		private Boolean _bHTinhTien = false;
		private Byte _dATT = 0;
		private Boolean _tToanSau = false;
		private String _nguoiTT = String.Empty;
		private SmartDate _ngayTToan = new SmartDate(true);
		private Boolean _daTra = false;
		private String _nguoiTra = String.Empty;
		private SmartDate _ngaytra = new SmartDate(true);
        private Decimal _sLTra = 0;
      
        private Boolean _duyet = false;
        private Boolean _phat = false;
		private SmartDate _ngayP = new SmartDate(true);
		private String _nguoiD = String.Empty;
		private String _nguoiP = String.Empty;
		private SmartDate _ngayD = new SmartDate(true);
		private String _maMay = String.Empty;
        private Boolean _huy = false ;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _lyDoHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _TenTM = String.Empty;
        private String _tenbschidinh = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenNguoiD = String.Empty;
        private String _tenNguoiP = String.Empty;
        private String _tenNguoiTra = String.Empty;
        private Decimal _thanhtien = 0;
        private Decimal _tONCK = 0;
        private Decimal _tONCKDT = 0;
        private String _makx = String.Empty;
        private Boolean _dadung = false;
        private Decimal _sLTraCu = 0;
        private Byte _daTTTT = 0;
        private SmartDate _ngayTToanTT = new SmartDate(true);
        private String _nguoiTTTT = String.Empty;
        private String _noiTTTT = String.Empty;
        private Byte _daTTBH = 0;
        private SmartDate _ngayTToanBH = new SmartDate(true);
        private String _nguoiTTBH = String.Empty;
        private String _noiTTBH = String.Empty;
        private String _maDT = String.Empty;
        private Decimal _DonGiaD = 0;
        private Decimal _SoLuongD = 0;
        private Decimal _sLTraD = 0;
        private Decimal _quyDoi = 1;
        private Boolean _DuyetBH = false;
        #endregion

        #region Business Properties and Methods
        public String TenGoc
        {
            get
            {
                CanReadProperty("TenGoc", true);
                return _tenGoc;
            }
            set
            {
                CanWriteProperty("TenGoc", true);
                if (_tenGoc != value)
                {
                    _tenGoc = value;
                    PropertyHasChanged("TenGoc");
                }
            }
        }
        public String hamluong
        {
            get
            {
                CanReadProperty("hamluong", true);
                return _hamluong;
            }
            set
            {
                CanWriteProperty("hamluong", true);
                if (_hamluong != value)
                {
                    _hamluong = value;
                    PropertyHasChanged("hamluong");
                }
            }
        }
        public String sovisa
        {
            get
            {
                CanReadProperty("sovisa", true);
                return _sovisa;
            }
            set
            {
                CanWriteProperty("sovisa", true);
                if (_sovisa != value)
                {
                    _sovisa = value;
                    PropertyHasChanged("sovisa");
                }
            }
        }
        public String matduong
        {
            get
            {
                CanReadProperty("matduong", true);
                return _matduong;
            }
            set
            {
                CanWriteProperty("matduong", true);
                if (_matduong != value)
                {
                    _matduong = value;
                    PropertyHasChanged("matduong");
                }
            }
        }
        public String lieuluong
        {
            get
            {
                CanReadProperty("lieuluong", true);
                return _lieuluong;
            }
            set
            {
                CanWriteProperty("lieuluong", true);
                if (_lieuluong != value)
                {
                    _lieuluong = value;
                    PropertyHasChanged("lieuluong");
                }
            }
        }
        public String duongdung
        {
            get
            {
                CanReadProperty("duongdung", true);
                return _duongdung;
            }
            set
            {
                CanWriteProperty("duongdung", true);
                if (_duongdung != value)
                {
                    _duongdung = value;
                    PropertyHasChanged("duongdung");
                }
            }
        }
        public String dvt
        {
            get
            {
                CanReadProperty("dvt", true);
                return _dvt;
            }
            set
            {
                CanWriteProperty("dvt", true);
                if (_dvt != value)
                {
                    _dvt = value;
                    PropertyHasChanged("dvt");
                }
            }
        }
        public String sothuoc
        {
            get
            {
                CanReadProperty("sothuoc", true);
                return _sothuoc;
            }
            set
            {
                CanWriteProperty("sothuoc", true);
                if (_sothuoc != value)
                {
                    _sothuoc = value;
                    PropertyHasChanged("sothuoc");
                }
            }
        }
        public String cachdungtt
        {
            get
            {
                CanReadProperty("cachdungtt", true);
                return _cachdungtt;
            }
            set
            {
                CanWriteProperty("cachdungtt", true);
                if (_cachdungtt != value)
                {
                    _cachdungtt = value;
                    PropertyHasChanged("cachdungtt");
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
       
        public string SLTraD
        {
            get
            {

                _sLTra = _sLTraD / _quyDoi;
               
                return _sLTraD.ToString("###,###");
            }
            set
            {
                if (_sLTraD.ToString() != value)
                {
                    _sLTraD = decimal.Parse(value);
                    _sLTra = _sLTraD / _quyDoi;
                    
                }
            }
        }
        public string DonGiaD
        {
            get
            {
                if ((_bHTinhTien != false) && (_tinhtien == false))
                {
                    _DonGiaD = (_donGiaBH * (100 - _ck) / _quyDoi) / (100)
                    + _giaChenhLech * (100 - _ck) / 100;
                }

                if ((_bHTinhTien == false) || (_tinhtien != false))
                    _DonGiaD = _dongiaTT * (100 - _ck) / _quyDoi / 100;


                if (_DonGiaD == 0)
                {
                    return "0";
                }
                else if (_DonGiaD - (int)(_DonGiaD) != 0)
                {
                    return _DonGiaD.ToString("###,##0.##");
                }
                else
                {
                    return _DonGiaD.ToString("###,###");
                }
            }
            //set
            //{
            //    if (_DonGiaD.ToString() != value)
            //    {
            //        _DonGiaD = decimal.Parse(value);

            //    }
            //}
        }
        public string DonGiaTTD
        {
            get
            {
               

                if (_dongiaTT == 0)
                {
                    return "0";
                }
                else if (_quyDoi == 0 && (_dongiaTT - (int)(_dongiaTT) != 0))
                {
                    return (_dongiaTT).ToString("###,##0.##");
                }
                else if (_quyDoi == 0 && (_dongiaTT - (int)(_dongiaTT) == 0))
                {
                    return (_dongiaTT).ToString("###,###");
                }
                else if (_dongiaTT / _quyDoi - (int)(_dongiaTT / _quyDoi) != 0)
                {
                    return (_dongiaTT/_quyDoi).ToString("###,##0.##");
                }
                else
                {
                    return (_dongiaTT/_quyDoi).ToString("###,###");
                }
            }
           
        }
        public string DonGiaBHD
        {
            get
            {


                if (_donGiaBH == 0)
                {
                    return "0";
                }
                else if (_quyDoi == 0 && (_donGiaBH - (int)(_donGiaBH) != 0))
                {
                    return (_donGiaBH).ToString("###,##0.##");
                }
                else if (_quyDoi == 0 && (_donGiaBH - (int)(_donGiaBH) == 0))
                {
                    return (_donGiaBH).ToString("###,###");
                }
                else if (_donGiaBH / _quyDoi - (int)(_donGiaBH / _quyDoi) != 0)
                {
                    return (_donGiaBH / _quyDoi).ToString("###,##0.##");
                }
                else
                {
                    return (_donGiaBH / _quyDoi).ToString("###,###");
                }
            }

        }
        public string SoLuongD
        {
            get
            {
                CanReadProperty("SoLuongD", true); 
                _sLKeDon = _SoLuongD / _quyDoi;
                _sLMua = _sLKeDon;
                return _SoLuongD.ToString("###,###");
            }
            set
            {
                CanWriteProperty("SoLuongD", true);
                if (_SoLuongD.ToString() != value)
                {
                    _SoLuongD = decimal.Parse(value);
                    _sLKeDon = _SoLuongD / _quyDoi;
                    _sLMua = _sLKeDon;
                    PropertyHasChanged("SoLuongD");
                }
            }
        }
        public Decimal QuyDoi
        {
            get
            {
                CanReadProperty("QuyDoi", true);
                return _quyDoi;
            }
            set
            {
                CanWriteProperty("QuyDoi", true);
                if (_quyDoi != value)
                {
                    _quyDoi = value;
                    PropertyHasChanged("QuyDoi");
                }
            }
        }

        public String NguoiTTBH
        {
            get
            {
                CanReadProperty("NguoiTTBH", true);
                return _nguoiTTBH;
            }
            set
            {
                CanWriteProperty("NguoiTTBH", true);
                if (_nguoiTTBH != value)
                {
                    _nguoiTTBH = value;
                    PropertyHasChanged("NguoiTTBH");
                }
            }
        }
        public String NoiTTBH
        {
            get
            {
                CanReadProperty("NoiTTBH", true);
                return _noiTTBH;
            }
            set
            {
                CanWriteProperty("NoiTTBH", true);
                if (_noiTTBH != value)
                {
                    _noiTTBH = value;
                    PropertyHasChanged("NoiTTBH");
                }
            }
        }
        public Byte DaTTBH
        {
            get
            {
                CanReadProperty("DaTTBH", true);
                return _daTTBH;
            }
            set
            {
                CanWriteProperty("DaTTBH", true);
                if (_daTTBH != value)
                {
                    _daTTBH = value;
                    PropertyHasChanged("DaTTBH");
                }
            }
        }

        public string NgayTToanBH
        {
            get
            {
                CanReadProperty("NgayTToanBH", true);
                return _ngayTToanBH.Text;
            }
            set
            {
                CanWriteProperty("NgayTToanBH", true);
                if (_ngayTToanBH.Text != value)
                {
                    _ngayTToanBH.Text = value;
                    PropertyHasChanged("NgayTToanBH");
                }
            }
        }
        public String NguoiTTTT
        {
            get
            {
                CanReadProperty("NguoiTTTT", true);
                return _nguoiTTTT;
            }
            set
            {
                CanWriteProperty("NguoiTTTT", true);
                if (_nguoiTTTT != value)
                {
                    _nguoiTTTT = value;
                    PropertyHasChanged("NguoiTTTT");
                }
            }
        }
        public String NoiTTTT
        {
            get
            {
                CanReadProperty("NoiTTTT", true);
                return _noiTTTT;
            }
            set
            {
                CanWriteProperty("NoiTTTT", true);
                if (_noiTTTT != value)
                {
                    _noiTTTT = value;
                    PropertyHasChanged("NoiTTTT");
                }
            }
        }
        public Byte DaTTTT
        {
            get
            {
                CanReadProperty("DaTTTT", true);
                return _daTTTT;
            }
            set
            {
                CanWriteProperty("DaTTTT", true);
                if (_daTTTT != value)
                {
                    _daTTTT = value;
                    PropertyHasChanged("DaTTTT");
                }
            }
        }

      
		
        public string NgayTToanTT
        {
            get
            {
                CanReadProperty("NgayTToanTT", true);
                return _ngayTToanTT.Text;
            }
            set
            {
                CanWriteProperty("NgayTToanTT", true);
                if (_ngayTToanTT.Text != value)
                {
                    _ngayTToanTT.Text = value;
                    PropertyHasChanged("NgayTToanTT");
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
        public string SLTraCu
        {
            get
            {
                CanReadProperty("SLTraCu", true);
                if (_sLTraCu == 0)
                    return "0";
                else if (_sLTraCu - (int)(_sLTraCu) != 0)
                    return _sLTraCu.ToString("###,###.###");
                else
                    return _sLTraCu.ToString("###,###");

            }
            set
            {
                CanWriteProperty("SLTraCu", true);
                if (_sLTraCu.ToString() != value)
                {
                    _sLTraCu = decimal.Parse(value);
                    PropertyHasChanged("SLTraCu");
                }
            }
        }
        public Boolean dadung
        {
            get
            {
                CanReadProperty("dadung", true);
                return _dadung;
            }
            set
            {
                CanWriteProperty("dadung", true);
                if (_dadung != value)
                {
                    _dadung = value;
                    PropertyHasChanged("dadung");
                }
            }
        }
        public String Makx
        {
            get
            {
                CanReadProperty("Makx", true);
                return _makx;
            }
            set
            {
                CanWriteProperty("Makx", true);
                if (_makx != value)
                {
                    _makx = value;
                    PropertyHasChanged("Makx");
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
        public string  thanhtien
        {
            get
            {
                CanReadProperty("thanhtien", true);
                if ((_bHTinhTien != false) && (_tinhtien == false))
                {
                    _thanhtien = (_donGiaBH * (100 - _ck)* (_sLMua - _sLTra)) / (100 )
                    + _giaChenhLech * (100 - _ck) * (_sLMua - _sLTra)/ 100 ;
                }

                if ((_bHTinhTien == false) || (_tinhtien != false))
                    _thanhtien = _dongiaTT * (100 - _ck)* (_sLMua - _sLTra) / 100 ;

                return _thanhtien.ToString("###,###");
                if (_SoLuongD == 0 && _sLMua != 0 && _quyDoi != 0)
                    _SoLuongD = _sLMua / _quyDoi;
                else if (_SoLuongD == 0 && _sLMua != 0)
                    _SoLuongD = _sLMua;
            }
            set
            {
                CanWriteProperty("thanhtien", true);
                if (_thanhtien.ToString()  != value)
                {
                    _thanhtien = decimal.Parse(value);
                    PropertyHasChanged("thanhtien");
                }
            }
        }
        public Decimal TONCK
        {
            get
            {
                CanReadProperty("TONCK", true);
                return _tONCK;
            }
            set
            {
                if (_tONCK != value)
                {
                    _tONCK = value;
                }
            }
        }

        public Decimal TONCKDT
        {
            get
            {
                CanReadProperty("TONCKDT", true);
                return _tONCKDT;
            }
            set
            {
                if (_tONCKDT != value)
                {
                    _tONCKDT = value;
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
        public String SoHDTra
        {
            get
            {
                CanReadProperty("SoHDTra", true);
                return _soHDTra;
            }
            set
            {
                CanWriteProperty("SoHDTra", true);
                if (_soHDTra != value)
                {
                    _soHDTra = value;
                    PropertyHasChanged("SoHDTra");
                }
            }
        }

        public String SoSoHDTra
        {
            get
            {
                CanReadProperty("SoSoHDTra", true);
                return _soSoHDTra;
            }
            set
            {
                CanWriteProperty("SoSoHDTra", true);
                if (_soSoHDTra != value)
                {
                    _soSoHDTra = value;
                    PropertyHasChanged("SoSoHDTra");
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
        public String tendvt
        {
            get
            {
                CanReadProperty("tendvt", true);
                return _tendvt;
            }
            set
            {
                CanWriteProperty("tendvt", true);
                if (_tendvt != value)
                {
                    _tendvt = value;
                    PropertyHasChanged("tendvt");
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
		
		public string  SLKeDon
		{
			get 
			{
				CanReadProperty("SLKeDon", true);
                if (_sLKeDon == 0)
                    return "0";
                else if (_sLKeDon-   (int)(_sLKeDon) !=0)
                return _sLKeDon.ToString("###,###.###");
                else
                return _sLKeDon.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("SLKeDon", true);
				if (_sLKeDon.ToString()  != value) 
				{
					_sLKeDon = decimal.Parse(  value);
					PropertyHasChanged("SLKeDon");
				}
			}
		}

        public string SLMua
		{
			get 
			{
				CanReadProperty("SLMua", true);
                if (_sLMua == 0)
                    return "0";
                else if (_sLMua- (int)(_sLMua) !=0)
                return _sLMua.ToString("###,###.###");
                else
                return _sLMua.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("SLMua", true);
                if (_sLMua.ToString() != value) 
				{
                    _sLMua = decimal.Parse(value);
					PropertyHasChanged("SLMua");
				}
			}
		}
      
        public string DongiaTT
		{
			get 
			{
				CanReadProperty("DongiaTT", true);
                if (_dongiaTT == 0)
                    return "0";
                else
                return _dongiaTT.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("DongiaTT", true);
                if (_dongiaTT.ToString() != value) 
				{
                    
                    _dongiaTT = decimal.Parse(value);
					PropertyHasChanged("DongiaTT");
				}
			}
		}

        public string DonGiaBH
		{
			get 
			{
				CanReadProperty("DonGiaBH", true);
                if (_donGiaBH == 0)
                    return "0";
                else
                return _donGiaBH.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("DonGiaBH", true);
                if (_donGiaBH.ToString() != value) 
				{
                    if (value == "")
                        _donGiaBH = 0;
                    else
                    _donGiaBH = decimal.Parse(value);
					PropertyHasChanged("DonGiaBH");
				}
			}
		}

        public string GiaChenhLech
		{
			get 
			{
				CanReadProperty("GiaChenhLech", true);
                if (_giaChenhLech == 0)
                    return "0";
                else
                return _giaChenhLech.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("GiaChenhLech", true);
                if (_giaChenhLech.ToString() != value) 
				{
                    if (value == "")
                        _giaChenhLech = 0;
                    else
                    _giaChenhLech = decimal.Parse(value);
					PropertyHasChanged("GiaChenhLech");
				}
			}
		}
		
		public String SoHD
		{
			get 
			{
				CanReadProperty("SoHD", true);
				return _soHD;
			}
			set 
			{
				CanWriteProperty("SoHD", true);
				if (_soHD != value) 
				{
					_soHD = value;
					PropertyHasChanged("SoHD");
				}
			}
		}
		
		public String SoSoHD
		{
			get 
			{
				CanReadProperty("SoSoHD", true);
				return _soSoHD;
			}
			set 
			{
				CanWriteProperty("SoSoHD", true);
				if (_soSoHD != value) 
				{
					_soSoHD = value;
					PropertyHasChanged("SoSoHD");
				}
			}
		}
		
		public Int32 Sophieu
		{
			get 
			{
				CanReadProperty("Sophieu", true);
				return _sophieu;
			}
			set 
			{
				CanWriteProperty("Sophieu", true);
				if (_sophieu != value) 
				{
					_sophieu = value;
					PropertyHasChanged("Sophieu");
				}
			}
		}

        public string CK
		{
			get 
			{
				CanReadProperty("CK", true);
                if (_ck == 0)
                    return "0";
                else
                return _ck.ToString("###,###");
			}
			set 
			{
				CanWriteProperty("CK", true);
                if (_ck.ToString() != value) 
				{
                    
                    _ck = decimal.Parse(value);
					PropertyHasChanged("CK");
				}
			}
		}
		
		public String BSChiDinh
		{
			get 
			{
				CanReadProperty("BSChiDinh", true);
				return _bSChiDinh;
			}
			set 
			{
				CanWriteProperty("BSChiDinh", true);
				if (_bSChiDinh != value) 
				{
					_bSChiDinh = value;
					PropertyHasChanged("BSChiDinh");
				}
			}
		}
		
		public String LieuDung
		{
			get 
			{
				CanReadProperty("LieuDung", true);
				return _lieuDung;
			}
			set 
			{
				CanWriteProperty("LieuDung", true);
				if (_lieuDung != value) 
				{
					_lieuDung = value;
					PropertyHasChanged("LieuDung");
				}
			}
		}
        public String toi
        {
            get
            {
                CanReadProperty("toi", true);
                return _toi;
            }
            set
            {
                CanWriteProperty("toi", true);
                if (_toi != value)
                {
                    _toi = value;
                   // _cachDung = "Sáng : " + _sang + " Trưa : " + _trua + " Chiều : " + _chieu + " Tối : " + _toi;
                   
                    PropertyHasChanged("toi");
                }
            }
        }
        public String trua
        {
            get
            {
                CanReadProperty("trua", true);
                return _trua;
            }
            set
            {
                CanWriteProperty("trua", true);
                if (_trua != value)
                {
                  
                    _trua = value;
                   // _cachDung = "Sáng : " + _sang + " Trưa : " + _trua + " Chiều : " + _chieu + " Tối : " + _toi;
                    PropertyHasChanged("trua");
                }
            }
        }
        public String chieu
        {
            get
            {
                CanReadProperty("chieu", true);
                return _chieu;
            }
            set
            {
               // _cachDung = "Sáng : " + _sang + " Trưa : " + _trua + " Chiều : " + _chieu + " Tối : " + _toi;
                CanWriteProperty("chieu", true);
                if (_chieu != value)
                {
                    _chieu = value;
                    PropertyHasChanged("chieu");
                }
            }
        }
        public String sang
        {
            get
            {
                CanReadProperty("sang", true);
                return _sang;
            }
            set
            {
                CanWriteProperty("sang", true);
                if (_sang != value)
                {
                      _sang = value;
                     // _cachDung = "Sáng : " + _sang + " Trưa : " + _trua + " Chiều : " + _chieu + " Tối : " + _toi;
                 
                    PropertyHasChanged("sang");
                }
            }
        }
		public String CachDung
		{
			get 
			{
				CanReadProperty("CachDung", true);
				return _cachDung;
			}
			set 
			{
				CanWriteProperty("CachDung", true);
				if (_cachDung != value) 
				{
					_cachDung = value;
					PropertyHasChanged("CachDung");
				}
			}
		}
		
		public Boolean Tinhtien
		{
			get 
			{
				CanReadProperty("Tinhtien", true);
				return _tinhtien;
			}
			set 
			{
				CanWriteProperty("Tinhtien", true);
				if (_tinhtien != value) 
				{
					_tinhtien = value;
					PropertyHasChanged("Tinhtien");
				}
			}
		}
		
		public Boolean BHTinhtien
		{
			get 
			{
				CanReadProperty("BHTinhtien", true);
				return _bHTinhTien;
			}
			set 
			{
				CanWriteProperty("BHTinhtien", true);
				if (_bHTinhTien != value) 
				{
					_bHTinhTien = value;
					PropertyHasChanged("BHTinhtien");
				}
			}
		}
		
		public Byte DATT
		{
			get 
			{
				CanReadProperty("DATT", true);
				return _dATT;
			}
			set 
			{
				CanWriteProperty("DATT", true);
				if (_dATT != value) 
				{
					_dATT = value;
					PropertyHasChanged("DATT");
				}
			}
		}
		
		public Boolean TToanSau
		{
			get 
			{
				CanReadProperty("TToanSau", true);
				return _tToanSau;
			}
			set 
			{
				CanWriteProperty("TToanSau", true);
				if (_tToanSau != value) 
				{
					_tToanSau = value;
					PropertyHasChanged("TToanSau");
				}
			}
		}
		
		public String NguoiTT
		{
			get 
			{
				CanReadProperty("NguoiTT", true);
				return _nguoiTT;
			}
			set 
			{
				CanWriteProperty("NguoiTT", true);
				if (_nguoiTT != value) 
				{
					_nguoiTT = value;
					PropertyHasChanged("NguoiTT");
				}
			}
		}
		
		public string NgayTToan
		{
			get 
			{
				CanReadProperty("NgayTToan", true);
				return _ngayTToan.Text;
			}
			set 
			{
				CanWriteProperty("NgayTToan", true);
				if (_ngayTToan.Text != value) 
				{
					_ngayTToan.Text = value;
					PropertyHasChanged("NgayTToan");
				}
			}
		}
		
		public Boolean DaTra
		{
			get 
			{
				CanReadProperty("DaTra", true);
				return _daTra;
			}
			set 
			{
				CanWriteProperty("DaTra", true);
				if (_daTra != value) 
				{
					_daTra = value;
					PropertyHasChanged("DaTra");
				}
			}
		}
		
		public String NguoiTra
		{
			get 
			{
				CanReadProperty("NguoiTra", true);
				return _nguoiTra;
			}
			set 
			{
				CanWriteProperty("NguoiTra", true);
				if (_nguoiTra != value) 
				{
					_nguoiTra = value;
					PropertyHasChanged("NguoiTra");
				}
			}
		}
		
		public string Ngaytra
		{
			get 
			{
				CanReadProperty("Ngaytra", true);
				return _ngaytra.Text;
			}
			set 
			{
				CanWriteProperty("Ngaytra", true);
				if (_ngaytra.Text != value) 
				{
					_ngaytra.Text = value;
					PropertyHasChanged("Ngaytra");
				}
			}
		}

        public string SLTra
		{
			get 
			{
				CanReadProperty("SLTra", true);
                if (_sLTra == 0)
                {
                    return "0";
                }
                else if (_sLTra - (int)(_sLTra) != 0)
                {
                    return _sLTra.ToString("###,###.###");
                }
                else
                {
                    return _sLTra.ToString("###,###");
                }

               
			}
			set 
			{
				CanWriteProperty("SLTra", true);
				if (_sLTra.ToString() != value) 
				{
                    _sLTra = decimal.Parse(value);
					PropertyHasChanged("SLTra");
				}
			}
		}
		
		public Boolean Duyet
		{
			get 
			{
				CanReadProperty("Duyet", true);
				return _duyet;
			}
			set 
			{
				CanWriteProperty("Duyet", true);
				if (_duyet != value) 
				{
					_duyet = value;
					PropertyHasChanged("Duyet");
				}
			}
		}
		
		public Boolean Phat
		{
			get 
			{
				CanReadProperty("Phat", true);
				return _phat;
			}
			set 
			{
				CanWriteProperty("Phat", true);
				if (_phat != value) 
				{
					_phat = value;
					PropertyHasChanged("Phat");
				}
			}
		}
		
        //public string NgayP
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayP", true);
        //        return _ngayP.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayP", true);
        //        if (_ngayP.Text != value) 
        //        {
        //            _ngayP.Text = value;
        //            PropertyHasChanged("NgayP");
        //        }
        //    }
        //}
		
        //public String NguoiD
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiD", true);
        //        return _nguoiD;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiD", true);
        //        if (_nguoiD != value) 
        //        {
        //            _nguoiD = value;
        //            PropertyHasChanged("NguoiD");
        //        }
        //    }
        //}
		
        //public String NguoiP
        //{
        //    get 
        //    {
        //        CanReadProperty("NguoiP", true);
        //        return _nguoiP;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NguoiP", true);
        //        if (_nguoiP != value) 
        //        {
        //            _nguoiP = value;
        //            PropertyHasChanged("NguoiP");
        //        }
        //    }
        //}
		
        //public string NgayD
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayD", true);
        //        return _ngayD.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayD", true);
        //        if (_ngayD.Text != value) 
        //        {
        //            _ngayD.Text = value;
        //            PropertyHasChanged("NgayD");
        //        }
        //    }
        //}
		
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
		
        //public String LyDoHuy
        //{
        //    get 
        //    {
        //        CanReadProperty("LyDoHuy", true);
        //        return _lyDoHuy;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("LyDoHuy", true);
        //        if (_lyDoHuy != value) 
        //        {
        //            _lyDoHuy = value;
        //            PropertyHasChanged("LyDoHuy");
        //        }
        //    }
        //}
		
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
        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _TenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_TenTM != value)
                {
                    _TenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }

        public String tenbschidinh
        {
            get
            {
                CanReadProperty("tenbschidinh", true);
                return _tenbschidinh;
            }
            set
            {
                CanWriteProperty("tenbschidinh", true);
                if (_tenbschidinh != value)
                {
                    _tenbschidinh = value;
                    PropertyHasChanged("tenbschidinh");
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
        //public String tenNguoiD
        //{
        //    get
        //    {
        //        CanReadProperty("tenNguoiD", true);
        //        return _tenNguoiD;
        //    }
        //    set
        //    {
        //        CanWriteProperty("tenNguoiD", true);
        //        if (_tenNguoiD != value)
        //        {
        //            _tenNguoiD = value;
        //            PropertyHasChanged("tenNguoiD");
        //        }
        //    }
        //}
        //public String tenNguoiP
        //{
        //    get
        //    {
        //        CanReadProperty("tenNguoiP", true);
        //        return _tenNguoiP;
        //    }
        //    set
        //    {
        //        CanWriteProperty("tenNguoiP", true);
        //        if (_tenNguoiP != value)
        //        {
        //            _tenNguoiP = value;
        //            PropertyHasChanged("tenNguoiP");
        //        }
        //    }
        //}
        //public String tenNguoiTra
        //{
        //    get
        //    {
        //        CanReadProperty("TenNguoiHuy", true);
        //        return _tenNguoiHuy;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TenNguoiHuy", true);
        //        if (_tenNguoiHuy != value)
        //        {
        //            _tenNguoiHuy = value;
        //            PropertyHasChanged("TenNguoiHuy");
        //        }
        //    }
        //}
		protected override Object GetIdValue()
		{
			return _maSoKham.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="KhamBenh_ThuocSD" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static KhamBenh_ThuocSD NewKhamBenh_ThuocSD()
        {
            return new KhamBenh_ThuocSD();
            //return DataPortal.Create<DMDichVu_PhieuIn_C>();
        }
        public static KhamBenh_ThuocSD NewKhamBenh_ThuocSD(string maThuoc)
        {
            return new KhamBenh_ThuocSD(DMThuoc.GetDMThuoc(maThuoc));
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
        public static KhamBenh_ThuocSD NewKhamBenh_ThuocSD(DMThuoc _DMThuoc)
        {
            return new KhamBenh_ThuocSD(_DMThuoc);
            //return DataPortal.Create<DMDichVu_PhieuIn_C>(DMDichVu.GetDMDichVu(idDMDichvu));
        }
		public static KhamBenh_ThuocSD GetKhamBenh_ThuocSD(String maSoKham, int sTT)
		{
			return DataPortal.Fetch<KhamBenh_ThuocSD>(new Criteria(maSoKham, sTT));
		}

        public static KhamBenh_ThuocSD GetKhamBenh_ThuocSD(SafeDataReader dr)
        {
            return new KhamBenh_ThuocSD(dr);
        }
       
		/// <summary>
		/// Marks the <see cref="KhamBenh_ThuocSD" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteKhamBenh_ThuocSD(String maSoKham, String sTT)
        //{
        //    DataPortal.Delete(new Criteria(maSoKham, sTT));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal KhamBenh_ThuocSD()
		{	
			// Prevent direct creation
            _sLMua   = 1;
            _sLKeDon = 1;
            _sLTra = 0;
            _ck = 0;
		}
		protected KhamBenh_ThuocSD(DMThuoc pro)
        {
            MarkAsChild();
           
            //_maPhieu = dr.GetString("MaPhieu");
            _mathuoc = pro.MaThuoc ;
           // _maMay = pro.MaMay;
           // _huy = pro.Huy;
           //// _ngaySD = pro.NgaySD ;
           // _nguoiSD = pro.NguoiSD;
       //     _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_ThuocSD(string maSoKham, DMThuoc pro)
        {
            MarkAsChild();

            _maSoKham = maSoKham;
            _mathuoc = pro.MaThuoc ;
            _maMay = pro.MaMay;
            _huy = pro.Huy;
            // _ngaySD = pro.NgaySD ;
            _nguoiSD = pro.NguoiSD;
          //  _tenDV = pro.TenDV;
            //MarkOld();
        }
        protected KhamBenh_ThuocSD(SafeDataReader dr)
        {
            MarkAsChild();

        
             Fetch(dr);
            MarkOld();
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
			
			private int _sTT;
            public int STT 
			{
				get
				{
					return _sTT;
				}
			}

            public Criteria(String maSoKham, int sTT)
			{
				_maSoKham = maSoKham;
				_sTT = sTT;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maSoKham.Equals(c._maSoKham)) 
						return false;
					if (!_sTT.Equals(c._sTT)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maSoKham.ToString(), _sTT.ToString()).GetHashCode();
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
		/// Retrieve an existing <see cref="KhamBenh_ThuocSD" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetKhamBenh_ThuocSD(String _maSoKham, String _sTT);
			// public override IDataReader GetKhamBenh_ThuocSD(String _maSoKham, String _sTT)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _sTT));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetKhamBenh_ThuocSD(crit.MaSoKham, crit.STT)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="KhamBenh_ThuocSD" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
            if (dr.GetString("hamluong") != null) _hamluong = dr.GetString("hamluong");
            if (dr.GetString("sovisa") != null) _sovisa = dr.GetString("sovisa");
            if (dr.GetString("duongdung") != null) _duongdung = dr.GetString("duongdung");
            if (dr.GetString("matduong") != null) _matduong = dr.GetString("matduong");

			if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetString("Mathuoc") != null) _mathuoc = dr.GetString("Mathuoc");
            if (dr.GetString("makx") != null) _makx = dr.GetString("makx");
            if (dr.GetString("maPX") != null) _maPX = dr.GetString("MaPX");
          
            if (dr.GetString("tendvt") != null) _tendvt = dr.GetString("tendvt");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
			if (dr.GetDecimal("SLKeDon") != null) _sLKeDon = dr.GetDecimal("SLKeDon");
            if (dr.GetDecimal("QUYDOI") != null) _quyDoi = dr.GetDecimal("QUYDOI");
             _SoLuongD = dr.GetDecimal("SLMua") * _quyDoi;
             if (dr.GetString("TenGoc") != null) _tenGoc = dr.GetString("TenGoc");
			if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
            if (dr.GetDecimal("SLTra") != null) _sLTraCu = dr.GetDecimal("SLTra");
            if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
			if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
			if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
			if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
			if (dr.GetString("SoHD") != null) _soHD = dr.GetString("SoHD");
			if (dr.GetString("SoSoHD") != null) _soSoHD = dr.GetString("SoSoHD");
            if (dr.GetString("SoHDTra") != null) _soHDTra = dr.GetString("SoHDTra");
            if (dr.GetString("SoSoHDTra") != null) _soSoHDTra = dr.GetString("SoSoHDTra");
			if (dr.GetInt32("Sophieu") != null) _sophieu = dr.GetInt32("Sophieu");
			if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
			if (dr.GetString("BSChiDinh") != null) _bSChiDinh = dr.GetString("BSChiDinh");
			if (dr.GetString("LieuDung") != null) _lieuDung = dr.GetString("LieuDung");
            //if (dr.GetString("CachDung") != null) _cachDung = dr.GetString("CachDung");
            
            //try
            //{
            //    if (dr.GetString("CachDung").LastIndexOf("Sáng :") >= 0)
            //        _sang = dr.GetString("CachDung").Substring(dr.GetString("CachDung").LastIndexOf("Sáng :") + 12, dr.GetString("CachDung").LastIndexOf(" Trưa :") - dr.GetString("CachDung").LastIndexOf("Sáng :") - 12);
            //    if (dr.GetString("CachDung").LastIndexOf(" Trưa :") >= 0)
            //        _trua = dr.GetString("CachDung").Substring(dr.GetString("CachDung").LastIndexOf(" Trưa :") + 12, dr.GetString("CachDung").LastIndexOf(" Chiều :") - dr.GetString("CachDung").LastIndexOf(" Trưa :") - 11);
            //    if (dr.GetString("CachDung").LastIndexOf(" Chiều :") >= 0)
            //        _chieu = dr.GetString("CachDung").Substring(dr.GetString("CachDung").LastIndexOf(" Chiều :") + 13, dr.GetString("CachDung").LastIndexOf(" Tối :") - dr.GetString("CachDung").LastIndexOf(" Chiều :") - 12);
            //    if (dr.GetString("CachDung").LastIndexOf(" Tối :") >= 0)
            //        _toi = dr.GetString("CachDung").Substring(dr.GetString("CachDung").LastIndexOf(" Tối :") + 12, dr.GetString("CachDung").Length - dr.GetString("CachDung").LastIndexOf(" Tối :") - 12);
            //}
            //catch (Exception ex)
            //{ }
			if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
			if (dr.GetBoolean("BHTinhtien") != null) _bHTinhTien = dr.GetBoolean("BHTinhtien");
			if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
			if (dr.GetBoolean("TToanSau") != null) _tToanSau = dr.GetBoolean("TToanSau");
			if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
			if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
			if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
			if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
			if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
            if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
            if (dr.GetBoolean("DuyetBH") != null) _DuyetBH = dr.GetBoolean("DuyetBh");
            if (dr.GetBoolean("Duyet") != null) _duyet = dr.GetBoolean("Duyet");
			if (dr.GetBoolean("Phat") != null) _phat = dr.GetBoolean("Phat");
			if (dr.GetSmartDate("NgayP", true) != null) _ngayP = dr.GetSmartDate("NgayP", true);
			if (dr.GetString("NguoiD") != null) _nguoiD = dr.GetString("NguoiD");
			if (dr.GetString("NguoiP") != null) _nguoiP = dr.GetString("NguoiP");
			if (dr.GetSmartDate("NgayD", true) != null) _ngayD = dr.GetSmartDate("NgayD", true);
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TENtm") != null) _TenTM = dr.GetString("TENtm");
            if (dr.GetString("TenGoc") != null) _tenGoc = dr.GetString("TenGoc");
            if (dr.GetString("TENbschidinh")!= null)  _tenbschidinh = dr.GetString("TENbschidinh");
            if ( dr.GetString("TENNGUOILAP")!= null)  _tenNguoiLap = dr.GetString("TENNGUOILAP");
            if ( dr.GetString("TENNGUOISD") != null) _tenNguoiSD = dr.GetString("TENNGUOISD");
            if ( dr.GetString("TENNGUOIHUY")!= null)  _tenNguoiHuy = dr.GetString("TENNGUOIHUY");
            if ( dr.GetString("TENNGUOId")!= null)  _tenNguoiD = dr.GetString("TENNGUOId");
            if (dr.GetString("TENNGUOIp") != null) _tenNguoiP = dr.GetString("TENNGUOIp");
            if (dr.GetString("TENNGUOItra") != null) _tenNguoiTra = dr.GetString("TENNGUOItra");
            if (dr.GetDecimal("TonCK") != null) _tONCK  = dr.GetDecimal("TonCK");
            if (dr.GetDecimal("TonCKDT") != null) _tONCKDT = dr.GetDecimal("TonCKDT");
            if (dr.GetBoolean("dadung") != null) _dadung = dr.GetBoolean("dadung");
            if (dr.GetString("NguoiTTBH") != null) _nguoiTTBH = dr.GetString("NguoiTTBH");
            if (dr.GetString("NoiTTBH") != null) _noiTTBH = dr.GetString("NoiTTBH");

            if (dr.GetByte("DaTTBH") != null) _daTTBH = dr.GetByte("DaTTBH");
            if (dr.GetSmartDate("NgayTToanBH", true) != null) _ngayTToanBH = dr.GetSmartDate("NgayTToanBH", true);

            if (dr.GetString("NguoiTTTT") != null) _nguoiTTTT = dr.GetString("NguoiTTTT");
            if (dr.GetString("NoiTTTT") != null) _noiTTTT = dr.GetString("NoiTTTT");

            if (dr.GetByte("DaTTTT") != null) _daTTTT = dr.GetByte("DaTTTT");
            if (dr.GetSmartDate("NgayTToanTT", true) != null) _ngayTToanTT = dr.GetSmartDate("NgayTToanTT", true);
            if (dr.GetString("MADT") != null) _maDT = dr.GetString("MADT");

        }
		
		/// <summary>
		/// Insert the new <see cref="KhamBenh_ThuocSD" /> Object to underlying database.
		/// </summary>
        internal virtual void Insert(KhamBenh bill)
        {
            
            
             if (_sLMua != 0)

                 _maSoKham = DataProvider.Instance().InsertKhamBenh_ThuocSD(bill.MaSoKham, _sTT, _mathuoc, bill.MaBN, _ngayDK, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _nguoiP, _ngayD, _maMay, _nguoiSD , _makx,_maPX , _makhoa, _dadung, _daTTTT, _ngayTToanTT, _daTTBH, _ngayTToanBH, _noiTTTT, _noiTTBH, _nguoiTTTT, _nguoiTTBH,bill.MaDT);
             MarkOld();// public abstract String InsertKhamBenh_ThuocSD(String _maSoKham, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat , SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap);
			// public override String InsertKhamBenh_ThuocSD(String _maSoKham, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat , SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_ThuocSD_Create", _maSoKham,  _mathuoc, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue, _maMay, _ngayLap.DBValue, _nguoiSD));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="KhamBenh_ThuocSD" /> Object to underlying database.
		/// </summary>
        internal virtual void Update(KhamBenh bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateKhamBenh_ThuocSD(bill.MaSoKham, _sTT, _mathuoc, _maBN, _ngayDK, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _nguoiP, _ngayD, _maMay, _huy, _nguoiSD , _soHDTra, _soSoHDTra, Makx,_maPX , _makhoa, _dadung, _daTTTT, _ngayTToanTT, _daTTBH, _ngayTToanBH, _noiTTTT, _noiTTBH, _nguoiTTTT, _nguoiTTBH,bill.MaDT,bill.loai );
                // public abstract void UpdateKhamBenh_ThuocSD(String _maSoKham, String _sTT,  String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat , SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateKhamBenh_ThuocSD(String _maSoKham, String _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat , SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy,  String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhamBenh_ThuocSD_Update", _maSoKham, _sTT, _mathuoc, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue, _maMay, _huy, _nguoiSD );
				// }
                MarkOld();
			}
		}
		
        internal void DeleteSelf(KhamBenh bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteKhamBenh_ThuocSD(_maMay, _nguoiSD , bill.MaSoKham, _sTT, _lyDoHuy );
            MarkNew();
        }
        internal virtual void Insert(KhamBenh_Q bill)
        {
            
            
            if (_sLMua != 0)

               _maSoKham = DataProvider.Instance().InsertKhamBenh_ThuocSD(bill.MaSoKham, _sTT, _mathuoc, bill.MaBN, _ngayDK, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _nguoiP, _ngayD, _maMay, _nguoiSD , _makx,_maPX , _makhoa, _dadung, _daTTTT, _ngayTToanTT, _daTTBH, _ngayTToanBH, _noiTTTT, _noiTTBH, _nguoiTTTT, _nguoiTTBH, bill.MaDT);
            MarkOld(); // public abstract String InsertKhamBenh_ThuocSD(String _maSoKham, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat , SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap);
            // public override String InsertKhamBenh_ThuocSD(String _maSoKham, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat , SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhambenh_ThuocSD_Create", _maSoKham,  _mathuoc, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhTien, _dATT, _tToanSau,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _ngayLap.DBValue, _nguoiSD));
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="KhamBenh_ThuocSD" /> Object to underlying database.
        /// </summary>
        internal virtual void Update(KhamBenh_Q bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                  DataProvider.Instance().UpdateKhamBenh_ThuocSD(bill.MaSoKham, _sTT, _mathuoc, _maBN, _ngayDK, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhTien, _dATT, _tToanSau, _nguoiTT, _ngayTToan, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _nguoiP, _ngayD, _maMay, _huy,_nguoiSD, _soHDTra, _soSoHDTra, _makx, _maPX, _makhoa, _dadung, _daTTTT, _ngayTToanTT, _daTTBH, _ngayTToanBH, _noiTTTT, _noiTTBH, _nguoiTTTT, _nguoiTTBH, bill.MaDT, bill.loai);
                // public abstract void UpdateKhamBenh_ThuocSD(String _maSoKham, String _sTT,  String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat , SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateKhamBenh_ThuocSD(String _maSoKham, String _sTT, String _mathuoc, String _maBN, SmartDate _ngayDK, Decimal _sLKeDon, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, String _soHD, String _soSoHD, Int32 _sophieu, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _bHTinhTien, Byte _dATT, Boolean _tToanSau, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, String _sLTra, Boolean _duyet, Boolean _phat , SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy,  String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spKhambenh_ThuocSD_Update", _maSoKham, _sTT, _mathuoc, _maBN, _ngayDK.DBValue, _sLKeDon, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _soHD, _soSoHD, _sophieu, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _bHTinhTien, _dATT, _tToanSau,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy, _nguoiSD);
                // }		
                MarkOld();
            }
        }

        internal void DeleteSelf(KhamBenh_Q bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteKhamBenh_ThuocSD(_maMay, _nguoiSD , bill.MaSoKham, _sTT, _lyDoHuy);
            MarkNew();
        }

		#endregion
	}

}
