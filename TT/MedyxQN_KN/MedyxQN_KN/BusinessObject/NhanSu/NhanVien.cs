// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	NhanVien
// Kieu doi tuong  :	NhanVien
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

namespace HTC.Business.NhanSu
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="NhanVien" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class NhanVien : BusinessBase<NhanVien>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maNV = String.Empty;
		private String _hoten = String.Empty;
		private String _hotenks = String.Empty;
		private Boolean _gioitinh = false;
        private Boolean _gioitinhNam = false;
		private SmartDate _ngaysinh = new SmartDate(true);
        private SmartDate _ngaysinhD = new SmartDate(true);
		private String _dienThoai = String.Empty;
		private String _maKhoa = String.Empty;
		private String _noisinh = String.Empty;
		private String _quequan = String.Empty;
		private String _matongiao = String.Empty;
		private String _madantoc = String.Empty;
		private String _chooHT = String.Empty;
		private String _thuongtru = String.Empty;
		private String _soCMND = String.Empty;
		private String _noicap = String.Empty;
		private SmartDate _ngaycap = new SmartDate(true);
		private String _maTPhanGD = String.Empty;
		private String _maTPhanBT = String.Empty;
		private String _maDienCSach = String.Empty;
		private String _soBHXH = String.Empty;
		private Boolean _dongBHXH = false;
		private SmartDate _tuNgayCM = new SmartDate(true);
		private SmartDate _denNgayCM = new SmartDate(true);
		private SmartDate _tuNgayCMy = new SmartDate(true);
		private SmartDate _denNgayCMy = new SmartDate(true);
		private SmartDate _tuNgayBCK = new SmartDate(true);
		private SmartDate _denNgayBCK = new SmartDate(true);
		private SmartDate _ngaynhapngu = new SmartDate(true);
		private SmartDate _ngayxuatngu = new SmartDate(true);
		private SmartDate _ngayVaoBChe = new SmartDate(true);
		private SmartDate _tuNgayPV = new SmartDate(true);
		private SmartDate _denNgayPV = new SmartDate(true);
		private SmartDate _tNXPhong = new SmartDate(true);
		private SmartDate _dNXPhong = new SmartDate(true);
		private SmartDate _tNDocHai = new SmartDate(true);
		private SmartDate _dNDocHai = new SmartDate(true);
		private SmartDate _tNKhac = new SmartDate(true);
		private SmartDate _dNKhac = new SmartDate(true);
		private String _maChucDanh = String.Empty;
		private String _maChucVu = String.Empty;
		private String _maHocHam = String.Empty;
		private String _maChuyenMon = String.Empty;
		private String _maHocVan = String.Empty;
		private String _maTDChinhTri = String.Empty;
		private String _maTDNgoaiNgu = String.Empty;
		private SmartDate _ngayDang = new SmartDate(true);
		private String _noiKNap = String.Empty;
		private String _nguoiGT = String.Empty;
		private SmartDate _ngayDoan = new SmartDate(true);
		private SmartDate _ngayvaoCQ = new SmartDate(true);
		private String _maSuckhoe = String.Empty;
		private String _maTrangthai = String.Empty;
		private SmartDate _ngaynghiviec = new SmartDate(true);
		private String _lydoNghi = String.Empty;
		private Byte[] _anh = new Byte[] {};
		private Boolean _tinhLuongHeso = false;
		private String _maMay = String.Empty;
		private SmartDate _ngayHuy = new SmartDate(true);
		private String _nguoiHuy = String.Empty;
		private SmartDate _ngayLap = new SmartDate(true);
		private String _nguoiLap = String.Empty;
		private SmartDate _ngaySD = new SmartDate(true);
		private String _nguoiSD = String.Empty;
		private Boolean _huy = false;
		private SmartDate _ngaySD1 = new SmartDate(true);
		private String _nguoiSD1 = String.Empty;
        private String _maLoaiHD = String.Empty;
		private String _maNVQL = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenKhoa = String.Empty;
        private String _tenChuyenmon = String.Empty;
        private String _tenCV = String.Empty;
        private String _maTDTinHoc = String.Empty;
        private String _maChuyenNganh = String.Empty;
        private Byte _tuoi = 0;
        private int _OrderNumber;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenTonGiao = String.Empty;
        private String _tenDanToc = String.Empty;
        private String _tenTPhanGD = String.Empty;
        private String _tenTPhanBT = String.Empty;
        private String _tenHocVan = String.Empty;
        private String _tenHocHam = String.Empty;
        private String _tenTDChinhTri = String.Empty;
        private String _tenTDTinHoc = String.Empty;
        private String _tenChuyenNganh = String.Empty;
        private String _tenCD = String.Empty;
        private String _tenSucKhoe = String.Empty;
        private String _tenDienCSach = String.Empty;
        #endregion

        #region Business Properties and Methods

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
		
		public String Hoten
		{
			get 
			{
				CanReadProperty("Hoten", true);
				return _hoten;
			}
			set 
			{
				CanWriteProperty("Hoten", true);
				if (_hoten != value) 
				{
					_hoten = value;
					PropertyHasChanged("Hoten");
				}
			}
		}
		
		public String Hotenks
		{
			get 
			{
				CanReadProperty("Hotenks", true);
				return _hotenks;
			}
			set 
			{
				CanWriteProperty("Hotenks", true);
				if (_hotenks != value) 
				{
					_hotenks = value;
					PropertyHasChanged("Hotenks");
				}
			}
		}

        public byte Tuoi
        {
            get
            {
                byte _Age = 0;
                //CanReadProperty("Tuoi", true);
                if (_ngaysinh.Date.Year != 1)
                    _Age = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaysinh.Date.Year + 1) ;
                return _Age;
            }
            set
            {
                CanWriteProperty("Tuoi", true);
                if (_tuoi != value)
                {
                    _tuoi = value;
                    PropertyHasChanged("Tuoi");
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
        public String GT
        {
            get
            {
                CanReadProperty("GT", true);
                if (_gioitinh == true)
                    return "Nam";
                else
                    return "Nữ";
            }

        }

        public string Ngaysinh
        {
            get
            {
                CanReadProperty("Ngaysinh", true);
                return _ngaysinh.Text;
            }
            set
            {
                CanWriteProperty("Ngaysinh", true);
                if (_ngaysinh.Text != value)
                {
                    _ngaysinh.Text = value;
                    PropertyHasChanged("Ngaysinh");
                }
            }
        }

        public string NgaysinhD
        {
            get
            {
                CanReadProperty("NgaysinhD", true);
                _ngaysinhD = _ngaysinh ;
                _ngaysinhD.FormatString = "dd/MM/yyyy";
                return _ngaysinhD.Text;
            }

        }


		
		public String DienThoai
		{
			get 
			{
				CanReadProperty("DienThoai", true);
				return _dienThoai;
			}
			set 
			{
				CanWriteProperty("DienThoai", true);
				if (_dienThoai != value) 
				{
					_dienThoai = value;
					PropertyHasChanged("DienThoai");
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
		
		public String Noisinh
		{
			get 
			{
				CanReadProperty("Noisinh", true);
				return _noisinh;
			}
			set 
			{
				CanWriteProperty("Noisinh", true);
				if (_noisinh != value) 
				{
					_noisinh = value;
					PropertyHasChanged("Noisinh");
				}
			}
		}
		
		public String Quequan
		{
			get 
			{
				CanReadProperty("Quequan", true);
				return _quequan;
			}
			set 
			{
				CanWriteProperty("Quequan", true);
				if (_quequan != value) 
				{
					_quequan = value;
					PropertyHasChanged("Quequan");
				}
			}
		}
		
		public String Matongiao
		{
			get 
			{
				CanReadProperty("Matongiao", true);
				return _matongiao;
			}
			set 
			{
				CanWriteProperty("Matongiao", true);
				if (_matongiao != value) 
				{
					_matongiao = value;
					PropertyHasChanged("Matongiao");
				}
			}
		}
		
		public String Madantoc
		{
			get 
			{
				CanReadProperty("Madantoc", true);
				return _madantoc;
			}
			set 
			{
				CanWriteProperty("Madantoc", true);
				if (_madantoc != value) 
				{
					_madantoc = value;
					PropertyHasChanged("Madantoc");
				}
			}
		}
		
		public String ChooHT
		{
			get 
			{
				CanReadProperty("ChooHT", true);
				return _chooHT;
			}
			set 
			{
				CanWriteProperty("ChooHT", true);
				if (_chooHT != value) 
				{
					_chooHT = value;
					PropertyHasChanged("ChooHT");
				}
			}
		}
		
		public String Thuongtru
		{
			get 
			{
				CanReadProperty("Thuongtru", true);
				return _thuongtru;
			}
			set 
			{
				CanWriteProperty("Thuongtru", true);
				if (_thuongtru != value) 
				{
					_thuongtru = value;
					PropertyHasChanged("Thuongtru");
				}
			}
		}
		
		public String SoCMND
		{
			get 
			{
				CanReadProperty("SoCMND", true);
				return _soCMND;
			}
			set 
			{
				CanWriteProperty("SoCMND", true);
				if (_soCMND != value) 
				{
					_soCMND = value;
					PropertyHasChanged("SoCMND");
				}
			}
		}
		
		public String Noicap
		{
			get 
			{
				CanReadProperty("Noicap", true);
				return _noicap;
			}
			set 
			{
				CanWriteProperty("Noicap", true);
				if (_noicap != value) 
				{
					_noicap = value;
					PropertyHasChanged("Noicap");
				}
			}
		}
		
		public string Ngaycap
		{
			get 
			{
				CanReadProperty("Ngaycap", true);
				return _ngaycap.Text;
			}
			set 
			{
				CanWriteProperty("Ngaycap", true);
				if (_ngaycap.Text != value) 
				{
					_ngaycap.Text = value;
					PropertyHasChanged("Ngaycap");
				}
			}
		}
		
		public String MaTPhanGD
		{
			get 
			{
				CanReadProperty("MaTPhanGD", true);
				return _maTPhanGD;
			}
			set 
			{
				CanWriteProperty("MaTPhanGD", true);
				if (_maTPhanGD != value) 
				{
					_maTPhanGD = value;
					PropertyHasChanged("MaTPhanGD");
				}
			}
		}
		
		public String MaTPhanBT
		{
			get 
			{
				CanReadProperty("MaTPhanBT", true);
				return _maTPhanBT;
			}
			set 
			{
				CanWriteProperty("MaTPhanBT", true);
				if (_maTPhanBT != value) 
				{
					_maTPhanBT = value;
					PropertyHasChanged("MaTPhanBT");
				}
			}
		}
		
		public String MaDienCSach
		{
			get 
			{
				CanReadProperty("MaDienCSach", true);
				return _maDienCSach;
			}
			set 
			{
				CanWriteProperty("MaDienCSach", true);
				if (_maDienCSach != value) 
				{
					_maDienCSach = value;
					PropertyHasChanged("MaDienCSach");
				}
			}
		}
		
		public String SoBHXH
		{
			get 
			{
				CanReadProperty("SoBHXH", true);
				return _soBHXH;
			}
			set 
			{
				CanWriteProperty("SoBHXH", true);
				if (_soBHXH != value) 
				{
					_soBHXH = value;
					PropertyHasChanged("SoBHXH");
				}
			}
		}
		
		public Boolean DongBHXH
		{
			get 
			{
				CanReadProperty("DongBHXH", true);
				return _dongBHXH;
			}
			set 
			{
				CanWriteProperty("DongBHXH", true);
				if (_dongBHXH != value) 
				{
					_dongBHXH = value;
					PropertyHasChanged("DongBHXH");
				}
			}
		}
		
		public string TuNgayCM
		{
			get 
			{
				CanReadProperty("TuNgayCM", true);
				return _tuNgayCM.Text;
			}
			set 
			{
				CanWriteProperty("TuNgayCM", true);
				if (_tuNgayCM.Text != value) 
				{
					_tuNgayCM.Text = value;
					PropertyHasChanged("TuNgayCM");
				}
			}
		}
		
		public string DenNgayCM
		{
			get 
			{
				CanReadProperty("DenNgayCM", true);
				return _denNgayCM.Text;
			}
			set 
			{
				CanWriteProperty("DenNgayCM", true);
				if (_denNgayCM.Text != value) 
				{
					_denNgayCM.Text = value;
					PropertyHasChanged("DenNgayCM");
				}
			}
		}
		
		public string TuNgayCMy
		{
			get 
			{
				CanReadProperty("TuNgayCMy", true);
				return _tuNgayCMy.Text;
			}
			set 
			{
				CanWriteProperty("TuNgayCMy", true);
				if (_tuNgayCMy.Text != value) 
				{
					_tuNgayCMy.Text = value;
					PropertyHasChanged("TuNgayCMy");
				}
			}
		}
		
		public string DenNgayCMy
		{
			get 
			{
				CanReadProperty("DenNgayCMy", true);
				return _denNgayCMy.Text;
			}
			set 
			{
				CanWriteProperty("DenNgayCMy", true);
				if (_denNgayCMy.Text != value) 
				{
					_denNgayCMy.Text = value;
					PropertyHasChanged("DenNgayCMy");
				}
			}
		}
		
		public string TuNgayBCK
		{
			get 
			{
				CanReadProperty("TuNgayBCK", true);
				return _tuNgayBCK.Text;
			}
			set 
			{
				CanWriteProperty("TuNgayBCK", true);
				if (_tuNgayBCK.Text != value) 
				{
					_tuNgayBCK.Text = value;
					PropertyHasChanged("TuNgayBCK");
				}
			}
		}
		
		public string DenNgayBCK
		{
			get 
			{
				CanReadProperty("DenNgayBCK", true);
				return _denNgayBCK.Text;
			}
			set 
			{
				CanWriteProperty("DenNgayBCK", true);
				if (_denNgayBCK.Text != value) 
				{
					_denNgayBCK.Text = value;
					PropertyHasChanged("DenNgayBCK");
				}
			}
		}
		
		public string Ngaynhapngu
		{
			get 
			{
				CanReadProperty("Ngaynhapngu", true);
				return _ngaynhapngu.Text;
			}
			set 
			{
				CanWriteProperty("Ngaynhapngu", true);
				if (_ngaynhapngu.Text != value) 
				{
					_ngaynhapngu.Text = value;
					PropertyHasChanged("Ngaynhapngu");
				}
			}
		}
		
		public string Ngayxuatngu
		{
			get 
			{
				CanReadProperty("Ngayxuatngu", true);
				return _ngayxuatngu.Text;
			}
			set 
			{
				CanWriteProperty("Ngayxuatngu", true);
				if (_ngayxuatngu.Text != value) 
				{
					_ngayxuatngu.Text = value;
					PropertyHasChanged("Ngayxuatngu");
				}
			}
		}
		
		public string NgayVaoBChe
		{
			get 
			{
				CanReadProperty("NgayVaoBChe", true);
				return _ngayVaoBChe.Text;
			}
			set 
			{
				CanWriteProperty("NgayVaoBChe", true);
				if (_ngayVaoBChe.Text != value) 
				{
					_ngayVaoBChe.Text = value;
					PropertyHasChanged("NgayVaoBChe");
				}
			}
		}
		
		public string TuNgayPV
		{
			get 
			{
				CanReadProperty("TuNgayPV", true);
				return _tuNgayPV.Text;
			}
			set 
			{
				CanWriteProperty("TuNgayPV", true);
				if (_tuNgayPV.Text != value) 
				{
					_tuNgayPV.Text = value;
					PropertyHasChanged("TuNgayPV");
				}
			}
		}
		
		public string DenNgayPV
		{
			get 
			{
				CanReadProperty("DenNgayPV", true);
				return _denNgayPV.Text;
			}
			set 
			{
				CanWriteProperty("DenNgayPV", true);
				if (_denNgayPV.Text != value) 
				{
					_denNgayPV.Text = value;
					PropertyHasChanged("DenNgayPV");
				}
			}
		}
		
		public string TNXPhong
		{
			get 
			{
				CanReadProperty("TNXPhong", true);
				return _tNXPhong.Text;
			}
			set 
			{
				CanWriteProperty("TNXPhong", true);
				if (_tNXPhong.Text != value) 
				{
					_tNXPhong.Text = value;
					PropertyHasChanged("TNXPhong");
				}
			}
		}
		
		public string DNXPhong
		{
			get 
			{
				CanReadProperty("DNXPhong", true);
				return _dNXPhong.Text;
			}
			set 
			{
				CanWriteProperty("DNXPhong", true);
				if (_dNXPhong.Text != value) 
				{
					_dNXPhong.Text = value;
					PropertyHasChanged("DNXPhong");
				}
			}
		}
		
		public string TNDocHai
		{
			get 
			{
				CanReadProperty("TNDocHai", true);
				return _tNDocHai.Text;
			}
			set 
			{
				CanWriteProperty("TNDocHai", true);
				if (_tNDocHai.Text != value) 
				{
					_tNDocHai.Text = value;
					PropertyHasChanged("TNDocHai");
				}
			}
		}
		
		public string DNDocHai
		{
			get 
			{
				CanReadProperty("DNDocHai", true);
				return _dNDocHai.Text;
			}
			set 
			{
				CanWriteProperty("DNDocHai", true);
				if (_dNDocHai.Text != value) 
				{
					_dNDocHai.Text = value;
					PropertyHasChanged("DNDocHai");
				}
			}
		}
		
		public string TNKhac
		{
			get 
			{
				CanReadProperty("TNKhac", true);
				return _tNKhac.Text;
			}
			set 
			{
				CanWriteProperty("TNKhac", true);
				if (_tNKhac.Text != value) 
				{
					_tNKhac.Text = value;
					PropertyHasChanged("TNKhac");
				}
			}
		}
		
		public string DNKhac
		{
			get 
			{
				CanReadProperty("DNKhac", true);
				return _dNKhac.Text;
			}
			set 
			{
				CanWriteProperty("DNKhac", true);
				if (_dNKhac.Text != value) 
				{
					_dNKhac.Text = value;
					PropertyHasChanged("DNKhac");
				}
			}
		}
		
		public String MaChucDanh
		{
			get 
			{
				CanReadProperty("MaChucDanh", true);
				return _maChucDanh;
			}
			set 
			{
				CanWriteProperty("MaChucDanh", true);
				if (_maChucDanh != value) 
				{
					_maChucDanh = value;
					PropertyHasChanged("MaChucDanh");
				}
			}
		}
		
		public String MaChucVu
		{
			get 
			{
				CanReadProperty("MaChucVu", true);
				return _maChucVu;
			}
			set 
			{
				CanWriteProperty("MaChucVu", true);
				if (_maChucVu != value) 
				{
					_maChucVu = value;
					PropertyHasChanged("MaChucVu");
				}
			}
		}
		
		public String MaHocHam
		{
			get 
			{
				CanReadProperty("MaHocHam", true);
				return _maHocHam;
			}
			set 
			{
				CanWriteProperty("MaHocHam", true);
				if (_maHocHam != value) 
				{
					_maHocHam = value;
					PropertyHasChanged("MaHocHam");
				}
			}
		}
		
		public String MaChuyenMon
		{
			get 
			{
				CanReadProperty("MaChuyenMon", true);
				return _maChuyenMon;
			}
			set 
			{
				CanWriteProperty("MaChuyenMon", true);
				if (_maChuyenMon != value) 
				{
					_maChuyenMon = value;
					PropertyHasChanged("MaChuyenMon");
				}
			}
		}
		
		public String MaHocVan
		{
			get 
			{
				CanReadProperty("MaHocVan", true);
				return _maHocVan;
			}
			set 
			{
				CanWriteProperty("MaHocVan", true);
				if (_maHocVan != value) 
				{
					_maHocVan = value;
					PropertyHasChanged("MaHocVan");
				}
			}
		}
		
		public String MaTDChinhTri
		{
			get 
			{
				CanReadProperty("MaTDChinhTri", true);
				return _maTDChinhTri;
			}
			set 
			{
				CanWriteProperty("MaTDChinhTri", true);
				if (_maTDChinhTri != value) 
				{
					_maTDChinhTri = value;
					PropertyHasChanged("MaTDChinhTri");
				}
			}
		}
		
		public String MaTDNgoaiNgu
		{
			get 
			{
				CanReadProperty("MaTDNgoaiNgu", true);
				return _maTDNgoaiNgu;
			}
			set 
			{
				CanWriteProperty("MaTDNgoaiNgu", true);
				if (_maTDNgoaiNgu != value) 
				{
					_maTDNgoaiNgu = value;
					PropertyHasChanged("MaTDNgoaiNgu");
				}
			}
		}
		
		public string NgayDang
		{
			get 
			{
				CanReadProperty("NgayDang", true);
				return _ngayDang.Text;
			}
			set 
			{
				CanWriteProperty("NgayDang", true);
				if (_ngayDang.Text != value) 
				{
					_ngayDang.Text = value;
					PropertyHasChanged("NgayDang");
				}
			}
		}
		
		public String NoiKNap
		{
			get 
			{
				CanReadProperty("NoiKNap", true);
				return _noiKNap;
			}
			set 
			{
				CanWriteProperty("NoiKNap", true);
				if (_noiKNap != value) 
				{
					_noiKNap = value;
					PropertyHasChanged("NoiKNap");
				}
			}
		}
		
		public String NguoiGT
		{
			get 
			{
				CanReadProperty("NguoiGT", true);
				return _nguoiGT;
			}
			set 
			{
				CanWriteProperty("NguoiGT", true);
				if (_nguoiGT != value) 
				{
					_nguoiGT = value;
					PropertyHasChanged("NguoiGT");
				}
			}
		}
		
		public string NgayDoan
		{
			get 
			{
				CanReadProperty("NgayDoan", true);
				return _ngayDoan.Text;
			}
			set 
			{
				CanWriteProperty("NgayDoan", true);
				if (_ngayDoan.Text != value) 
				{
					_ngayDoan.Text = value;
					PropertyHasChanged("NgayDoan");
				}
			}
		}
		
		public string NgayvaoCQ
		{
			get 
			{
				CanReadProperty("NgayvaoCQ", true);
				return _ngayvaoCQ.Text;
			}
			set 
			{
				CanWriteProperty("NgayvaoCQ", true);
				if (_ngayvaoCQ.Text != value) 
				{
					_ngayvaoCQ.Text = value;
					PropertyHasChanged("NgayvaoCQ");
				}
			}
		}
		
		public String MaSuckhoe
		{
			get 
			{
				CanReadProperty("MaSuckhoe", true);
				return _maSuckhoe;
			}
			set 
			{
				CanWriteProperty("MaSuckhoe", true);
				if (_maSuckhoe != value) 
				{
					_maSuckhoe = value;
					PropertyHasChanged("MaSuckhoe");
				}
			}
		}
		
		public String MaTrangthai
		{
			get 
			{
				CanReadProperty("MaTrangthai", true);
				return _maTrangthai;
			}
			set 
			{
				CanWriteProperty("MaTrangthai", true);
				if (_maTrangthai != value) 
				{
					_maTrangthai = value;
					PropertyHasChanged("MaTrangthai");
				}
			}
		}
		
		public string Ngaynghiviec
		{
			get 
			{
				CanReadProperty("Ngaynghiviec", true);
				return _ngaynghiviec.Text;
			}
			set 
			{
				CanWriteProperty("Ngaynghiviec", true);
				if (_ngaynghiviec.Text != value) 
				{
					_ngaynghiviec.Text = value;
					PropertyHasChanged("Ngaynghiviec");
				}
			}
		}
		
		public String LydoNghi
		{
			get 
			{
				CanReadProperty("LydoNghi", true);
				return _lydoNghi;
			}
			set 
			{
				CanWriteProperty("LydoNghi", true);
				if (_lydoNghi != value) 
				{
					_lydoNghi = value;
					PropertyHasChanged("LydoNghi");
				}
			}
		}
		
		public Byte[] Anh
		{
			get 
			{
				CanReadProperty("Anh", true);
				return _anh;
			}
			set 
			{
				CanWriteProperty("Anh", true);
				bool setNewValue = false;
				if (value != null && _anh == null)
					setNewValue = true;
				if (!setNewValue && value != null && _anh != null) {
					if (_anh.Length != value.Length) {
						setNewValue = true;
					}
					else {
						for (int i=0; i < value.Length; i++) {
							if (value[i] != _anh[i]) {
								setNewValue = true;
								break;
							}
						}
					}
				}
				if (setNewValue) 
				{
					_anh = value;
					PropertyHasChanged("Anh");
				}
			}
		}
		
		public Boolean TinhLuongHeso
		{
			get 
			{
				CanReadProperty("TinhLuongHeso", true);
				return _tinhLuongHeso;
			}
			set 
			{
				CanWriteProperty("TinhLuongHeso", true);
				if (_tinhLuongHeso != value) 
				{
					_tinhLuongHeso = value;
					PropertyHasChanged("TinhLuongHeso");
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
		
        //public string NgayLap
        //{
        //    get 
        //    {
        //        CanReadProperty("NgayLap", true);
        //        return _ngayLap.Text;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("NgayLap", true);
        //        if (_ngayLap.Text != value) 
        //        {
        //            _ngayLap.Text = value;
        //            PropertyHasChanged("NgayLap");
        //        }
        //    }
        //}

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

 
        //public string NgaySD
        //{
        //    get
        //    {
        //        CanReadProperty("NgaySD", true);
        //        return _ngaySD.Text;
        //    }
        //    set
        //    {
        //        CanWriteProperty("NgaySD", true);
        //        if (_ngaySD.Text != value)
        //        {
        //            _ngaySD.Text = value;
        //            PropertyHasChanged("NgaySD");
        //        }
        //    }
        //}

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

        public String MaLoaiHD
		{
			get 
			{
				CanReadProperty("MaLoaiHD", true);
				return _maLoaiHD;
			}
			set 
			{
				CanWriteProperty("MaLoaiHD", true);
				if (_maLoaiHD != value) 
				{
					_maLoaiHD = value;
					PropertyHasChanged("MaLoaiHD");
				}
			}
		}
		
		public String MaNVQL
		{
			get 
			{
				CanReadProperty("MaNVQL", true);
                if (_maNVQL == "")
                    return _maNV;
                else
				return _maNVQL;
			}
			set 
			{
				CanWriteProperty("MaNVQL", true);
				if (_maNVQL != value) 
				{
					_maNVQL = value;
					PropertyHasChanged("MaNVQL");
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

        public String TenChuyenMon
        {
            get
            {
                CanReadProperty("TenChuyenMon", true);
                return _tenChuyenmon;
            }
            set
            {
                CanWriteProperty("TenChuyenMon", true);
                if (_tenChuyenmon != value)
                {
                    _tenChuyenmon = value;
                    PropertyHasChanged("TenChuyenMon");
                }
            }
        }
        public String TenCV
        {
            get
            {
                CanReadProperty("TenCV", true);
                return _tenCV;
            }
            set
            {
                CanWriteProperty("TenCV", true);
                if (_tenCV != value)
                {
                    _tenCV = value;
                    PropertyHasChanged("TenCV");
                }
            }
        }
        public String MaTDTinHoc
        {
            get
            {
                CanReadProperty("MaTDTinHoc", true);
                return _maTDTinHoc;
            }
            set
            {
                CanWriteProperty("MaTDTinHoc", true);
                if (_maTDTinHoc != value)
                {
                    _maTDTinHoc = value;
                    PropertyHasChanged("MaTDTinHoc");
                }
            }
        }
        public String MaChuyenNganh
        {
            get
            {
                CanReadProperty("MaChuyenNganh", true);
                return _maChuyenNganh ;
            }
            set
            {
                CanWriteProperty("MaChuyenNganh", true);
                if (_maChuyenNganh != value)
                {
                    _maChuyenNganh = value;
                    PropertyHasChanged("MaChuyenNganh");
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
        public String TenDanToc
        {
            get
            {
                CanReadProperty("TenDanToc", true);
                return _tenDanToc;
            }
            set
            {
                CanWriteProperty("TenDanToc", true);
                if (_tenDanToc != value)
                {
                    _tenDanToc = value;
                    PropertyHasChanged("TenDanToc");
                }
            }
        }
        public String TenTonGiao
        {
            get
            {
                CanReadProperty("TenTonGiao", true);
                return _tenTonGiao;
            }
            set
            {
                CanWriteProperty("TenTonGiao", true);
                if (_tenTonGiao != value)
                {
                    _tenTonGiao = value;
                    PropertyHasChanged("TenTonGiao");
                }
            }
        }
        public String TenTPhanGD
        {
            get
            {
                CanReadProperty("TenTPhanGD", true);
                return _tenTPhanGD;
            }
            set
            {
                CanWriteProperty("TenTPhanGD", true);
                if (_tenTPhanGD != value)
                {
                    _tenTPhanGD = value;
                    PropertyHasChanged("TenTPhanGD");
                }
            }
        }
        public String TenTPhanBT
        {
            get
            {
                CanReadProperty("TenTPhanBT", true);
                return _tenTPhanBT;
            }
            set
            {
                CanWriteProperty("TenTPhanBT", true);
                if (_tenTPhanBT != value)
                {
                    _tenTPhanBT = value;
                    PropertyHasChanged("TenTPhanBT");
                }
            }
        }
        public String TenHocVan
        {
            get
            {
                CanReadProperty("TenHocVan", true);
                return _tenHocVan;
            }
            set
            {
                CanWriteProperty("TenHocVan", true);
                if (_tenHocVan != value)
                {
                    _tenHocVan = value;
                    PropertyHasChanged("TenHocVan");
                }
            }
        }
        public String TenHocHam
        {
            get
            {
                CanReadProperty("TenHocHam", true);
                return _tenHocHam;
            }
            set
            {
                CanWriteProperty("TenHocHam", true);
                if (_tenHocHam != value)
                {
                    _tenHocHam = value;
                    PropertyHasChanged("TenHocHam");
                }
            }
        }
        public String TenTDChinhTri
        {
            get
            {
                CanReadProperty("TenTDChinhTri", true);
                return _tenTDChinhTri;
            }
            set
            {
                CanWriteProperty("TenTDChinhTri", true);
                if (_tenTDChinhTri != value)
                {
                    _tenTDChinhTri = value;
                    PropertyHasChanged("TenTDChinhTri");
                }
            }
        }
        public String TenTDTinHoc
        {
            get
            {
                CanReadProperty("TenTDTinHoc", true);
                return _tenTDTinHoc;
            }
            set
            {
                CanWriteProperty("TenTDTinHoc", true);
                if (_tenTDTinHoc != value)
                {
                    _tenTDTinHoc = value;
                    PropertyHasChanged("TenTDTinHoc");
                }
            }
        }
        public String TenChuyenNganh
        {
            get
            {
                CanReadProperty("TenChuyenNganh", true);
                return _tenChuyenNganh;
            }
            set
            {
                CanWriteProperty("TenChuyenNganh", true);
                if (_tenChuyenNganh != value)
                {
                    _tenChuyenNganh = value;
                    PropertyHasChanged("TenChuyenNganh");
                }
            }
        }
        public String TenCD
        {
            get
            {
                CanReadProperty("TenCD", true);
                return _tenCD;
            }
            set
            {
                CanWriteProperty("TenCD", true);
                if (_tenCD != value)
                {
                    _tenCD = value;
                    PropertyHasChanged("TenCD");
                }
            }
        }
        public String TenSucKhoe
        {
            get
            {
                CanReadProperty("TenSucKhoe", true);
                return _tenSucKhoe;
            }
            set
            {
                CanWriteProperty("TenSucKhoe", true);
                if (_tenSucKhoe != value)
                {
                    _tenSucKhoe = value;
                    PropertyHasChanged("TenSucKhoe");
                }
            }
        }
        public String TenDienCSach
        {
            get
            {
                CanReadProperty("TenDienCSach", true);
                return _tenDienCSach;
            }
            set
            {
                CanWriteProperty("TeDienCSach", true);
                if (_tenDienCSach != value)
                {
                    _tenDienCSach = value;
                    PropertyHasChanged("TenDienCSach");
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
			return _maNV;
		}
		
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
	
		#endregion
		
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="NhanVien" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static NhanVien NewNhanVien()
        {
            return DataPortal.Create<NhanVien>();
        }
		public static NhanVien GetNhanVien(String maNV)
		{
			return DataPortal.Fetch<NhanVien>(new Criteria(maNV));
		}
		
		/// <summary>
		/// Marks the <see cref="NhanVien" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteNhanVien(String maNV, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maNV));
		}
		
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal NhanVien()
		{	
			// Prevent direct creation
		}

        internal NhanVien( 
                                int OrderNumber,
                                String maNV ,
		                     String hoten ,
		                     String hotenks ,
		                     Boolean gioitinh ,
		                     SmartDate ngaysinh ,
		                     String dienThoai ,
		                     String maKhoa ,
		                     String noisinh ,
		                     String quequan ,
		                     String matongiao ,
		                     String madantoc ,
		                     String chooHT ,
		                     String thuongtru ,
		                     String soCMND ,
		                     String noicap ,
		                     SmartDate ngaycap ,
		                     String maTPhanGD ,
		                     String maTPhanBT ,
		                     String maDienCSach ,
		                     String soBHXH ,
		                     Boolean dongBHXH ,
		                     SmartDate tuNgayCM ,
		                     SmartDate denNgayCM ,
		                     SmartDate tuNgayCMy ,
		                     SmartDate denNgayCMy ,
		                     SmartDate tuNgayBCK ,
		                     SmartDate denNgayBCK ,
		                     SmartDate ngaynhapngu ,
		                     SmartDate ngayxuatngu ,
		                     SmartDate ngayVaoBChe ,
		                     SmartDate tuNgayPV ,
		                     SmartDate denNgayPV ,
		                     SmartDate tNXPhong ,
		                     SmartDate dNXPhong ,
		                     SmartDate tNDocHai ,
		                     SmartDate dNDocHai ,
		                     SmartDate tNKhac ,
		                     SmartDate dNKhac ,
		                     String maChucDanh ,
		                     String maChucVu ,
		                     String maHocHam ,
		                     String maChuyenMon ,
		                     String maHocVan ,
		                     String maTDChinhTri ,
		                     String maTDNgoaiNgu ,
		                     SmartDate ngayDang ,
		                     String noiKNap ,
		                     String nguoiGT ,
		                     SmartDate ngayDoan ,
		                     SmartDate ngayvaoCQ ,
		                     String maSuckhoe ,
		                     String maTrangthai ,
		                     SmartDate ngaynghiviec ,
		                     String lydoNghi ,
		                     Byte[] anh ,
		                     Boolean tinhLuongHeso ,
		                     String maMay ,
		                     SmartDate ngayHuy ,
		                     String nguoiHuy ,
		                     SmartDate ngayLap ,
		                     String nguoiLap ,
		                     SmartDate ngaySD ,
		                     String nguoiSD ,
		                     Boolean huy ,
		                     SmartDate ngaySD1 ,
		                     String nguoiSD1 ,
                             String maLoaiHD,
		                     String maNVQL ,
                             String tenNguoiSD ,
                            String tenNguoilap,
                            String tenNguoihuy,
                             String tenKhoa ,
                             String maTDTinHoc,
                            String maChuyenNganh,
                             String tenChuyenmon ,
                             String tenCV,
                             String tenTG,
                             String tenDT,
                             String tenTPhanGD,
                             String tenTPhanBT,
                             String tenHocVan ,
                             String tenHocHam,
                             String tenTDChinhTri,
                             String tenTDTinHoc,
                             String tenChuyenNganh,
                             String tenCD,
                             String tenSucKhoe,
                             String tenDienCSach
         )
        {
                                 _OrderNumber = OrderNumber ;
                                 _maNV = maNV ;
		                      _hoten = hoten ;
		                      _hotenks = hotenks ;
		                      _gioitinh = gioitinh ;
		                      _ngaysinh = ngaysinh ;
		                      _dienThoai = dienThoai ;
		                      _maKhoa = maKhoa ;
		                      _noisinh = noisinh ;
		                      _quequan = quequan ;
		                      _matongiao = matongiao ;
		                      _madantoc = madantoc ;
		                      _chooHT = chooHT ;
		                      _thuongtru = thuongtru ;
		                      _soCMND = soCMND ;
		                      _noicap = noicap ;
		                      _ngaycap = ngaycap ;
		                      _maTPhanGD = maTPhanGD ;
		                      _maTPhanBT = maTPhanBT ;
		                      _maDienCSach = maDienCSach ;
		                      _soBHXH = soBHXH ;
		                      _dongBHXH = dongBHXH ;
		                      _tuNgayCM = tuNgayCM ;
		                      _denNgayCM = denNgayCM ;
		                      _tuNgayCMy = tuNgayCMy  ;
		                      _denNgayCMy = denNgayCMy ;
		                      _tuNgayBCK = tuNgayBCK ;
		                      _denNgayBCK = denNgayBCK ;
		                      _ngaynhapngu = ngaynhapngu ;
		                      _ngayxuatngu = ngayxuatngu ;
		                      _ngayVaoBChe = ngayVaoBChe ;
		                      _tuNgayPV = tuNgayPV ;
		                      _denNgayPV = denNgayPV ;
		                      _tNXPhong = tNXPhong ;
		                      _dNXPhong = dNXPhong ;
		                      _tNDocHai = tNDocHai ;
		                      _dNDocHai = dNDocHai ;
		                      _tNKhac = tNKhac ;
		                      _dNKhac = dNKhac ;
		                      _maChucDanh = maChucDanh ;
		                      _maChucVu = maChucVu ;
		                      _maHocHam = maHocHam ;
		                      _maChuyenMon = maChuyenMon ;
		                      _maHocVan = maHocVan ;
		                      _maTDChinhTri = maTDChinhTri ;
		                      _maTDNgoaiNgu = maTDNgoaiNgu ;
		                      _ngayDang = ngayDang ;
		                      _noiKNap = noiKNap ;
		                      _nguoiGT = nguoiGT ;
		                      _ngayDoan = ngayDoan ;
		                      _ngayvaoCQ = ngayvaoCQ ;
		                      _maSuckhoe = maSuckhoe ;
		                      _maTrangthai = maTrangthai ;
		                      _ngaynghiviec = ngaynghiviec ;
		                      _lydoNghi = lydoNghi ;
		                      _anh = anh ;
		                      _tinhLuongHeso = tinhLuongHeso ;
		                      _maMay = maMay ;
		                      _ngayHuy = ngayHuy ;
		                      _nguoiHuy = nguoiHuy ;
		                      _ngayLap = ngayLap ;
		                      _nguoiLap = nguoiLap ;
		                      _ngaySD = ngaySD ;
		                      _nguoiSD = nguoiSD ;
		                      _huy = huy ;
		                      _ngaySD1 = ngaySD1 ;
		                      _nguoiSD1 = nguoiSD1 ;
		                      _maLoaiHD = maLoaiHD ;
		                      _maNVQL = maNVQL ;
                              _tenNguoiSD = tenNguoiSD ;
                              _tenNguoiLap = tenNguoilap;
                              _tenNguoiHuy = tenNguoihuy;
                              _tenKhoa = tenKhoa ;
                              _maTDTinHoc = maTDTinHoc;
                              _maChuyenNganh = maChuyenNganh;
                              _tenChuyenmon = tenChuyenmon ;
                              _tenCV = tenCV ;
            _tenTonGiao = tenTG;
            _tenTonGiao = tenDT;
            _tenTPhanBT = tenTPhanBT;
            _tenTPhanGD = tenTPhanGD;
            _tenHocVan = tenHocVan;
            _tenHocHam = tenHocHam;
            _tenTDChinhTri = tenTDChinhTri;
            _tenTDTinHoc = tenTDTinHoc;
            _tenChuyenNganh = tenChuyenNganh;
            _tenCD = tenCD;
            _tenSucKhoe = tenSucKhoe;
            _tenDienCSach = tenDienCSach;
        }
		
		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maNV;
			public String MaNV 
			{
				get
				{
					return _maNV;
				}
			}
			
			public Criteria(String maNV)
			{
				_maNV = maNV;
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maNV.Equals(c._maNV)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maNV.ToString()).GetHashCode();
			}
		}

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNV;
            public String MaNV
            {
                get
                {
                    return _maNV;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maNV)
            {
                _maNV = maNV;
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
		/// Retrieve an existing <see cref="NhanVien" /> Object based on data in the database.
		/// </summary>
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetNhanVien(String _maNV);
			// public override IDataReader GetNhanVien(String _maNV)
			// {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_Get", _maNV));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetNhanVien(crit.MaNV)))
			{
				if (dr.Read()){
					Fetch(dr);
					MarkOld();
					ValidationRules.CheckRules();
				}
			}
		}
		/// <summary>
		/// Load a <see cref="NhanVien" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
			if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
			if (dr.GetString("Hotenks") != null) _hotenks = dr.GetString("Hotenks");
			if (dr.GetBoolean("Gioitinh") != null) _gioitinh = dr.GetBoolean("Gioitinh");
			if (dr.GetSmartDate("Ngaysinh", true) != null) _ngaysinh = dr.GetSmartDate("Ngaysinh", true);
			if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
			if (dr.GetString("MaKhoa") != null) _maKhoa = dr.GetString("MaKhoa");
			if (dr.GetString("Noisinh") != null) _noisinh = dr.GetString("Noisinh");
			if (dr.GetString("Quequan") != null) _quequan = dr.GetString("Quequan");
			if (dr.GetString("Matongiao") != null) _matongiao = dr.GetString("Matongiao");
			if (dr.GetString("Madantoc") != null) _madantoc = dr.GetString("Madantoc");
			if (dr.GetString("ChooHT") != null) _chooHT = dr.GetString("ChooHT");
			if (dr.GetString("Thuongtru") != null) _thuongtru = dr.GetString("Thuongtru");
			if (dr.GetString("SoCMND") != null) _soCMND = dr.GetString("SoCMND");
			if (dr.GetString("Noicap") != null) _noicap = dr.GetString("Noicap");
			if (dr.GetSmartDate("Ngaycap", true) != null) _ngaycap = dr.GetSmartDate("Ngaycap", true);
			if (dr.GetString("MaTPhanGD") != null) _maTPhanGD = dr.GetString("MaTPhanGD");
			if (dr.GetString("MaTPhanBT") != null) _maTPhanBT = dr.GetString("MaTPhanBT");
			if (dr.GetString("MaDienCSach") != null) _maDienCSach = dr.GetString("MaDienCSach");
			if (dr.GetString("SoBHXH") != null) _soBHXH = dr.GetString("SoBHXH");
			if (dr.GetBoolean("DongBHXH") != null) _dongBHXH = dr.GetBoolean("DongBHXH");
			if (dr.GetSmartDate("TuNgayCM", true) != null) _tuNgayCM = dr.GetSmartDate("TuNgayCM", true);
			if (dr.GetSmartDate("DenNgayCM", true) != null) _denNgayCM = dr.GetSmartDate("DenNgayCM", true);
			if (dr.GetSmartDate("TuNgayCMy", true) != null) _tuNgayCMy = dr.GetSmartDate("TuNgayCMy", true);
			if (dr.GetSmartDate("DenNgayCMy", true) != null) _denNgayCMy = dr.GetSmartDate("DenNgayCMy", true);
			if (dr.GetSmartDate("TuNgayBCK", true) != null) _tuNgayBCK = dr.GetSmartDate("TuNgayBCK", true);
			if (dr.GetSmartDate("DenNgayBCK", true) != null) _denNgayBCK = dr.GetSmartDate("DenNgayBCK", true);
			if (dr.GetSmartDate("Ngaynhapngu", true) != null) _ngaynhapngu = dr.GetSmartDate("Ngaynhapngu", true);
			if (dr.GetSmartDate("Ngayxuatngu", true) != null) _ngayxuatngu = dr.GetSmartDate("Ngayxuatngu", true);
			if (dr.GetSmartDate("NgayVaoBChe", true) != null) _ngayVaoBChe = dr.GetSmartDate("NgayVaoBChe", true);
			if (dr.GetSmartDate("TuNgayPV", true) != null) _tuNgayPV = dr.GetSmartDate("TuNgayPV", true);
			if (dr.GetSmartDate("DenNgayPV", true) != null) _denNgayPV = dr.GetSmartDate("DenNgayPV", true);
			if (dr.GetSmartDate("TNXPhong", true) != null) _tNXPhong = dr.GetSmartDate("TNXPhong", true);
			if (dr.GetSmartDate("DNXPhong", true) != null) _dNXPhong = dr.GetSmartDate("DNXPhong", true);
			if (dr.GetSmartDate("TNDocHai", true) != null) _tNDocHai = dr.GetSmartDate("TNDocHai", true);
			if (dr.GetSmartDate("DNDocHai", true) != null) _dNDocHai = dr.GetSmartDate("DNDocHai", true);
			if (dr.GetSmartDate("TNKhac", true) != null) _tNKhac = dr.GetSmartDate("TNKhac", true);
			if (dr.GetSmartDate("DNKhac", true) != null) _dNKhac = dr.GetSmartDate("DNKhac", true);
			if (dr.GetString("MaChucDanh") != null) _maChucDanh = dr.GetString("MaChucDanh");
			if (dr.GetString("MaChucVu") != null) _maChucVu = dr.GetString("MaChucVu");
			if (dr.GetString("MaHocHam") != null) _maHocHam = dr.GetString("MaHocHam");
			if (dr.GetString("MaChuyenMon") != null) _maChuyenMon = dr.GetString("MaChuyenMon");
			if (dr.GetString("MaHocVan") != null) _maHocVan = dr.GetString("MaHocVan");
			if (dr.GetString("MaTDChinhTri") != null) _maTDChinhTri = dr.GetString("MaTDChinhTri");
			if (dr.GetString("MaTDNgoaiNgu") != null) _maTDNgoaiNgu = dr.GetString("MaTDNgoaiNgu");
			if (dr.GetSmartDate("NgayDang", true) != null) _ngayDang = dr.GetSmartDate("NgayDang", true);
			if (dr.GetString("NoiKNap") != null) _noiKNap = dr.GetString("NoiKNap");
			if (dr.GetString("NguoiGT") != null) _nguoiGT = dr.GetString("NguoiGT");
			if (dr.GetSmartDate("NgayDoan", true) != null) _ngayDoan = dr.GetSmartDate("NgayDoan", true);
			if (dr.GetSmartDate("NgayvaoCQ", true) != null) _ngayvaoCQ = dr.GetSmartDate("NgayvaoCQ", true);
			if (dr.GetString("MaSuckhoe") != null) _maSuckhoe = dr.GetString("MaSuckhoe");
			if (dr.GetString("MaTrangthai") != null) _maTrangthai = dr.GetString("MaTrangthai");
			if (dr.GetSmartDate("Ngaynghiviec", true) != null) _ngaynghiviec = dr.GetSmartDate("Ngaynghiviec", true);
			if (dr.GetString("LydoNghi") != null) _lydoNghi = dr.GetString("LydoNghi");
			if ((Byte[])dr.GetValue("Anh") != null) _anh = (Byte[])dr.GetValue("Anh");
			if (dr.GetBoolean("TinhLuongHeso") != null) _tinhLuongHeso = dr.GetBoolean("TinhLuongHeso");
			if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
			if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
			if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
			if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
			if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
			if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
			if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
			if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
			if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
			if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("MaLoaiHD") != null) _maLoaiHD = dr.GetString("MaLoaiHD");
			if (dr.GetString("MaNVQL") != null) _maNVQL = dr.GetString("MaNVQL");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");

            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");

            if (dr.GetString("TenKhoa") != null) _tenKhoa = dr.GetString("TenKhoa");
            if (dr.GetString("MaTDTinHoc") != null) _maTDTinHoc  = dr.GetString("MaTDTinHoc");
            if (dr.GetString("MaChuyenNganh") != null) _maChuyenNganh  = dr.GetString("MaChuyenNganh");
            if (dr.GetString("TenChuyenMon") != null) _tenChuyenmon = dr.GetString("TenChuyenMon");
            if (dr.GetString("TenCV") != null) _tenCV = dr.GetString("TenCV");
            if (dr.GetString("TenTonGiao") != null) _tenTonGiao = dr.GetString("TenTonGiao");
            if (dr.GetString("TenDanToc") != null) _tenDanToc = dr.GetString("TenDanToc");
            if (dr.GetString("TenTPhanGD") != null) _tenTPhanGD = dr.GetString("TenTPhanGD");
            if (dr.GetString("TenTPhanBT") != null) _tenTPhanBT = dr.GetString("TenTPhanBT");
            if (dr.GetString("TenHocVan") != null) _tenHocVan = dr.GetString("TenHocVan");
            if (dr.GetString("TenHocHam") != null) _tenHocHam = dr.GetString("TenHocHam");
            if (dr.GetString("TenTDChinhTri") != null) _tenTDChinhTri = dr.GetString("TenTDChinhTri");
            if (dr.GetString("TenTDTinHoc") != null) _tenTDTinHoc = dr.GetString("TenTDTinHoc");
            if (dr.GetString("TenChuyenNganh") != null) _tenChuyenNganh = dr.GetString("TenChuyenNganh");
            if (dr.GetString("TenCD") != null) _tenCD = dr.GetString("TenCD");
            if (dr.GetString("TenSucKhoe") != null) _tenSucKhoe = dr.GetString("TenSucKhoe");
            if (dr.GetString("TenDienCSach") != null) _tenDienCSach = dr.GetString("TenDienCSach");

        }
		
		/// <summary>
		/// Insert the new <see cref="NhanVien" /> Object to underlying database.
		/// </summary>
        /// 


        protected override void DataPortal_Create()
        {
            

            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertNhanVien
			// Copy & paste ham duoi day vao file DataProvider.cs
            
            
            _maNV = DataProvider.Instance().InsertNhanVien(_hoten, _hotenks, _gioitinh, _ngaysinh, _dienThoai, _maKhoa, _noisinh, _quequan, _matongiao, _madantoc, _chooHT, _thuongtru, _soCMND, _noicap, _ngaycap, _maTPhanGD, _maTPhanBT, _maDienCSach, _soBHXH, _dongBHXH, _tuNgayCM, _denNgayCM, _tuNgayCMy, _denNgayCMy, _tuNgayBCK, _denNgayBCK, _ngaynhapngu, _ngayxuatngu, _ngayVaoBChe, _tuNgayPV, _denNgayPV, _tNXPhong, _dNXPhong, _tNDocHai, _dNDocHai, _tNKhac, _dNKhac, _maChucDanh, _maChucVu, _maHocHam, _maChuyenMon, _maHocVan, _maTDChinhTri, _maTDNgoaiNgu, _ngayDang, _noiKNap, _nguoiGT, _ngayDoan, _ngayvaoCQ, _maSuckhoe, _maTrangthai, _ngaynghiviec, _lydoNghi, _anh, _tinhLuongHeso, _maMay, _nguoiSD , _maLoaiHD, _maNVQL, _maTDTinHoc, _maChuyenNganh );
			// public abstract String InsertNhanVien(String _hoten, String _hotenks, Boolean _gioitinh, SmartDate _ngaysinh, String _dienThoai, String _maKhoa, String _noisinh, String _quequan, String _matongiao, String _madantoc, String _chooHT, String _thuongtru, String _soCMND, String _noicap, SmartDate _ngaycap, String _maTPhanGD, String _maTPhanBT, String _maDienCSach, String _soBHXH, Boolean _dongBHXH, SmartDate _tuNgayCM, SmartDate _denNgayCM, SmartDate _tuNgayCMy, SmartDate _denNgayCMy, SmartDate _tuNgayBCK, SmartDate _denNgayBCK, SmartDate _ngaynhapngu, SmartDate _ngayxuatngu, SmartDate _ngayVaoBChe, SmartDate _tuNgayPV, SmartDate _denNgayPV, SmartDate _tNXPhong, SmartDate _dNXPhong, SmartDate _tNDocHai, SmartDate _dNDocHai, SmartDate _tNKhac, SmartDate _dNKhac, String _maChucDanh, String _maChucVu, String _maHocHam, String _maChuyenMon, String _maHocVan, String _maTDChinhTri, String _maTDNgoaiNgu, SmartDate _ngayDang, String _noiKNap, String _nguoiGT, SmartDate _ngayDoan, SmartDate _ngayvaoCQ, String _maSuckhoe, String _maTrangthai, SmartDate _ngaynghiviec, String _lydoNghi, ByteArray _anh, Boolean _tinhLuongHeso, String _maMay, String _nguoiLap, Boolean _maLoaiHD, String _maNVQL);
			// public override String InsertNhanVien(String _hoten, String _hotenks, Boolean _gioitinh, SmartDate _ngaysinh, String _dienThoai, String _maKhoa, String _noisinh, String _quequan, String _matongiao, String _madantoc, String _chooHT, String _thuongtru, String _soCMND, String _noicap, SmartDate _ngaycap, String _maTPhanGD, String _maTPhanBT, String _maDienCSach, String _soBHXH, Boolean _dongBHXH, SmartDate _tuNgayCM, SmartDate _denNgayCM, SmartDate _tuNgayCMy, SmartDate _denNgayCMy, SmartDate _tuNgayBCK, SmartDate _denNgayBCK, SmartDate _ngaynhapngu, SmartDate _ngayxuatngu, SmartDate _ngayVaoBChe, SmartDate _tuNgayPV, SmartDate _denNgayPV, SmartDate _tNXPhong, SmartDate _dNXPhong, SmartDate _tNDocHai, SmartDate _dNDocHai, SmartDate _tNKhac, SmartDate _dNKhac, String _maChucDanh, String _maChucVu, String _maHocHam, String _maChuyenMon, String _maHocVan, String _maTDChinhTri, String _maTDNgoaiNgu, SmartDate _ngayDang, String _noiKNap, String _nguoiGT, SmartDate _ngayDoan, SmartDate _ngayvaoCQ, String _maSuckhoe, String _maTrangthai, SmartDate _ngaynghiviec, String _lydoNghi, ByteArray _anh, Boolean _tinhLuongHeso, String _maMay, String _nguoiLap, Boolean _maLoaiHD, String _maNVQL)
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_Create", _hoten, _hotenks, _gioitinh, _ngaysinh.DBValue, _dienThoai, _maKhoa, _noisinh, _quequan, _matongiao, _madantoc, _chooHT, _thuongtru, _soCMND, _noicap, _ngaycap.DBValue, _maTPhanGD, _maTPhanBT, _maDienCSach, _soBHXH, _dongBHXH, _tuNgayCM.DBValue, _denNgayCM.DBValue, _tuNgayCMy.DBValue, _denNgayCMy.DBValue, _tuNgayBCK.DBValue, _denNgayBCK.DBValue, _ngaynhapngu.DBValue, _ngayxuatngu.DBValue, _ngayVaoBChe.DBValue, _tuNgayPV.DBValue, _denNgayPV.DBValue, _tNXPhong.DBValue, _dNXPhong.DBValue, _tNDocHai.DBValue, _dNDocHai.DBValue, _tNKhac.DBValue, _dNKhac.DBValue, _maChucDanh, _maChucVu, _maHocHam, _maChuyenMon, _maHocVan, _maTDChinhTri, _maTDNgoaiNgu, _ngayDang.DBValue, _noiKNap, _nguoiGT, _ngayDoan.DBValue, _ngayvaoCQ.DBValue, _maSuckhoe, _maTrangthai, _ngaynghiviec.DBValue, _lydoNghi, _anh, _tinhLuongHeso, _maMay, _nguoiSD , _maLoaiHD, _maNVQL));
			// }
		}
		
		/// <summary>
		/// Update all changes made on <see cref="NhanVien" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNhanVien
			if (IsDirty){
                
                  
                DataProvider.Instance().UpdateNhanVien(_maNV, _hoten, _hotenks, _gioitinh, _ngaysinh, _dienThoai, _maKhoa, _noisinh, _quequan, _matongiao, _madantoc, _chooHT, _thuongtru, _soCMND, _noicap, _ngaycap, _maTPhanGD, _maTPhanBT, _maDienCSach, _soBHXH, _dongBHXH, _tuNgayCM, _denNgayCM, _tuNgayCMy, _denNgayCMy, _tuNgayBCK, _denNgayBCK, _ngaynhapngu, _ngayxuatngu, _ngayVaoBChe, _tuNgayPV, _denNgayPV, _tNXPhong, _dNXPhong, _tNDocHai, _dNDocHai, _tNKhac, _dNKhac, _maChucDanh, _maChucVu, _maHocHam, _maChuyenMon, _maHocVan, _maTDChinhTri, _maTDNgoaiNgu, _ngayDang, _noiKNap, _nguoiGT, _ngayDoan, _ngayvaoCQ, _maSuckhoe, _maTrangthai, _ngaynghiviec, _lydoNghi, _anh, _tinhLuongHeso, _maMay, _nguoiSD , _huy, _maLoaiHD, _maNVQL, _maTDTinHoc,_maChuyenNganh );
				// public abstract void UpdateNhanVien(String _maNV, String _hoten, String _hotenks, Boolean _gioitinh, SmartDate _ngaysinh, String _dienThoai, String _maKhoa, String _noisinh, String _quequan, String _matongiao, String _madantoc, String _chooHT, String _thuongtru, String _soCMND, String _noicap, SmartDate _ngaycap, String _maTPhanGD, String _maTPhanBT, String _maDienCSach, String _soBHXH, Boolean _dongBHXH, SmartDate _tuNgayCM, SmartDate _denNgayCM, SmartDate _tuNgayCMy, SmartDate _denNgayCMy, SmartDate _tuNgayBCK, SmartDate _denNgayBCK, SmartDate _ngaynhapngu, SmartDate _ngayxuatngu, SmartDate _ngayVaoBChe, SmartDate _tuNgayPV, SmartDate _denNgayPV, SmartDate _tNXPhong, SmartDate _dNXPhong, SmartDate _tNDocHai, SmartDate _dNDocHai, SmartDate _tNKhac, SmartDate _dNKhac, String _maChucDanh, String _maChucVu, String _maHocHam, String _maChuyenMon, String _maHocVan, String _maTDChinhTri, String _maTDNgoaiNgu, SmartDate _ngayDang, String _noiKNap, String _nguoiGT, SmartDate _ngayDoan, SmartDate _ngayvaoCQ, String _maSuckhoe, String _maTrangthai, SmartDate _ngaynghiviec, String _lydoNghi, ByteArray _anh, Boolean _tinhLuongHeso, String _maMay, String _nguoiSD, Boolean _huy, Boolean _maLoaiHD, String _maNVQL);
				// public override void UpdateNhanVien(String _maNV, String _hoten, String _hotenks, Boolean _gioitinh, SmartDate _ngaysinh, String _dienThoai, String _maKhoa, String _noisinh, String _quequan, String _matongiao, String _madantoc, String _chooHT, String _thuongtru, String _soCMND, String _noicap, SmartDate _ngaycap, String _maTPhanGD, String _maTPhanBT, String _maDienCSach, String _soBHXH, Boolean _dongBHXH, SmartDate _tuNgayCM, SmartDate _denNgayCM, SmartDate _tuNgayCMy, SmartDate _denNgayCMy, SmartDate _tuNgayBCK, SmartDate _denNgayBCK, SmartDate _ngaynhapngu, SmartDate _ngayxuatngu, SmartDate _ngayVaoBChe, SmartDate _tuNgayPV, SmartDate _denNgayPV, SmartDate _tNXPhong, SmartDate _dNXPhong, SmartDate _tNDocHai, SmartDate _dNDocHai, SmartDate _tNKhac, SmartDate _dNKhac, String _maChucDanh, String _maChucVu, String _maHocHam, String _maChuyenMon, String _maHocVan, String _maTDChinhTri, String _maTDNgoaiNgu, SmartDate _ngayDang, String _noiKNap, String _nguoiGT, SmartDate _ngayDoan, SmartDate _ngayvaoCQ, String _maSuckhoe, String _maTrangthai, SmartDate _ngaynghiviec, String _lydoNghi, ByteArray _anh, Boolean _tinhLuongHeso, String _maMay, String _nguoiSD, Boolean _huy, Boolean _maLoaiHD, String _maNVQL)
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_UPDATE", _maNV, _hoten, _hotenks, _gioitinh, _ngaysinh.DBValue, _dienThoai, _maKhoa, _noisinh, _quequan, _matongiao, _madantoc, _chooHT, _thuongtru, _soCMND, _noicap, _ngaycap.DBValue, _maTPhanGD, _maTPhanBT, _maDienCSach, _soBHXH, _dongBHXH, _tuNgayCM.DBValue, _denNgayCM.DBValue, _tuNgayCMy.DBValue, _denNgayCMy.DBValue, _tuNgayBCK.DBValue, _denNgayBCK.DBValue, _ngaynhapngu.DBValue, _ngayxuatngu.DBValue, _ngayVaoBChe.DBValue, _tuNgayPV.DBValue, _denNgayPV.DBValue, _tNXPhong.DBValue, _dNXPhong.DBValue, _tNDocHai.DBValue, _dNDocHai.DBValue, _tNKhac.DBValue, _dNKhac.DBValue, _maChucDanh, _maChucVu, _maHocHam, _maChuyenMon, _maHocVan, _maTDChinhTri, _maTDNgoaiNgu, _ngayDang.DBValue, _noiKNap, _nguoiGT, _ngayDoan.DBValue, _ngayvaoCQ.DBValue, _maSuckhoe, _maTrangthai, _ngaynghiviec.DBValue, _lydoNghi, _anh, _tinhLuongHeso, _maMay, _nguoiSD , _huy, _maLoaiHD, _maNVQL);
				// }				
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNV));
		}

		/// <summary>
		/// Delete the <see cref="NhanVien" />.
		/// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateNhanVien
            DataProvider.Instance().DeleteNhanVien(crit.MaMay, crit.NguoiSD, crit.MaNV);
			// public abstract void DeleteNhanVien(String _maNV);
			// public override void DeleteNhanVien(String _maNV)
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spNHANVIEN_DELETED", _maNV);
			// }
		}

		#endregion
	}

}
