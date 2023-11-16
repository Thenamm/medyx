// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_TTNgoai
// Kieu doi tuong  :	BenhAn_TTNgoai
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	7/14/2009 2:38:48 PM
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
	/// This is a base generated class of <see cref="BenhAn_TTNgoai" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_TTNgoai : BusinessBase<BenhAn_TTNgoai>
	{
		#region Business Methods
		
		#region State Fields
        private String _maBS = String.Empty;
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private String _maDV = String.Empty;
		private String _MaSoKham = String.Empty;
        private String _malh = String.Empty;
        private SmartDate _tuNgay = new SmartDate("", true);
        private SmartDate _tuNgayD = new SmartDate("", true);
        private SmartDate _denNgay = new SmartDate("", true);
        private SmartDate _denNgayD = new SmartDate("", true);
        private SmartDate _ngayDK = new SmartDate("", true);
        private SmartDate _ngayDKD = new SmartDate("", true);
		private Decimal _soLuong = 0;
		private Decimal _dongiaTT = 0;
		private Decimal _donGiaBH = 0;
		private Decimal _giaChenhLech = 0;
		private Decimal _ck = 0;
		private Byte _daTT = 0;
        private Byte _loaikham = 0;
        private String _kq = String.Empty;
      
        private SmartDate _ngayTToan = new SmartDate("", true);
        private SmartDate _ngayTToanD = new SmartDate("", true);
		private String _bSKham = String.Empty;
        private SmartDate _ngayGioKham = new SmartDate("", true);
        private SmartDate _ngayGioKhamD = new SmartDate("", true);
        private SmartDate _ngayKT = new SmartDate("", true);
        private SmartDate _ngayKTD = new SmartDate("", true);
		private Boolean _tinhTien = false;
		private Boolean _bHTinhTien = false;
		private Boolean _tinhNgoai = false;
		private String _maMay = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private String _lyDoHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private String _lydoTra = String.Empty;
		private Boolean _daTra = false;
		private String _nguoiTra = String.Empty;
        private SmartDate _ngaytra = new SmartDate("", true);
        private SmartDate _ngaytraD = new SmartDate("", true);
		private Decimal _sLTra = 0;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
		private String _nguoiTT = String.Empty;
		private Decimal _tyGia = 0;
		private Boolean _aDGiaUSD = false;
		private Byte _uuTien = 0;
		private Decimal _slmua = 0;
		private String _maHuongDT = String.Empty;
		private String _maBenh = String.Empty;
        private String _tenDV = String.Empty;
        private String _tenBS = String.Empty;
        private String _tenbs1 = String.Empty;
        private String _tenTat = String.Empty;
        private Boolean _nhapSL = false;
        private String _tenBenh = String.Empty;
        private String _maICD = String.Empty;
        private String _tenKhoa = String.Empty;
        private String _tenKhoacd = String.Empty;
        private String _maKhoa = String.Empty;
        private String _khoaKham = String.Empty;
        private Decimal _thanhtien = 0;
        private int _OrderNumber;
        private Boolean _thuocpm = false;
        private Int32 _STTDT = 0;
        private String _maDT = String.Empty;
        private String _bschidinh = String.Empty;
        private String _tenbschidinh = String.Empty;
        private String _ghichu = String.Empty;
        
        private String _mabs4 = String.Empty;
        private String _mabs3 = String.Empty;
        private String _tenbs3 = String.Empty;
        private String _tenbs4 = String.Empty;
		#endregion
		
		#region Business Properties and Methods
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
   
        public String KQ
        {
            get
            {
                CanReadProperty("KQ", true);
                return _kq;
            }
            set
            {
                CanWriteProperty("KQ", true);
                if (_kq != value)
                {
                    _kq = value;
                    PropertyHasChanged("KQ");
                }
            }
        }
	
        public String bschidinh
        {
            get
            {
                CanReadProperty("bschidinh", true);
                return _bschidinh;
            }
            set
            {
                CanWriteProperty("bschidinh", true);
                if (_bschidinh != value)
                {
                    _bschidinh = value;
                    PropertyHasChanged("bschidinh");
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
        public String mabs3
        {
            get
            {
                CanReadProperty("mabs3", true);
                return _mabs3;
            }
            set
            {
                CanWriteProperty("mabs3", true);
                if (_mabs3 != value)
                {
                    _mabs3 = value;
                    PropertyHasChanged("mabs3");
                }
            }
        }
        public String tenbs3
        {
            get
            {
                CanReadProperty("tenbs3", true);
                return _tenbs3;
            }
            set
            {
                CanWriteProperty("tenbs3", true);
                if (_tenbs3 != value)
                {
                    _tenbs3 = value;
                    PropertyHasChanged("tenbs3");
                }
            }
        }
        public String mabs4
        {
            get
            {
                CanReadProperty("mabs4", true);
                return _mabs4;
            }
            set
            {
                CanWriteProperty("mabs4", true);
                if (_mabs4 != value)
                {
                    _mabs4 = value;
                    PropertyHasChanged("mabs4");
                }
            }
        }
        public String tenbs4
        {
            get
            {
                CanReadProperty("tenbs4", true);
                return _tenbs4;
            }
            set
            {
                CanWriteProperty("tenbs4", true);
                if (_tenbs4 != value)
                {
                    _tenbs4 = value;
                    PropertyHasChanged("tenbs4");
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
        public String tenbs1
        {
            get
            {
                CanReadProperty("tenbs1", true);
                return _tenbs1;
            }
            set
            {
                CanWriteProperty("tenbs1", true);
                if (_tenbs1 != value)
                {
                    _tenbs1 = value;
                    PropertyHasChanged("tenbs1");
                }
            }
        }
        public String MaBS
        {
            get
            {
                CanReadProperty("MaBS", true);
                return _maBS;
            }
            set
            {
                CanWriteProperty("MaBS", true);
                if (_maBS != value)
                {
                    _maBS = value;
                    PropertyHasChanged("MaBS");
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
                CanReadProperty("TuNgay", true);
                
                _tuNgayD = _tuNgay;
                _tuNgayD.FormatString = "dd/MM/yyyy";
                return _tuNgayD.Text;
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

        public string DenNgayD
        {
            get
            {
                CanReadProperty("DenNgayD", true);
                _denNgayD = _denNgay;
                _denNgayD.FormatString = "dd/MM/yyyy";

                return _denNgayD.Text;
            }
            //set
            //{
            //    CanWriteProperty("DenNgay", true);
            //    if (_denNgay.Text != value)
            //    {
            //        _denNgay.Text = value;
            //        PropertyHasChanged("DenNgay");
            //    }
            //}
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
		
		public String MaDV
		{
			get 
			{
				CanReadProperty("MaDV", true);
				return _maDV;
			}
			set 
			{
				CanWriteProperty("MaDV", true);
				if (_maDV != value) 
				{
					_maDV = value;
					PropertyHasChanged("MaDV");
				}
			}
		}
		
		public String MaSoKham
		{
			get 
			{
				CanReadProperty("MaSoKham", true);
				return _MaSoKham;
			}
			set 
			{
				CanWriteProperty("MaSoKham", true);
				if (_MaSoKham != value) 
				{
					_MaSoKham = value;
					PropertyHasChanged("MaSoKham");
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

        public string NgayDKD
        {
            get
            {
                CanReadProperty("NgayDKD", true);
                
                _ngayDKD = _ngayDK;
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

        //public Decimal SoLuong
        //{
        //    get 
        //    {
        //        CanReadProperty("SoLuong", true);
        //        return _soLuong;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SoLuong", true);
        //        if (_soLuong != value) 
        //        {
        //            _soLuong = value;
        //            PropertyHasChanged("SoLuong");
        //        }
        //    }
        //}
        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                {
                    return "0";
                }
                else if (_soLuong - (int)(_soLuong) != 0)
                {
                    return _soLuong.ToString("###,###.##");
                }
                else
                {
                    return _soLuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLuong", true);

                if (_soLuong.ToString() != value)
                {
                    _soLuong = decimal.Parse(value);
                    PropertyHasChanged("SoLuong");
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

        public string DongiaBH
        {
            get
            {
                CanReadProperty("DongiaBH", true);
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
                CanWriteProperty("DongiaBH", true);

                if (_donGiaBH.ToString() != value)
                {
                    _donGiaBH = decimal.Parse(value);
                    PropertyHasChanged("DongiaBH");
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
		
		public Byte DaTT
		{
			get 
			{
				CanReadProperty("DaTT", true);
				return _daTT;
			}
			set 
			{
				CanWriteProperty("DaTT", true);
				if (_daTT != value) 
				{
					_daTT = value;
					PropertyHasChanged("DaTT");
				}
			}
		}
        public Byte loaikham
        {
            get
            {
                CanReadProperty("loaikham", true);
                return _loaikham;
            }
            set
            {
                CanWriteProperty("loaikham", true);
                if (_loaikham != value)
                {
                    _loaikham = value;
                    PropertyHasChanged("loaikham");
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

        public string NgayTToanD
        {
            get
            {
                CanReadProperty("NgayTToanD", true);
                _ngayTToanD.FormatString = "dd/MM/yyyy";
                _ngayTToanD = _ngayTToan;
                return _ngayTToanD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayTToanD", true);
            //    if (_ngayTToan.Text != value)
            //    {
            //        _ngayTToan.Text = value;
            //        PropertyHasChanged("NgayTToanD");
            //    }
            //}
        }

		public String BSKham
		{
			get 
			{
				CanReadProperty("BSKham", true);
				return _bSKham;
			}
			set 
			{
				CanWriteProperty("BSKham", true);
				if (_bSKham != value) 
				{
					_bSKham = value;
					PropertyHasChanged("BSKham");
				}
			}
		}
		
		public string NgayGioKham
		{
			get 
			{
				CanReadProperty("NgayGioKham", true);
				return _ngayGioKham.Text;
			}
			set 
			{
				CanWriteProperty("NgayGioKham", true);
				if (_ngayGioKham.Text != value) 
				{
					_ngayGioKham.Text = value;
					PropertyHasChanged("NgayGioKham");
				}
			}
		}

        public string NgayGioKhamD
        {
            get
            {
                CanReadProperty("NgayGioKham", true);
                _ngayGioKhamD.FormatString = "dd/MM/yyyy";
                _ngayGioKhamD = _ngayGioKham; 
                return _ngayGioKhamD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayGioKham", true);
            //    if (_ngayGioKham.Text != value)
            //    {
            //        _ngayGioKham.Text = value;
            //        PropertyHasChanged("NgayGioKham");
            //    }
            //}
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

        public string NgayKTD
        {
            get
            {
                CanReadProperty("NgayKTD", true);
                _ngayKTD.FormatString = "dd/MM/yyyy";
                _ngayKTD = _ngayKT;
                return _ngayKTD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NgayKT", true);
            //    if (_ngayKT.Text != value)
            //    {
            //        _ngayKT.Text = value;
            //        PropertyHasChanged("NgayKT");
            //    }
            //}
        }
		
		public Boolean TinhTien
		{
			get 
			{
				CanReadProperty("TinhTien", true);
				return _tinhTien;
			}
			set 
			{
				CanWriteProperty("TinhTien", true);
				if (_tinhTien != value) 
				{
					_tinhTien = value;
					PropertyHasChanged("TinhTien");
				}
			}
		}
		
		public Boolean BHTinhTien
		{
			get 
			{
				CanReadProperty("BHTinhTien", true);
				return _bHTinhTien;
			}
			set 
			{
				CanWriteProperty("BHTinhTien", true);
				if (_bHTinhTien != value) 
				{
					_bHTinhTien = value;
					PropertyHasChanged("BHTinhTien");
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
		
		public String LydoTra
		{
			get 
			{
				CanReadProperty("LydoTra", true);
				return _lydoTra;
			}
			set 
			{
				CanWriteProperty("LydoTra", true);
				if (_lydoTra != value) 
				{
					_lydoTra = value;
					PropertyHasChanged("LydoTra");
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

        public string NgaytraD
        {
            get
            {
                CanReadProperty("NgaytraD", true);
                _ngaytraD.FormatString = "dd/MM/yyyy";
                _ngaytraD = _ngaytra;
                return _ngaytraD.Text;
            }
            //set
            //{
            //    CanWriteProperty("Ngaytra", true);
            //    if (_ngaytra.Text != value)
            //    {
            //        _ngaytra.Text = value;
            //        PropertyHasChanged("Ngaytra");
            //    }
            //}
        }
		
        //public Decimal SLTra
        //{
        //    get 
        //    {
        //        CanReadProperty("SLTra", true);
        //        return _sLTra;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("SLTra", true);
        //        if (_sLTra != value) 
        //        {
        //            _sLTra = value;
        //            PropertyHasChanged("SLTra");
        //        }
        //    }
        //}

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
                    return _sLTra.ToString("###,###.##");
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
		
		public Boolean ADGiaUSD
		{
			get 
			{
				CanReadProperty("ADGiaUSD", true);
				return _aDGiaUSD;
			}
			set 
			{
				CanWriteProperty("ADGiaUSD", true);
				if (_aDGiaUSD != value) 
				{
					_aDGiaUSD = value;
					PropertyHasChanged("ADGiaUSD");
				}
			}
		}
		
		public Byte UuTien
		{
			get 
			{
				CanReadProperty("UuTien", true);
				return _uuTien;
			}
			set 
			{
				CanWriteProperty("UuTien", true);
				if (_uuTien != value) 
				{
					_uuTien = value;
					PropertyHasChanged("UuTien");
				}
			}
		}
		
        //public Decimal Slmua
        //{
        //    get 
        //    {
        //        CanReadProperty("Slmua", true);
        //        return _slmua;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Slmua", true);
        //        if (_slmua != value) 
        //        {
        //            _slmua = value;
        //            PropertyHasChanged("Slmua");
        //        }
        //    }
        //}

        public string Slmua
        {
            get
            {
                CanReadProperty("Slmua", true);
                if (_slmua == 0)
                {
                    return "0";
                }
                else if (_slmua - (int)(_slmua) != 0)
                {
                    return _slmua.ToString("###,###.###");
                }
                else
                {
                    return _slmua.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Slmua", true);

                if (_slmua.ToString() != value)
                {
                    _slmua = decimal.Parse(value);
                    PropertyHasChanged("Slmua");
                }
            }
        }
		
		public String MaHuongDT
		{
			get 
			{
				CanReadProperty("MaHuongDT", true);
				return _maHuongDT;
			}
			set 
			{
				CanWriteProperty("MaHuongDT", true);
				if (_maHuongDT != value) 
				{
					_maHuongDT = value;
					PropertyHasChanged("MaHuongDT");
				}
			}
		}
		
		public String MaBenh
		{
			get 
			{
				CanReadProperty("MaBenh", true);
				return _maBenh;
			}
			set 
			{
				CanWriteProperty("MaBenh", true);
				if (_maBenh != value) 
				{
					_maBenh = value;
					PropertyHasChanged("MaBenh");
				}
			}
		}

        public String TenDV
        {
            get
            {
                CanReadProperty("TenDV", true);
                return _tenDV;
            }
            set
            {
                CanWriteProperty("TenDV", true);
                if (_tenDV != value)
                {
                    _tenDV = value;
                    PropertyHasChanged("TenDV");
                }
            }
        }

        public String TenBS
        {
            get
            {
                CanReadProperty("TenBS", true);
                return _tenBS;
            }
            set
            {
                CanWriteProperty("TenBS", true);
                if (_tenBS != value)
                {
                    _tenBS = value;
                    PropertyHasChanged("TenBS");
                }
            }
        }

        public String TenTat
        {
            get
            {
                CanReadProperty("TenTat", true);
                return _tenTat;
            }
            set
            {
                CanWriteProperty("TenTat", true);
                if (_tenTat != value)
                {
                    _tenTat = value;
                    PropertyHasChanged("TenTat");
                }
            }
        }

        public bool NhapSL
        {
            get
            {
                CanReadProperty("NhapSL", true);
                return _nhapSL;
            }
            set
            {
                CanWriteProperty("NhapSL", true);
                if (_nhapSL != value)
                {
                    _nhapSL = value;
                    PropertyHasChanged("NhapSL");
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

        public String KhoaKham
        {
            get
            {
                CanReadProperty("KhoaKham", true);
                return _khoaKham;
            }
            set
            {
                CanWriteProperty("KhoaKham", true);
                if (_khoaKham != value)
                {
                    _khoaKham = value;
                    PropertyHasChanged("KhoaKham");
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
        public String TenKhoacd
        {
            get
            {
                CanReadProperty("TenKhoacd", true);
                return _tenKhoacd;
            }
            set
            {
                CanWriteProperty("TenKhoacd", true);
                if (_tenKhoacd != value)
                {
                    _tenKhoacd = value;
                    PropertyHasChanged("TenKhoacd");
                }
            }
        }
        public string thanhtien
        {
            get
            {
                CanReadProperty("thanhtien", true);
                if ((_bHTinhTien != false) && (_tinhTien == false))
                {
                    _thanhtien = (_donGiaBH * (100 - _ck) * (_soLuong - _sLTra)) / (100)
                    + _giaChenhLech * (100 - _ck) * (_soLuong - _sLTra) / 100;
                }

                if ((_bHTinhTien == false) || (_tinhTien != false))
                    _thanhtien = _dongiaTT * (100 - _ck) * (_soLuong - _sLTra) / 100;

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
        public BenhAn_XNList _BenhAn_XNList = BenhAn_XNList.NewBenhAn_XNList();

        public BenhAn_XNList BenhAn_XNList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _BenhAn_XNList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_BenhAn_XNList.Equals(value))
                {
                    _BenhAn_XNList = value;
                    PropertyHasChanged();
                }
            }
        }
       
		protected override Object GetIdValue()
		{
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _BenhAn_XNList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _BenhAn_XNList.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        //protected override void AddBusinessRules()
        //{
        //TODO: add validation rules

        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationTuNgayDenNgay<BenhAn_ThuocSD>, "TuNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationTuNgayDenNgay<BenhAn_ThuocSD>, "DenNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationNgayDKDenNgay<BenhAn_ThuocSD>, "DenNgay");
        //ValidationRules.AddRule<BenhAn_ThuocSD>(ValidationNgayDKDenNgay<BenhAn_ThuocSD>, "NgayDK");
        //ValidationRules.AddDependantProperty("TuNgay", "DenNgay");
        //ValidationRules.AddDependantProperty("DenNgay", "NgayDK");

        //}

        //private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_TTNgoaihamsoc
        //{
        //    if (target._tuNgay.Date > System.DateTime.Now.AddDays(1))
        //    {
        //        e.Description = "VALIDATION_NOW";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationNgayDKDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_ThuocSD
        //{
        //    if (target._ngayDK > target._DenNgay)
        //    {
        //        e.Description = "Ngày lĩnh không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        //private static bool ValidationTuNgayDenNgay<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_ThuocSD
        //{
        //    if (target._TuNgay > target._DenNgay)
        //    {
        //        e.Description = "Từ ngày không được lớn hơn đến ngày";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_TTNgoai" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 

        public static BenhAn_TTNgoai NewBenhAn_TTNgoai()
        {
            return new BenhAn_TTNgoai();
        }
        //public static BenhAn_TTNgoai NewBenhAn_TTNgoai(string idDMDichvu)
        //{
        //    return new BenhAn_TTNgoai(DMDichVu.GetDMDichVu(idDMDichvu));
        //}
        //public static BenhAn_TTNgoai GetBenhAn_TTNgoai(String maBA, Int32 sTT, Int32 sTTKhoa)
        //{
        //    return DataPortal.Fetch<BenhAn_TTNgoai>(new Criteria(maBA, sTT, sTTKhoa));
        //}
        internal static BenhAn_TTNgoai GetBenhAn_TTNgoai(SafeDataReader dr, int i)
        {
            return new BenhAn_TTNgoai(dr, i);
        }
        internal static BenhAn_TTNgoai GetBenhAn_TTNgoai(SafeDataReader dr, int i,int loaiphieu)
        {
            return new BenhAn_TTNgoai(dr, i,loaiphieu );
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_TTNgoai" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteBenhAn_TTNgoai(String maBA, Int32 sTT, Int32 sTTKhoa, string lydohuy)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBA, sTT, sTTKhoa, lydohuy));
        //}
        public BenhAn_TTNgoai()
        {
            MarkAsChild();
        }
		#endregion
		
       // #region Constructors
       // // Chu y !!!
       // // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
       // // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
       // protected internal BenhAn_TTNgoai()
       // {	
       //     // Prevent direct creation
       // }
       // internal BenhAn_TTNgoai(       int OrderNumber,
       //                          String maBA ,
       //                          Int32 sTT ,
       //                          Int32 sTTKhoa ,
       //                          String maDV ,
       //                          String MaSoKham ,
       //                          SmartDate ngayDK ,
       //                         // SmartDate _ngayDKD = new SmartDate("", true);
       //                          Decimal soLuong ,
       //                          Decimal dongiaTT ,
       //                          Decimal donGiaBH ,
       //                          Decimal giaChenhLech ,
       //                          Decimal ck ,
       //                          Byte daTT ,
       //                          SmartDate ngayTToan ,
       //                          //SmartDate _ngayTToanD = new SmartDate("", true);
       //                          String bSKham ,
       //                          SmartDate ngayGioKham ,
       //                         // SmartDate _ngayGioKhamD = new SmartDate("", true);
       //                          SmartDate ngayKT ,
       //                          //SmartDate _ngayKTD = new SmartDate("", true);
       //                          Boolean tinhTien ,
       //                          Boolean bHTinhTien ,
       //                          Boolean tinhNgoai ,
       //                          String maMay ,
       //                          Boolean huy ,
       //                          SmartDate ngayHuy ,
       //                          String nguoiHuy ,
       //                          String lyDoHuy ,
       //                          SmartDate ngayLap ,
       //                          String nguoiLap ,
       //                          SmartDate ngaySD ,
       //                          String nguoiSD ,
       //                          String lydoTra ,
       //                          Boolean daTra ,
       //                          String nguoiTra ,
       //                          SmartDate ngaytra ,
       //                          //SmartDate _ngaytraD = new SmartDate("", true);
       //                          Decimal sLTra ,
       //                          SmartDate ngaySD1 ,
       //                          String nguoiSD1 ,
       //                          String nguoiTT ,
       //                          Decimal tyGia ,
       //                          Boolean aDGiaUSD ,
       //                          Byte uuTien ,
       //                          Decimal slmua ,
       //                          String maHuongDT ,
       //                          String maBenh ,
       //                          String tenDV ,
       //                          String tenBS ,
       //                          String tenTat ,
       //                          Boolean nhapSL ,
       //                          String tenBenh ,
       //                          String maICD ,
       //                             string makhoa,
       //                             string tenkhoa
                                 
       //     )
       // {
       //                          _OrderNumber = OrderNumber;
       //                           _maBA = maBA;
       //                           _sTT = sTT;
       //                           _sTTKhoa = sTTKhoa;
       //                           _maDV = maDV ;
       //                           _MaSoKham = MaSoKham ;
       //                           _ngayDK = ngayDK ;
       //                         // SmartDate _ngayDKD = new SmartDate("", true);
       //                           _soLuong = soLuong ;
       //                           _dongiaTT = dongiaTT ;
       //                           _donGiaBH = donGiaBH ;
       //                           _giaChenhLech = giaChenhLech ;
       //                           _ck = ck ;
       //                           _daTT = daTT ;
       //                           _ngayTToan = ngayTToan ;
       //                          //SmartDate _ngayTToanD = new SmartDate("", true);
       //                           _bSKham = bSKham ;
       //                           _ngayGioKham = ngayGioKham ;
       //                         // SmartDate _ngayGioKhamD = new SmartDate("", true);
       //                           _ngayKT = ngayKT ;
       //                          //SmartDate _ngayKTD = new SmartDate("", true);
       //                           _tinhTien = tinhTien ;
       //                           _bHTinhTien = bHTinhTien ;
       //                           _tinhNgoai = tinhNgoai ;
       //                           _maMay = maMay ;
       //                           _huy = huy ;
       //                           _ngayHuy = ngayHuy ;
       //                           _nguoiHuy = nguoiHuy ;
       //                           _lyDoHuy = lyDoHuy ;
       //                           _ngayLap = ngayLap ;
       //                           _nguoiLap = nguoiLap ;
       //                           _ngaySD = ngaySD ;
       //                           _nguoiSD = nguoiSD ;
       //                           _lydoTra = lydoTra ;
       //                           _daTra = daTra ;
       //                           _nguoiTra = nguoiTra ;
       //                           _ngaytra = ngaytra ;
       //                          //SmartDate _ngaytraD = new SmartDate("", true);
       //                           _sLTra = 0;
       //                           _ngaySD1 = ngaySD1 ;
       //                           _nguoiSD1 = nguoiSD1 ;
       //                           _nguoiTT = nguoiTT ;
       //                           _tyGia = tyGia ;
       //                           _aDGiaUSD = aDGiaUSD ;
       //                           _uuTien = uuTien ;
       //                           _slmua = slmua ;
       //                           _maHuongDT = maHuongDT ;
       //                           _maBenh = maBenh ;
       //                           _tenDV = tenDV ;
       //                           _tenBS = tenBS ;
       //                           _tenTat = tenTat ;
       //                           _nhapSL = nhapSL ;
       //                           _tenBenh = tenBenh ;
       //                           _maICD = maICD;
       //                           _maKhoa = makhoa;
       //                           _tenKhoa = tenkhoa;
       // }
       // protected BenhAn_TTNgoai(DMDichVu pro)
       // {
       //     MarkAsChild();
           
       //     //_maPhieu = dr.GetString("MaPhieu");
       //     _maDV = pro.MaDV;
       //    // _maMay = pro.MaMay;
       //    // _huy = pro.Huy;
       //    //// _ngaySD = pro.NgaySD ;
       //    // _nguoiSD = pro.NguoiSD;
       ////     _tenDV = pro.TenDV;
       //     //MarkOld();
       // }
       // #endregion

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
		/// Retrieve an existing <see cref="BenhAn_TTNgoai" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBenhAn_TTNgoai(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override IDataReader GetBenhAn_TTNgoai(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_TTNgoai(crit.MaBA, crit.STT, crit.STTKhoa)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            //if (dr.NextResult())
        //            //{
        //            //    _PhieuNhap_Cs = PhieuNhap_Cs.GetPhieuNhap_Cs(dr);//////////////
        //            //}
        //            //MarkOld();
        //            //ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BenhAn_TTNgoai" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
        //    if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
        //    if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
        //    if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
        //    if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
        //    if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
        //    if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
        //    if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
        //    if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
        //    if (dr.GetByte("DaTT") != null) _daTT = dr.GetByte("DaTT");
        //    if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
        //    if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
        //    if (dr.GetSmartDate("NgayGioKham", true) != null) _ngayGioKham = dr.GetSmartDate("NgayGioKham", true);
        //    if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
        //    if (dr.GetBoolean("TinhTien") != null) _tinhTien = dr.GetBoolean("TinhTien");
        //    if (dr.GetBoolean("BHTinhTien") != null) _bHTinhTien = dr.GetBoolean("BHTinhTien");
        //    if (dr.GetBoolean("TinhNgoai") != null) _tinhNgoai = dr.GetBoolean("TinhNgoai");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetString("LydoTra") != null) _lydoTra = dr.GetString("LydoTra");
        //    if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
        //    if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
        //    if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
        //    if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
        //    if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
        //    if (dr.GetBoolean("ADGiaUSD") != null) _aDGiaUSD = dr.GetBoolean("ADGiaUSD");
        //    if (dr.GetByte("UuTien") != null) _uuTien = dr.GetByte("UuTien");
        //    if (dr.GetDecimal("Slmua") != null) _slmua = dr.GetDecimal("Slmua");
        //    if (dr.GetString("MaHuongDT") != null) _maHuongDT = dr.GetString("MaHuongDT");
        //    if (dr.GetString("MaBenh") != null) _maBenh = dr.GetString("MaBenh");
        //    _tenDV = dr.GetString("TenDV");
        //    _tenBS = dr.GetString("TenBS");
        //    _tenTat = dr.GetString("TENTAT");
        //    _nhapSL  = dr.GetBoolean("NhapSL");
        //    _tenBenh = dr.GetString("TENBenh");
        //    _maICD = dr.GetString("MaICD");
        //    _maKhoa = dr.GetString("MaKhoa");
        //    _tenKhoa = dr.GetString("TenKhoa");
        //}
        private BenhAn_TTNgoai(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("bschidinh") != null) _bschidinh = dr.GetString("bschidinh");
            if (dr.GetString("TENbsCHIDINH") != null) _tenbschidinh = dr.GetString("TENbsCHIDINH");
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");
			
			if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
			if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
			if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
			if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
			if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
			if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
			if (dr.GetByte("DaTT") != null) _daTT = dr.GetByte("DaTT");
            if (dr.GetString("MaBS") != null) _maBS = dr.GetString("MaBS");
            if (dr.GetString("malh") != null) _malh = dr.GetString("malh");
         
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgayD = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgayD = dr.GetSmartDate("DenNgay", true);
			if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
			if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
			if (dr.GetSmartDate("NgayGioKham", true) != null) _ngayGioKham = dr.GetSmartDate("NgayGioKham", true);
			if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
			if (dr.GetBoolean("TinhTien") != null) _tinhTien = dr.GetBoolean("TinhTien");
			if (dr.GetBoolean("BHTinhTien") != null) _bHTinhTien = dr.GetBoolean("BHTinhTien");
			if (dr.GetBoolean("TinhNgoai") != null) _tinhNgoai = dr.GetBoolean("TinhNgoai");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetString("LydoTra") != null) _lydoTra = dr.GetString("LydoTra");
			if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
			if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
			if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
			if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
			if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
			if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
			if (dr.GetBoolean("ADGiaUSD") != null) _aDGiaUSD = dr.GetBoolean("ADGiaUSD");
			if (dr.GetByte("UuTien") != null) _uuTien = dr.GetByte("UuTien");
			if (dr.GetDecimal("Slmua") != null) _slmua = dr.GetDecimal("Slmua");
			if (dr.GetString("MaHuongDT") != null) _maHuongDT = dr.GetString("MaHuongDT");
			if (dr.GetString("MaBenh") != null) _maBenh = dr.GetString("MaBenh");
            if (dr.GetString("TENbs1") != null) _tenbs1 = dr.GetString("TENbs1");
            if (dr.GetString("Mabs3") != null) _mabs3 = dr.GetString("Mabs3");
            if (dr.GetString("TENbs3") != null) _tenbs3 = dr.GetString("TENbs3");
            if (dr.GetString("Mabs4") != null) _mabs4 = dr.GetString("Mabs4");
            if (dr.GetString("TENbs4") != null) _tenbs4 = dr.GetString("TENbs4");
            _tenDV = dr.GetString("TenDV");
            _tenBS = dr.GetString("TenBS");
            _tenTat = dr.GetString("TENTAT");
            _nhapSL  = dr.GetBoolean("NhapSL");
            _tenBenh = dr.GetString("TENBenh");
            _maICD = dr.GetString("MaICD");
            _maKhoa = dr.GetString("MaKhoa");
            _tenKhoa = dr.GetString("TenKhoa");
            _khoaKham = dr.GetString("KhoaKham");
            
           
            MarkOld();
           
        }
        private BenhAn_TTNgoai(SafeDataReader dr, int i,int loaiphieu)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
            if (dr.GetString("bschidinh") != null) _bschidinh = dr.GetString("bschidinh");
            if (dr.GetString("TENbsCHIDINH") != null) _tenbschidinh = dr.GetString("TENbsCHIDINH");
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetString("MaDV") != null) _maDV = dr.GetString("MaDV");
            if (dr.GetString("KQ") != null) _kq = dr.GetString("KQ");

            if (dr.GetString("MaSoKham") != null) _MaSoKham = dr.GetString("MaSoKham");
            if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
            if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
            if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
            if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
            if (dr.GetByte("DaTT") != null) _daTT = dr.GetByte("DaTT");
            if (dr.GetString("MaBS") != null) _maBS = dr.GetString("MaBS");
            if (dr.GetString("malh") != null) _malh = dr.GetString("malh");

            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgayD = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgayD = dr.GetSmartDate("DenNgay", true);
            if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
            if (dr.GetString("BSKham") != null) _bSKham = dr.GetString("BSKham");
            if (dr.GetSmartDate("NgayGioKham", true) != null) _ngayGioKham = dr.GetSmartDate("NgayGioKham", true);
            if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
            if (dr.GetBoolean("TinhTien") != null) _tinhTien = dr.GetBoolean("TinhTien");
            if (dr.GetBoolean("BHTinhTien") != null) _bHTinhTien = dr.GetBoolean("BHTinhTien");
            if (dr.GetBoolean("TinhNgoai") != null) _tinhNgoai = dr.GetBoolean("TinhNgoai");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("LydoTra") != null) _lydoTra = dr.GetString("LydoTra");
            if (dr.GetBoolean("DaTra") != null) _daTra = dr.GetBoolean("DaTra");
            if (dr.GetString("NguoiTra") != null) _nguoiTra = dr.GetString("NguoiTra");
            if (dr.GetSmartDate("Ngaytra", true) != null) _ngaytra = dr.GetSmartDate("Ngaytra", true);
            if (dr.GetDecimal("SLTra") != null) _sLTra = dr.GetDecimal("SLTra");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
            if (dr.GetDecimal("TyGia") != null) _tyGia = dr.GetDecimal("TyGia");
            if (dr.GetBoolean("ADGiaUSD") != null) _aDGiaUSD = dr.GetBoolean("ADGiaUSD");
            if (dr.GetByte("UuTien") != null) _uuTien = dr.GetByte("UuTien");
            if (dr.GetDecimal("Slmua") != null) _slmua = dr.GetDecimal("Slmua");
            if (dr.GetString("MaHuongDT") != null) _maHuongDT = dr.GetString("MaHuongDT");
            if (dr.GetString("MaBenh") != null) _maBenh = dr.GetString("MaBenh");
            if (dr.GetString("TENbs1") != null) _tenbs1 = dr.GetString("TENbs1");
            if (dr.GetString("Mabs3") != null) _mabs3 = dr.GetString("Mabs3");
            if (dr.GetString("TENbs3") != null) _tenbs3 = dr.GetString("TENbs3");
            if (dr.GetString("Mabs4") != null) _mabs4 = dr.GetString("Mabs4");
            if (dr.GetString("TENbs4") != null) _tenbs4 = dr.GetString("TENbs4");
            _tenDV = dr.GetString("TenDV");
            _tenBS = dr.GetString("TenBS");
            _tenTat = dr.GetString("TENTAT");
            _nhapSL = dr.GetBoolean("NhapSL");
            _tenBenh = dr.GetString("TENBenh");
            _maICD = dr.GetString("MaICD");
            _maKhoa = dr.GetString("MaKhoa");
            _tenKhoa = dr.GetString("TenKhoa");
            _khoaKham = dr.GetString("KhoaKham");
            if (dr.GetBoolean("thuocpm") != null) _thuocpm = dr.GetBoolean("thuocpm");

            _BenhAn_XNList = BenhAn_XNList.GetBenhAn_XN_GetAll(_maBA, _sTTKhoa, " AND A.STT =" + STT);//////////////


            MarkOld();

        }
		
		/// <summary>
		/// Insert the new <see cref="BenhAn_TTNgoai" /> Object to underlying database.
		/// </summary>
        /// 

        //protected override void DataPortal_Create()
        //{
        //    _ngayLap.Date = DateTime.Now;
        //    ValidationRules.CheckRules();
        //}
        internal void Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_TTNgoai
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            
          _sTT = DataProvider.Instance().InsertBenhAn_TTNgoai(_maBA, _sTTKhoa, _maDV, _MaSoKham, _ngayDK, _soLuong, _slmua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _daTT, _ngayTToan, _bSKham, _ngayGioKham, _ngayKT, _tinhTien, _bHTinhTien, _maMay , _nguoiSD , _nguoiTT , _tyGia, _aDGiaUSD, _uuTien, _maHuongDT, _maBenh, _maKhoa, _tuNgay, _denNgay, _khoaKham, _maBS, _thuocpm, _maDT, _STTDT, _bschidinh, _ghichu);
			// public abstract String InsertBenhAn_TTNgoai(String _maBA, Int32 _sTTKhoa, String _maDV, String _MaSoKham, SmartDate _ngayDK, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _bSKham, SmartDate _ngayGioKham, SmartDate _ngayKT, Boolean _tinhTien, Boolean _bHTinhTien, String _maMay, String _nguoiLap, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien, String _maHuongDT, String _maBenh);
			// public override String InsertBenhAn_TTNgoai(String _maBA, Int32 _sTTKhoa, String _maDV, String _MaSoKham, SmartDate _ngayDK, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _bSKham, SmartDate _ngayGioKham, SmartDate _ngayKT, Boolean _tinhTien, Boolean _bHTinhTien, String _maMay, String _nguoiLap, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien, String _maHuongDT, String _maBenh)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_TTNgoai_Create", _maBA, _sTTKhoa, _maDV, _MaSoKham, _ngayDK.DBValue, _soLuong, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _daTT, _ngayTToan.DBValue, _bSKham, _ngayGioKham.DBValue, _ngayKT.DBValue, _tinhTien, _bHTinhTien,,_maMay ,  ,   HTC.ShareVariables .pub_sNguoiSD ,_nguoiSD, _tyGia, _aDGiaUSD, _uuTien, _maHuongDT, _maBenh));
			// }
            //_PhieuNhap_Cs.Update(this);
             MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_TTNgoai" /> Object to underlying database.
		/// </summary>
        internal void Update()
        {
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_TTNgoai
			if (!this.IsDirty)
                return;
                
               // _nguoiSD  = HTC.ShareVariables.pub_sNguoiSD;
                DataProvider.Instance().UpdateBenhAn_TTNgoai(_maBA, _sTT, _sTTKhoa, _maDV, _MaSoKham, _ngayDK, _soLuong, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _daTT, _ngayTToan, _bSKham, _ngayGioKham, _ngayKT, _tinhTien, _bHTinhTien, _maMay , _huy, _nguoiSD , _lydoTra, _daTra, _nguoiTra, _ngaytra, _sLTra, _nguoiSD , _tyGia, _aDGiaUSD, _uuTien, _maHuongDT, _maBenh, _maKhoa, _tuNgay, _denNgay, _khoaKham, _maBS, _thuocpm, _bschidinh, _ghichu, _mabs3, _mabs4,_kq);
				// public abstract void UpdateBenhAn_TTNgoai(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maDV, String _MaSoKham, SmartDate _ngayDK, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _bSKham, SmartDate _ngayGioKham, SmartDate _ngayKT, Boolean _tinhTien, Boolean _bHTinhTien, String _maMay, String _nguoiSD, String _lydoTra, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien, String _maHuongDT, String _maBenh);
				// public override void UpdateBenhAn_TTNgoai(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maDV, String _MaSoKham, SmartDate _ngayDK, Decimal _soLuong, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Byte _daTT, SmartDate _ngayTToan, String _bSKham, SmartDate _ngayGioKham, SmartDate _ngayKT, Boolean _tinhTien, Boolean _bHTinhTien, String _maMay, String _nguoiSD, String _lydoTra, Boolean _daTra, String _nguoiTra, SmartDate _ngaytra, Decimal _sLTra, String _nguoiTT, Decimal _tyGia, Boolean _aDGiaUSD, Byte _uuTien, String _maHuongDT, String _maBenh)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_TTNgoai_Update", _maBA, _sTT, _sTTKhoa, _maDV, _MaSoKham, _ngayDK.DBValue, _soLuong, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _daTT, _ngayTToan.DBValue, _bSKham, _ngayGioKham.DBValue, _ngayKT.DBValue, _tinhTien, _bHTinhTien, _tinhNgoai,_maMay ,   _nguoiSD, _lydoTra, _daTra, _nguoiTra, _ngaytra.DBValue, _sLTra,_nguoiSD, _tyGia, _aDGiaUSD, _uuTien, _maHuongDT, _maBenh);
				// }		
                //_PhieuNhap_Cs.Update(this);
              MarkOld();
			
		}
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   , _maBA, _sTT, _sTTKhoa, _lyDoHuy ));
        //}

        ///// <summary>
        ///// Delete the <see cref="BenhAn_TTNgoai" />.
        ///// </summary>
        //protected void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_TTNgoai
        //    DataProvider.Instance().DeleteBenhAn_TTNgoai(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa, crit.lydohuy );
        //    // public abstract void DeleteBenhAn_TTNgoai(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override void DeleteBenhAn_TTNgoai(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa);
        //    // }
        //}
        internal void DeleteSelf()
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;
          
            // if we're new then don't update the database
            if (this.IsNew)
                return;
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataProvider.Instance().DeleteBenhAn_TTNgoai(_maMay,_nguoiSD, _maBA, _sTT, _sTTKhoa, _lyDoHuy);
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteBenhAn_TTNgoai(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa, crit.lydohuy);
        }
		#endregion
	}

}
