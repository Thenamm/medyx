// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_PhauThuat
// Kieu doi tuong  :	BenhAn_PhauThuat
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/15/2009 2:07:17 PM
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

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="BenhAn_PhauThuat" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_PhauThuat : BusinessBase<BenhAn_PhauThuat>
	{
		#region Business Methods
		
		#region State Fields
        private Int32 _STTDT = 0;
        private String _maDT = String.Empty;
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private String _maPT = String.Empty;
        private String _maloaiPT = String.Empty;
		private String _maBN = String.Empty;
        private SmartDate _ngayDK = new SmartDate("", true);
        private SmartDate _ngayDKD = new SmartDate("", true);
		private Boolean _daThucHien = false;
		private Decimal _sLYCau = 0;
		private Decimal _sLMua = 0;
		private Decimal _dongiaTT = 0;
		private Decimal _dongiaUSD = 0;
		private Decimal _tyGia = 0;
		private Decimal _donGiaBH = 0;
		private Decimal _giaChenhLech = 0;
		private Decimal _ck = 0;
		private String _bSChiDinh = String.Empty;
		private String _cDTruocMo = String.Empty;
		private String _cDSauMo = String.Empty;
		private String _maGPBenh = String.Empty;
		private Byte _hTPhauThuat = 0;
     
		private Boolean _taibienPT = false;
		private Boolean _tinhtien = false;
		private Boolean _bHTinhtien = false;
		private Boolean _tinhNgoai = false;
		private Byte _dATT = 0;
		private String _nguoiTT = String.Empty;
        private SmartDate _ngayTToan = new SmartDate("", true);
        private SmartDate _ngayTToanD = new SmartDate("", true);
		private Boolean _aDGIAUSD = false;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _lyDoHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _tenPT = String.Empty;
        private String _tenloaiPT = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenBSChidinh = String.Empty;
        private String _tenNguoiTra = String.Empty;
        private String _tenBenhCDTruocMo = String.Empty;
        private String _tenBenhCDSauMo = String.Empty;
        private String _maICDTruocMo = String.Empty;
        private String _maICDSauMo = String.Empty;
        private String _maKhoa = String.Empty;
        private String _malh = String.Empty;
        private String _maChungLoai = String.Empty;
        private String _chieucao = String.Empty;
        private String _cannang = String.Empty;
        private String _maphong = "0";
        private byte _ca = 1;
        private String _ptvien = String.Empty;
        private String _ptvienc = String.Empty;
        private String _ptvien1 = String.Empty;
        private String _ptvien2 = String.Empty;
        private String _cec = String.Empty;
        private String _cecc = String.Empty;
        private String _cec1 = String.Empty;
        private String _cec2 = String.Empty;
        private String _gayme = String.Empty;
        private String _gaymec = String.Empty;
        private String _gayme1 = String.Empty;
        private String _gayme2 = String.Empty;
        private String _cachgayme = String.Empty;
        private String _ppphauthuat = String.Empty;
        private String _dungcu = String.Empty;
        private String _dungcuc = String.Empty;
        private String _dungcu1 = String.Empty;
        private String _dungcu2 = String.Empty;
        private String _loai = String.Empty;
        private String _noiDung = String.Empty;
        private int _OrderNumber;
        private String _tenKhoa = String.Empty;
        private String _tenlh = String.Empty;
        private Decimal _thanhtien = 0;
        private Decimal _thanhtientt = 0;
        private Decimal _thanhtienbh = 0;
        private Boolean _bh = false;
        private String _maKhoaQL = String.Empty;
        private String _tentat = String.Empty;
        private Boolean _KTC = false;
        #endregion

        #region Business Properties and Methods
        public Boolean KTC
        {
            get
            {
                CanReadProperty("KTC", true);
                return _KTC;
            }
            set
            {
                CanWriteProperty("KTC", true);
                if (_KTC != value)
                {
                    _KTC = value;
                    PropertyHasChanged("KTC");
                }
            }
        }
        public String MaKhoaQL
        {
            get
            {
                CanReadProperty("MaKhoaQL", true);
                return _maKhoaQL;
            }
            set
            {
                CanWriteProperty("MaKhoaQL", true);
                if (_maKhoaQL != value)
                {
                    _maKhoaQL = value;
                    PropertyHasChanged("MaKhoaQL");
                }
            }
        }
        public Boolean BH
        {
            get
            {
                CanReadProperty("BH", true);
                return _bh;
            }
            set
            {
                CanWriteProperty("BH", true);
                if (_bh != value)
                {
                    _bh = value;
                    if (_bh == false)
                    {
                        _tinhtien = true;
                    }
                    else if (_bh == true)
                    {
                        _bHTinhtien = true;
                    }
                    PropertyHasChanged("BH");
                }
            }
        }
        public Decimal DGTT
        {
            get
            {

                return _dongiaTT;
            }

        }
        public Decimal DGBH
        {
            get
            {

                return _donGiaBH;
            }

        }
        public Decimal DGCL
        {
            get
            {

                return _giaChenhLech;
            }

        }
        public string mabapt
        {
            get
            {

                return _maBA+"/"+_sTTKhoa +"/"+_sTT ;
            }

        }
        public string thanhtien
        {
            get
            {
                CanReadProperty("thanhtien", true);
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _thanhtien = (_donGiaBH * (100 - _ck) * (_sLMua)) / (100)
                    + _giaChenhLech * (100 - _ck) * (_sLMua) / 100;
                }

                if ((_bHTinhtien == false) || (_tinhtien != false))
                    _thanhtien = _dongiaTT * (100 - _ck) * (_sLMua) / 100;

                return _thanhtien.ToString("###,###");
            }
            set
            {
                CanWriteProperty("thanhtien", true);
                if (_thanhtien.ToString() != value)
                {
                    _thanhtien = decimal.Parse(value);
                    PropertyHasChanged("thanhtien");
                }
            }
        }

        public string thanhtientt
        {
            get
            {
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _thanhtientt = _giaChenhLech * (100 - _ck) * (_sLMua) / 100;
                }

                else if ((_bHTinhtien == false) || (_tinhtien != false))
                    _thanhtientt = _dongiaTT * (100 - _ck) * (_sLMua) / 100;

                return _thanhtientt.ToString("###,###");
            }

        }
        public string thanhtienbh
        {
            get
            {
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _thanhtienbh = (_donGiaBH * (100 - _ck) * (_sLMua)) / (100);

                }

                return _thanhtienbh.ToString("###,###");
            }

        }
        public String tenlh
        {
            get
            {
                CanReadProperty("tenlh", true);
                return _tenlh;
            }
            set
            {
                CanWriteProperty("tenlh", true);
                if (_tenlh != value)
                {
                    _tenlh = value;
                    PropertyHasChanged("tenlh");
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
        public Int32 STTDT
        {
            get
            {
                CanReadProperty("STTDT", true);
                return _STTDT;
            }
            set
            {
                CanWriteProperty("STTDT", true);
                if (_STTDT != value)
                {
                    _STTDT = value;
                    PropertyHasChanged("STTDT");
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
        public String malh
        {
            get
            {
                CanReadProperty("malh", true);
                return _malh;
            }
            set
            {
                CanWriteProperty("malh", true);
                if (_malh != value)
                {
                    _malh = value;
                    PropertyHasChanged("malh");
                }
            }
        }
        public String chieucao
        {
            get
            {
                CanReadProperty("chieucao", true);
                return _chieucao;
            }
            set
            {
                CanWriteProperty("chieucao", true);
                if (_chieucao != value)
                {
                    _chieucao = value;
                    PropertyHasChanged("chieucao");
                }
            }
        }
        public String cannang
        {
            get
            {
                CanReadProperty("cannang", true);
                return _cannang;
            }
            set
            {
                CanWriteProperty("cannang", true);
                if (_cannang != value)
                {
                    _cannang = value;
                    PropertyHasChanged("cannang");
                }
            }
        }
        public String ptvien
        {
            get
            {
                CanReadProperty("ptvien", true);
                return _ptvien;
            }
            set
            {
                CanWriteProperty("ptvien", true);
                if (_ptvien != value)
                {
                    _ptvien = value;
                    PropertyHasChanged("ptvien");
                }
            }
        }
        public String ptvienc
        {
            get
            {
                CanReadProperty("ptvienc", true);
                return _ptvienc;
            }
            set
            {
                CanWriteProperty("ptvienc", true);
                if (_ptvienc != value)
                {
                    _ptvienc = value;
                    PropertyHasChanged("ptvienc");
                }
            }
        }
        public String ptvien1
        {
            get
            {
                CanReadProperty("ptvien1", true);
                return _ptvien1;
            }
            set
            {
                CanWriteProperty("ptvien1", true);
                if (_ptvien1 != value)
                {
                    _ptvien1 = value;
                    PropertyHasChanged("ptvien1");
                }
            }
        }
        public String ptvien2
        {
            get
            {
                CanReadProperty("ptvien2", true);
                return _ptvien2;
            }
            set
            {
                CanWriteProperty("ptvien2", true);
                if (_ptvien2 != value)
                {
                    _ptvien2 = value;
                    PropertyHasChanged("ptvien2");
                }
            }
        }
        public String gayme
        {
            get
            {
                CanReadProperty("gayme", true);
                return _gayme;
            }
            set
            {
                CanWriteProperty("gayme", true);
                if (_gayme != value)
                {
                    _gayme = value;
                    PropertyHasChanged("gayme");
                }
            }
        }
        public String gaymec
        {
            get
            {
                CanReadProperty("gaymec", true);
                return _gaymec;
            }
            set
            {
                CanWriteProperty("gaymec", true);
                if (_gaymec != value)
                {
                    _gaymec = value;
                    PropertyHasChanged("gaymec");
                }
            }
        }
        public String gayme1
        {
            get
            {
                CanReadProperty("gayme1", true);
                return _gayme1;
            }
            set
            {
                CanWriteProperty("gayme1", true);
                if (_gayme1 != value)
                {
                    _gayme1 = value;
                    PropertyHasChanged("gayme1");
                }
            }
        }
        public String gayme2
        {
            get
            {
                CanReadProperty("gayme2", true);
                return _gayme2;
            }
            set
            {
                CanWriteProperty("gayme2", true);
                if (_gayme2 != value)
                {
                    _gayme2 = value;
                    PropertyHasChanged("gayme2");
                }
            }
        }
        public String cachgayme
        {
            get
            {
                CanReadProperty("cachgayme", true);
                return _cachgayme;
            }
            set
            {
                CanWriteProperty("cachgayme", true);
                if (_cachgayme != value)
                {
                    _cachgayme = value;
                    PropertyHasChanged("cachgayme");
                }
            }
        }
        public String ppphauthuat
        {
            get
            {
                CanReadProperty("ppphauthuat", true);
                return _ppphauthuat;
            }
            set
            {
                CanWriteProperty("ppphauthuat", true);
                if (_ppphauthuat != value)
                {
                    _ppphauthuat = value;
                    PropertyHasChanged("ppphauthuat");
                }
            }
        }
        public String cec
        {
            get
            {
                CanReadProperty("cec", true);
                return _cec;
            }
            set
            {
                CanWriteProperty("cec", true);
                if (_cec != value)
                {
                    _cec = value;
                    PropertyHasChanged("cec");
                }
            }
        }
        public String cecc
        {
            get
            {
                CanReadProperty("cecc", true);
                return _cecc;
            }
            set
            {
                CanWriteProperty("cecc", true);
                if (_cecc != value)
                {
                    _cecc = value;
                    PropertyHasChanged("cecc");
                }
            }
        }
        public String cec1
        {
            get
            {
                CanReadProperty("cec1", true);
                return _cec1;
            }
            set
            {
                CanWriteProperty("cec1", true);
                if (_cec1 != value)
                {
                    _cec1 = value;
                    PropertyHasChanged("cec1");
                }
            }
        }
        public String cec2
        {
            get
            {
                CanReadProperty("cec2", true);
                return _cec2;
            }
            set
            {
                CanWriteProperty("cec2", true);
                if (_cec2 != value)
                {
                    _cec2 = value;
                    PropertyHasChanged("cec2");
                }
            }
        }
        public String dungcu
        {
            get
            {
                CanReadProperty("dungcu", true);
                return _dungcu;
            }
            set
            {
                CanWriteProperty("dungcu", true);
                if (_dungcu != value)
                {
                    _dungcu = value;
                    PropertyHasChanged("dungcu");
                }
            }
        }
        public String dungcuc
        {
            get
            {
                CanReadProperty("dungcuc", true);
                return _dungcuc;
            }
            set
            {
                CanWriteProperty("dungcuc", true);
                if (_dungcuc != value)
                {
                    _dungcuc = value;
                    PropertyHasChanged("dungcuc");
                }
            }
        }
        public String dungcu1
        {
            get
            {
                CanReadProperty("dungcu1", true);
                return _dungcu1;
            }
            set
            {
                CanWriteProperty("dungcu1", true);
                if (_dungcu1 != value)
                {
                    _dungcu1 = value;
                    PropertyHasChanged("dungcu1");
                }
            }
        }
        public String dungcu2
        {
            get
            {
                CanReadProperty("dungcu2", true);
                return _dungcu2;
            }
            set
            {
                CanWriteProperty("dungcu2", true);
                if (_dungcu2 != value)
                {
                    _dungcu2 = value;
                    PropertyHasChanged("dungcu2");
                }
            }
        }
        public String loai
        {
            get
            {
                CanReadProperty("loai", true);
                return _loai;
            }
            set
            {
                CanWriteProperty("loai", true);
                if (_loai != value)
                {
                    _loai = value;
                    PropertyHasChanged("loai");
                }
            }
        }

        public String NoiDung
        {
            get
            {
                CanReadProperty("NoiDung", true);
                return _noiDung;
            }
            set
            {
                CanWriteProperty("NoiDung", true);
                if (_noiDung != value)
                {
                    _noiDung = value;
                    PropertyHasChanged("NoiDung");
                }
            }
        }
       
        public String MaChungLoai
        {
            get
            {
                CanReadProperty("MaChungLoai", true);
                return _maChungLoai;
            }
            set
            {
                CanWriteProperty("MaChungLoai", true);
                if (_maChungLoai != value)
                {
                    _maChungLoai = value;
                    PropertyHasChanged("MaChungLoai");
                }
            }
        }
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
        public string maphong
        {
            get
            {
                CanReadProperty("maphong", true);
                return _maphong;
            }
            set
            {
                CanWriteProperty("maphong", true);
                if (_maphong != value)
                {
                    _maphong = value;
                    PropertyHasChanged("maphong");
                }
            }
        }
        public byte ca
        {
            get
            {
                CanReadProperty("ca", true);
                return _ca;
            }
            set
            {
                CanWriteProperty("ca", true);
                if (_ca != value)
                {
                    _ca = value;
                    PropertyHasChanged("ca");
                }
            }
        }
		public String MaPT
		{
			get 
			{
				CanReadProperty("MaPT", true);
				return _maPT;
			}
			set 
			{
				CanWriteProperty("MaPT", true);
				if (_maPT != value) 
				{
					_maPT = value;
					PropertyHasChanged("MaPT");
				}
			}
		}
        public String tentat
        {
            get
            {
                CanReadProperty("tentat", true);
                return _tentat;
            }
            set
            {
                CanWriteProperty("tentat", true);
                if (_tentat != value)
                {
                    _tentat = value;
                    PropertyHasChanged("tentat");
                }
            }
        }
        public String MaLoaiPT
        {
            get
            {
                CanReadProperty("MaLoaiPT", true);
                return _maloaiPT;
            }
            set
            {
                CanWriteProperty("MaLoaiPT", true);
                if (_maloaiPT != value)
                {
                    _maloaiPT = value;
                    PropertyHasChanged("MaLoaiPT");
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
                _ngayDK.FormatString = "dd/MM/yyyy HH:mm"; 
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

        public string NgayDKD
        {
            get
            {
                //CanReadProperty("NgayDKD", true);
                //_ngayDKD.FormatString = "dd/MM/yyyy HH:mm";
                //_ngayDKD = _ngayDK;
                //return _ngayDKD.Text;
                _ngayDKD  = _ngayDK ;
                _ngayDKD.FormatString = "dd/MM/yyyy";

                return _ngayDKD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayDK", true);
            //    if (_ngayDK.Text != value)
            //    {
            //        _ngayDK.Text = value;
            //        PropertyHasChanged("NgayDK");
            //    }
            //}
        }
		
		public Boolean DaThucHien
		{
			get 
			{
				CanReadProperty("DaThucHien", true);
				return _daThucHien;
			}
			set 
			{
				CanWriteProperty("DaThucHien", true);
				if (_daThucHien != value) 
				{
					_daThucHien = value;
					PropertyHasChanged("DaThucHien");
				}
			}
		}
		
		public Decimal SLYCau
		{
			get 
			{
				CanReadProperty("SLYCau", true);
				return _sLYCau;
			}
			set 
			{
				CanWriteProperty("SLYCau", true);
				if (_sLYCau != value) 
				{
					_sLYCau = value;
					PropertyHasChanged("SLYCau");
				}
			}
		}
		
		public Decimal SLMua
		{
			get 
			{
				CanReadProperty("SLMua", true);
				return _sLMua;
			}
			set 
			{
				CanWriteProperty("SLMua", true);
				if (_sLMua != value) 
				{
					_sLMua = value;
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
                {
                    return "0";
                }
                else
                {
                    return _dongiaTT.ToString("###,###");
                }
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
                {
                    return "0";
                }
                else
                {
                    return _donGiaBH.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DonGiaBH", true);

                if (_donGiaBH.ToString() != value)
                {
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
                {
                    return "0";
                }
                else if (_giaChenhLech - (int)(_giaChenhLech) != 0)
                {
                    return _giaChenhLech.ToString("###,###.##");
                }
                else
                {
                    return _giaChenhLech.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("GiaChenhLech", true);

                if (_giaChenhLech.ToString() != value)
                {
                    _giaChenhLech = decimal.Parse(value);
                    PropertyHasChanged("GiaChenhLech");
                }
            }
        }
        //public Decimal DongiaTT
        //{
        //    get 
        //    {
        //        CanReadProperty("DongiaTT", true);
        //        return _dongiaTT;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("DongiaTT", true);
        //        if (_dongiaTT != value) 
        //        {
        //            _dongiaTT = value;
        //            PropertyHasChanged("DongiaTT");
        //        }
        //    }
        //}
		
		public Decimal DongiaUSD
		{
			get 
			{
				CanReadProperty("DongiaUSD", true);
				return _dongiaUSD;
			}
			set 
			{
				CanWriteProperty("DongiaUSD", true);
				if (_dongiaUSD != value) 
				{
					_dongiaUSD = value;
					PropertyHasChanged("DongiaUSD");
				}
			}
		}
		
		public Decimal TyGia
		{
			get 
			{
				CanReadProperty("TyGia", true);
				return _tyGia;
			}
			set 
			{
				CanWriteProperty("TyGia", true);
				if (_tyGia != value) 
				{
					_tyGia = value;
					PropertyHasChanged("TyGia");
				}
			}
		}
		
        //public Decimal DonGiaBH
        //{
        //    get 
        //    {
        //        CanReadProperty("DonGiaBH", true);
        //        return _donGiaBH;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("DonGiaBH", true);
        //        if (_donGiaBH != value) 
        //        {
        //            _donGiaBH = value;
        //            PropertyHasChanged("DonGiaBH");
        //        }
        //    }
        //}
		
        //public Decimal GiaChenhLech
        //{
        //    get 
        //    {
        //        CanReadProperty("GiaChenhLech", true);
        //        return _giaChenhLech;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("GiaChenhLech", true);
        //        if (_giaChenhLech != value) 
        //        {
        //            _giaChenhLech = value;
        //            PropertyHasChanged("GiaChenhLech");
        //        }
        //    }
        //}
		
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
		
		public String CDTruocMo
		{
			get 
			{
				CanReadProperty("CDTruocMo", true);
				return _cDTruocMo;
			}
			set 
			{
				CanWriteProperty("CDTruocMo", true);
				if (_cDTruocMo != value) 
				{
					_cDTruocMo = value;
					PropertyHasChanged("CDTruocMo");
				}
			}
		}
		
		public String CDSauMo
		{
			get 
			{
				CanReadProperty("CDSauMo", true);
				return _cDSauMo;
			}
			set 
			{
				CanWriteProperty("CDSauMo", true);
				if (_cDSauMo != value) 
				{
					_cDSauMo = value;
					PropertyHasChanged("CDSauMo");
				}
			}
		}
		
		public String MaGPBenh
		{
			get 
			{
				CanReadProperty("MaGPBenh", true);
				return _maGPBenh;
			}
			set 
			{
				CanWriteProperty("MaGPBenh", true);
				if (_maGPBenh != value) 
				{
					_maGPBenh = value;
					PropertyHasChanged("MaGPBenh");
				}
			}
		}
		
		public Byte HTPhauThuat
		{
			get 
			{
				CanReadProperty("HTPhauThuat", true);
				return _hTPhauThuat;
			}
			set 
			{
				CanWriteProperty("HTPhauThuat", true);
				if (_hTPhauThuat != value) 
				{
					_hTPhauThuat = value;
					PropertyHasChanged("HTPhauThuat");
				}
			}
		}
     
		public Boolean TaibienPT
		{
			get 
			{
				CanReadProperty("TaibienPT", true);
				return _taibienPT;
			}
			set 
			{
				CanWriteProperty("TaibienPT", true);
				if (_taibienPT != value) 
				{
					_taibienPT = value;
					PropertyHasChanged("TaibienPT");
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
				return _bHTinhtien;
			}
			set 
			{
				CanWriteProperty("BHTinhtien", true);
				if (_bHTinhtien != value) 
				{
					_bHTinhtien = value;
					PropertyHasChanged("BHTinhtien");
				}
			}
		}
		
		public Boolean TinhNgoai
		{
			get 
			{
				CanReadProperty("TinhNgoai", true);
				return _tinhNgoai;
			}
			set 
			{
				CanWriteProperty("TinhNgoai", true);
				if (_tinhNgoai != value) 
				{
					_tinhNgoai = value;
					PropertyHasChanged("TinhNgoai");
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
                _ngayTToan.FormatString = "dd/MM/yyyy HH:mm"; 
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

        public string NgayTToanD
        {
            get
            {
                CanReadProperty("NgayTToan", true);
                _ngayTToanD.FormatString = "dd/MM/yyyy";
                _ngayTToanD = _ngayTToan;
                return _ngayTToanD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayTToan", true);
            //    if (_ngayTToan.Text != value)
            //    {
            //        _ngayTToan.Text = value;
            //        PropertyHasChanged("NgayTToan");
            //    }
            //}
        }
		
		public Boolean ADGIAUSD
		{
			get 
			{
				CanReadProperty("ADGIAUSD", true);
				return _aDGIAUSD;
			}
			set 
			{
				CanWriteProperty("ADGIAUSD", true);
				if (_aDGIAUSD != value) 
				{
					_aDGIAUSD = value;
					PropertyHasChanged("ADGIAUSD");
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
		
		public String LyDoHuy
		{
			get 
			{
				CanReadProperty("LyDoHuy", true);
				return _lyDoHuy;
			}
			set 
			{
				CanWriteProperty("LyDoHuy", true);
				if (_lyDoHuy != value) 
				{
					_lyDoHuy = value;
					PropertyHasChanged("LyDoHuy");
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
        


        public String TenPT
        {
            get
            {
                CanReadProperty("TenPT", true);
                return _tenPT;
            }
            set
            {
                CanWriteProperty("TenPT", true);
                if (_tenPT != value)
                {
                    _tenPT = value;
                    PropertyHasChanged("TenPT");
                }
            }
        }

        public String TenLoaiPT
        {
            get
            {
                CanReadProperty("TenLoaiPT", true);
                return _tenloaiPT;
            }
            set
            {
                CanWriteProperty("TenLoaiPT", true);
                if (_tenloaiPT != value)
                {
                    _tenloaiPT = value;
                    PropertyHasChanged("TenLoaiPT");
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

        public String TenBSChidinh
        {
            get
            {
                CanReadProperty("TenBSChidinh", true);
                return _tenBSChidinh;
            }
            set
            {
                CanWriteProperty("TenBSChidinh", true);
                if (_tenBSChidinh != value)
                {
                    _tenBSChidinh = value;
                    PropertyHasChanged("TenBSChidinh");
                }
            }
        }

        public String TenBenhCDTruocMo
        {
            get
            {
                CanReadProperty("TenBenhCDTruocMo", true);
                return _tenBenhCDTruocMo;
            }
            set
            {
                CanWriteProperty("TenBenhCDTruocMo", true);
                if (_tenBenhCDTruocMo != value)
                {
                    _tenBenhCDTruocMo = value;
                    PropertyHasChanged("TenBenhCDTruocMo");
                }
            }
        }

        public String TenBenhCDSauMo
        {
            get
            {
                CanReadProperty("TenBenhCDSauMo", true);
                return _tenBenhCDSauMo;
            }
            set
            {
                CanWriteProperty("TenBenhCDSauMo", true);
                if (_tenBenhCDSauMo != value)
                {
                    _tenBenhCDSauMo = value;
                    PropertyHasChanged("TenBenhCDSauMo");
                }
            }
        }

        public String MaICDTruocMo
        {
            get
            {
                CanReadProperty("MaICDTruocMo", true);
                return _maICDTruocMo;
            }
            set
            {
                CanWriteProperty("MaICDTruocMo", true);
                if (_maICDTruocMo != value)
                {
                    _maICDTruocMo = value;
                    PropertyHasChanged("MaICDTruocMo");
                }
            }
        }

        public String MaICDSauMo
        {
            get
            {
                CanReadProperty("MaICDSauMo", true);
                return _maICDSauMo;
            }
            set
            {
                CanWriteProperty("MaICDSauMo", true);
                if (_maICDSauMo != value)
                {
                    _maICDSauMo = value;
                    PropertyHasChanged("MaICDSauMo");
                }
            }
        }

        public String MaKhoa
        {
            get
            {
                CanReadProperty("MaKhoa", true);
                return _maKhoa;
            }
            set
            {
                CanWriteProperty("MaKhoa", true);
                if (_maKhoa != value)
                {
                    _maKhoa = value;
                    PropertyHasChanged("MaKhoa");
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

        BenhAn_PhauThuat_TVList _BenhAn_PhauThuat_TVList = BenhAn_PhauThuat_TVList.NewBenhAn_PhauThuat_TVList();

        public BenhAn_PhauThuat_TVList BenhAn_PhauThuat_TVs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _BenhAn_PhauThuat_TVList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_BenhAn_PhauThuat_TVList.Equals(value))
                {
                    _BenhAn_PhauThuat_TVList = value;
                    PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _BenhAn_PhauThuat_TVList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _BenhAn_PhauThuat_TVList.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_PhauThuat" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static BenhAn_PhauThuat NewBenhAn_PhauThuat()
        {
            return DataPortal.Create<BenhAn_PhauThuat>();
        }
        //public static BenhAn_PhauThuat NewBenhAn_PhauThuat(string idDMPhauthuat)
        //{
        //    return new BenhAn_PhauThuat(DMPhauThuat.GetDMPhauThuat(idDMPhauthuat));
        //}
		public static BenhAn_PhauThuat GetBenhAn_PhauThuat(String maBA, Int32 sTT, Int32 sTTKhoa,Boolean qadmin)
		{
            return DataPortal.Fetch<BenhAn_PhauThuat>(new Criteria(maBA, sTT, sTTKhoa, qadmin));
		}
        public static BenhAn_PhauThuat GetBenhAn_PhauThuat(SafeDataReader dr)
        {
            BenhAn_PhauThuat obj = new BenhAn_PhauThuat();
            obj.Fetch(dr);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_PhauThuat" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_PhauThuat(String maBA, Int32 sTT, Int32 sTTKhoa, string lydohuy, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa, lydohuy ));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_PhauThuat()
		{	
			// Prevent direct creation
            _sLMua = 1;
            _sLYCau = 1;
		}

        internal BenhAn_PhauThuat(
  int OrderNumber,
  String maBA ,
		                                 Int32 sTT ,
		                                 Int32 sTTKhoa,
		                                 String maPT ,
             String tentat,
		                                 String maBN ,
  SmartDate ngayDK ,
  //SmartDate ngayDKD ,
		                                 Boolean daThucHien ,
		                                 Decimal sLYCau ,
		                                 Decimal sLMua ,
		                                 Decimal dongiaTT ,
		                                 Decimal dongiaUSD ,
		                                 Decimal tyGia ,
		                                 Decimal donGiaBH ,
		                                 Decimal giaChenhLech ,
		                                 Decimal ck ,
		                                 String bSChiDinh ,
		                                 String cDTruocMo ,
		                                 String cDSauMo ,
		                                 String maGPBenh ,
  Byte hTPhauThuat,
		                                 Boolean taibienPT ,
		                                 Boolean tinhtien ,
		                                 Boolean bHTinhtien ,
		                                 Boolean tinhNgoai ,
		                                 Byte dATT ,
		                                 String nguoiTT ,
  SmartDate ngayTToan ,
  //SmartDate ngayTToanD ,
		                                 Boolean aDGIAUSD ,
		                                 String maMay ,
		                                 Boolean huy,
		                                 SmartDate ngayHuy ,
		                                 String lyDoHuy ,
		                                 SmartDate ngayLap ,
		                                 String nguoiLap ,
		                                 SmartDate ngaySD ,
		                                 String nguoiSD ,
		                                 String nguoiHuy ,
		                                 SmartDate ngaySD1 ,
		                                 String nguoiSD1 ,
  String tenPT ,
  String tenNguoiLap ,
  String tenNguoiSD ,
  String tenNguoiHuy ,
  String tenBSChidinh ,
 // String tenNguoiTra ,
  String tenBenhCDTruocMo ,
  String tenBenhCDSauMo ,
 string makhoa,
 string maicdtruocmo,
 string maicdsaumo,
 string noidung, string cachgayme, string pphauthuat, string maloaipt, string tenloaipt, string tenkhoa,
            string tenlh,string makhoaql, byte ca,Boolean ktc
         
            )
        {
                  _OrderNumber = OrderNumber ;
                  _ca = ca;
                  _maBA = maBA ;
                  _KTC = ktc;
		          _sTT = sTT ;
		          _sTTKhoa = sTTKhoa ;
                  _maKhoaQL = makhoaql;
		          _maPT = maPT ;
                  _tentat = tentat;
                  _tenloaiPT = tenloaipt;
                  _maloaiPT = maloaipt;
		          _maBN = maBN ;
                  _ngayDK = ngayDK ;
                  _tenKhoa = tenkhoa;
                  _tenlh = tenlh;
                 // _ngayDKD = new SmartDate("", true);
		          _daThucHien = daThucHien ;
		          _sLYCau = sLYCau ;
		          _sLMua = sLMua ;
		          _dongiaTT = dongiaTT ;
		          _dongiaUSD = dongiaUSD ;
		          _tyGia = tyGia ;
		          _donGiaBH = donGiaBH ;
		          _giaChenhLech = giaChenhLech ;
		          _ck = ck ;
		          _bSChiDinh = bSChiDinh ;
		          _cDTruocMo = cDTruocMo ;
		          _cDSauMo = cDSauMo ;
		          _maGPBenh = maGPBenh ;
		          _hTPhauThuat = hTPhauThuat ;
		          _taibienPT = taibienPT ;
		          _tinhtien = tinhtien ;
		          _bHTinhtien = bHTinhtien ;
		          _tinhNgoai = tinhNgoai ;
		          _dATT = dATT  ;
		          _nguoiTT = nguoiTT ;
                  _ngayTToan = ngayTToan ;
                  //_ngayTToanD = new SmartDate("", true);
		          _aDGIAUSD = aDGIAUSD ;
		          _maMay = maMay ;
		          _huy = huy ;
		          _ngayHuy = ngayHuy ;
		          _lyDoHuy = lyDoHuy ;
		          _ngayLap = ngayLap ;
		          _nguoiLap = nguoiLap ;
		          _ngaySD = ngaySD ;
		          _nguoiSD = nguoiSD ;
		          _nguoiHuy = nguoiHuy ;
		          _ngaySD1 = ngaySD1  ;
		          _nguoiSD1 = nguoiSD1 ;
                  _tenPT = tenPT ;
                  _tenNguoiLap = tenNguoiLap ;
                  _tenNguoiSD = tenNguoiSD ;
                  _tenNguoiHuy = tenNguoiHuy ;
                  _tenBSChidinh = tenBSChidinh ;
                  //_tenNguoiTra = tenNguoiTra ;
                  _tenBenhCDTruocMo = tenBenhCDTruocMo;
                  _tenBenhCDSauMo = tenBenhCDSauMo;
                  _maKhoa = makhoa;
                  _maICDTruocMo = maicdtruocmo;
                  _maICDSauMo = maicdsaumo;
                  _noiDung = noidung;
                  _cachgayme = cachgayme;
                  _ppphauthuat = pphauthuat;
                  if (_tinhtien == true || _bHTinhtien == false)
                      _bh = false;
                  else if (_bHTinhtien == true)
                      _bh = true;
        }
       // protected BenhAn_PhauThuat(DMPhauThuat pro)
       // {
       //     MarkAsChild();
           
       //     //_maPhieu = dr.GetString("MaPhieu");
       //     _maPT = pro.MaPT;
       //    // _maMay = pro.MaMay;
       //    // _huy = pro.Huy;
       //    //// _ngaySD = pro.NgaySD ;
       //    // _nguoiSD = pro.NguoiSD;
       ////     _tenDV = pro.TenDV;
       //     //MarkOld();
       // }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
            private bool _qadmin = false   ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
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
			
			public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa, bool qadmin)
			{
				_maBA = maBA;
				_sTT = sTT;
				_sTTKhoa = sTTKhoa;
                _qadmin = qadmin;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
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
            private String _lydohuy;
            public String lydohuy
            {
                get
                {
                    return _lydohuy;
                }
            }
            public OtherCriteria(String Mamay, String Nguoisd, String maBA, Int32 sTT, Int32 sTTKhoa, String lydohuy)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _lydohuy = lydohuy;
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
		/// Retrieve an existing <see cref="BenhAn_PhauThuat" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_PhauThuat_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_PhauThuat(crit.MaBA, crit.STT, crit.STTKhoa, crit.qadmin  )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _BenhAn_PhauThuat_TVList = BenhAn_PhauThuat_TVList.GetBenhAn_PhauThuat_TVList(dr);//////////////
                    }
                    //MarkOld();
                    //ValidationRules.CheckRules();
				}
                dr.Close(); dr.Dispose();
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_PhauThuat" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetString("MaPT") != null) _maPT = dr.GetString("MaPT");
            if (dr.GetString("tentat") != null) _tentat = dr.GetString("tentat");
            if (dr.GetString("MaloaiPT") != null) _maloaiPT = dr.GetString("MaloaiPT");
            _tenloaiPT = dr.GetString("TenloaiPT");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("malh") != null) _malh = dr.GetString("malh");
            if (dr.GetString("tenKhoa") != null) _tenKhoa = dr.GetString("tenKhoa");
            if (dr.GetString("tenlh") != null) _tenlh = dr.GetString("tenlh");
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
			if (dr.GetBoolean("DaThucHien") != null) _daThucHien = dr.GetBoolean("DaThucHien");
			if (dr.GetDecimal("SLYCau") != null) _sLYCau = dr.GetDecimal("SLYCau");
			if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
			if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
			if (dr.GetDecimal("DongiaUSD") != null) _dongiaUSD = dr.GetDecimal("DongiaUSD");
			if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
			if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
			if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
			if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
			if (dr.GetString("BSChiDinh") != null) _bSChiDinh = dr.GetString("BSChiDinh");
			if (dr.GetString("CDTruocMo") != null) _cDTruocMo = dr.GetString("CDTruocMo");
			if (dr.GetString("CDSauMo") != null) _cDSauMo = dr.GetString("CDSauMo");
			if (dr.GetString("MaGPBenh") != null) _maGPBenh = dr.GetString("MaGPBenh");
            if (dr.GetByte("hTPhauThuat") != null) _hTPhauThuat = dr.GetByte("hTPhauThuat");
			if (dr.GetBoolean("TaibienPT") != null) _taibienPT = dr.GetBoolean("TaibienPT");
			if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
			if (dr.GetBoolean("BHTinhtien") != null) _bHTinhtien = dr.GetBoolean("BHTinhtien");
            if (_tinhtien == true || _bHTinhtien == false)
                _bh = false;
            else if (_bHTinhtien == true)
                _bh = true;
            _maKhoaQL = dr.GetString("MaKhoaql");
			if (dr.GetBoolean("TinhNgoai") != null) _tinhNgoai = dr.GetBoolean("TinhNgoai");
            if (dr.GetBoolean("KTC") != null) _KTC = dr.GetBoolean("KTC");
          
			if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
			if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
			if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
			if (dr.GetBoolean("ADGIAUSD") != null) _aDGIAUSD = dr.GetBoolean("ADGIAUSD");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetString("cannang") != null) _cannang = dr.GetString("cannang");
            if (dr.GetString("chieucao") != null) _chieucao = dr.GetString("chieucao");
            if (dr.GetString("ptvien") != null) _ptvien = dr.GetString("ptvien");
            if (dr.GetString("ptvienc") != null) _ptvienc = dr.GetString("ptvienc");
            if (dr.GetString("ptvien1") != null) _ptvien1 = dr.GetString("ptvien1");
            if (dr.GetString("ptvien2") != null) _ptvien2 = dr.GetString("ptvien2");
            if (dr.GetString("cec") != null) _cec = dr.GetString("cec");
            if (dr.GetString("cecc") != null) _cecc = dr.GetString("cecc");
            if (dr.GetString("cec1") != null) _cec1 = dr.GetString("cec1");
            if (dr.GetString("cec2") != null) _cec2 = dr.GetString("cec2");
            if (dr.GetString("gayme") != null) _gayme = dr.GetString("gayme");
            if (dr.GetString("gaymec") != null) _gaymec = dr.GetString("gaymec");
            if (dr.GetString("gayme1") != null) _gayme1  = dr.GetString("gayme1");
            if (dr.GetString("gayme2") != null) _gayme2 = dr.GetString("gayme2");
            if (dr.GetString("cachgayme") != null) _cachgayme = dr.GetString("cachgayme");
            if (dr.GetString("ppphauthuat") != null) _ppphauthuat = dr.GetString("ppphauthuat");
            if (dr.GetByte("ca") != null) _ca = dr.GetByte("ca");
            if (dr.GetString("maphong") != null) _maphong = dr.GetString("maphong");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
                     _tenPT = dr.GetString("TenPT");
                     _tenNguoiLap = dr.GetString("TenNguoiLap");
                     _tenNguoiSD = dr.GetString("TenNguoiSD");
                     _tenNguoiHuy = dr.GetString("TenNguoiHuy");
                     _tenBSChidinh = dr.GetString("TenBSChidinh");
                    // _tenNguoiTra = dr.GetString("TenNguoiTra");
                     _tenBenhCDTruocMo = dr.GetString("TenBenhCDTruocMo");
                     _tenBenhCDSauMo = dr.GetString("TenBenhCDSauMo");
                     if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
                     _maICDTruocMo = dr.GetString("maICDTruocMo");
                     _maICDSauMo = dr.GetString("maICDSauMo");
                     _dungcu  = dr.GetString("dungcu");
                     _dungcu1 = dr.GetString("dungcu1");
                     _dungcu2 = dr.GetString("dungcu2");
                     _dungcuc = dr.GetString("dungcuc");
                     _loai = dr.GetString("loai");
                     if (dr.GetString("Noidung") != null) _noiDung = dr.GetString("Noidung");




		}
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_PhauThuat" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _sTT = DataProvider.Instance().InsertBenhAn_PhauThuat(_maBA, _sTT, _sTTKhoa, _maPT, _maBN, _ngayDK, _daThucHien, _sLYCau, _sLMua, _dongiaTT, _dongiaUSD, _tyGia, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _cDTruocMo, _cDSauMo, _maGPBenh, _hTPhauThuat, _taibienPT, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT, _nguoiTT, _ngayTToan, _aDGIAUSD, _maMay, _nguoiSD , _maKhoa, _maChungLoai, _malh, _chieucao, _cannang, _ca, _maphong, _ptvien, _ptvienc, _ptvien1, _ptvien2, _gayme, _gaymec, _gayme1, _gayme2, _cec, _cecc, _cec1, _cec2, _dungcu, _dungcuc, _dungcu1, _dungcu2, _loai, _cachgayme, _ppphauthuat ,_maloaiPT , _tenBenhCDTruocMo, _tenBenhCDSauMo, _noiDung, _maDT, _STTDT);
			// public abstract String InsertBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _ngayDK, Boolean _daThucHien, Decimal _sLYCau, Decimal _sLMua, Decimal _dongiaTT, Decimal _dongiaUSD, Decimal _tyGia, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _aDGIAUSD, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _ngayDK, Boolean _daThucHien, Decimal _sLYCau, Decimal _sLMua, Decimal _dongiaTT, Decimal _dongiaUSD, Decimal _tyGia, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _aDGIAUSD, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_PhauThuat_Create", _maBA, _sTT, _sTTKhoa, _maPT, _maBN, _ngayDK.DBValue, _daThucHien, _sLYCau, _sLMua, _dongiaTT, _dongiaUSD, _tyGia, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _cDTruocMo, _cDSauMo, _maGPBenh, _hTPhauThuat, _taibienPT, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _aDGIAUSD,_maMay ,   _nguoiLap);
			// }
            MarkOld();
            _BenhAn_PhauThuat_TVList.Update(this);
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_PhauThuat" /> Object to underlying database.
		/// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_C
            if (IsDirty)
            {
                
                  
                  DataProvider.Instance().UpdateBenhAn_PhauThuat(_maBA, _sTT, _sTTKhoa, _maPT, _maBN, _ngayDK, _daThucHien, _sLYCau, _sLMua, _dongiaTT, _dongiaUSD, _tyGia, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _cDTruocMo, _cDSauMo, _maGPBenh, _hTPhauThuat, _taibienPT, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan, _aDGIAUSD,_maMay, _huy,_nguoiSD, _maChungLoai, _malh, _chieucao, _cannang, _ca, _maphong, _ptvien, _ptvienc, _ptvien1, _ptvien2, _gayme, _gaymec, _gayme1, _gayme2, _cec, _cecc, _cec1, _cec2, _dungcu, _dungcuc, _dungcu1, _dungcu2, _loai, _cachgayme,_ppphauthuat ,_maloaiPT ,  _tenBenhCDTruocMo, _tenBenhCDSauMo, _noiDung);
				// public abstract void UpdateBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _ngayDK, Boolean _daThucHien, Decimal _sLYCau, Decimal _sLMua, Decimal _dongiaTT, Decimal _dongiaUSD, Decimal _tyGia, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _aDGIAUSD, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maPT, String _maBN, SmartDate _ngayDK, Boolean _daThucHien, Decimal _sLYCau, Decimal _sLMua, Decimal _dongiaTT, Decimal _dongiaUSD, Decimal _tyGia, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, String _bSChiDinh, String _cDTruocMo, String _cDSauMo, String _maGPBenh, Byte _hTPhauThuat, Boolean _taibienPT, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _aDGIAUSD, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_PhauThuat_Update", _maBA, _sTT, _sTTKhoa, _maPT, _maBN, _ngayDK.DBValue, _daThucHien, _sLYCau, _sLMua, _dongiaTT, _dongiaUSD, _tyGia, _donGiaBH, _giaChenhLech, _ck, _bSChiDinh, _cDTruocMo, _cDSauMo, _maGPBenh, _hTPhauThuat, _taibienPT, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue, _aDGIAUSD,_maMay ,   _huy, _nguoiSD);
				// }			
                _BenhAn_PhauThuat_TVList.Update(this);
			}
		}
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   ,_maBA, _sTT, _sTTKhoa, _lyDoHuy ));
        }

        /// <summary>
        /// Delete the <see cref="BenhAn_PhauThuat" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_PhauThuat
            DataProvider.Instance().DeleteBenhAn_PhauThuat(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa, crit.lydohuy  );
            // public abstract void DeleteBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override void DeleteBenhAn_PhauThuat(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_PhauThuat_Deleted", _maBA, _sTT, _sTTKhoa);
            // }
        }
        //internal void DeleteSelf(BenhAn obj)
        //{
        //    // if we're not dirty then don't update the database
        //    if (!this.IsDirty)
        //        return;

        //    // if we're new then don't update the database
        //    if (this.IsNew)
        //        return;
        //    //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
        //    DataProvider.Instance().DeleteBenhAn_PhauThuat(_maMay,_nguoiSD, obj.MaBA, _sTT, _sTTKhoa, _lyDoHuy);
        //    MarkNew();
        //}
		#endregion
	}

}
