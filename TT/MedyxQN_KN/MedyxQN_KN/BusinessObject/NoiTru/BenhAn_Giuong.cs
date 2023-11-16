// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_Giuong
// Kieu doi tuong  :	BenhAn_Giuong
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/27/2009 2:57:00 PM
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
	/// This is a base generated class of <see cref="BenhAn_Giuong" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class BenhAn_Giuong : BusinessBase<BenhAn_Giuong>
	{
		#region Business Methods
		
		#region State Fields
        private Int32 _STTDT = 0;
        private String _maDT = String.Empty;
		private String _maBA = String.Empty;
		private Int32 _sTT = 0;
		private Int32 _sTTKhoa = 0;
		private String _maKhoa = String.Empty;
		private String _maGiuong = String.Empty;
        private String _soGiuong = string.Empty;
        private string _soPhong = string.Empty;
		private String _maBN = String.Empty;
		private SmartDate _ngayDK = new SmartDate(true);
        private SmartDate _ngayDKD = new SmartDate("", true);
        private SmartDate _tuNgay = new SmartDate(true);
        private SmartDate _TuNgayD = new SmartDate(true);
		private SmartDate _denNgay = new SmartDate(true);
        private SmartDate _DenNgayD = new SmartDate(true);
		private Decimal _sLYC = 0;
		private Decimal _sLMua = 0;
		private Decimal _dongiaTT = 0;
		private Decimal _donGiaBH = 0;
		private Decimal _giaChenhLech = 0;
		private Decimal _ck = 0;
		private Boolean _tinhtien = false;
		private Boolean _bHTinhtien = false;
		private Boolean _tinhNgoai = false;
		private Byte _dATT = 0;
		private String _nguoiTT = String.Empty;
		private SmartDate _ngayTToan = new SmartDate(true);
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
        private String _tenGiuong = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private Decimal _thanhtien = 0;
        private Decimal _thanhtientt = 0;
        private Decimal _thanhtienbh = 0;

        private int _OrderNumber;
        private String _tenKhoa = String.Empty;
        private String _maKhoaQL = String.Empty;
        private Boolean _bh = false;
        private String _magiuongql = String.Empty;
        #endregion

        #region Business Properties and Methods
        public SmartDate tn
        {
            get
            {
                CanReadProperty("TuNgay", true);
                return _tuNgay;
            }

        }
        public SmartDate dn
        {
            get
            {
                CanReadProperty("DenNgay", true);
                return _denNgay;
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
        public string thanhtien
        {
            get
            {
                CanReadProperty("thanhtien", true);
                if ((_bHTinhtien != false) && (_tinhtien == false))
                {
                    _thanhtien = (_donGiaBH * (100 - _ck) * (_sLMua  )) / (100)
                    + _giaChenhLech * (100 - _ck) * (_sLMua ) / 100;
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
                    _thanhtientt = _giaChenhLech * (100 - _ck) * (_sLMua ) / 100;
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
		
		public String MaGiuong
		{
			get 
			{
				CanReadProperty("MaGiuong", true);
				return _maGiuong;
			}
			set 
			{
				CanWriteProperty("MaGiuong", true);
				if (_maGiuong != value) 
				{
					_maGiuong = value;
					PropertyHasChanged("MaGiuong");
				}
			}
		}
        public String magiuongql
        {
            get
            {
                CanReadProperty("magiuongql", true);
                return _magiuongql;
            }
            set
            {
                CanWriteProperty("magiuongql", true);
                if (_magiuongql != value)
                {
                    _magiuongql = value;
                    PropertyHasChanged("magiuongql");
                }
            }
        }
        public String SoGiuong
        {
            get
            {
                CanReadProperty("SoGiuong", true);
                return _soGiuong;
            }
            set
            {
                CanWriteProperty("SoGiuong", true);
                if (_soGiuong != value)
                {
                    _soGiuong = value;
                    PropertyHasChanged("SoGiuong");
                }
            }
        }
        public String SoPhong
        {
            get
            {
                CanReadProperty("SoPhong", true);
                return _soPhong;
            }
            set
            {
                CanWriteProperty("SoPhong", true);
                if (_soPhong != value)
                {
                    _soPhong = value;
                    PropertyHasChanged("SoPhong");
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
                _TuNgayD = _tuNgay;
                _TuNgayD.FormatString = "dd/MM/yyyy";
                return _TuNgayD.Text;
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
                _DenNgayD = _denNgay;
                _DenNgayD.FormatString = "dd/MM/yyyy";
                return _DenNgayD.Text;
            }

        }
		
		public Decimal SLYC
		{
			get 
			{
				CanReadProperty("SLYC", true);
				return _sLYC;
			}
			set 
			{
				CanWriteProperty("SLYC", true);
				if (_sLYC != value) 
				{
					_sLYC = value;
					PropertyHasChanged("SLYC");
				}
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
                    return _sLMua.ToString("###,##0.###");
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
                    PropertyHasChanged("Soluong");
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
                    return _giaChenhLech.ToString("###,##0.##");
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
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm"; 

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
        public String TenGiuong
        {
            get
            {
                CanReadProperty("TenGiuong", true);
                return _tenGiuong;
            }
            set
            {
                CanWriteProperty("TenGiuong", true);
                if (_tenGiuong != value)
                {
                    _tenGiuong = value;
                    PropertyHasChanged("TenGiuong");
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
			return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="BenhAn_Giuong" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static BenhAn_Giuong NewBenhAn_Giuong()
        {

            return new BenhAn_Giuong();
        }
		public static BenhAn_Giuong GetBenhAn_Giuong(String maBA, Int32 sTT, Int32 sTTKhoa)
		{
			return DataPortal.Fetch<BenhAn_Giuong>(new Criteria(maBA, sTT, sTTKhoa));
		}
        internal static BenhAn_Giuong GetBenhAn_Giuong(SafeDataReader dr, int i)
        {
            return new BenhAn_Giuong(dr, i);
        }
		/// <summary>
		/// Marks the <see cref="BenhAn_Giuong" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteBenhAn_Giuong(String maBA, Int32 sTT, Int32 sTTKhoa)
        //{
        //    DataPortal.Delete(new Criteria(maBA, sTT, sTTKhoa));
        //}
        public BenhAn_Giuong()
        {
            MarkAsChild();
        }
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BenhAn_Giuong()
        //{	
        //    // Prevent direct creation
        //}
		
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
            public OtherCriteria(String Mamay, String Nguoisd, String maBA, Int32 sTT, Int32 sTTKhoa, string lydohuy)
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
		/// Retrieve an existing <see cref="BenhAn_Giuong" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBenhAn_Giuong(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
        //    // public override IDataReader GetBenhAn_Giuong(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT, _sTTKhoa));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_Giuong(crit.MaBA, crit.STT, crit.STTKhoa)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="BenhAn_Giuong" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
        //    if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
        //    if (dr.GetString("MaGiuong") != null) _maGiuong = dr.GetString("MaGiuong");
        //    if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
        //    if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
        //    if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
        //    if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
        //    if (dr.GetDecimal("SLYC") != null) _sLYC = dr.GetDecimal("SLYC");
        //    if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
        //    if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
        //    if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
        //    if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
        //    if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
        //    if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
        //    if (dr.GetBoolean("BHTinhtien") != null) _bHTinhtien = dr.GetBoolean("BHTinhtien");
        //    if (dr.GetBoolean("TinhNgoai") != null) _tinhNgoai = dr.GetBoolean("TinhNgoai");
        //    if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
        //    if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
        //    if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("LyDoHuy") != null) _lyDoHuy = dr.GetString("LyDoHuy");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //}
        private BenhAn_Giuong(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
			if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetString("MaGiuong") != null) _maGiuong = dr.GetString("MaGiuong");
            if (dr.GetString("magiuongql") != null) _magiuongql = dr.GetString("magiuongql");
            if (dr.GetString("SoGiuong") != null) _soGiuong = dr.GetString("SoGiuong");
            if (dr.GetString("SoPhong") != null) _soPhong = dr.GetString("SoPhong");
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetString("tenKhoa") != null) _tenKhoa = dr.GetString("tenKhoa");
			if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
			if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
			if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
			if (dr.GetDecimal("SLYC") != null) _sLYC = dr.GetDecimal("SLYC");
			if (dr.GetDecimal("SLMua") != null) _sLMua = dr.GetDecimal("SLMua");
            if (dr.GetString("tenKhoa") != null) _tenKhoa = dr.GetString("tenKhoa");
			if (dr.GetDecimal("DongiaTT") != null) _dongiaTT = dr.GetDecimal("DongiaTT");
			if (dr.GetDecimal("DonGiaBH") != null) _donGiaBH = dr.GetDecimal("DonGiaBH");
			if (dr.GetDecimal("GiaChenhLech") != null) _giaChenhLech = dr.GetDecimal("GiaChenhLech");
			if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
			if (dr.GetBoolean("Tinhtien") != null) _tinhtien = dr.GetBoolean("Tinhtien");
			if (dr.GetBoolean("BHTinhtien") != null) _bHTinhtien = dr.GetBoolean("BHTinhtien");
            if (_tinhtien == true || _bHTinhtien == false)
                _bh = false;
            else if (_bHTinhtien == true)
                _bh = true;
			if (dr.GetBoolean("TinhNgoai") != null) _tinhNgoai = dr.GetBoolean("TinhNgoai");
            _maKhoaQL = dr.GetString("MaKhoaql");
			if (dr.GetByte("DATT") != null) _dATT = dr.GetByte("DATT");
			if (dr.GetString("NguoiTT") != null) _nguoiTT = dr.GetString("NguoiTT");
			if (dr.GetSmartDate("NgayTToan", true) != null) _ngayTToan = dr.GetSmartDate("NgayTToan", true);
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
            if (dr.GetString("TenGiuong") != null) _tenGiuong = dr.GetString("TenGiuong");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
           
          
            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="BenhAn_Giuong" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _maBA = DataProvider.Instance().InsertBenhAn_Giuong(_maBA, _sTT, _sTTKhoa, _maKhoa, _maGiuong, _maBN, _ngayDK, _sLYC, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT, _nguoiSD , _ngayTToan, _maMay , _nguoiSD , _tuNgay, _denNgay, _maDT, _STTDT, _soGiuong ,_soPhong );
			// public abstract String InsertBenhAn_Giuong(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maKhoa, String _maGiuong, String _maBN, SmartDate _ngayDK, Decimal _sLYC, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, String _maMay, String _nguoiLap);
			// public override String InsertBenhAn_Giuong(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maKhoa, String _maGiuong, String _maBN, SmartDate _ngayDK, Decimal _sLYC, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_Giuong_Create", _maBA, _sTT, _sTTKhoa, _maKhoa, _maGiuong, _maBN, _ngayDK.DBValue, _sLYC, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue,_maMay ,   _nguoiLap);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="BenhAn_Giuong" /> Object to underlying database.
		/// </summary>
		 internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateBenhAn_Giuong(_maBA, _sTT, _sTTKhoa, _maKhoa, _maGiuong, _maBN, _ngayDK, _sLYC, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan,_maMay ,   _huy,_nguoiSD   , _tuNgay, _denNgay,_soGiuong ,_soPhong );
				// public abstract void UpdateBenhAn_Giuong(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maKhoa, String _maGiuong, String _maBN, SmartDate _ngayDK, Decimal _sLYC, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, String _maMay, Boolean _huy, String _nguoiSD);
				// public override void UpdateBenhAn_Giuong(String _maBA, Int32 _sTT, Int32 _sTTKhoa, String _maKhoa, String _maGiuong, String _maBN, SmartDate _ngayDK, Decimal _sLYC, Decimal _sLMua, Decimal _dongiaTT, Decimal _donGiaBH, Decimal _giaChenhLech, Decimal _ck, Boolean _tinhtien, Boolean _bHTinhtien, Boolean _tinhNgoai, Byte _dATT, String _nguoiTT, SmartDate _ngayTToan, String _maMay, Boolean _huy, String _nguoiSD)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_Giuong_Update", _maBA, _sTT, _sTTKhoa, _maKhoa, _maGiuong, _maBN, _ngayDK.DBValue, _sLYC, _sLMua, _dongiaTT, _donGiaBH, _giaChenhLech, _ck, _tinhtien, _bHTinhtien, _tinhNgoai, _dATT,_nguoiSD, _ngayTToan.DBValue,_maMay ,   _huy, _nguoiSD);
				// }				
                MarkOld();
		}
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD, _maBA, _sTT, _sTTKhoa, _lyDoHuy));
            MarkNew();
        }

		/// <summary>
		/// Delete the <see cref="BenhAn_Giuong" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Giuong
            DataProvider.Instance().DeleteBenhAn_Giuong(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa, crit.lydohuy  );
			// public abstract void DeleteBenhAn_Giuong(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
			// public override void DeleteBenhAn_Giuong(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhan_Giuong_Deleted", _maBA, _sTT, _sTTKhoa);
			// }
		}

		#endregion
	}

}
