using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.BusinessObject.TBYT
{
	public class TBPhieuSuaChua_C
	{
		private static string ConnectString
		{
			get
			{
                return System.Configuration.ConfigurationManager.ConnectionStrings["SqlDataProvider"].ToString();
			}
		}

		#region State Fields

		private String _maPhieuYC;
		private Decimal _sTT;
		private String _maTB;
        private String _maBarCode;
        private String _model;
        private String _serialNo;
        private String _maNoiSua;
        private String _tenNoiSua;
		private Byte _phanLoai;
		private Int32 _maMoTaYC;
		private String _motaYC;
		private String _yC_TinhTrangTB;
		private Boolean _huykhongsua;
		private String _nguyenNhanKhongSua;
		private Boolean _kS_YeuCauDuyet;
		private String _kS_TinhTrangTB;
		private String _kS_NguyenNhanHuHong;
		private String _kS_GiaiPhapKT;
		private Boolean _kS_Huy;
		private Boolean _duyetKS;
		private String _kS_YKienNguoiDuyet;
		private DateTime _ngayDuyetKS;
		private String _nguoiDuyetKS;
		private Boolean _isLapDuTru;
		private DateTime _ngaySuaChuaBD;
		private DateTime _ngaySuaChuaKT;
		private String _nguoiLapDuTru;
		private DateTime _ngayLapDuTru;
		private Byte _loaiPhieuDuTru;
		private String _maPX;
		private Decimal _chiPhiNC;
		private Boolean _duyetDuTru;
		private String _nguoiDuyetDuTru;
		private DateTime _ngayDuyetDuTru;
		private String _yKienNguoiDuyetDuTru;
		private String _tinhTrangTB;
		private Byte _trangthaiCV;
		private String _nguyenNhanSauSc;
		private String _giaiPhapKTSauSc;
		private DateTime _ngayHoanThanh;
		private Boolean _khongSuachua;
		private String _maNVSC;
		private String _maDVSuaChua;
		private Boolean _huy;
		private String _tenTB;
		private String _tenDVT;
		private String _tenPhanLoai;
		private String _tenMoTaYC;
		private String _tenNguoiDuyetKS;
		private String _tenDVSuaChua;
		private String _tenTrangThai;
		private String _tenTinhTrangTB;
		private String _tenNVSC;
		private String _tenNguoiLapDuTru;
		private String _tenNguoiDuyetDuTru;
		private String _maKhoaYC;
		private String _tenKhoaYC;
		private DateTime _ngayYC;
		private String _nhanVienYC;
		private String _tenNhanVienYC;
		private int _ordernumber;
		#endregion

		#region Business Properties and Methods
		public String MaPhieuYC
		{
			get
			{
				return _maPhieuYC;
			}
			set
			{
				_maPhieuYC = value;
			}
		}
		public Decimal STT
		{
			get
			{
				return _sTT;
			}
			set
			{
				_sTT = value;
			}
		}
		public String MaTB
		{
			get
			{
				return _maTB;
			}
			set
			{
				_maTB = value;
			}
		}
        public String MaBarCode
        {
            get
            {
                return _maBarCode;
            }
            set
            {
                _maBarCode = value;
            }
        }
        public String Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public String SerialNo
        {
            get
            {
                return _serialNo;
            }
            set
            {
                _serialNo = value;
            }
        }
		public Byte PhanLoai
		{
			get
			{
				return _phanLoai;
			}
			set
			{
				_phanLoai = value;
			}
		}
		public Int32 MaMoTaYC
		{
			get
			{
				return _maMoTaYC;
			}
			set
			{
				_maMoTaYC = value;
			}
		}
		public String MotaYC
		{
			get
			{
				return _motaYC;
			}
			set
			{
				_motaYC = value;
			}
		}
		public String YC_TinhTrangTB
		{
			get
			{
				return _yC_TinhTrangTB;
			}
			set
			{
				_yC_TinhTrangTB = value;
			}
		}
		public Boolean Huykhongsua
		{
			get
			{
				return _huykhongsua;
			}
			set
			{
				_huykhongsua = value;
			}
		}
		public String NguyenNhanKhongSua
		{
			get
			{
				return _nguyenNhanKhongSua;
			}
			set
			{
				_nguyenNhanKhongSua = value;
			}
		}
		public Boolean KS_YeuCauDuyet
		{
			get
			{
				return _kS_YeuCauDuyet;
			}
			set
			{
				_kS_YeuCauDuyet = value;
			}
		}
		public String KS_TinhTrangTB
		{
			get
			{
				return _kS_TinhTrangTB;
			}
			set
			{
				_kS_TinhTrangTB = value;
			}
		}
		public String KS_NguyenNhanHuHong
		{
			get
			{
				return _kS_NguyenNhanHuHong;
			}
			set
			{
				_kS_NguyenNhanHuHong = value;
			}
		}
		public String KS_GiaiPhapKT
		{
			get
			{
				return _kS_GiaiPhapKT;
			}
			set
			{
				_kS_GiaiPhapKT = value;
			}
		}
		public Boolean KS_Huy
		{
			get
			{
				return _kS_Huy;
			}
			set
			{
				_kS_Huy = value;
			}
		}
		public Boolean DuyetKS
		{
			get
			{
				return _duyetKS;
			}
			set
			{
				_duyetKS = value;
			}
		}
		public String KS_YKienNguoiDuyet
		{
			get
			{
				return _kS_YKienNguoiDuyet;
			}
			set
			{
				_kS_YKienNguoiDuyet = value;
			}
		}
		public DateTime NgayDuyetKS
		{
			get
			{
				return _ngayDuyetKS;
			}
			set
			{
				_ngayDuyetKS = value;
			}
		}
		public String NguoiDuyetKS
		{
			get
			{
				return _nguoiDuyetKS;
			}
			set
			{
				_nguoiDuyetKS = value;
			}
		}
		public Boolean IsLapDuTru
		{
			get
			{
				return _isLapDuTru;
			}
			set
			{
				_isLapDuTru = value;
			}
		}
		public DateTime NgaySuaChuaBD
		{
			get
			{
				return _ngaySuaChuaBD;
			}
			set
			{
				_ngaySuaChuaBD = value;
			}
		}
		public DateTime NgaySuaChuaKT
		{
			get
			{
				return _ngaySuaChuaKT;
			}
			set
			{
				_ngaySuaChuaKT = value;
			}
		}
		public String NguoiLapDuTru
		{
			get
			{
				return _nguoiLapDuTru;
			}
			set
			{
				_nguoiLapDuTru = value;
			}
		}
		public DateTime NgayLapDuTru
		{
			get
			{
				return _ngayLapDuTru;
			}
			set
			{
				_ngayLapDuTru = value;
			}
		}
		public Byte LoaiPhieuDuTru
		{
			get
			{
				return _loaiPhieuDuTru;
			}
			set
			{
				_loaiPhieuDuTru = value;
			}
		}
		public String MaPX
		{
			get
			{
				return _maPX;
			}
			set
			{
				_maPX = value;
			}
		}
		public Decimal ChiPhiNC
		{
			get
			{
				return _chiPhiNC;
			}
			set
			{
				_chiPhiNC = value;
			}
		}
		public Boolean DuyetDuTru
		{
			get
			{
				return _duyetDuTru;
			}
			set
			{
				_duyetDuTru = value;
			}
		}
		public String NguoiDuyetDuTru
		{
			get
			{
				return _nguoiDuyetDuTru;
			}
			set
			{
				_nguoiDuyetDuTru = value;
			}
		}
		public DateTime NgayDuyetDuTru
		{
			get
			{
				return _ngayDuyetDuTru;
			}
			set
			{
				_ngayDuyetDuTru = value;
			}
		}
		public String YKienNguoiDuyetDuTru
		{
			get
			{
				return _yKienNguoiDuyetDuTru;
			}
			set
			{
				_yKienNguoiDuyetDuTru = value;
			}
		}
		public String TinhTrangTB
		{
			get
			{
				return _tinhTrangTB;
			}
			set
			{
				_tinhTrangTB = value;
			}
		}
		public Byte TrangthaiCV
		{
			get
			{
				return _trangthaiCV;
			}
			set
			{
				_trangthaiCV = value;
			}
		}
		public String NguyenNhanSauSc
		{
			get
			{
				return _nguyenNhanSauSc;
			}
			set
			{
				_nguyenNhanSauSc = value;
			}
		}
		public String GiaiPhapKTSauSc
		{
			get
			{
				return _giaiPhapKTSauSc;
			}
			set
			{
				_giaiPhapKTSauSc = value;
			}
		}
		public DateTime NgayHoanThanh
		{
			get
			{
				return _ngayHoanThanh;
			}
			set
			{
				_ngayHoanThanh = value;
			}
		}
		public Boolean KhongSuachua
		{
			get
			{
				return _khongSuachua;
			}
			set
			{
				_khongSuachua = value;
			}
		}
		public String MaNVSC
		{
			get
			{
				return _maNVSC;
			}
			set
			{
				_maNVSC = value;
			}
		}
		public String MaDVSuaChua
		{
			get
			{
				return _maDVSuaChua;
			}
			set
			{
				_maDVSuaChua = value;
			}
		}
		public Boolean Huy
		{
			get
			{
				return _huy;
			}
			set
			{
				_huy = value;
			}
		}
		public String TenTB
		{
			get
			{
				return _tenTB;
			}
			set
			{
				_tenTB = value;
			}
		}
        public String MaNoiSua
        {
            get
            {
                return _maNoiSua;
            }
            set
            {
                _maNoiSua = value;
            }
        }
        public String TenNoiSua
        {
            get
            {
                return _tenNoiSua;
            }
            set
            {
                _tenNoiSua = value;
            }
        }
		public String TenDVT
		{
			get
			{
				return _tenDVT;
			}
			set
			{
				_tenDVT = value;
			}
		}
		public String TenPhanLoai
		{
			get
			{
				return _tenPhanLoai;
			}
			set
			{
				_tenPhanLoai = value;
			}
		}
		public String TenMoTaYC
		{
			get
			{
				return _tenMoTaYC;
			}
			set
			{
				_tenMoTaYC = value;
			}
		}
		public String TenNguoiDuyetKS
		{
			get
			{
				return _tenNguoiDuyetKS;
			}
			set
			{
				_tenNguoiDuyetKS = value;
			}
		}
		public String TenDVSuaChua
		{
			get
			{
				return _tenDVSuaChua;
			}
			set
			{
				_tenDVSuaChua = value;
			}
		}
		public String TenTrangThai
		{
			get
			{
				return _tenTrangThai;
			}
			set
			{
				_tenTrangThai = value;
			}
		}
		public String TenTinhTrangTB
		{
			get
			{
				return _tenTinhTrangTB;
			}
			set
			{
				_tenTinhTrangTB = value;
			}
		}
		public String TenNVSC
		{
			get
			{
				return _tenNVSC;
			}
			set
			{
				_tenNVSC = value;
			}
		}
		public String TenNguoiLapDuTru
		{
			get
			{
				return _tenNguoiLapDuTru;
			}
			set
			{
				_tenNguoiLapDuTru = value;
			}
		}
		public String TenNguoiDuyetDuTru
		{
			get
			{
				return _tenNguoiDuyetDuTru;
			}
			set
			{
				_tenNguoiDuyetDuTru = value;
			}
		}
		public String MaKhoaYC
		{
			get
			{
				return _maKhoaYC;
			}
			set
			{
				_maKhoaYC = value;
			}
		}
		public String TenKhoaYC
		{
			get
			{
				return _tenKhoaYC;
			}
			set
			{
				_tenKhoaYC = value;
			}
		}
		public DateTime NgayYC
		{
			get
			{
				return _ngayYC;
			}
			set
			{
				_ngayYC = value;
			}
		}
		public String NhanVienYC
		{
			get
			{
				return _nhanVienYC;
			}
			set
			{
				_nhanVienYC = value;
			}
		}
		public String TenNhanVienYC
		{
			get
			{
				return _tenNhanVienYC;
			}
			set
			{
				_tenNhanVienYC = value;
			}
		}
		public int Ordernumber
		{
			get
			{
				return _ordernumber;
			}
			set
			{
				_ordernumber = value;
			}
		}
		#endregion


		#region Data Access
		public TBPhieuSuaChua_C()
		{

		}

        public TBPhieuSuaChua_C(IDataReader dr, int Ordernumber)
        {
            _ordernumber = Ordernumber;
            if (dr["MaPhieuYC"] != null && dr["MaPhieuYC"].GetType().Name != "DBNull") _maPhieuYC = Convert.ToString(dr["MaPhieuYC"]);
            if (dr["STT"] != null && dr["STT"].GetType().Name != "DBNull") _sTT = Convert.ToDecimal(dr["STT"]);
            if (dr["MaTB"] != null && dr["MaTB"].GetType().Name != "DBNull") _maTB = Convert.ToString(dr["MaTB"]);
            if (dr["MaBarCode"] != null && dr["MaBarCode"].GetType().Name != "DBNull") _maBarCode = Convert.ToString(dr["MaBarCode"]);
            if (dr["Model"] != null && dr["Model"].GetType().Name != "DBNull") _model = Convert.ToString(dr["Model"]);
            if (dr["SerialNo"] != null && dr["SerialNo"].GetType().Name != "DBNull") _serialNo = Convert.ToString(dr["SerialNo"]);
            if (dr["MaNoiSua"] != null && dr["MaNoiSua"].GetType().Name != "DBNull") _maNoiSua = Convert.ToString(dr["MaNoiSua"]);
            if (dr["TenNoiSua"] != null && dr["TenNoiSua"].GetType().Name != "DBNull") _tenNoiSua = Convert.ToString(dr["TenNoiSua"]);
            if (dr["PhanLoai"] != null && dr["PhanLoai"].GetType().Name != "DBNull") _phanLoai = Convert.ToByte(dr["PhanLoai"]);
            if (dr["MaMoTaYC"] != null && dr["MaMoTaYC"].GetType().Name != "DBNull") _maMoTaYC = Convert.ToInt32(dr["MaMoTaYC"]);
            if (dr["MotaYC"] != null && dr["MotaYC"].GetType().Name != "DBNull") _motaYC = Convert.ToString(dr["MotaYC"]);
            if (dr["YC_TinhTrangTB"] != null && dr["YC_TinhTrangTB"].GetType().Name != "DBNull") _yC_TinhTrangTB = Convert.ToString(dr["YC_TinhTrangTB"]);
            if (dr["Huykhongsua"] != null && dr["Huykhongsua"].GetType().Name != "DBNull") _huykhongsua = Convert.ToBoolean(dr["Huykhongsua"]);
            if (dr["NguyenNhanKhongSua"] != null && dr["NguyenNhanKhongSua"].GetType().Name != "DBNull") _nguyenNhanKhongSua = Convert.ToString(dr["NguyenNhanKhongSua"]);
            if (dr["KS_YeuCauDuyet"] != null && dr["KS_YeuCauDuyet"].GetType().Name != "DBNull") _kS_YeuCauDuyet = Convert.ToBoolean(dr["KS_YeuCauDuyet"]);
            if (dr["KS_TinhTrangTB"] != null && dr["KS_TinhTrangTB"].GetType().Name != "DBNull") _kS_TinhTrangTB = Convert.ToString(dr["KS_TinhTrangTB"]);
            if (dr["KS_NguyenNhanHuHong"] != null && dr["KS_NguyenNhanHuHong"].GetType().Name != "DBNull") _kS_NguyenNhanHuHong = Convert.ToString(dr["KS_NguyenNhanHuHong"]);
            if (dr["KS_GiaiPhapKT"] != null && dr["KS_GiaiPhapKT"].GetType().Name != "DBNull") _kS_GiaiPhapKT = Convert.ToString(dr["KS_GiaiPhapKT"]);
            if (dr["KS_Huy"] != null && dr["KS_Huy"].GetType().Name != "DBNull") _kS_Huy = Convert.ToBoolean(dr["KS_Huy"]);
            if (dr["DuyetKS"] != null && dr["DuyetKS"].GetType().Name != "DBNull") _duyetKS = Convert.ToBoolean(dr["DuyetKS"]);
            if (dr["KS_YKienNguoiDuyet"] != null && dr["KS_YKienNguoiDuyet"].GetType().Name != "DBNull") _kS_YKienNguoiDuyet = Convert.ToString(dr["KS_YKienNguoiDuyet"]);
            if (dr["NgayDuyetKS"] != null && dr["NgayDuyetKS"].GetType().Name != "DBNull") _ngayDuyetKS = Convert.ToDateTime(dr["NgayDuyetKS"]);
            if (dr["NguoiDuyetKS"] != null && dr["NguoiDuyetKS"].GetType().Name != "DBNull") _nguoiDuyetKS = Convert.ToString(dr["NguoiDuyetKS"]);
            if (dr["IsLapDuTru"] != null && dr["IsLapDuTru"].GetType().Name != "DBNull") _isLapDuTru = Convert.ToBoolean(dr["IsLapDuTru"]);
            if (dr["NgaySuaChuaBD"] != null && dr["NgaySuaChuaBD"].GetType().Name != "DBNull") _ngaySuaChuaBD = Convert.ToDateTime(dr["NgaySuaChuaBD"]);
            if (dr["NgaySuaChuaKT"] != null && dr["NgaySuaChuaKT"].GetType().Name != "DBNull") _ngaySuaChuaKT = Convert.ToDateTime(dr["NgaySuaChuaKT"]);
            if (dr["NguoiLapDuTru"] != null && dr["NguoiLapDuTru"].GetType().Name != "DBNull") _nguoiLapDuTru = Convert.ToString(dr["NguoiLapDuTru"]);
            if (dr["NgayLapDuTru"] != null && dr["NgayLapDuTru"].GetType().Name != "DBNull") _ngayLapDuTru = Convert.ToDateTime(dr["NgayLapDuTru"]);
            if (dr["LoaiPhieuDuTru"] != null && dr["LoaiPhieuDuTru"].GetType().Name != "DBNull") _loaiPhieuDuTru = Convert.ToByte(dr["LoaiPhieuDuTru"]);
            if (dr["MaPX"] != null && dr["MaPX"].GetType().Name != "DBNull") _maPX = Convert.ToString(dr["MaPX"]);
            if (dr["ChiPhiNC"] != null && dr["ChiPhiNC"].GetType().Name != "DBNull") _chiPhiNC = Convert.ToDecimal(dr["ChiPhiNC"]);
            if (dr["DuyetDuTru"] != null && dr["DuyetDuTru"].GetType().Name != "DBNull") _duyetDuTru = Convert.ToBoolean(dr["DuyetDuTru"]);
            if (dr["NguoiDuyetDuTru"] != null && dr["NguoiDuyetDuTru"].GetType().Name != "DBNull") _nguoiDuyetDuTru = Convert.ToString(dr["NguoiDuyetDuTru"]);
            if (dr["NgayDuyetDuTru"] != null && dr["NgayDuyetDuTru"].GetType().Name != "DBNull") _ngayDuyetDuTru = Convert.ToDateTime(dr["NgayDuyetDuTru"]);
            if (dr["YKienNguoiDuyetDuTru"] != null && dr["YKienNguoiDuyetDuTru"].GetType().Name != "DBNull") _yKienNguoiDuyetDuTru = Convert.ToString(dr["YKienNguoiDuyetDuTru"]);
            if (dr["TinhTrangTB"] != null && dr["TinhTrangTB"].GetType().Name != "DBNull") _tinhTrangTB = Convert.ToString(dr["TinhTrangTB"]);
            if (dr["TrangthaiCV"] != null && dr["TrangthaiCV"].GetType().Name != "DBNull") _trangthaiCV = Convert.ToByte(dr["TrangthaiCV"]);
            if (dr["NguyenNhanSauSc"] != null && dr["NguyenNhanSauSc"].GetType().Name != "DBNull") _nguyenNhanSauSc = Convert.ToString(dr["NguyenNhanSauSc"]);
            if (dr["GiaiPhapKTSauSc"] != null && dr["GiaiPhapKTSauSc"].GetType().Name != "DBNull") _giaiPhapKTSauSc = Convert.ToString(dr["GiaiPhapKTSauSc"]);
            if (dr["NgayHoanThanh"] != null && dr["NgayHoanThanh"].GetType().Name != "DBNull") _ngayHoanThanh = Convert.ToDateTime(dr["NgayHoanThanh"]);
            if (dr["KhongSuachua"] != null && dr["KhongSuachua"].GetType().Name != "DBNull") _khongSuachua = Convert.ToBoolean(dr["KhongSuachua"]);
            if (dr["MaNVSC"] != null && dr["MaNVSC"].GetType().Name != "DBNull") _maNVSC = Convert.ToString(dr["MaNVSC"]);
            if (dr["MaDVSuaChua"] != null && dr["MaDVSuaChua"].GetType().Name != "DBNull") _maDVSuaChua = Convert.ToString(dr["MaDVSuaChua"]);
            if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
            if (dr["TenTB"] != null && dr["TenTB"].GetType().Name != "DBNull") _tenTB = Convert.ToString(dr["TenTB"]);
            if (dr["TenDVT"] != null && dr["TenDVT"].GetType().Name != "DBNull") _tenDVT = Convert.ToString(dr["TenDVT"]);
            if (dr["TenPhanLoai"] != null && dr["TenPhanLoai"].GetType().Name != "DBNull") _tenPhanLoai = Convert.ToString(dr["TenPhanLoai"]);
            if (dr["TenMoTaYC"] != null && dr["TenMoTaYC"].GetType().Name != "DBNull") _tenMoTaYC = Convert.ToString(dr["TenMoTaYC"]);
            if (dr["TenNguoiDuyetKS"] != null && dr["TenNguoiDuyetKS"].GetType().Name != "DBNull") _tenNguoiDuyetKS = Convert.ToString(dr["TenNguoiDuyetKS"]);
            if (dr["TenDVSuaChua"] != null && dr["TenDVSuaChua"].GetType().Name != "DBNull") _tenDVSuaChua = Convert.ToString(dr["TenDVSuaChua"]);
            if (dr["TenTrangThai"] != null && dr["TenTrangThai"].GetType().Name != "DBNull") _tenTrangThai = Convert.ToString(dr["TenTrangThai"]);
            if (dr["TenTinhTrangTB"] != null && dr["TenTinhTrangTB"].GetType().Name != "DBNull") _tenTinhTrangTB = Convert.ToString(dr["TenTinhTrangTB"]);
            if (dr["TenNVSC"] != null && dr["TenNVSC"].GetType().Name != "DBNull") _tenNVSC = Convert.ToString(dr["TenNVSC"]);
            if (dr["TenNguoiLapDuTru"] != null && dr["TenNguoiLapDuTru"].GetType().Name != "DBNull") _tenNguoiLapDuTru = Convert.ToString(dr["TenNguoiLapDuTru"]);
            if (dr["TenNguoiDuyetDuTru"] != null && dr["TenNguoiDuyetDuTru"].GetType().Name != "DBNull") _tenNguoiDuyetDuTru = Convert.ToString(dr["TenNguoiDuyetDuTru"]);
            if (dr["MaKhoaYC"] != null && dr["MaKhoaYC"].GetType().Name != "DBNull") _maKhoaYC = Convert.ToString(dr["MaKhoaYC"]);
            if (dr["TenKhoaYC"] != null && dr["TenKhoaYC"].GetType().Name != "DBNull") _tenKhoaYC = Convert.ToString(dr["TenKhoaYC"]);
            if (dr["NgayYC"] != null && dr["NgayYC"].GetType().Name != "DBNull") _ngayYC = Convert.ToDateTime(dr["NgayYC"]);
            if (dr["NhanVienYC"] != null && dr["NhanVienYC"].GetType().Name != "DBNull") _nhanVienYC = Convert.ToString(dr["NhanVienYC"]);
            if (dr["TenNhanVienYC"] != null && dr["TenNhanVienYC"].GetType().Name != "DBNull") _tenNhanVienYC = Convert.ToString(dr["TenNhanVienYC"]);
        }

		public static TBPhieuSuaChua_C GetBySTT(Decimal STT)
		{
			using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBPHIEUSUACHUA_C_Get", STT)))
			{
				while (dr.Read())
				{
					return new TBPhieuSuaChua_C(dr, 1);
				}
			}
			return null;
		}

		public static void Delete(Decimal STT, String NguyenNhanHuy)
		{
			SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBPHIEUSUACHUA_C_Delete", STT, NguyenNhanHuy);
		}

		public static Decimal UpdateYeuCau(Decimal STT, String MaTB, Byte PhanLoai, int MaMoTaYC, String MotaYC, String YC_TinhTrangTB, Boolean HuyYC, Boolean Huy)
		{
			return Decimal.Parse(System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_YeuCau_UPDATE", STT, MaTB, PhanLoai, MaMoTaYC, MotaYC, YC_TinhTrangTB, HuyYC, Huy)));
		}

		public static String InsertYeucau(String MaPhieuYC,String MaTB, Byte PhanLoai, int MaMoTaYC, String MotaYC, String YC_TinhTrangTB)
		{
			return System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_YeuCau_INSERT", MaPhieuYC, MaTB, PhanLoai, MaMoTaYC, MotaYC, YC_TinhTrangTB));
		}

        public static Decimal UpdateKhaoSat(Decimal STT, String KS_TinhTrangTB, String KS_NguyenNhanHuHong, String KS_GiaiPhapKT, Boolean KS_Huy, Boolean DuyetKS, String NguoiDuyetKS, String KS_YKienNguoiDuyet, Boolean Huy)
        {
			return Decimal.Parse(System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_KhaoSat_C_Update", STT, KS_TinhTrangTB, KS_NguyenNhanHuHong, KS_GiaiPhapKT, KS_Huy, DuyetKS, NguoiDuyetKS, KS_YKienNguoiDuyet, Huy)));
        }

        public static void DeleteKhaoSat(Decimal STT, String NguoiDuyetKS, String KS_YKienNguoiDuyet)
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBPHIEUSUACHUA_KhaoSat_C_Delete", STT, NguoiDuyetKS, KS_YKienNguoiDuyet);
        }


		public static Decimal UpdateDuTruThayTheVatTu(Decimal STT, DateTime NgayLapDuTru, String NguoiLapDT,  String KS_TinhTrangTB, String KS_NguyenNhanHuHong, String KS_GiaiPhapKT, DateTime NgaySuaChuaBD, DateTime NgaySuaChuaKT, Nullable<Decimal> ChiPhiNC, Byte LoaiPhieuDuTru, String MaDonViSuaChua, String MaNhanVienSC)
		{
			return Decimal.Parse(System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_DuTruThayThe_Update", STT, NgayLapDuTru, NguoiLapDT, KS_TinhTrangTB, KS_NguyenNhanHuHong, KS_GiaiPhapKT, NgaySuaChuaBD, NgaySuaChuaKT, ChiPhiNC, LoaiPhieuDuTru, MaDonViSuaChua, MaNhanVienSC)));
		}

		public static Decimal UpdateDuyetDuTruThayTheVatTu(Decimal STT, Boolean DuyetDuTru, String YKienNguoiDuyetDuTru, String NguoiDuyetDuTru, DateTime NgayDuyetDuTru)
		{
			return Decimal.Parse(System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_DuyetDuTruThayThe_Update", STT, DuyetDuTru, YKienNguoiDuyetDuTru, NguoiDuyetDuTru, NgayDuyetDuTru)));
		}

		public static Decimal UpdateDuTruThayTheVatTuMaPX(Decimal STT, String MaPX)
		{
			return Decimal.Parse(System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_DuTruThayThe_UpdateMaPX", STT, MaPX)));
		}

        public static Decimal UpdateDaSua(Decimal STT, byte TrangthaiCV, String TinhTrangTB, Csla.SmartDate NgayHoanThanh, String NguyenNhanSauSc, String NguyenNhanKhongSua, String GiaiPhapKTSauSc, String MaNVSC)
        {
            return Decimal.Parse(System.Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBPHIEUSUACHUA_C_DaSua_UPDATE", STT, TrangthaiCV, TinhTrangTB, NgayHoanThanh.DBValue, NguyenNhanSauSc, NguyenNhanKhongSua, GiaiPhapKTSauSc, MaNVSC)));
        }


        public static DataSet CRBienBanKhaoSatSuaChua_Get(String MaPhieuSC, Decimal STT)
        {
            DataSet ds = new DataSet();
            string[] s = { "PhieuKhaoSat", "DanhSachTBKhaoSat" };
            SqlHelper.FillDataset(ConnectString, "dbo.CRBienBanKhaoSatSuaChua_Get", ds, s, MaPhieuSC, STT);
            //ds.WriteXmlSchema("E:\\PhieuKhaoSat.xsd");
            return ds;
        }

        public static DataSet CRBienBanDuTruSuaChua_GetMaPhieu(String MaPhieuSC, Boolean isqAdmin)
        {
            DataSet ds = new DataSet();
            string[] s = new String[] { "PhieuYeuCau", "PhieuXuatKho", "PhieuXuatNgoai" };
            SqlHelper.FillDataset(ConnectString, "dbo.CRBienBanDuTruSuaChua_GetMaPhieu", ds, s, MaPhieuSC, isqAdmin);
            //ds.WriteXmlSchema("E:\\PhieuYeuCauSC.xsd");
            return ds;
        }
		#endregion

	}
}
