// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_ThuocSD_DY
// Kieu doi tuong  :	BenhAn_ThuocSD_DY
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/11/2009 10:52:41 AM
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
	/// This is a base generated class of <see cref="BenhAn_ThuocSD_DY" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_ThuocSD_DY : BusinessBase<BenhAn_ThuocSD_DY>
	{
		#region Business Methods
		
		#region State Fields
        private Int32 _STTDT = 0;
        private String _maDT = String.Empty;
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private String _maBN = String.Empty;
		private SmartDate _ngayDK = new SmartDate(DateTime.Today);
		private SmartDate _tuNgay = new SmartDate(DateTime.Today);
        private SmartDate _denNgay = new SmartDate(DateTime.Today);
		private Decimal _sLThang = 1;
		private Decimal _sLMua = 1;
		private Decimal _ck = 0;
		private String _bSChiDinh = String.Empty;
		private String _lieuDung = String.Empty;
		private String _cachDung = String.Empty;
		private Boolean _tinhtien = false;
		private Boolean _sac = true;
		private Byte _dATT = 0;
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
		private String _maKX = String.Empty;
		private Boolean _thuocBX = false;
		private Boolean _thuocDX = false;
		private String _maKhoa = String.Empty;
        private String _tenKhoa = String.Empty;
		private String _maPX = String.Empty;

        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenBSChiDinh = String.Empty;
        private String _tenNguoiTra = String.Empty;
        private String _tenNguoiD = String.Empty;
        private String _tenNguoiP = String.Empty;

        private SmartDate _ngayDKD = new SmartDate("", true);
        private SmartDate _TuNgayD = new SmartDate(true);
        private SmartDate _DenNgayD = new SmartDate(true);
        private Boolean _thuocpm = false;

        private int _OrderNumber;
        private BenhAn_ThuocSD_DY_CList _BenhAn_ThuocSD_DY_CList = BenhAn_ThuocSD_DY_CList.NewBenhAn_ThuocSD_DY_CList();

		#endregion
		
		#region Business Properties and Methods
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
        public Boolean ThuocPM
        {
            get
            {
                CanReadProperty("ThuocPM", true);
                return _thuocpm;
            }
            set
            {
                CanWriteProperty("ThuocPM", true);
                if (_thuocpm != value)
                {
                    _thuocpm = value;
                    PropertyHasChanged("ThuocPM");
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
		
        //public Decimal SLThang
        //{
        //    get 
        //    {
        //        CanReadProperty("SLThang", true);
        //        return _sLThang;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLThang", true);
        //        if (_sLThang != value) 
        //        {
        //            _sLThang = value;
        //            PropertyHasChanged("SLThang");
        //        }
        //    }
        //}

        public string SLThang
        {
            get
            {
                CanReadProperty("SLThang", true);
                if (_sLThang == 0)
                {
                    return "0";
                }
                else if (_sLThang - (int)(_sLThang) != 0)
                {
                    return _sLThang.ToString("###,##0.##");
                }
                else
                {
                    return _sLThang.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SLThang", true);

                if (_sLThang.ToString() != value)
                {
                    _sLThang = decimal.Parse(value);
                    PropertyHasChanged("SLThang");
                }
            }
        }
		
        //public Decimal SLMua
        //{
        //    get 
        //    {
        //        CanReadProperty("SLMua", true);
        //        return _sLMua;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLMua", true);
        //        if (_sLMua != value) 
        //        {
        //            _sLMua = value;
        //            PropertyHasChanged("SLMua");
        //        }
        //    }
        //}
        public string SoLuongTHD
        {
            get
            {

                return (_sLMua * (((_denNgay.Date - _tuNgay.Date).Days) + 1)).ToString("###,###");

            }

        }
        public string SLMua
        {
            get
            {
                CanReadProperty("SLMua", true);
                if (_sLMua == 0)
                {
                    return "0";
                }
                else if (_sLMua - (int)(_sLMua) != 0)
                {
                    return _sLMua.ToString("###,##0.##");
                }
                else
                {
                    return _sLMua.ToString("###,###");
                }
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
        public Boolean BHTinhtien
        {
            get
            {
                if (_tinhtien ==true ||_maDT.Substring (0,1)=="0")
               
                return false;
                else
                    return true;
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
		
		public Boolean Sac
		{
			get 
			{
				CanReadProperty("Sac", true);
				return _sac;
			}
			set 
			{
				CanWriteProperty("Sac", true);
				if (_sac != value) 
				{
					_sac = value;
					PropertyHasChanged("Sac");
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
		
		public Decimal SLTra
		{
			get 
			{
				CanReadProperty("SLTra", true);
				return _sLTra;
			}
			set 
			{
				CanWriteProperty("SLTra", true);
				if (_sLTra != value) 
				{
					_sLTra = value;
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
		
		public string NgayP
		{
			get 
			{
				CanReadProperty("NgayP", true);
				return _ngayP.Text;
			}
			set 
			{
				CanWriteProperty("NgayP", true);
				if (_ngayP.Text != value) 
				{
					_ngayP.Text = value;
					PropertyHasChanged("NgayP");
				}
			}
		}
		
		public String NguoiD
		{
			get 
			{
				CanReadProperty("NguoiD", true);
				return _nguoiD;
			}
			set 
			{
				CanWriteProperty("NguoiD", true);
				if (_nguoiD != value) 
				{
					_nguoiD = value;
					PropertyHasChanged("NguoiD");
				}
			}
		}
		
		public String NguoiP
		{
			get 
			{
				CanReadProperty("NguoiP", true);
				return _nguoiP;
			}
			set 
			{
				CanWriteProperty("NguoiP", true);
				if (_nguoiP != value) 
				{
					_nguoiP = value;
					PropertyHasChanged("NguoiP");
				}
			}
		}
		
		public string NgayD
		{
			get 
			{
				CanReadProperty("NgayD", true);
				return _ngayD.Text;
			}
			set 
			{
				CanWriteProperty("NgayD", true);
				if (_ngayD.Text != value) 
				{
					_ngayD.Text = value;
					PropertyHasChanged("NgayD");
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
		
		public String MaKX
		{
			get 
			{
				CanReadProperty("MaKX", true);
				return _maKX;
			}
			set 
			{
				CanWriteProperty("MaKX", true);
				if (_maKX != value) 
				{
					_maKX = value;
					PropertyHasChanged("MaKX");
				}
			}
		}
		
		public Boolean ThuocBX
		{
			get 
			{
				CanReadProperty("ThuocBX", true);
				return _thuocBX;
			}
			set 
			{
				CanWriteProperty("ThuocBX", true);
				if (_thuocBX != value) 
				{
					_thuocBX = value;
					PropertyHasChanged("ThuocBX");
				}
			}
		}
		
		public Boolean ThuocDX
		{
			get 
			{
				CanReadProperty("ThuocDX", true);
				return _thuocDX;
			}
			set 
			{
				CanWriteProperty("ThuocDX", true);
				if (_thuocDX != value) 
				{
					_thuocDX = value;
					PropertyHasChanged("ThuocDX");
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
                return _tenBSChiDinh;
            }
            set
            {
                CanWriteProperty("TenBSChidinh", true);
                if (_tenBSChiDinh != value)
                {
                    _tenBSChiDinh = value;
                    PropertyHasChanged("TenBSChidinh");
                }
            }
        }

        public String TenNguoiTra
        {
            get
            {
                CanReadProperty("TenNguoiTra", true);
                return _tenNguoiTra;
            }
            set
            {
                CanWriteProperty("TenNguoiTra", true);
                if (_tenNguoiTra != value)
                {
                    _tenNguoiTra = value;
                    PropertyHasChanged("TenNguoiTra");
                }
            }
        }

        public String TenNguoiD
        {
            get
            {
                CanReadProperty("TenNguoiD", true);
                return _tenNguoiD;
            }
            set
            {
                CanWriteProperty("TenNguoiD", true);
                if (_tenNguoiD != value)
                {
                    _tenNguoiD = value;
                    PropertyHasChanged("TenNguoiD");
                }
            }
        }

        public String TenNguoiP
        {
            get
            {
                CanReadProperty("TenNguoiP", true);
                return _tenNguoiP;
            }
            set
            {
                CanWriteProperty("TenNguoiP", true);
                if (_tenNguoiP != value)
                {
                    _tenNguoiP = value;
                    PropertyHasChanged("TenNguoiP");
                }
            }
        }
        
        public string NgayDKD
        {
            get
            {
                CanReadProperty("NgayDKD", true);

                _ngayDKD = _ngayDK;
                _ngayDKD.FormatString = "dd/MM/yyyy";
                return _ngayDKD.Text;
            }

        }
        public string TuNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _TuNgayD = _tuNgay;
                _TuNgayD.FormatString = "dd/MM/yyyy";
                return _TuNgayD.Text;
            }

        }
        public string DenNgayD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _DenNgayD = _denNgay;
                _DenNgayD.FormatString = "dd/MM/yyyy";
                return _DenNgayD.Text;
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

        public BenhAn_ThuocSD_DY_CList BenhAn_ThuocSD_DY_Cs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _BenhAn_ThuocSD_DY_CList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_BenhAn_ThuocSD_DY_CList.Equals(value))
                {
                    _BenhAn_ThuocSD_DY_CList = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _BenhAn_ThuocSD_DY_CList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _BenhAn_ThuocSD_DY_CList.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_ThuocSD_DY" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_ThuocSD_DY NewBenhAn_ThuocSD_DY()
        {
            return DataPortal.Create<BenhAn_ThuocSD_DY>();
        }
		public static BenhAn_ThuocSD_DY GetBenhAn_ThuocSD_DY(String maBA, Int32 sTT, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_ThuocSD_DY>(new Criteria(maBA, sTT, sTTKhoa));
		}
        public static BenhAn_ThuocSD_DY GetBenhAn_ThuocSD_DY(SafeDataReader dr)
        {
            BenhAn_ThuocSD_DY obj = new BenhAn_ThuocSD_DY();
            obj.Fetch(dr);
            return obj;
        }
        public static BenhAn_ThuocSD_DY GetBenhAn_ThuocSD_DY(SafeDataReader dr,int i)
        {
            BenhAn_ThuocSD_DY obj = new BenhAn_ThuocSD_DY();
            obj.Fetch(dr,i);
            return obj;
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_ThuocSD_DY" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteBenhAn_ThuocSD_DY(String maBA, Int32 sTT, Int32 sTTKhoa, string lydohuy, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa, lydohuy));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal BenhAn_ThuocSD_DY()
		{	
			// Prevent direct creation
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
		/// Retrieve an existing <see cref="BenhAn_ThuocSD_DY" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override IDataReader GetBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_ThuocSD_DY_GET", _maBA, _sTT, _sTTKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_ThuocSD_DY(crit.MaBA, crit.STT, crit.STTKhoa,false    )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _BenhAn_ThuocSD_DY_CList = BenhAn_ThuocSD_DY_CList.GetBenhAn_ThuocSD_DY_CList(dr);//////////////
                    }
                    //MarkOld();
                    //ValidationRules.CheckRules();
                } dr.Close(); dr.Dispose();
			}
		}
		/// <summary>
		/// Load a <see cref="BenhAn_ThuocSD_DY" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
			if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
			if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
			if (dr.GetDecimal("SLThang") != null) _sLThang = dr.GetDecimal("SLThang");
			if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
			if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
			if (dr.GetString("BSChiDinh") != null) _bSChiDinh = dr.GetString("BSChiDinh");
			if (dr.GetString("LieuDung") != null) _lieuDung = dr.GetString("LieuDung");
			if (dr.GetString("CachDung") != null) _cachDung = dr.GetString("CachDung");
			if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
			if (dr.GetBoolean("Sac") != null) _sac = dr.GetBoolean("Sac");
			if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
			if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
			if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
			if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
			if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
			if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
			if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
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
			if (dr.GetString("MaKX") != null) _maKX = dr.GetString("MaKX");
			if (dr.GetBoolean("ThuocBX") != null) _thuocBX = dr.GetBoolean("ThuocBX");
			if (dr.GetBoolean("ThuocDX") != null) _thuocDX = dr.GetBoolean("ThuocDX");
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetString("MaPX") != null) _maPX = dr.GetString("MaPX");
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            _tenBSChiDinh = dr.GetString("TenBSChidinh");
            _tenNguoiTra = dr.GetString("TenNguoiTra");
            _tenNguoiD = dr.GetString("tenNguoiD");
            _tenNguoiP = dr.GetString("tenNguoiP");
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            //if (dr.GetBoolean("thuocpm") != null) _thuocpm = dr.GetBoolean("thuocpm");
		}
        private void Fetch(SafeDataReader dr,int i)
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetDecimal("SLThang") != null) _sLThang = dr.GetDecimal("SLThang");
            if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
            if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
            if (dr.GetString("BSChiDinh") != null) _bSChiDinh = dr.GetString("BSChiDinh");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
            if (dr.GetString("LieuDung") != null) _lieuDung = dr.GetString("LieuDung");
            if (dr.GetString("CachDung") != null) _cachDung = dr.GetString("CachDung");
            if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
            if (dr.GetBoolean("Sac") != null) _sac = dr.GetBoolean("Sac");
            if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
            if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
            if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
            if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
            if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
            if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
            if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
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
            if (dr.GetString("MaKX") != null) _maKX = dr.GetString("MaKX");
            if (dr.GetBoolean("ThuocBX") != null) _thuocBX = dr.GetBoolean("ThuocBX");
            if (dr.GetBoolean("ThuocDX") != null) _thuocDX = dr.GetBoolean("ThuocDX");
            if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("MaPX") != null) _maPX = dr.GetString("MaPX");
            _tenNguoiLap = dr.GetString("TenNguoiLap");
            _tenNguoiSD = dr.GetString("TenNguoiSD");
            _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            _tenBSChiDinh = dr.GetString("TenBSChidinh");
            _tenNguoiTra = dr.GetString("TenNguoiTra");
            _tenNguoiD = dr.GetString("tenNguoiD");
            _tenNguoiP = dr.GetString("tenNguoiP");
            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            //if (dr.GetBoolean("thuocpm") != null) _thuocpm = dr.GetBoolean("thuocpm");
        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_ThuocSD_DY" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_ThuocSD_DY
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _sTT = DataProvider.Instance().InsertBenhAn_ThuocSD_DY(_maBA, _sTT, _sTTKhoa, _maBN, _ngayDK, _tuNgay, _denNgay, _sLThang, _sLMua, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _sac, _dATT,_nguoiSD, _ngayTToan, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _nguoiP, _ngayD,_maMay ,_nguoiSD, _maKX, _thuocBX, _thuocDX, _maKhoa,_maDT ,_STTDT );
			// public abstract String InsertBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maBN, SmartDate _ngayDK, SmartDate _tuNgay, SmartDate _denNgay, Decimal _sLThang, Decimal _sLMua, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _sac, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _maKX, Boolean _thuocBX, Boolean _thuocDX, String _maKhoa);
			// public override String InsertBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maBN, SmartDate _ngayDK, SmartDate _tuNgay, SmartDate _denNgay, Decimal _sLThang, Decimal _sLMua, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _sac, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, String _nguoiLap, String _maKX, Boolean _thuocBX, Boolean _thuocDX, String _maKhoa)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_ThuocSD_DY_Create", _maBA, _sTT, _sTTKhoa, _maBN, _ngayDK.DBValue, _tuNgay.DBValue, _denNgay.DBValue, _sLThang, _sLMua, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _sac, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue  ,_maMay ,_nguoiSD, _maKX, _thuocBX, _thuocDX, _maKhoa));
			// }
            _BenhAn_ThuocSD_DY_CList.Update(this);
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_ThuocSD_DY" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_ThuocSD_DY
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateBenhAn_ThuocSD_DY(_maBA, _sTT, _sTTKhoa, _maBN, _ngayDK, _tuNgay, _denNgay, _sLThang, _sLMua, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _sac, _dATT, _nguoiSD , _ngayTToan, _daTra, _nguoiTra, _ngaytra, _sLTra, _duyet, _phat, _ngayP, _nguoiD, _nguoiP, _ngayD, _maMay , _huy,_nguoiSD, _maKX, _thuocBX, _thuocDX);
				// public abstract void UpdateBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maBN, SmartDate _ngayDK, SmartDate _tuNgay, SmartDate _denNgay, Decimal _sLThang, Decimal _sLMua, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _sac, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _maKX, Boolean _thuocBX, Boolean _thuocDX);
				// public override void UpdateBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maBN, SmartDate _ngayDK, SmartDate _tuNgay, SmartDate _denNgay, Decimal _sLThang, Decimal _sLMua, Decimal _ck, String _bSChiDinh, String _lieuDung, String _cachDung, Boolean _tinhtien, Boolean _sac, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, Boolean _duyet, Boolean _phat, SmartDate _ngayP, String _nguoiD, String _nguoiP, SmartDate _ngayD, String _maMay, Boolean _huy, String _nguoiSD, String _maKX, Boolean _thuocBX, Boolean _thuocDX)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_ThuocSD_DY_Update", _maBA, _sTT, _sTTKhoa, _maBN, _ngayDK.DBValue, _tuNgay.DBValue, _denNgay.DBValue, _sLThang, _sLMua, _ck, _bSChiDinh, _lieuDung, _cachDung, _tinhtien, _sac, _dATT,_nguoiSD, _ngayTToan.DBValue, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra, _duyet, _phat, _ngayP.DBValue, _nguoiD, _nguoiP, _ngayD.DBValue,_maMay ,   _huy,_nguoiSD   , _maKX, _thuocBX, _thuocDX);
				// }		
                _BenhAn_ThuocSD_DY_CList.Update(this);
                MarkOld();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   , _maBA, _sTT, _sTTKhoa, _lyDoHuy));
		}

		/// <summary>
		/// Delete the <see cref="BenhAn_ThuocSD_DY" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_ThuocSD_DY
           
            DataProvider.Instance().DeleteBenhAn_ThuocSD_DY(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa, crit.lydohuy);
			// public abstract void DeleteBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_ThuocSD_DY(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_ThuocSD_DY_Deleted", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
