// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_TT
// Kieu doi tuong  :	Luong_TT
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	01/05/2010 9:09:24 AM
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
using HTC.Business;
////

namespace HTC.Business.Luong
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="Luong_TT" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_TT : BusinessBase<Luong_TT>
	{
		#region Business Methods
		
		#region State Fields
		
		private SmartDate _thang = new SmartDate(true);
		private String _maKhoa = String.Empty;
        private Decimal _db = 0;
        private Decimal _i = 0;
        private Decimal _ii = 0;
        private Decimal _iII = 0;
        private Decimal _dONGIADBBS = 0;
        private Decimal _dONGIADBDD = 0;
        private Decimal _dONGIAIBS = 0;
        private Decimal _dONGIAIDD = 0;
        private Decimal _dONGIAIIBS = 0;
        private Decimal _dONGIAIIDD = 0;
        private Decimal _dONGIAIIIBS = 0;
        private Decimal _dONGIAIIIDD = 0;
        private Decimal _tong = 0;
        private String _ghiChu = String.Empty;
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
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;

        private Decimal _thanhTienDBBS = 0;
        private Decimal _thanhTienDBDD = 0;
        private Decimal _thanhTienIBS = 0;
        private Decimal _thanhTienIDD = 0;
        private Decimal _thanhTienIIBS = 0;
        private Decimal _thanhTienIIDD = 0;
        private Decimal _thanhTienIIIBS = 0;
        private Decimal _thanhTienIIIDD = 0;

        private Decimal _thanhTienDB = 0;
        private Decimal _thanhTienI = 0;
        private Decimal _thanhTienII = 0;
        private Decimal _thanhTienIII = 0;

        private int _OrderNumber;

		#endregion
		
		#region Business Properties and Methods
		
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

        public String DB
        {
            get
            {
                CanReadProperty("DB", true);
                if (_db == 0)
                {
                    return "";
                }
                else
                {
                    return _db.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DB", true);
                if (_db.ToString() != value)
                {
                    if (value == "")
                        _db = 0;
                    else
                        _db = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
            }
        }

        public String I
        {
            get
            {
                CanReadProperty("I", true);
                if (_i == 0)
                {
                    return "";
                }
                else
                {
                    return _i.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("I", true);
                if (_i.ToString() != value)
                {
                    if (value == "")
                        _i = 0;
                    else
                        _i = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
            }
        }

        public String II
        {
            get
            {
                CanReadProperty("II", true);
                if (_ii == 0)
                {
                    return "";
                }
                else
                {
                    return _ii.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("II", true);
                if (_ii.ToString() != value)
                {
                    if (value == "")
                        _ii = 0;
                    else
                        _ii = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
            }
        }

        public String III
        {
            get
            {
                CanReadProperty("III", true);
                if (_iII == 0)
                {
                    return "";
                }
                else
                {
                    return _iII.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("III", true);
                if (_iII.ToString() != value)
                {
                    if (value == "")
                        _iII = 0;
                    else
                        _iII = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
            }
        }

        public String DONGIADBBS
        {
            get
            {
                CanReadProperty("DONGIADBBS", true);
                if (_dONGIADBBS == 0)
                {
                    return "";
                }
                else
                {
                    return _dONGIADBBS.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DONGIADBBS", true);
                if (_dONGIADBBS.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBBS = 0;
                    else
                        _dONGIADBBS = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
            }
        }

        public String DONGIADBDD
        {
            get
            {
                CanReadProperty("DONGIADBDD", true);
                if (_dONGIADBDD == 0)
                {
                    return "";
                }
                else
                {
                    return _dONGIADBDD.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DONGIADBDD", true);
                if (_dONGIADBDD.ToString() != value)
                {
                    if (value == "")
                        _dONGIADBDD = 0;
                    else
                        _dONGIADBDD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
            }
        }

        public String DONGIAIBS
        {
            get
            {
                CanReadProperty("DONGIAIBS", true);
                if (_dONGIAIBS == 0)
                {
                    return "";
                }
                else
                {
                    return _dONGIAIBS.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DONGIAIBS", true);
                if (_dONGIAIBS.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIBS = 0;
                    else
                        _dONGIAIBS = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
            }
        }

        public String DONGIAIDD
        {
            get
            {
                CanReadProperty("DONGIAIDD", true);
                if (_dONGIAIDD == 0)
                {
                    return "";
                }
                else
                {
                    return _dONGIAIDD.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DONGIAIDD", true);
                if (_dONGIAIDD.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIDD = 0;
                    else
                        _dONGIAIDD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
            }
        }

        public String DONGIAIIBS
        {
            get
            {
                CanReadProperty("DONGIAIIBS", true);
                if (_dONGIAIIBS == 0)
                {
                    return "";
                }
                else
                {
                    return _dONGIAIIBS.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DONGIAIIBS", true);
                if (_dONGIAIIBS.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIIBS = 0;
                    else
                        _dONGIAIIBS = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
            }
        }

        public String DONGIAIIDD
        {
            get
            {
                CanReadProperty("DONGIAIIDD", true);
                if (_dONGIAIIDD == 0)
                {
                    return "";
                }
                else
                {
                    return _dONGIAIIDD.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DONGIAIIDD", true);
                if (_dONGIAIIDD.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIIDD = 0;
                    else
                        _dONGIAIIDD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongTuan1");
                }
            }
        }

        public String DONGIAIIIBS
        {
            get
            {
                CanReadProperty("DONGIAIIIBS", true);
                if (_dONGIAIIIBS == 0)
                {
                    return "";
                }
                else
                {
                    return _dONGIAIIIBS.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DONGIAIIIBS", true);
                if (_dONGIAIIIBS.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIIIBS = 0;
                    else
                        _dONGIAIIIBS = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAIIIBS");
                }
            }
        }

        public String DONGIAIIIDD
        {
            get
            {
                CanReadProperty("DONGIAIIIDD", true);
                if (_dONGIAIIIDD == 0)
                {
                    return "";
                }
                else
                {
                    return _dONGIAIIIDD.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("DONGIAIIIDD", true);
                if (_dONGIAIIIDD.ToString() != value)
                {
                    if (value == "")
                        _dONGIAIIIDD = 0;
                    else
                        _dONGIAIIIDD = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("DONGIAIIIDD");
                }
            }
        }

        public String Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                _tong  = _thanhTienDB + _thanhTienI + _thanhTienII  + _thanhTienIII ;
                if (_tong == 0)
                {
                    return "";
                }
                else
                {
                    return _tong.ToString("###,###");
                }
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

        public string THANHTIENDBBS
        {
            get
            {
                CanReadProperty("THANHTIENDBBS", true);
                _thanhTienDBBS  = _dONGIADBBS * _db ;
                if (_thanhTienDBBS == 0)
                {
                    return "";
                }
                else
                {
                    return _thanhTienDBBS.ToString("#,###,###");
                }
            }
            set
            {
                CanWriteProperty("THANHTIENDBBS", true);

                if (_thanhTienDBBS.ToString() != value)
                {
                    if (value == "")
                        _thanhTienDBBS = 0;
                    else
                        _thanhTienDBBS = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENDBBS");
                }
            }
        }
        public string THANHTIENDBDD
        {
            get
            {
                CanReadProperty("THANHTIENDBDD", true);
                _thanhTienDBDD  = _dONGIADBDD * _db   ;
                if (_thanhTienDBDD  == 0)
                {
                    return "";
                }
                else
                {
                    return _thanhTienDBDD.ToString("#,###,###");
                }
            }
            set
            {
                CanWriteProperty("THANHTIENDBDD", true);

                if (_thanhTienDBDD.ToString() != value)
                {
                    if (value == "")
                        _thanhTienDBDD = 0;
                    else
                        _thanhTienDBDD = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENDBDD");
                }
            }
        }

        public string THANHTIENIBS
        {
            get
            {
                CanReadProperty("THANHTIENIBS", true);
                _thanhTienIBS = _dONGIAIBS * _i;
                if (_thanhTienIBS == 0)
                {
                    return "";
                }
                else
                {
                    return _thanhTienIBS.ToString("#,###,###");
                }
            }
            set
            {
                CanWriteProperty("THANHTIENIBS", true);

                if (_thanhTienIBS.ToString() != value)
                {
                    if (value == "")
                        _thanhTienIBS = 0;
                    else
                        _thanhTienIBS = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENIBS");
                }
            }
        }
        public string THANHTIENIDD
        {
            get
            {
                CanReadProperty("THANHTIENIDD", true);
                _thanhTienIDD = _dONGIAIDD  * _i;
                if (_thanhTienIDD  == 0)
                {
                    return "";
                }
                else
                {
                    return _thanhTienIDD.ToString("#,###,###");
                }
            }
            set
            {
                CanWriteProperty("THANHTIENIDD", true);

                if (_thanhTienIDD.ToString() != value)
                {
                    if (value == "")
                        _thanhTienIDD = 0;
                    else
                        _thanhTienIDD = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENIDD");
                }
            }
        }

        public string THANHTIENIIBS
        {
            get
            {
                CanReadProperty("THANHTIENIIBS", true);
                _thanhTienIIBS  = _dONGIAIIBS * _ii ;
                if (_thanhTienIBS == 0)
                {
                    return "";
                }
                else
                {
                    return _thanhTienIIBS.ToString("#,###,###");
                }
            }
            set
            {
                CanWriteProperty("THANHTIENIIBS", true);

                if (_thanhTienIIBS.ToString() != value)
                {
                    if (value == "")
                        _thanhTienIIBS = 0;
                    else
                        _thanhTienIIBS = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENIIBS");
                }
            }
        }
        public string THANHTIENIIDD
        {
            get
            {
                CanReadProperty("THANHTIENIIDD", true);
                _thanhTienIIDD  = _dONGIAIIDD * _ii ;
                if (_thanhTienIIDD == 0)
                {
                    return "";
                }
                else
                {
                    return _thanhTienIIDD.ToString("#,###,###");
                }
            }
            set
            {
                CanWriteProperty("THANHTIENIIDD", true);

                if (_thanhTienIIDD.ToString() != value)
                {
                    if (value == "")
                        _thanhTienIIDD = 0;
                    else
                        _thanhTienIIDD = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENIIDD");
                }
            }
        }

        public string THANHTIENIIIBS
        {
            get
            {
                CanReadProperty("THANHTIENIIIBS", true);
                _thanhTienIIIBS  = _dONGIAIIIBS * _iII ;
                if (_thanhTienIIIBS == 0)
                {
                    return "";
                }
                else
                {
                    return _thanhTienIIIBS.ToString("#,###,###");
                }
            }
            set
            {
                CanWriteProperty("THANHTIENIIIBS", true);

                if (_thanhTienIIIBS.ToString() != value)
                {
                    if (value == "")
                        _thanhTienIIIBS = 0;
                    else
                        _thanhTienIIIBS = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENIIIBS");
                }
            }
        }
        public string THANHTIENIIIDD
        {
            get
            {
                CanReadProperty("THANHTIENIIIDD", true);
                _thanhTienIIIDD = _dONGIAIIIDD * _iII ;
                if (_thanhTienIIIDD == 0)
                {
                    return "";
                }
                else
                {
                    return _thanhTienIIIDD.ToString("#,###,###");
                }
            }
            set
            {
                CanWriteProperty("THANHTIENIIIDD", true);

                if (_thanhTienIIIDD.ToString() != value)
                {
                    if (value == "")
                        _thanhTienIIIDD = 0;
                    else
                        _thanhTienIIIDD = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENIIIDD");
                }
            }
        }

        public string THANHTIENDB
        {
            get
            {
                //CanReadProperty("THANHTIENDB", true);
                _thanhTienDB = _dONGIADBBS  * _db + _dONGIADBDD  * _db;
                //if (_thanhTienDB == 0)
                //{
                //    return "";
                //}
                //else
                //{
                    return _thanhTienDB.ToString("#,###,###");
                //}
            }
            set
            {
                CanWriteProperty("THANHTIENDB", true);

                if (_thanhTienDB.ToString() != value)
                {
                    if (value == "")
                        _thanhTienDB = 0;
                    else
                        _thanhTienDB = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENDB");
                }
            }
        }

        public string THANHTIENI
        {
            get
            {
                //CanReadProperty("THANHTIENI", true);
                //_thanhTienI = _thanhTienIBS  + _thanhTienIDD ;
                //_dONGIAIBS * _i
                _thanhTienI = _dONGIAIBS * _i + _dONGIAIDD * _i;
                //if (_thanhTienI  == 0)
                //{
                //    return "";
                //}
                //else
                //{
                    return _thanhTienI.ToString("#,###,###");
                //}
            }
            set
            {
                CanWriteProperty("THANHTIENI", true);

                if (_thanhTienI.ToString() != value)
                {
                    if (value == "")
                        _thanhTienI = 0;
                    else
                        _thanhTienI = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENI");
                }
            }
        }

        public string THANHTIENII
        {
            get
            {
                //CanReadProperty("THANHTIENII", true);
                _thanhTienII  = _dONGIAIIBS * _ii + _dONGIAIIDD * _ii ;
                //if (_thanhTienII == 0)
                //{
                //    return "";
                //}
                //else
                //{
                    return _thanhTienII.ToString("#,###,###");
                //}
            }
            set
            {
                CanWriteProperty("THANHTIENII", true);

                if (_thanhTienII.ToString() != value)
                {
                    if (value == "")
                        _thanhTienII = 0;
                    else
                        _thanhTienII = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENII");
                }
            }
        }

        public string THANHTIENIII
        {
            get
            {
                //CanReadProperty("THANHTIENIII", true);
                _thanhTienIII = _dONGIAIIIBS * _iII + _dONGIAIIIDD  * _iII ; 
                //if (_thanhTienIII == 0)
                //{
                //    return "";
                //}
                //else
                //{
                    return _thanhTienIII.ToString("#,###,###");
                //}
            }
            set
            {
                CanWriteProperty("THANHTIENIII", true);

                if (_thanhTienIII.ToString() != value)
                {
                    if (value == "")
                        _thanhTienIII = 0;
                    else
                        _thanhTienIII = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("THANHTIENIII");
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
        Luong_TT_NVList _Luong_TT_NVs = Luong_TT_NVList.NewLuong_TT_NVList();

        public Luong_TT_NVList Luong_TT_NVs
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _Luong_TT_NVs;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_Luong_TT_NVs.Equals(value))
                {
                    _Luong_TT_NVs = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _thang.ToString() + "!" + _maKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _Luong_TT_NVs.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _Luong_TT_NVs.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="Luong_TT" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_TT NewLuong_TT()
        {
            return DataPortal.Create<Luong_TT>();
        }
        public static Luong_TT GetLuong_TT(DateTime thang, String maKhoa, string dk)
		{
            return DataPortal.Fetch<Luong_TT>(new Criteria(thang, maKhoa, dk ));
		}
        public static Luong_TT GetLuong_TT(SafeDataReader dr)
        {
            Luong_TT obj = new Luong_TT();
            obj.Fetch(dr);
            return obj;
        }
        public static bool CheckLuong_TT(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_TT(Thang, maKhoa, dk)))
            {
                if (dr.Read())
                {
                    if (!dr.GetSmartDate("Thang", true).IsEmpty)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
		/// <summary>
		/// Marks the <see cref="Luong_TT" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteLuong_TT(SmartDate thang, String maKhoa, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maKhoa, thang));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal Luong_TT()
		{	
			// Prevent direct creation
		}
        internal Luong_TT(
  int OrderNumber,
  SmartDate thang ,
		                             String maKhoa ,
		                             Decimal db ,
  Decimal i ,
  Decimal ii ,
  Decimal iII ,
  Decimal dONGIADBBS ,
  Decimal dONGIADBDD ,
  Decimal dONGIAIBS ,
  Decimal dONGIAIDD ,
  Decimal dONGIAIIBS ,
  Decimal dONGIAIIDD ,
  Decimal dONGIAIIIBS ,
  Decimal dONGIAIIIDD ,
		                             Decimal tong ,
		                             String ghiChu ,
		                             String maMay ,
		                             SmartDate ngayLap ,
		                             String nguoiLap ,
		                             SmartDate ngayHuy ,
		                             String nguoiHuy ,
		                             SmartDate ngaySD ,
		                             String nguoiSD ,
		                             SmartDate ngaySD1 ,
		                             String nguoiSD1 ,
		                             Boolean huy ,
  String tenNguoiLap ,
  String tenNguoiSD ,
  String tenNguoiHuy 
         
            )
        {
                              _OrderNumber = OrderNumber ;
                              _thang = thang ;
		                      _maKhoa = maKhoa ;
		                       _i = i;
   _ii = ii;
   _iII = iII;
   _dONGIADBBS = dONGIADBBS ;
   _dONGIADBDD = dONGIADBDD ;
   _dONGIAIBS = dONGIAIBS ;
   _dONGIAIDD = dONGIAIDD ;
   _dONGIAIIBS = dONGIAIIBS ;
   _dONGIAIIDD = dONGIAIIDD ;
   _dONGIAIIIBS = dONGIAIIIBS ;
   _dONGIAIIIDD = dONGIAIIIDD ;
		                      _tong = tong ;
		                      _ghiChu = ghiChu ;
		                      _maMay = maMay ;
		                      _ngayLap = ngayLap ;
		                      _nguoiLap = nguoiLap ;
		                      _ngayHuy = ngayHuy ;
		                      _nguoiHuy = nguoiHuy ;
		                      _ngaySD = ngaySD ;
		                      _nguoiSD = nguoiSD ;
		                      _ngaySD1 = ngaySD1 ;
		                      _nguoiSD1 = nguoiSD1 ;
		                      _huy = huy ;
                              _tenNguoiLap = tenNguoiLap ;
                              _tenNguoiSD = tenNguoiSD ;
                              _tenNguoiHuy = tenNguoiHuy ;
        }
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private DateTime _thang;
            public DateTime Thang 
			{
				get
				{
					return _thang;
				}
			}
			
			private String _maKhoa;
			public String MaKhoa 
			{
				get
				{
					return _maKhoa;
				}
			}
            private String _dk;
            public String DK
            {
                get
                {
                    return _dk;
                }
            }

            public Criteria(DateTime thang, String maKhoa, string dk)
			{
				_thang = thang;
				_maKhoa = maKhoa;
                _dk = dk;
			}
			
			
		}
        [Serializable()]
        protected class OtherCriteria
        {
            private SmartDate _thang;
            public SmartDate Thang
            {
                get
                {
                    return _thang;
                }
            }

            private String _maKhoa;
            public String MaKhoa
            {
                get
                {
                    return _maKhoa;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maKhoa, SmartDate thang)
            {
                _thang = thang;
                _maKhoa = maKhoa;
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
		/// Retrieve an existing <see cref="Luong_TT" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetLuong_TT(SmartDate _thang, String _maKhoa);
			// public override IDataReader GetLuong_TT(SmartDate _thang, String _maKhoa)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_TT_GET", _thang, _maKhoa));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_TT(crit.Thang, crit.MaKhoa, crit.DK  )))
			{
				if (dr.Read()){
					Fetch(dr);
                    if (dr.NextResult())
                    {
                        _Luong_TT_NVs = Luong_TT_NVList.GetLuong_TT_NVList(dr);//////////////
                    }
                    //MarkOld();
                    //ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="Luong_TT" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
            if (dr.GetDecimal("DB") != null) _db = dr.GetDecimal("DB");
            if (dr.GetDecimal("I") != null) _i = dr.GetDecimal("I");
            if (dr.GetDecimal("II") != null) _ii = dr.GetDecimal("II");
            if (dr.GetDecimal("III") != null) _iII = dr.GetDecimal("III");
            if (dr.GetDecimal("DONGIADBBS") != null) _dONGIADBBS = dr.GetDecimal("DONGIADBBS");
            if (dr.GetDecimal("DONGIADBDD") != null) _dONGIADBDD = dr.GetDecimal("DONGIADBDD");
            if (dr.GetDecimal("DONGIAIBS") != null) _dONGIAIBS = dr.GetDecimal("DONGIAIBS");
            if (dr.GetDecimal("DONGIAIDD") != null) _dONGIAIDD = dr.GetDecimal("DONGIAIDD");
            if (dr.GetDecimal("DONGIAIIBS") != null) _dONGIAIIBS = dr.GetDecimal("DONGIAIIBS");
            if (dr.GetDecimal("DONGIAIIDD") != null) _dONGIAIIDD = dr.GetDecimal("DONGIAIIDD");
            if (dr.GetDecimal("DONGIAIIIBS") != null) _dONGIAIIIBS = dr.GetDecimal("DONGIAIIIBS");
            if (dr.GetDecimal("DONGIAIIIDD") != null) _dONGIAIIIDD = dr.GetDecimal("DONGIAIIIDD");
			if (dr.GetDecimal("Tong") != null) _tong = dr.GetDecimal("Tong");
			if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
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
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
		}
		
		/// <summary>
		/// Insert the new <see cref="Luong_TT" /> Object to underlying database.
		/// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertLuong_TT
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maKhoa = DataProvider.Instance().InsertLuong_TT(_thang, _maKhoa, _db, _i, _ii, _iII, _dONGIADBBS, _dONGIADBDD, _dONGIAIBS, _dONGIAIDD, _dONGIAIIBS, _dONGIAIIDD, _dONGIAIIIBS, _dONGIAIIIDD, _tong, _ghiChu, _maMay, _nguoiSD);
            // public abstract String InsertLuong_TT(SmartDate _thang, String _maKhoa, Decimal _db, Decimal _i, Decimal _ii, Decimal _iII, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap);
            // public override String InsertLuong_TT(SmartDate _thang, String _maKhoa, Decimal _db, Decimal _i, Decimal _ii, Decimal _iII, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _tong, String _ghiChu, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_TT_CREATE", _thang.DBValue, _maKhoa, _db, _i, _ii, _iII, _dONGIADBBS, _dONGIADBDD, _dONGIAIBS, _dONGIAIDD, _dONGIAIIBS, _dONGIAIIDD, _dONGIAIIIBS, _dONGIAIIIDD, _tong, _ghiChu, _maMay, _nguoiSD));
			// }
            if (this.Luong_TT_NVs.IsDirty == true)

            _Luong_TT_NVs.Update(this);
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_TT" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_TT
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateLuong_TT(_thang, _maKhoa, _db, _i, _ii, _iII, _dONGIADBBS, _dONGIADBDD, _dONGIAIBS, _dONGIAIDD, _dONGIAIIBS, _dONGIAIIDD, _dONGIAIIIBS, _dONGIAIIIDD, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateLuong_TT(SmartDate _thang, String _maKhoa, Decimal _db, Decimal _i, Decimal _ii, Decimal _iII, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong_TT(SmartDate _thang, String _maKhoa, Decimal _db, Decimal _i, Decimal _ii, Decimal _iII, Decimal _dONGIADBBS, Decimal _dONGIADBDD, Decimal _dONGIAIBS, Decimal _dONGIAIDD, Decimal _dONGIAIIBS, Decimal _dONGIAIIDD, Decimal _dONGIAIIIBS, Decimal _dONGIAIIIDD, Decimal _tong, String _ghiChu, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_TT_UPDATE", _thang.DBValue, _maKhoa, _db, _i, _ii, _iII, _dONGIADBBS, _dONGIADBDD, _dONGIAIBS, _dONGIAIDD, _dONGIAIIBS, _dONGIAIIDD, _dONGIAIIIBS, _dONGIAIIIDD, _tong, _ghiChu, _maMay, _nguoiSD , _huy);
				// }		
                if (this.Luong_TT_NVs.IsDirty == true)

                _Luong_TT_NVs.Update(this);

			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maKhoa, _thang));
		}

		/// <summary>
		/// Delete the <see cref="Luong_TT" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_TT
            DataProvider.Instance().DeleteLuong_TT(crit.MaMay, crit.NguoiSD, crit.MaKhoa, crit.Thang);
			// public abstract void DeleteLuong_TT(SmartDate _thang, String _maKhoa);
			// public override void DeleteLuong_TT(SmartDate _thang, String _maKhoa)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_TT_DELETED", _thang, _maKhoa);
			// }
		}

		#endregion
	}

}
