// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThongtinBN_Q
// Kieu doi tuong  :	ThongtinBN_Q
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/23/2009 9:30:39 AM
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
 //using System.Windows.Forms;


namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="ThongtinBN_Q" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ThongtinBN_Q : BusinessBase<ThongtinBN_Q>
	{
		#region Business Methods
		
		#region State Fields
        private SmartDate _giaTriTN = new SmartDate(true);
		private String _maBN = String.Empty;
		private String _hoten = String.Empty;
		private String _sothe = String.Empty;
		private String _maBV = String.Empty;
		private SmartDate _giaTriDN = new SmartDate(true);
        private String _maDT = String.Empty;
		private String _diaChi = String.Empty;
        private String _diaChiC = String.Empty;
		private String _dienThoai = String.Empty;
		private String _dTDD = String.Empty;
		private String _dTCQ = String.Empty;
		private String _mail = String.Empty;
		private Byte _tuoi = 1;
        private int _thang = 1;
		private SmartDate _ngaySinh = new SmartDate(true);
        private SmartDate _ngaySinhD = new SmartDate(true);
        private SmartDate _ngayyc = new SmartDate(true);
		private Boolean _gt = false;
        private Boolean _gtNu = false;
		private String _baoTin = String.Empty;
		private String _maQG = String.Empty;
		private String _maTinh = String.Empty;
		private String _maHuyen = String.Empty;
		private String _maNN = String.Empty;
		private String _tienSu = String.Empty;
		private String _tienSuThuoc = String.Empty;
		private String _tienSuGiaDinh = String.Empty;
		private String _nhomMau = String.Empty;
		private String _maBANoiT = String.Empty;
		private String _maKhoaVV = String.Empty;
		private SmartDate _ngayVV = new SmartDate(true);
		private String _maBANgoaiT = String.Empty;
		private SmartDate _ngayKham = new SmartDate(true);
		private String _ghichu = String.Empty;
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
		private SmartDate _ngayBANgoaiT = new SmartDate(true);
        private String _madantoc = String.Empty;
        private String _hotenbome = String.Empty;
		
        private int _OrderNumber;
        private String _mabhxh = String.Empty;
        private String _tenbv = String.Empty;
        private String _maBAQL = String.Empty;
        private String _TenDT = String.Empty;
        private String _MaQuanHeQD = String.Empty;
        private String _MaQuanHam = String.Empty;
        private String _MaDonVi = String.Empty;
        private String _SoCMT = String.Empty;
		#endregion
		
		#region Business Properties and Methods
        public String MaQuanHeQD
        {
            get
            {
                CanReadProperty("MaQuanHeQD", true);
                return _MaQuanHeQD;
            }
            set
            {
                CanWriteProperty("MaQuanHeQD", true);
                if (_MaQuanHeQD != value)
                {
                    _MaQuanHeQD = value;
                    PropertyHasChanged("MaQuanHeQD");
                }
            }
        }
        public String MaQuanHam
        {
            get
            {
                CanReadProperty("MaQuanHam", true);
                return _MaQuanHam;
            }
            set
            {
                CanWriteProperty("MaQuanHam", true);
                if (_MaQuanHam != value)
                {
                    _MaQuanHam = value;
                    PropertyHasChanged("MaQuanHam");
                }
            }
        }
        public String MaDonVi
        {
            get
            {
                CanReadProperty("MaDonVi", true);
                return _MaDonVi;
            }
            set
            {
                CanWriteProperty("MaDonVi", true);
                if (_MaDonVi != value)
                {
                    _MaDonVi = value;
                    PropertyHasChanged("MaDonVi");
                }
            }
        }
        public String SoCMT
        {
            get
            {
                CanReadProperty("SoCMT", true);
                return _SoCMT;
            }
            set
            {
                CanWriteProperty("SoCMT", true);
                if (_SoCMT != value)
                {
                    _SoCMT = value;
                    PropertyHasChanged("SoCMT");
                }
            }
        }
        public String MaBAQL
        {
            get
            {
                CanReadProperty("MaBAQL", true);
                return _maBAQL;
            }
            set
            {
                CanWriteProperty("MaBAQL", true);
                if (_maBAQL != value)
                {
                    _maBAQL = value;
                    PropertyHasChanged("MaBAQL");
                }
            }
        }
        public string GiaTriTN
        {
            get
            {
                CanReadProperty("GiaTriTN", true);
                return _giaTriTN.Text;
            }
            set
            {
                CanWriteProperty("GiaTriTN", true);
                if (_giaTriTN.Text != value)
                {
                    _giaTriTN.Text = value;
                    PropertyHasChanged("GiaTriTN");
                }
            }
        }
        public String mabhxh
        {
            get
            {
                CanReadProperty("mabhxh", true);
                return _mabhxh;
            }
            set
            {
                CanWriteProperty("mabhxh", true);
                if (_mabhxh != value)
                {
                    _mabhxh = value;
                    PropertyHasChanged("mabhxh");
                }
            }
        }
        public String hotenbome
        {
            get
            {
                CanReadProperty("hotenbome", true);
                return _hotenbome;
            }
            set
            {
                CanWriteProperty("hotenbome", true);
                if (_hotenbome != value)
                {
                    _hotenbome = value;
                    PropertyHasChanged("hotenbome");
                }
            }
        }
        public String madantoc
        {
            get
            {
                CanReadProperty("madantoc", true);
                return _madantoc;
            }
            set
            {
                CanWriteProperty("madantoc", true);
                if (_madantoc != value)
                {
                    _madantoc = value;
                    PropertyHasChanged("madantoc");
                }
            }
        }
        public String tenbv
        {
            get
            {
                CanReadProperty("tenbv", true);
                return _tenbv;
            }
            set
            {
                CanWriteProperty("tenbv", true);
                if (_tenbv != value)
                {
                    _tenbv = value;
                    PropertyHasChanged("tenbv");
                }
            }
        }
        public String Sothe
        {
            get
            {
                CanReadProperty("Sothe", true);
                return _sothe;
            }
            set
            {
                CanWriteProperty("Sothe", true);
                if (_sothe != value)
                {
                    _sothe = value;
                    PropertyHasChanged("Sothe");
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
		
		public String Hoten
		{
			get 
			{
				CanReadProperty("Hoten", true);
				return  _hoten.ToUpper();
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
		
        //public String Sothe
        //{
        //    get 
        //    {
        //        CanReadProperty("Sothe", true);
        //        return _sothe;
        //    }
        //    set 
        //    {
        //        CanWriteProperty("Sothe", true);
        //        if (_sothe != value) 
        //        {
        //            _sothe = value;
        //            PropertyHasChanged("Sothe");
        //        }
        //    }
        //}
		
		public String MaBV
		{
			get 
			{
				CanReadProperty("MaBV", true);
				return _maBV;
			}
			set 
			{
				CanWriteProperty("MaBV", true);
				if (_maBV != value) 
				{
					_maBV = value;
					PropertyHasChanged("MaBV");
				}
			}
		}
		
		public string GiaTriDN
		{
			get 
			{
				CanReadProperty("GiaTriDN", true);
				return _giaTriDN.Text;
			}
			set 
			{
				CanWriteProperty("GiaTriDN", true);
				if (_giaTriDN.Text != value) 
				{
					_giaTriDN.Text = value;
					PropertyHasChanged("GiaTriDN");
				}
			}
		}
		
		public String DiaChi
		{
			get 
			{
				CanReadProperty("DiaChi", true);
               
				return _diaChi;
			}
			set 
			{
				CanWriteProperty("DiaChi", true);
				if (_diaChi != value) 
				{
					_diaChi = value;
					PropertyHasChanged("DiaChi");
				}
			}
		}
        public String DiaChiC
        {
            get
            {
                CanReadProperty("DiaChiC", true);

                return _diaChiC;
            }
            set
            {
                CanWriteProperty("DiaChiC", true);
                if (_diaChiC != value)
                {
                    _diaChiC = value;
                    PropertyHasChanged("DiaChiC");
                }
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
		
		public String DTDD
		{
			get 
			{
				CanReadProperty("DTDD", true);
				return _dTDD;
			}
			set 
			{
				CanWriteProperty("DTDD", true);
				if (_dTDD != value) 
				{
					_dTDD = value;
					PropertyHasChanged("DTDD");
				}
			}
		}
		
		public String DTCQ
		{
			get 
			{
				CanReadProperty("DTCQ", true);
				return _dTCQ;
			}
			set 
			{
				CanWriteProperty("DTCQ", true);
				if (_dTCQ != value) 
				{
					_dTCQ = value;
					PropertyHasChanged("DTCQ");
				}
			}
		}
		
		public String Mail
		{
			get 
			{
				CanReadProperty("Mail", true);
				return _mail;
			}
			set 
			{
				CanWriteProperty("Mail", true);
				if (_mail != value) 
				{
					_mail = value;
					PropertyHasChanged("Mail");
				}
			}
		}
		
		public byte Tuoi
		{
			get
            {
                   
				//CanReadProperty("Tuoi", true);
              if (_ngaySinh.Date   != DateTime.MinValue   ) 
              if (_ngaySinh.Date.Year != 0)
                  _tuoi = Convert.ToByte ( Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year );
                return _tuoi;
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
        public int thang
        {
            get
            {

                //CanReadProperty("thang", true);
                if (Convert.ToInt32(DateTime.Now.Month - _ngaySinh.Date.Month) < 0)
                    _thang = Convert.ToInt32 (DateTime.Now.Month - _ngaySinh.Date.Month  +13);
                else
                    _thang = Convert.ToInt32(DateTime.Now.Month - _ngaySinh.Date.Month + 1);
                return _thang; 
            }
            set
            {
                CanWriteProperty("thang", true);
                if (_thang != value)
                {
                    _thang = value;
                    PropertyHasChanged("thang");
                }
            }
        }
		public string NgaySinh
		{
			get 
			{
				CanReadProperty("NgaySinh", true);
             //   _ngaySinh.FormatString = "MM/dd/yyyy"; 
				return _ngaySinh.Text;
			}
			set 
			{
				CanWriteProperty("NgaySinh", true);
				if (_ngaySinh.Text != value) 
				{
					_ngaySinh.Text = value;
                    if (_ngaySinh.Date.Year != 1)
                        _tuoi  = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
					PropertyHasChanged("NgaySinh");
				}
			}
		}
        public string NgaySinhD
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                _ngaySinhD = _ngaySinh;
                _ngaySinhD.FormatString = "dd/MM/yyyy";
                return _ngaySinh.Text;
            }
            
        }
		public Boolean GT
		{
			get 
			{
				CanReadProperty("GT", true);
				return _gt;
			}
			set 
			{
				CanWriteProperty("GT", true);
				if (_gt != value) 
				{
					_gt = value;
					PropertyHasChanged("GT");
				}
			}
		}
        public Boolean GTNu
        {
            get
            {
                CanReadProperty("GTNu", true);
                if (_gt == true)
                    return false;
                else
                    return true;
            }
            set
            {
                CanWriteProperty("GTNu", true);
                if (_gtNu  != value)
                {
                    if (value == true)
                        _gt = false;
                    else
                        _gt = true;
                    _gtNu  = value;

                    PropertyHasChanged("GTnu");
                }
                
            }
        }
		public String BaoTin
		{
			get 
			{
				CanReadProperty("BaoTin", true);
				return _baoTin;
			}
			set 
			{
				CanWriteProperty("BaoTin", true);
				if (_baoTin != value) 
				{
					_baoTin = value;
					PropertyHasChanged("BaoTin");
				}
			}
		}
		
		public String MaQG
		{
			get 
			{
				CanReadProperty("MaQG", true);
				return _maQG;
			}
			set 
			{
				CanWriteProperty("MaQG", true);
				if (_maQG != value) 
				{
					_maQG = value;
					PropertyHasChanged("MaQG");
				}
			}
		}
		
		public String MaTinh
		{
			get 
			{
				CanReadProperty("MaTinh", true);
				return _maTinh;
			}
			set 
			{
				CanWriteProperty("MaTinh", true);
				if (_maTinh != value) 
				{
					_maTinh = value;
					PropertyHasChanged("MaTinh");
				}
			}
		}
		
		public String MaHuyen
		{
			get 
			{
				CanReadProperty("MaHuyen", true);
				return _maHuyen;
			}
			set 
			{
				CanWriteProperty("MaHuyen", true);
				if (_maHuyen != value) 
				{
					_maHuyen = value;
					PropertyHasChanged("MaHuyen");
				}
			}
		}
		
		public String MaNN
		{
			get 
			{
				CanReadProperty("MaNN", true);
				return _maNN;
			}
			set 
			{
				CanWriteProperty("MaNN", true);
				if (_maNN != value) 
				{
					_maNN = value;
					PropertyHasChanged("MaNN");
				}
			}
		}
		
		public String TienSu
		{
			get 
			{
				CanReadProperty("TienSu", true);
				return _tienSu;
			}
			set 
			{
				CanWriteProperty("TienSu", true);
				if (_tienSu != value) 
				{
					_tienSu = value;
					PropertyHasChanged("TienSu");
				}
			}
		}
		
		public String TienSuThuoc
		{
			get 
			{
				CanReadProperty("TienSuThuoc", true);
				return _tienSuThuoc;
			}
			set 
			{
				CanWriteProperty("TienSuThuoc", true);
				if (_tienSuThuoc != value) 
				{
					_tienSuThuoc = value;
					PropertyHasChanged("TienSuThuoc");
				}
			}
		}
		
		public String TienSuGiaDinh
		{
			get 
			{
				CanReadProperty("TienSuGiaDinh", true);
				return _tienSuGiaDinh;
			}
			set 
			{
				CanWriteProperty("TienSuGiaDinh", true);
				if (_tienSuGiaDinh != value) 
				{
					_tienSuGiaDinh = value;
					PropertyHasChanged("TienSuGiaDinh");
				}
			}
		}
		
		public String NhomMau
		{
			get 
			{
				CanReadProperty("NhomMau", true);
				return _nhomMau;
			}
			set 
			{
				CanWriteProperty("NhomMau", true);
				if (_nhomMau != value) 
				{
					_nhomMau = value;
					PropertyHasChanged("NhomMau");
				}
			}
		}
		
		public String MaBANoiT
		{
			get 
			{
				CanReadProperty("MaBANoiT", true);
				return _maBANoiT;
			}
			set 
			{
				CanWriteProperty("MaBANoiT", true);
				if (_maBANoiT != value) 
				{
					_maBANoiT = value;
					PropertyHasChanged("MaBANoiT");
				}
			}
		}
		
		public String MaKhoaVV
		{
			get 
			{
				CanReadProperty("MaKhoaVV", true);
				return _maKhoaVV;
			}
			set 
			{
				CanWriteProperty("MaKhoaVV", true);
				if (_maKhoaVV != value) 
				{
					_maKhoaVV = value;
					PropertyHasChanged("MaKhoaVV");
				}
			}
		}
		
		public string NgayVV
		{
			get 
			{
				CanReadProperty("NgayVV", true);
				return _ngayVV.Text;
			}
			set 
			{
				CanWriteProperty("NgayVV", true);
				if (_ngayVV.Text != value) 
				{
					_ngayVV.Text = value;
					PropertyHasChanged("NgayVV");
				}
			}
		}
		
		public String MaBANgoaiT
		{
			get 
			{
				CanReadProperty("MaBANgoaiT", true);
				return _maBANgoaiT;
			}
			set 
			{
				CanWriteProperty("MaBANgoaiT", true);
				if (_maBANgoaiT != value) 
				{
					_maBANgoaiT = value;
					PropertyHasChanged("MaBANgoaiT");
				}
			}
		}
		
		public string NgayKham
		{
			get 
			{
				CanReadProperty("NgayKham", true);
                _ngayKham.FormatString = "dd/MM/yyyy";
				return _ngayKham.Text;
			}
			set 
			{
				CanWriteProperty("NgayKham", true);
				if (_ngayKham.Text != value) 
				{
                    _ngayKham.FormatString = "dd/MM/yyyy";
					_ngayKham.Text = value;
					PropertyHasChanged("NgayKham");
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
		
		public string NgayBANgoaiT
		{
			get 
			{
				CanReadProperty("NgayBANgoaiT", true);
				return _ngayBANgoaiT.Text;
			}
			set 
			{
				CanWriteProperty("NgayBANgoaiT", true);
				if (_ngayBANgoaiT.Text != value) 
				{
					_ngayBANgoaiT.Text = value;
					PropertyHasChanged("NgayBANgoaiT");
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
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }
        KhamBenh_Q _KhamBenh = KhamBenh_Q.NewKhamBenh();

        public KhamBenh_Q KhamBenh_Q
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _KhamBenh;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_KhamBenh.Equals(value))
                {
                    _KhamBenh = value;
                    PropertyHasChanged();
                }
            }
        }
		protected override Object GetIdValue()
		{
			return _maBN;
		}
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty|| _KhamBenh.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _KhamBenh.IsValid;
            }
        }
		#endregion
		#endregion

				
		#region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //TODO: add validation rules

            ValidationRules.AddRule<ThongtinBN_Q>(ValidationNgaySinh<ThongtinBN_Q>, "NgaySinh");
           
        }
        private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : ThongtinBN_Q
        {
            if (target._ngaySinh.Date > System.DateTime.Now.AddDays(1))
            {
                e.Description = "VALIDATION_NOW";
                return false;
            }
            else
                return true;
        }

		#endregion

       
		#region Factory Methods
		
		
		/// <summary>
		/// Factory method. New <see cref="ThongtinBN_Q" /> Object is loaded from the database, based on given parameters.
		/// </summary> 
        /// 
        public static ThongtinBN_Q NewThongtinBN()
        {
            //return new DMNhomThuoc();

            return DataPortal.Create<ThongtinBN_Q>();
        }
		public static ThongtinBN_Q GetThongtinBN(String maBN,DateTime ngaydk,Byte loai)
		{
			return DataPortal.Fetch<ThongtinBN_Q>(new Criteria(maBN,ngaydk,loai  ));
		}
        public static ThongtinBN_Q GetThongtinBN(String maBN, Byte loai, string mamay, string nguoihuy)
        {
            return DataPortal.Fetch<ThongtinBN_Q>(new OtherCriteria(mamay,nguoihuy ,maBN, loai));
        }
        public static ThongtinBN_Q GetThongtinBN(String maBN, DateTime ngaydk, Byte loai,string masokham, int stt,byte loaikqcn,byte loaikq,string makhoa)
        {
            return DataPortal.Fetch<ThongtinBN_Q>(new CriteriaKB(maBN, ngaydk, loai, masokham, stt, loaikqcn, loaikq, makhoa));
        }
        public static ThongtinBN_Q GetThongtinBN(String maBN, DateTime ngaydk, Byte loai, string masokham, int stt, byte loaikqcn)
        {
            return DataPortal.Fetch<ThongtinBN_Q>(new CriteriaKB(maBN, ngaydk, loai, masokham, stt, loaikqcn, 0,""));
        }
		/// <summary>
		/// Marks the <see cref="ThongtinBN_Q" /> Object for deletion. The Object will be deleted as part of the next save operation.
		/// </summary>
        public static void DeleteThongtinBN(String maBN, string mamay, string nguoihuy)
		{
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maBN, 0));
		}
        
		#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal ThongtinBN_Q()
		{
             // MarkAsChild();
            
             _maDT = "00001";
             _madantoc = "00025";
             _maQG = "00084";
             _gt = false ;
            //MarkOld();
                         
		}

        internal ThongtinBN_Q(             int OrderNumber,
  String maBN,
  String hoten,
  String sothe,
  String maBV,
  SmartDate giaTriDN,
  String diaChi,
            String diaChiC,
  String dienThoai,
  String dTDD,
  String dTCQ,
  String mail,
  Byte tuoi,
  SmartDate ngaySinh,
  Boolean gt,
  String baoTin,
  String maQG,
  String maTinh,
  String maHuyen,
  String maNN,
  String tienSu,
  String tienSuThuoc,
  String tienSuGiaDinh,
  String nhomMau,
  String maBANoiT,
  String maKhoaVV,
  SmartDate ngayVV,
  String maBANgoaiT,
  SmartDate ngayKham,
  String ghichu,
  String maMay,
  SmartDate ngayLap,
  String nguoiLap,
  SmartDate ngayHuy,
  String nguoiHuy,
  SmartDate ngaySD,
  String nguoiSD,
  SmartDate ngaySD1,
  String nguoiSD1,
  Boolean huy,
  SmartDate ngayBANgoaiT,
  string mabhxh,
      
  string tenbv,
  string madt,
                             SmartDate giatriTN, string mabaql, string tendt,
  SmartDate ngaydk, string madonvi
 , string maquanham
 , string maquanheqd
 , string socmt)
        {
            _TenDT = tendt;
            _OrderNumber = OrderNumber;
            _maBN = maBN;
            _MaDonVi = madonvi;
            _MaQuanHam = maquanham;
            _MaQuanHeQD = maquanheqd;
            _SoCMT = socmt;
            _maBAQL = mabaql;
                
  
		                                  _hoten = hoten  ;
		                                  _sothe = sothe  ;
		                                  _maBV = maBV  ;
		                                  _giaTriDN = giaTriDN   ;
		                                  _diaChi = diaChi  ;
   _diaChiC = diaChiC;
		                                  _dienThoai = dienThoai  ;
		                                  _dTDD = dTDD  ;
		                                  _dTCQ = dTCQ  ;
		                                  _mail = mail  ;
		                                  _tuoi = tuoi  ;
		                                  _ngaySinh = ngaySinh  ;
		                                  _gt = gt  ;
		                                  _baoTin = baoTin  ;
		                                  _maQG = maQG  ;
		                                  _maTinh = maTinh  ;
		                                  _maHuyen = maHuyen  ;
		                                  _maNN = maNN  ;
		                                  _tienSu = tienSu  ;
		                                  _tienSuThuoc = tienSuThuoc  ;
		                                  _tienSuGiaDinh = tienSuGiaDinh  ;
		                                  _nhomMau = nhomMau  ;
		                                  _maBANoiT = maBANoiT  ;
		                                  _maKhoaVV = maKhoaVV  ;
		                                  _ngayVV = ngayVV  ;
		                                  _maBANgoaiT = maBANgoaiT  ;
		                                  _ngayKham = ngayKham  ;
		                                  _ghichu = ghichu  ;
		                                  _maMay = maMay  ;
		                                  _ngayLap = ngayLap  ;
		                                  _nguoiLap = nguoiLap  ;
		                                  _ngayHuy = ngayHuy  ;
		                                  _nguoiHuy = nguoiHuy  ;
		                                  _ngaySD = ngaySD  ;
		                                  _nguoiSD  = nguoiSD ;
		                                  _ngaySD1 = ngaySD1  ;
		                                  _nguoiSD1 = nguoiSD1  ;
		                                  _huy = huy  ;
   _ngayBANgoaiT = ngayBANgoaiT ;
   _mabhxh = mabhxh;
   _maDT = madt;
   _tenbv = tenbv;
   _giaTriTN = giatriTN;
   if (_maDT=="")
   _maDT = "00001";
   if (_madantoc=="")
   _madantoc = "00025";
   if (_maQG=="")
   _maQG = "00084";
   }

		#endregion

		#region Criteria
         	
		[Serializable()]
		protected class Criteria
		{
			private String _maBN;
			public String MaBN 
			{
				get
				{
					return _maBN;
				}
			}
            private DateTime _ngaydk;
            public DateTime ngaydk
            {
                get
                {
                    return _ngaydk;
                }
            }
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
			public Criteria(String maBN,DateTime ngaydk,Byte loai)
			{
				_maBN = maBN;
                _ngaydk = ngaydk;
                _loai = loai;
                
			}
			
			public override bool Equals(object obj)
			{
				if (obj is Criteria)
				{
					Criteria c = (Criteria) obj;
					if (!_maBN.Equals(c._maBN)) 
						return false;
					return true;
				}
				return false;
			}
			
			public override int GetHashCode()
			{
				return string.Concat("Criteria", _maBN.ToString()).GetHashCode();
			}
		}
        [Serializable()]
        protected class CriteriaKB
        {
            private String _maBN;
            public String MaBN
            {
                get
                {
                    return _maBN;
                }
            }
            private String _makhoa;
            public String Makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            private String _masokham;
            public String masokham
            {
                get
                {
                    return _masokham;
                }
            }
            private DateTime _ngaydk;
            public DateTime ngaydk
            {
                get
                {
                    return _ngaydk;
                }
            }
            private Byte _loai;
            public Byte loai
            {
                get
                {
                    return _loai;
                }
            }
            private Byte _loaikqcn;
            public Byte loaikqcn
            {
                get
                {
                    return _loaikqcn;
                }
            }
            private Byte _loaikq;
            public Byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }
            private int _stt;
            public int  stt
            {
                get
                {
                    return _stt;
                }
            }
            public CriteriaKB(String maBN, DateTime ngaydk, Byte loai, string masokham, int stt, byte loaikqcn, byte loaikq, string makhoa)
            {
                _maBN = maBN;
                _ngaydk = ngaydk;
                _loai = loai;
                _masokham = masokham;
                _stt = stt;
                _loaikqcn = loaikqcn;
                _loaikq = loaikq;
                _makhoa = makhoa;
             
            }

            public override bool Equals(object obj)
            {
                if (obj is CriteriaKB)
                {
                    CriteriaKB c = (CriteriaKB)obj;
                    if (!_maBN.Equals(c._maBN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("CriteriaKB", _maBN.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBN;
            public String maBN
            {
                get
                {
                    return _maBN;
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

            public OtherCriteria(String Mamay, String Nguoisd, String maBN, byte loai)
            {
                _maBN = maBN;
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
		/// Retrieve an existing <see cref="ThongtinBN_Q" /> Object based on data in the database.
		/// </summary>
        /// 
        
		protected void DataPortal_Fetch(Criteria crit)
		{
			// public abstract IDataReader GetThongtinBN(String _maBN);
			// public override IDataReader GetThongtinBN(String _maBN)
			// {
			//	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN));
			// }
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongtinBN(crit.MaBN )))
			{
				if (dr.Read()){
					Fetch(dr);
                    //if (dr.NextResult())
                    //{
                    dr.Close();
                    _KhamBenh = KhamBenh_Q.FindKhamBenh(_maBN, crit.ngaydk, "", crit.loai, crit.loaikqcn, 0, "");
                      //  _KhamBenh = KhamBenh_Q.GetKhamBenh(dr.GetString("masokham")   "", crit.loai, crit.loaikqcn);
                        if (_KhamBenh.MaSoKham == "")
                        {
                            _KhamBenh = KhamBenh_Q.NewKhamBenh();
                            _KhamBenh.MaBV = _maBV;
                            _KhamBenh.MaDT = _maDT;
                            _KhamBenh.NgayDK = DateTime.Now.ToLongDateString();
                            _KhamBenh.mabhxh = _mabhxh;
                            _KhamBenh.Sothe = _sothe;
                            _KhamBenh.tenbv = _tenbv;
                            _KhamBenh.GiatriDN = _giaTriDN.ToString();
                            _KhamBenh.GiaTriTN = _giaTriTN.ToString();
                            
                        }
                       
                    //}
					MarkOld();
					ValidationRules.CheckRules();
                   // dr.Close();
				}
			}
		}
        protected void DataPortal_Fetch(CriteriaKB crit)
        {
            // public abstract IDataReader GetThongtinBN(String _maBN);
            // public override IDataReader GetThongtinBN(String _maBN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongtinBN(crit.MaBN)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if ((crit.loaikq == 1 || crit.loaikq == 2) && crit.loai == 4)
                        _KhamBenh = KhamBenh_Q.FindKhamBenh(crit.MaBN, crit.ngaydk, crit.loaikqcn.ToString(), crit.loai, crit.loaikqcn, crit.loaikq, crit.Makhoa);
                    else
                    _KhamBenh = KhamBenh_Q.FindKhamBenh(crit.MaBN, crit.ngaydk, crit.stt.ToString(), crit.loai, crit.loaikqcn, crit.loaikq,"");

                        if (_KhamBenh.MaSoKham == "")
                        {
                            _KhamBenh.MaBV = _maBV;
                            _KhamBenh.MaBN = _maBN;
                            _KhamBenh.MaDT = _maDT;
                            _KhamBenh.NgayDK = DateTime.Now.ToLongDateString();
                            _KhamBenh.mabhxh = _mabhxh;
                            _KhamBenh.Sothe = _sothe;
                            _KhamBenh.tenbv = _tenbv;
                            _KhamBenh.GiatriDN = _giaTriDN.ToString ();
                            _KhamBenh.GiaTriTN = _giaTriTN.ToString(); 
                            _KhamBenh.NgayDK = DateTime.Now.ToLongDateString();
                        }
                    
                    MarkOld();
                    ValidationRules.CheckRules();
                   // dr.Close();
                }
            }
        }
        protected void DataPortal_Fetch(OtherCriteria crit)
        {
            // public abstract IDataReader GetThongtinBN(String _maBN);
            // public override IDataReader GetThongtinBN(String _maBN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetThongtinBN(crit.maBN)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    
                    MarkOld();
                    ValidationRules.CheckRules();
                }
               // dr.Close();
            }
        }
		/// <summary>
		/// Load a <see cref="ThongtinBN_Q" /> Object from given SafeDataReader.
		/// </summary>
		private void Fetch(SafeDataReader dr)
		{
			// Value properties
			if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
			if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
			if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
			if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
			if (dr.GetSmartDate("GiaTriDN", true) != null) _giaTriDN = dr.GetSmartDate("GiaTriDN", true);
			if (dr.GetString("DiaChi") != null) _diaChi = dr.GetString("DiaChi");
            if (dr.GetString("DiaChiC") != null) _diaChiC = dr.GetString("DiaChiC");
			if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
			if (dr.GetString("DTDD") != null) _dTDD = dr.GetString("DTDD");
			if (dr.GetString("DTCQ") != null) _dTCQ = dr.GetString("DTCQ");
			if (dr.GetString("Mail") != null) _mail = dr.GetString("Mail");
			if (dr.GetByte("Tuoi") != null) _tuoi = dr.GetByte("Tuoi");
            if (dr.GetSmartDate("GiatritN", true) != null) _giaTriTN = dr.GetSmartDate("GiatritN", true);
			if (dr.GetSmartDate("NgaySinh", true) != null) _ngaySinh = dr.GetSmartDate("NgaySinh", true);
			if (dr.GetBoolean("GT") != null) _gt = dr.GetBoolean("GT");
			if (dr.GetString("BaoTin") != null) _baoTin = dr.GetString("BaoTin");
			if (dr.GetString("MaQG") != null) _maQG = dr.GetString("MaQG");
			if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
			if (dr.GetString("MaHuyen") != null) _maHuyen = dr.GetString("MaHuyen");
			if (dr.GetString("MaNN") != null) _maNN = dr.GetString("MaNN");
			if (dr.GetString("TienSu") != null) _tienSu = dr.GetString("TienSu");
			if (dr.GetString("TienSuThuoc") != null) _tienSuThuoc = dr.GetString("TienSuThuoc");
			if (dr.GetString("TienSuGiaDinh") != null) _tienSuGiaDinh = dr.GetString("TienSuGiaDinh");
			if (dr.GetString("NhomMau") != null) _nhomMau = dr.GetString("NhomMau");
			if (dr.GetString("MaBANoiT") != null) _maBANoiT = dr.GetString("MaBANoiT");
			if (dr.GetString("MaKhoaVV") != null) _maKhoaVV = dr.GetString("MaKhoaVV");
			if (dr.GetSmartDate("NgayVV", true) != null) _ngayVV = dr.GetSmartDate("NgayVV", true);
			if (dr.GetString("MaBANgoaiT") != null) _maBANgoaiT = dr.GetString("MaBANgoaiT");
			if (dr.GetSmartDate("NgayKham", true) != null) _ngayKham = dr.GetSmartDate("NgayKham", true);

            if (dr.GetString("mabaql") != null) _maBAQL = dr.GetString("mabaql");
            if (dr.GetString("SoCMT") != null) _SoCMT = dr.GetString("SoCMT");
            if (dr.GetString("MaDonVi") != null) _MaDonVi = dr.GetString("MaDonVi");
            if (dr.GetString("MaQuanHam") != null) _MaQuanHam = dr.GetString("MaQuanHam");
            if (dr.GetString("MaDonVi") != null) _MaDonVi = dr.GetString("MaDonVi");
            if (dr.GetString("MaQuanheqd") != null) _MaQuanHeQD = dr.GetString("MaQuanHeQD");
         
           
			if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
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
			if (dr.GetSmartDate("NgayBANgoaiT", true) != null) _ngayBANgoaiT = dr.GetSmartDate("NgayBANgoaiT", true);
            if (dr.GetString("mabhxh") != null) _mabhxh = dr.GetString("mabhxh");
            if (dr.GetString("madantoc") != null) _madantoc = dr.GetString("madantoc");
            if (dr.GetString("hotenbome") != null) _hotenbome = dr.GetString("hotenbome");
            if (dr.GetString("tenbv") != null) _tenbv = dr.GetString("tenbv");
            if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
		}
		
		/// <summary>
		/// Insert the new <see cref="ThongtinBN_Q" /> Object to underlying database.
		/// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            //MarkAsChild();
            ValidationRules.CheckRules();
            _maDT = "00001";
            _maQG = "00084";
            _ngayKham.Date = DateTime.Now; 
            //MarkOld();
        }
		protected override void DataPortal_Insert()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham InsertThongtinBN
			// Copy & paste ham duoi day vao file DataProvider.cs
			_maBN = DataProvider.Instance().InsertThongtinBN(_hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _dTDD, _dTCQ, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen, null,_maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu  ,_maMay ,_nguoiSD,_madantoc ,_hotenbome,_giaTriTN, _maBAQL, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT,""  );
			// public abstract String InsertThongtinBN(String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap);
			// public override String InsertThongtinBN(String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, String _nguoiLap);
			// {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spTHONGTINBN_CREATE",_hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _dTDD, _dTCQ, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu,_maMay ,   _nguoiLap);
			// }
            MarkOld();
            _KhamBenh.MaBN = _maBN; 
              KhamBenh_Q  tmp = _KhamBenh.Clone() ;
              if (tmp.IsDirty)
              {
                  tmp.ApplyEdit();
                  _KhamBenh = tmp.Save();
              };
           
		}
		
		/// <summary>
		/// Update all changes made on <see cref="ThongtinBN_Q" /> Object to underlying database.
		/// </summary>
		protected override void DataPortal_Update()
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongtinBN
			if (IsDirty){
                DataProvider.Instance().UpdateThongtinBN(_maBN, _hoten, _sothe, _maBV, _giaTriDN, _diaChi, _dienThoai, _dTDD, _dTCQ, _mail, _tuoi, _ngaySinh, _gt, _baoTin, _maQG, _maTinh, _maHuyen,null, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu, _maMay , _huy, _nguoiSD , _madantoc, _hotenbome, _giaTriTN, _maBAQL, _MaQuanHeQD, _MaQuanHam, _MaDonVi, _SoCMT,"");
                // public abstract void UpdateThongtinBN(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateThongtinBN(String _maBN, String _hoten, String _sothe, String _maBV, SmartDate _giaTriDN, String _diaChi, String _dienThoai, String _dTDD, String _dTCQ, String _mail, Byte _tuoi, SmartDate _ngaySinh, Boolean _gt, String _baoTin, String _maQG, String _maTinh, String _maHuyen, String _maNN, String _tienSu, String _tienSuThuoc, String _tienSuGiaDinh, String _nhomMau, String _ghichu, String _maMay, Boolean _huy, String _nguoiSD);
				// {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTHONGTINBN_UPDATE", _maBN, _hoten, _sothe, _maBV, _giaTriDN.DBValue, _diaChi, _dienThoai, _dTDD, _dTCQ, _mail, _tuoi, _ngaySinh.DBValue, _gt, _baoTin, _maQG, _maTinh, _maHuyen, _maNN, _tienSu, _tienSuThuoc, _tienSuGiaDinh, _nhomMau, _ghichu,_maMay ,   _huy, _nguoiSD);
				// }	
                _KhamBenh.MaBN = _maBN;
                KhamBenh_Q tmp = _KhamBenh.Clone();
               tmp.ApplyEdit();
                  _KhamBenh= tmp.Save();
			}
		}
		protected override void DataPortal_DeleteSelf()
		{
            DataPortal_Delete(new OtherCriteria(_maMay,_nguoiSD   , _maBN,0));
		}

		/// <summary>
		/// Delete the <see cref="ThongtinBN_Q" />.
		/// </summary>
		protected void DataPortal_Delete(OtherCriteria crit)
		{
			// TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongtinBN
            DataProvider.Instance().DeleteThongtinBN(crit.MaMay, crit.NguoiSD, crit.maBN);
			// public abstract void DeleteThongtinBN(String _maBN);
			// public override void DeleteThongtinBN(String _maBN);
			// {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spTHONGTINBN_DELETED", _maBN);
			// }
		}

		#endregion
	}

}
