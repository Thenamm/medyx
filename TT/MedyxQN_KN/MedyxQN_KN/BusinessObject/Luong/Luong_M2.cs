// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Luong_M2
// Kieu doi tuong  :	Luong_M2
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
	/// This is a base generated class of <see cref="Luong_M2" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Luong_M2 : BusinessBase<Luong_M2>
	{
		#region Business Methods
		
		#region State Fields
		
		private Int32 _sTT = 0;
		private SmartDate _thang = new SmartDate(true);
		private String _maNV = String.Empty;
		private String _makhoa = String.Empty;
        private Decimal _heSoChucVu = 0;
        private Decimal _heSoDieuDuong = 0;
        private Decimal _heSoCKCI = 0;
        private Decimal _heSoNT = 0;
        private Decimal _heSoHVK = 0;
        private Decimal _heSoDaiHoc = 0;
        private Decimal _heSoCaoDang = 0;
        private Decimal _heSoTrungCap = 0;
        private Decimal _heSoKhac = 0;
        private Decimal _heSoToTruong = 0;
        private SmartDate _namDiLam = new SmartDate(true);
        private Decimal _heSoThamNien = 0;
        private Decimal _tongSo = 0;
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
        private String _hoten = String.Empty;
        private String _tenChuyenMon = String.Empty;
        private String _tenLoaiHD = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private Decimal _donGia = 0;
        private SmartDate _NgaySinh = new SmartDate(true);
        private Boolean _gioitinh = false;
        private Boolean _gioitinhNam = false;
        private int  _soNam = 0;
        private int _OrderNumber;
        private Decimal _mucLuongCB = 0;
        private Decimal _Tong = 0;
        private Decimal _ngayCong = 22;
		#endregion
		
		#region Business Properties and Methods
        public string MucLuongCB
        {
            get
            {
                CanReadProperty("MucLuongCB", true);

                {
                    return _mucLuongCB.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("MucLuongCB", true);

                if (_mucLuongCB.ToString() != value)
                {
                    if (value == "")
                        _mucLuongCB = 0;
                    else
                        _mucLuongCB = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("MucLuongCB");
                }
            }
        }

        public string Tong
        {
            get
            {
                CanReadProperty("Tong", true);
                _Tong = _mucLuongCB * _tongSo * _ngayCong ;
                if (_Tong == 0)
                {
                    return "";
                }
                else
                {
                    return _Tong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("Tong", true);

                if (_Tong.ToString() != value)
                {
                    if (value == "")
                        _Tong = 0;
                    else
                        _Tong = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("Tong");
                }
            }
        }

        public string NgayCong
        {
            get
            {
                CanReadProperty("NgayCong", true);

                {
                    return _ngayCong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("NgayCong", true);

                if (_ngayCong.ToString() != value)
                {
                    if (value == "")
                        _ngayCong = 0;
                    else
                        _ngayCong = decimal.Parse(value.Replace(",", ""));
                    PropertyHasChanged("NgayCong");
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

        public string Thang
        {
            get
            {
                CanReadProperty("Thang", true);
                _thang.FormatString = "MM/yyyy";

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

        //public Decimal HeSoChucVu
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoChucVu", true);
        //        return _heSoChucVu;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoChucVu", true);
        //        if (_heSoChucVu != value)
        //        {
        //            _heSoChucVu = value;
        //            PropertyHasChanged("HeSoChucVu");
        //        }
        //    }
        //}
        public string HeSoChucVu
        {
            get
            {
                CanReadProperty("HeSoChucVu", true);
                if (_heSoChucVu == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoChucVu.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoChucVu", true);

                if (_heSoChucVu.ToString() != value)
                {
                    if (value == "")
                        _heSoChucVu = 0;
                    else
                        _heSoChucVu = Decimal.Parse(value);
                    PropertyHasChanged("HeSoChucVu");
                }
            }
        }

        //public Decimal HeSoDieuDuong
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoDieuDuong", true);
        //        return _heSoDieuDuong;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoDieuDuong", true);
        //        if (_heSoDieuDuong != value)
        //        {
        //            _heSoDieuDuong = value;
        //            PropertyHasChanged("HeSoDieuDuong");
        //        }
        //    }
        //}

        public string HeSoDieuDuong
        {
            get
            {
                CanReadProperty("HeSoDieuDuong", true);
                if (_heSoDieuDuong == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoDieuDuong.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoDieuDuong", true);

                if (_heSoDieuDuong.ToString() != value)
                {
                    if (value == "")
                        _heSoDieuDuong = 0;
                    else
                        _heSoDieuDuong = Decimal.Parse(value);
                    PropertyHasChanged("HeSoDieuDuong");
                }
            }
        }

        //public Decimal HeSoCKCI
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoCKCI", true);
        //        return _heSoCKCI;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoCKCI", true);
        //        if (_heSoCKCI != value)
        //        {
        //            _heSoCKCI = value;
        //            PropertyHasChanged("HeSoCKCI");
        //        }
        //    }
        //}
        public string HeSoCKCI
        {
            get
            {
                CanReadProperty("HeSoCKCI", true);
                if (_heSoCKCI == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoCKCI.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoCKCI", true);

                if (_heSoCKCI.ToString() != value)
                {
                    if (value == "")
                        _heSoCKCI = 0;
                    else
                        _heSoCKCI = Decimal.Parse(value);
                    PropertyHasChanged("HeSoCKCI");
                }
            }
        }
        //public Decimal HeSoNT
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoNT", true);
        //        return _heSoNT;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoNT", true);
        //        if (_heSoNT != value)
        //        {
        //            _heSoNT = value;
        //            PropertyHasChanged("HeSoNT");
        //        }
        //    }
        //}
        public string HeSoNT
        {
            get
            {
                CanReadProperty("HeSoNT", true);
                if (_heSoNT == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoNT.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoNT", true);

                if (_heSoNT.ToString() != value)
                {
                    if (value == "")
                        _heSoNT = 0;
                    else
                        _heSoNT = Decimal.Parse(value);
                    PropertyHasChanged("HeSoNT");
                }
            }
        }

        //public Decimal HeSoHVK
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoHVK", true);
        //        return _heSoHVK;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoHVK", true);
        //        if (_heSoHVK != value)
        //        {
        //            _heSoHVK = value;
        //            PropertyHasChanged("HeSoHVK");
        //        }
        //    }
        //}

        public string HeSoHVK
        {
            get
            {
                CanReadProperty("HeSoHVK", true);
                if (_heSoHVK == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoHVK.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoHVK", true);

                if (_heSoHVK.ToString() != value)
                {
                    if (value == "")
                        _heSoHVK = 0;
                    else
                        _heSoHVK = Decimal.Parse(value);
                    PropertyHasChanged("HeSoHVK");
                }
            }
        }

        //public Decimal HeSoDaiHoc
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoDaiHoc", true);
        //        return _heSoDaiHoc;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoDaiHoc", true);
        //        if (_heSoDaiHoc != value)
        //        {
        //            _heSoDaiHoc = value;
        //            PropertyHasChanged("HeSoDaiHoc");
        //        }
        //    }
        //}
        public string HeSoDaiHoc
        {
            get
            {
                CanReadProperty("HeSoDaiHoc", true);
                if (_heSoDaiHoc == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoDaiHoc.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoDaiHoc", true);

                if (_heSoDaiHoc.ToString() != value)
                {
                    if (value == "")
                        _heSoDaiHoc = 0;
                    else
                        _heSoDaiHoc = Decimal.Parse(value);
                    PropertyHasChanged("HeSoDaiHoc");
                }
            }
        }

        //public Decimal HeSoCaoDang
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoCaoDang", true);
        //        return _heSoCaoDang ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoCaoDang", true);
        //        if (_heSoCaoDang != value)
        //        {
        //            _heSoCaoDang = value;
        //            PropertyHasChanged("HeSoCaoDang");
        //        }
        //    }
        //}

        public string HeSoCaoDang
        {
            get
            {
                CanReadProperty("HeSoCaoDang", true);
                if (_heSoCaoDang == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoCaoDang.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoCaoDang", true);

                if (_heSoCaoDang.ToString() != value)
                {
                    if (value == "")
                        _heSoCaoDang = 0;
                    else
                        _heSoCaoDang = Decimal.Parse(value);
                    PropertyHasChanged("HeSoCaoDang");
                }
            }
        }

        //public Decimal HeSoTrungCap
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoTrungCap", true);
        //        return _heSoTrungCap;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoTrungCap", true);
        //        if (_heSoTrungCap != value)
        //        {
        //            _heSoTrungCap = value;
        //            PropertyHasChanged("HeSoTrungCap");
        //        }
        //    }
        //}
        public string HeSoTrungCap
        {
            get
            {
                CanReadProperty("HeSoTrungCap", true);
                if (_heSoTrungCap == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoTrungCap.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoTrungCap", true);

                if (_heSoTrungCap.ToString() != value)
                {
                    if (value == "")
                        _heSoTrungCap = 0;
                    else
                        _heSoTrungCap = Decimal.Parse(value);
                    PropertyHasChanged("HeSoTrungCap");
                }
            }
        }

        //public Decimal HeSoKhac
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoKhac", true);
        //        return _heSoKhac;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoKhac", true);
        //        if (_heSoKhac != value)
        //        {
        //            _heSoKhac = value;
        //            PropertyHasChanged("HeSoKhac");
        //        }
        //    }
        //}
        public string HeSoKhac
        {
            get
            {
                CanReadProperty("HeSoKhac", true);
                if (_heSoKhac == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoKhac.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoKhac", true);

                if (_heSoKhac.ToString() != value)
                {
                    if (value == "")
                        _heSoKhac = 0;
                    else
                        _heSoKhac = Decimal.Parse(value);
                    PropertyHasChanged("HeSoKhac");
                }
            }
        }
        //public Decimal HeSoToTruong
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoToTruong", true);
        //        return _heSoToTruong ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoToTruong", true);
        //        if (_heSoToTruong != value)
        //        {
        //            _heSoToTruong = value;
        //            PropertyHasChanged("HeSoToTruong");
        //        }
        //    }
        //}
        public string HeSoToTruong
        {
            get
            {
                CanReadProperty("HeSoToTruong", true);
                if (_heSoToTruong == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoToTruong.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoToTruong", true);

                if (_heSoToTruong.ToString() != value)
                {
                    if (value == "")
                        _heSoToTruong = 0;
                    else
                        _heSoToTruong = Decimal.Parse(value);
                    PropertyHasChanged("HeSoToTruong");
                }
            }
        }
        //public string NamDiLam
        //{
        //    get
        //    {
        //        CanReadProperty("NamDiLam", true);
        //        return _namDiLam.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NamDiLam", true);
        //        if (_namDiLam.Text != value)
        //        {
        //            _namDiLam.Text = value;
        //            PropertyHasChanged("NamDiLam");
        //        }
        //    }
        //}
        public string NamDiLam
        {
            get
            {
                CanReadProperty("NamDiLam", true);
                _namDiLam.FormatString = "MM/yyyy";

                return _namDiLam.Text;
            }
            set
            {
                CanWriteProperty("NamDiLam", true);
                if (_namDiLam.Text != value)
                {
                    _namDiLam.Text = value;
                    PropertyHasChanged("NamDiLam");
                }
            }
        }
        //public String NamDiLam
        //{
        //    get
        //    {
        //        CanReadProperty("NamDiLam", true);
        //        //_hanSD.FormatString = "MM/dd/yyyy";
        //        return _namDiLam.Text;
        //    }
        //    set
        //    {


        //        if (!_namDiLam.Equals(value))
        //        {
        //            //  _hanSD.FormatString = "MM/dd/yyyy";
        //            _namDiLam.Text = value;

        //        }
        //    }
        //}

        //public String NamDiLamD
        //{
        //    get
        //    {
        //        CanReadProperty("NamDiLamD", true);
        //        _namDiLamD = _namDiLam;

        //        this._namDiLamD.FormatString = "dd/MM/yyyy";
        //        return _namDiLamD.Text;
        //    }
        //    set
        //    {
        //        //CanWriteProperty("HanSDD", true);
        //        if (this._namDiLamD.FormatString == "dd/MM/yyyy")
        //            value = value.Substring(3, 2) + "/" + value.Substring(0, 2) + "/" + value.Substring(6, 4);
        //        if (!_namDiLamD.Equals(value))
        //        {
        //            _namDiLamD.FormatString = "dd/MM/yyyy";
        //            _namDiLam = SmartDate.Parse(value);
        //            _namDiLamD.Text = value;

        //            //PropertyHasChanged("HanSDD");
        //        }

        //    }

        //}

        //public byte SoNam
        //{
        //    get
        //    {
        //        CanReadProperty("SoNam", true);
        //        return _soNam;
        //    }
        //    set
        //    {
        //        CanWriteProperty("SoNam", true);
        //        if (_soNam != value)
        //        {
        //            _soNam = value;
        //            PropertyHasChanged("SoNam");
        //        }
        //    }
        //}
        public int  SoNam
        {
            get
            {
                int  _Nam = 0;
                //CanReadProperty("Tuoi", true);
                if (_namDiLam.Date.Year != 1)
                   // _Nam = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _namDiLam.Date.Year + 1);
                _Nam = (12 * (Convert.ToInt32(_thang.Date.Year) - Convert.ToInt32(_namDiLam.Date.Year)) + Convert.ToInt32(_thang.Date.Month) - Convert.ToInt32(_namDiLam.Date.Month))/12;
                return _Nam;
            }
            set
            {
                CanWriteProperty("SoNam", true);
                if (_soNam != value)
                {
                    _soNam = value;
                    PropertyHasChanged("SoNam");
                }
            }
        }

        public string HeSoThamNien
        {
            get
            {
                CanReadProperty("HeSoThamNien", true);
                if (_heSoThamNien == 0)
                {
                    return "";
                }
                else
                {
                    return _heSoThamNien.ToString("##,###.##");
                }
            }
            set
            {
                CanWriteProperty("HeSoThamNien", true);

                if (_heSoThamNien.ToString() != value)
                {
                    if (value == "")
                        _heSoThamNien = 0;
                    else
                        _heSoThamNien = Decimal.Parse(value);
                    PropertyHasChanged("HeSoThamNien");
                }
            }
        }

        //public Decimal HeSoThamNien
        //{
        //    get
        //    {
        //        CanReadProperty("HeSoThamNien", true);
        //        return _heSoThamNien;
        //    }
        //    set
        //    {
        //        CanWriteProperty("HeSoThamNien", true);
        //        if (_heSoThamNien != value)
        //        {
        //            _heSoThamNien = value;
        //            PropertyHasChanged("HeSoThamNien");
        //        }
        //    }
        //}

        public string TongSo
        {
            get
            {
                CanReadProperty("TongSo", true);
                _tongSo = _heSoChucVu  + _heSoDieuDuong + _heSoCKCI + _heSoNT  + _heSoHVK  + _heSoDaiHoc  + _heSoCaoDang  + _heSoTrungCap  + _heSoKhac  + _heSoToTruong  + _heSoThamNien ;
                //return _tongSoTheo.ToString("###,###");
                if (_tongSo == 0)
                {
                    return "";
                }
                else
                {
                    return _tongSo.ToString("###,###.##");
                }
            }
            set
            {
                CanWriteProperty("TongSo", true);

                if (_tongSo.ToString() != value)
                {
                    if (value == "")
                        _tongSo = 0;
                    else
                        _tongSo = Int32.Parse(value.Replace(",", ""));
                    PropertyHasChanged("TongSo");
                }
            }
        }

        //public Decimal TongSo
        //{
        //    get
        //    {
        //        CanReadProperty("TongSo", true);
        //        return _tongSo ;
        //    }
        //    set
        //    {
        //        CanWriteProperty("TongSo", true);
        //        if (_tongSo != value)
        //        {
        //            _tongSo = value;
        //            PropertyHasChanged("TongSo");
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
        public Boolean Gioitinh
        {
            get
            {
                CanReadProperty("Gioitinh", true);
                return _gioitinh;
            }
            set
            {
                CanWriteProperty("Gioitinh", true);
                if (_gioitinh != value)
                {
                    _gioitinh = value;
                    PropertyHasChanged("Gioitinh");
                }
            }
        }

        public Boolean GioitinhNu
        {
            get
            {
                CanReadProperty("GioitinhNu", true);
                if (_gioitinh == true)
                    return false;
                else
                    return true;
            }

        }
        public string Ngaysinh
        {
            get
            {
                CanReadProperty("Ngaysinh", true);
                return _NgaySinh.Text;
            }
            set
            {
                CanWriteProperty("Ngaysinh", true);
                if (_NgaySinh.Text != value)
                {
                    _NgaySinh.Text = value;
                    PropertyHasChanged("Ngaysinh");
                }
            }
        }
        public Decimal Dongia
        {
            get
            {
                CanReadProperty("Dongia", true);
                return _donGia;
            }
            set
            {
                CanWriteProperty("Dongia", true);
                if (_donGia != value)
                {
                    _donGia = value;
                    PropertyHasChanged("Dongia");
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
		/// Factory method. New <see cref="Luong_M2" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static Luong_M2 NewLuong_M2()
        {
            return new Luong_M2();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static Luong_M2 GetLuong_M2(SafeDataReader dr, int i)
        {
            return new Luong_M2(dr, i);
        }
        //public static Luong_M2 GetLuong_M2(Int32 sTT, SmartDate thang)
        //{
        //    return DataPortal.Fetch<Luong_M2>(new Criteria(sTT, thang));
        //}
        public Luong_M2()
        {
            MarkAsChild();
        }
		/// <summary>
		/// Marks the <see cref="Luong_M2" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        //public static void DeleteLuong_M2(Int32 sTT, SmartDate thang)
        //{
        //    DataPortal.Delete(new Criteria(sTT, thang));
        //}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal Luong_M2()
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
		/// Retrieve an existing <see cref="Luong_M2" /> Object based on data in the database.
		/// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetLuong_M2(Int32 _sTT, SmartDate _thang);
        //    // public override IDataReader GetLuong_M2(Int32 _sTT, SmartDate _thang)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _sTT, _thang));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetLuong_M2(crit.STT, crit.Thang.DBValue)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
		/// <summary>
		/// Load a <see cref="Luong_M2" /> Object from given SafeDataReader.
		/// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
        //    if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
        //    if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
        //    if (dr.GetDecimal("MucLuong_M2CB") != null) _mucLuong_M2CB = dr.GetDecimal("MucLuong_M2CB");
        //    if (dr.GetDecimal("HeSoLuong_M2") != null) _heSoLuong_M2 = dr.GetDecimal("HeSoLuong_M2");
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
        private Luong_M2(SafeDataReader dr, int i)
        {
            MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
			if (dr.GetSmartDate("Thang", true) != null) _thang = dr.GetSmartDate("Thang", true);
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("Makhoa") != null) _makhoa = dr.GetString("Makhoa");
            if (dr.GetDecimal("HeSoChucVu") != null) _heSoChucVu = dr.GetDecimal("HeSoChucVu");
            if (dr.GetDecimal("HeSoDieuDuong") != null) _heSoDieuDuong = dr.GetDecimal("HeSoDieuDuong");
            if (dr.GetDecimal("HeSoCKCI") != null) _heSoCKCI = dr.GetDecimal("HeSoCKCI");
            if (dr.GetDecimal("HeSoNT") != null) _heSoNT = dr.GetDecimal("HeSoNT");
            if (dr.GetDecimal("HeSoHVK") != null) _heSoHVK = dr.GetDecimal("HeSoHVK");
            if (dr.GetDecimal("HeSoDaiHoc") != null) _heSoDaiHoc = dr.GetDecimal("HeSoDaiHoc");
            if (dr.GetDecimal("HeSoCaoDang") != null) _heSoCaoDang  = dr.GetDecimal("HeSoCaoDang");
            if (dr.GetDecimal("HeSoTrungCap") != null) _heSoTrungCap = dr.GetDecimal("HeSoTrungCap");
            if (dr.GetDecimal("HeSoKhac") != null) _heSoKhac = dr.GetDecimal("HeSoKhac");
            if (dr.GetDecimal("HeSoToTruong") != null) _heSoToTruong = dr.GetDecimal("HeSoToTruong");
            if (dr.GetSmartDate("NamDiLam", true) != null) _namDiLam = dr.GetSmartDate("NamDiLam", true);
            if (dr.GetDecimal("HeSoThamNien") != null) _heSoThamNien = dr.GetDecimal("HeSoThamNien");
            if (dr.GetDecimal("TongSo") != null) _tongSo = dr.GetDecimal("TongSo");
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
            if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
            if (dr.GetString("TenChuyenMon") != null) _tenChuyenMon = dr.GetString("TenChuyenMon");
            if (dr.GetString("tenLoaiHD") != null) _tenLoaiHD = dr.GetString("tenLoaiHD");
            if (dr.GetBoolean("Gioitinh") != null) _gioitinh = dr.GetBoolean("Gioitinh");
            if (dr.GetSmartDate("Ngaysinh", true) != null) _NgaySinh = dr.GetSmartDate("Ngaysinh", true);
            if (dr.GetDecimal("mucluongcb") != null) _mucLuongCB = dr.GetDecimal("mucluongcb");
            if (dr.GetDecimal("NgayCong") != null) _ngayCong = dr.GetDecimal("NgayCong");

            MarkOld();
        }
		/// <summary>
		/// Insert the new <see cref="Luong_M2" /> Object to underlying database.
		/// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
            
            _sTT = DataProvider.Instance().InsertLuong_M2(_thang, _maNV, _makhoa, _heSoChucVu, _heSoDieuDuong, _heSoCKCI, _heSoNT, _heSoHVK, _heSoDaiHoc, _heSoCaoDang, _heSoTrungCap, _heSoKhac, _heSoToTruong ,_namDiLam, _heSoThamNien, _tongSo , _maMay, _nguoiSD ,_mucLuongCB ,_Tong, _ngayCong  );
            // public abstract Int32 InsertLuong_M2(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSoDieuDuong, Decimal _heSoCKCI, Decimal _heSoNT, Decimal _heSoHVK, Decimal _heSoDaiHoc, Decimal _heSoTrungCap, Decimal _heSoDuocTa, SmartDate _namDiLam, Decimal _heSoThamNien, String _maMay, String _nguoiLap);
            // public override Int32 InsertLuong_M2(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSoDieuDuong, Decimal _heSoCKCI, Decimal _heSoNT, Decimal _heSoHVK, Decimal _heSoDaiHoc, Decimal _heSoTrungCap, Decimal _heSoDuocTa, SmartDate _namDiLam, Decimal _heSoThamNien, String _maMay, String _nguoiLap)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_M2_CREATE", _sTT, _thang.DBValue, _maNV, _makhoa, _heSoChucVu, _heSoDieuDuong, _heSoCKCI, _heSoNT, _heSoHVK, _heSoDaiHoc, _heSoTrungCap, _heSoDuocTa, _namDiLam, _heSoThamNien, _maMay, _nguoiSD);
			// }
            MarkOld();
		}
		
		/// <summary>
		/// Update all changes made on <see cref="Luong_M2" /> Object to underlying database.
		/// </summary>
		 internal void Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
			 if (!this.IsDirty)
                return;
                
                  
                DataProvider.Instance().UpdateLuong_M2(_sTT, _thang, _maNV, _makhoa, _heSoChucVu, _heSoDieuDuong, _heSoCKCI, _heSoNT, _heSoHVK, _heSoDaiHoc, _heSoCaoDang, _heSoTrungCap, _heSoKhac, _heSoToTruong, _namDiLam, _heSoThamNien, _tongSo, _maMay, _nguoiSD , _huy, _mucLuongCB, _Tong, _ngayCong);
                // public abstract void UpdateLuong_M2(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSoDieuDuong, Decimal _heSoCKCI, Decimal _heSoNT, Decimal _heSoHVK, Decimal _heSoDaiHoc, Decimal _heSoTrungCap, Decimal _heSoDuocTa, SmartDate _namDiLam, Decimal _heSoThamNien, String _maMay, String _nguoiSD, Boolean _huy);
                // public override void UpdateLuong_M2(Int32 _sTT, SmartDate _thang, String _maNV, String _makhoa, Decimal _heSoChucVu, Decimal _heSoDieuDuong, Decimal _heSoCKCI, Decimal _heSoNT, Decimal _heSoHVK, Decimal _heSoDaiHoc, Decimal _heSoTrungCap, Decimal _heSoDuocTa, SmartDate _namDiLam, Decimal _heSoThamNien, String _maMay, String _nguoiSD, Boolean _huy)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_M2_UPDATE", _sTT, _thang.DBValue, _maNV, _makhoa, _heSoChucVu, _heSoDieuDuong, _heSoCKCI, _heSoNT, _heSoHVK, _heSoDaiHoc, _heSoTrungCap, _heSoDuocTa, _namDiLam, _heSoThamNien, _maMay, _nguoiSD , _huy);
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
		/// Delete the <see cref="Luong_M2" />.
		/// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateLuong_M2
            DataProvider.Instance().DeleteLuong_M2(crit.MaMay, crit.NguoiSD, crit.STT, crit.Thang);
			// public abstract void DeleteLuong_M2(Int32 _sTT, SmartDate _thang);
			// public override void DeleteLuong_M2(Int32 _sTT, SmartDate _thang);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spLuong_M2_DELETED", _sTT, _thang);
			// }
		}

		#endregion
	}

}
