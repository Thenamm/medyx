using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

namespace Dzual.CategoryList
{
    [Serializable()]
    public class DMTBYT_XuatTra
    {
        #region State Fields

        private String _maTB;
        private String _tenTB;
        private String _maDVT;
        private String _maNhom;
        private String _maChungLoai;
        private String _maKho;
        private String _maKhoa;
        private String _maNoiSua;
        private String _maQG;
        private String _maBarCode;
        private String _maNSX;
        private Int32 _namSX;
        private String _serialNo;
        private String _model;
        private String _maTinhTrang;
        private String _tanSuatSuDung;
        private Int32 _khauhao;
        private Byte _maKHBaoTri;
        private Boolean _baoTriDinhKy;
        private String _kHTuNgay;
        private String _kHDenNgay;
        private Decimal _gianhap;
        private String _nguonKP;
        private String _ngayHopDong;
        private String _soHopDong;
        private String _maNCC;
        private String _ngayMua;
        private Int32 _thoiGianBH;
        private String _ngaySuDung;
        private String _anhTB;
        private String _ghichu;
        private String _maMay;
        private String _ngayLap;
        private String _nguoiLap;
        private String _ngaySD;
        private String _nguoiSD;
        private Boolean _huy;
        private String _ngayHuy;
        private String _nguoiHuy;
        private String _tenDVT;
        private String _tenNhom;
        private String _tenChungLoai;
        private String _tenKho;
        private String _tenKhoa;
        private String _tenNoiSua;
        private String _tenQG;
        private String _tenNSX;
        private String _tenTrangThai;
        private String _keHoach;
        private Int32 _thoiGianTHKeHoach;
        private String _tenNCC;
        private String _tenNguoiLap;
        private String _tenNguoiSD;
        private String _tenNguoiHuy;
        private String _tenNguon;
        private int _ordernumber;
        #endregion

        #region Business Properties and Methods
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
        public String MaDVT
        {
            get
            {
                return _maDVT;
            }
            set
            {
                _maDVT = value;
            }
        }
        public String MaNhom
        {
            get
            {
                return _maNhom;
            }
            set
            {
                _maNhom = value;
            }
        }
        public String MaChungLoai
        {
            get
            {
                return _maChungLoai;
            }
            set
            {
                _maChungLoai = value;
            }
        }
        public String MaKho
        {
            get
            {
                return _maKho;
            }
            set
            {
                _maKho = value;
            }
        }
        public String MaKhoa
        {
            get
            {
                return _maKhoa;
            }
            set
            {
                _maKhoa = value;
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
        public String MaQG
        {
            get
            {
                return _maQG;
            }
            set
            {
                _maQG = value;
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
        public String MaNSX
        {
            get
            {
                return _maNSX;
            }
            set
            {
                _maNSX = value;
            }
        }
        public Int32 NamSX
        {
            get
            {
                return _namSX;
            }
            set
            {
                _namSX = value;
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
        public String MaTinhTrang
        {
            get
            {
                return _maTinhTrang;
            }
            set
            {
                _maTinhTrang = value;
            }
        }
        public String TanSuatSuDung
        {
            get
            {
                return _tanSuatSuDung;
            }
            set
            {
                _tanSuatSuDung = value;
            }
        }
        public Int32 Khauhao
        {
            get
            {
                return _khauhao;
            }
            set
            {
                _khauhao = value;
            }
        }
        public Byte MaKHBaoTri
        {
            get
            {
                return _maKHBaoTri;
            }
            set
            {
                _maKHBaoTri = value;
            }
        }
        public Boolean BaoTriDinhKy
        {
            get
            {
                return _baoTriDinhKy;
            }
            set
            {
                _baoTriDinhKy = value;
            }
        }
        public String KHTuNgay
        {
            get
            {
                return _kHTuNgay;
            }
            set
            {
                _kHTuNgay = value;
            }
        }
        public String KHDenNgay
        {
            get
            {
                return _kHDenNgay;
            }
            set
            {
                _kHDenNgay = value;
            }
        }
        public Decimal Gianhap
        {
            get
            {
                return _gianhap;
            }
            set
            {
                _gianhap = value;
            }
        }
        public String NguonKP
        {
            get
            {
                return _nguonKP;
            }
            set
            {
                _nguonKP = value;
            }
        }
        public String NgayHopDong
        {
            get
            {
                return _ngayHopDong;
            }
            set
            {
                _ngayHopDong = value;
            }
        }
        public String SoHopDong
        {
            get
            {
                return _soHopDong;
            }
            set
            {
                _soHopDong = value;
            }
        }
        public String MaNCC
        {
            get
            {
                return _maNCC;
            }
            set
            {
                _maNCC = value;
            }
        }
        public String NgayMua
        {
            get
            {
                return _ngayMua;
            }
            set
            {
                _ngayMua = value;
            }
        }
        public Int32 ThoiGianBH
        {
            get
            {
                return _thoiGianBH;
            }
            set
            {
                _thoiGianBH = value;
            }
        }
        public String NgaySuDung
        {
            get
            {
                return _ngaySuDung;
            }
            set
            {
                _ngaySuDung = value;
            }
        }
        public String AnhTB
        {
            get
            {
                return _anhTB;
            }
            set
            {
                _anhTB = value;
            }
        }
        public String Ghichu
        {
            get
            {
                return _ghichu;
            }
            set
            {
                _ghichu = value;
            }
        }
        public String MaMay
        {
            get
            {
                return _maMay;
            }
            set
            {
                _maMay = value;
            }
        }
        public String NgayLap
        {
            get
            {
                return _ngayLap;
            }
            set
            {
                _ngayLap = value;
            }
        }
        public String NguoiLap
        {
            get
            {
                return _nguoiLap;
            }
            set
            {
                _nguoiLap = value;
            }
        }
        public String NgaySD
        {
            get
            {
                return _ngaySD;
            }
            set
            {
                _ngaySD = value;
            }
        }
        public String NguoiSD
        {
            get
            {
                return _nguoiSD;
            }
            set
            {
                _nguoiSD = value;
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
        public String NgayHuy
        {
            get
            {
                return _ngayHuy;
            }
            set
            {
                _ngayHuy = value;
            }
        }
        public String NguoiHuy
        {
            get
            {
                return _nguoiHuy;
            }
            set
            {
                _nguoiHuy = value;
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
        public String TenNhom
        {
            get
            {
                return _tenNhom;
            }
            set
            {
                _tenNhom = value;
            }
        }
        public String TenChungLoai
        {
            get
            {
                return _tenChungLoai;
            }
            set
            {
                _tenChungLoai = value;
            }
        }
        public String TenKho
        {
            get
            {
                return _tenKho;
            }
            set
            {
                _tenKho = value;
            }
        }
        public String TenKhoa
        {
            get
            {
                return _tenKhoa;
            }
            set
            {
                _tenKhoa = value;
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
        public String TenQG
        {
            get
            {
                return _tenQG;
            }
            set
            {
                _tenQG = value;
            }
        }
        public String TenNSX
        {
            get
            {
                return _tenNSX;
            }
            set
            {
                _tenNSX = value;
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
        public String KeHoach
        {
            get
            {
                return _keHoach;
            }
            set
            {
                _keHoach = value;
            }
        }
        
        public Int32 ThoiGianTHKeHoach
        {
            get
            {
                return _thoiGianTHKeHoach;
            }
            set
            {
                _thoiGianTHKeHoach = value;
            }
        }
        public String TenNCC
        {
            get
            {
                return _tenNCC;
            }
            set
            {
                _tenNCC = value;
            }
        }
        public String TenNguoiLap
        {
            get
            {
                return _tenNguoiLap;
            }
            set
            {
                _tenNguoiLap = value;
            }
        }
        public String TenNguoiSD
        {
            get
            {
                return _tenNguoiSD;
            }
            set
            {
                _tenNguoiSD = value;
            }
        }
        public String TenNguoiHuy
        {
            get
            {
                return _tenNguoiHuy;
            }
            set
            {
                _tenNguoiHuy = value;
            }
        }

        public String TenNguon
        {
            get
            {
                return _tenNguon;
            }
            set
            {
                _tenNguon = value;
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
        public DMTBYT_XuatTra()
        {

        }
        public DMTBYT_XuatTra(IDataReader dr, int Ordernumber)
        {
            _ordernumber = Ordernumber;
            if (dr["MaTB"] != null && dr["MaTB"].GetType().Name != "DBNull") _maTB = Convert.ToString(dr["MaTB"]);
            if (dr["TenTB"] != null && dr["TenTB"].GetType().Name != "DBNull") _tenTB = Convert.ToString(dr["TenTB"]);
            if (dr["MaDVT"] != null && dr["MaDVT"].GetType().Name != "DBNull") _maDVT = Convert.ToString(dr["MaDVT"]);
            if (dr["MaNhom"] != null && dr["MaNhom"].GetType().Name != "DBNull") _maNhom = Convert.ToString(dr["MaNhom"]);
            if (dr["MaChungLoai"] != null && dr["MaChungLoai"].GetType().Name != "DBNull") _maChungLoai = Convert.ToString(dr["MaChungLoai"]);
            if (dr["MaKho"] != null && dr["MaKho"].GetType().Name != "DBNull") _maKho = Convert.ToString(dr["MaKho"]);
            if (dr["MaKhoa"] != null && dr["MaKhoa"].GetType().Name != "DBNull") _maKhoa = Convert.ToString(dr["MaKhoa"]);
            if (dr["MaNoiSua"] != null && dr["MaNoiSua"].GetType().Name != "DBNull") _maNoiSua = Convert.ToString(dr["MaNoiSua"]);
            if (dr["MaQG"] != null && dr["MaQG"].GetType().Name != "DBNull") _maQG = Convert.ToString(dr["MaQG"]);
            if (dr["MaBarCode"] != null && dr["MaBarCode"].GetType().Name != "DBNull") _maBarCode = Convert.ToString(dr["MaBarCode"]);
            if (dr["MaNSX"] != null && dr["MaNSX"].GetType().Name != "DBNull") _maNSX = Convert.ToString(dr["MaNSX"]);
            if (dr["NamSX"] != null && dr["NamSX"].GetType().Name != "DBNull") _namSX = Convert.ToInt32(dr["NamSX"]);
            if (dr["SerialNo"] != null && dr["SerialNo"].GetType().Name != "DBNull") _serialNo = Convert.ToString(dr["SerialNo"]);
            if (dr["Model"] != null && dr["Model"].GetType().Name != "DBNull") _model = Convert.ToString(dr["Model"]);
            if (dr["MaTinhTrang"] != null && dr["MaTinhTrang"].GetType().Name != "DBNull") _maTinhTrang = Convert.ToString(dr["MaTinhTrang"]);
            if (dr["TanSuatSuDung"] != null && dr["TanSuatSuDung"].GetType().Name != "DBNull") _tanSuatSuDung = Convert.ToString(dr["TanSuatSuDung"]);
            if (dr["Khauhao"] != null && dr["Khauhao"].GetType().Name != "DBNull") _khauhao = Convert.ToInt32(dr["Khauhao"]);
            if (dr["MaKHBaoTri"] != null && dr["MaKHBaoTri"].GetType().Name != "DBNull") _maKHBaoTri = Convert.ToByte(dr["MaKHBaoTri"]);
            if (dr["BaoTriDinhKy"] != null && dr["BaoTriDinhKy"].GetType().Name != "DBNull") _baoTriDinhKy = Convert.ToBoolean(dr["BaoTriDinhKy"]);
            if (dr["KHTuNgay"] != null && dr["KHTuNgay"].GetType().Name != "DBNull") _kHTuNgay = Convert.ToDateTime(dr["KHTuNgay"]).ToString("dd/MM/yyyy");
            if (dr["KHDenNgay"] != null && dr["KHDenNgay"].GetType().Name != "DBNull") _kHDenNgay = Convert.ToDateTime(dr["KHDenNgay"]).ToString("dd/MM/yyyy");
            if (dr["Gianhap"] != null && dr["Gianhap"].GetType().Name != "DBNull") _gianhap = Convert.ToDecimal(dr["Gianhap"]);
            if (dr["NguonKP"] != null && dr["NguonKP"].GetType().Name != "DBNull") _nguonKP = Convert.ToString(dr["NguonKP"]);
            if (dr["NgayHopDong"] != null && dr["NgayHopDong"].GetType().Name != "DBNull") _ngayHopDong = Convert.ToDateTime(dr["NgayHopDong"]).ToString("dd/MM/yyyy");
            if (dr["SoHopDong"] != null && dr["SoHopDong"].GetType().Name != "DBNull") _soHopDong = Convert.ToString(dr["SoHopDong"]);
            if (dr["MaNCC"] != null && dr["MaNCC"].GetType().Name != "DBNull") _maNCC = Convert.ToString(dr["MaNCC"]);
            if (dr["NgayMua"] != null && dr["NgayMua"].GetType().Name != "DBNull") _ngayMua = Convert.ToDateTime(dr["NgayMua"]).ToString("dd/MM/yyyy");
            if (dr["ThoiGianBH"] != null && dr["ThoiGianBH"].GetType().Name != "DBNull") _thoiGianBH = Convert.ToInt32(dr["ThoiGianBH"]);
            if (dr["NgaySuDung"] != null && dr["NgaySuDung"].GetType().Name != "DBNull") _ngaySuDung = Convert.ToDateTime(dr["NgaySuDung"]).ToString("dd/MM/yyyy");
            if (dr["AnhTB"] != null && dr["AnhTB"].GetType().Name != "DBNull") _anhTB = Convert.ToString(dr["AnhTB"]);
            if (dr["Ghichu"] != null && dr["Ghichu"].GetType().Name != "DBNull") _ghichu = Convert.ToString(dr["Ghichu"]);
            if (dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
            if (dr["NgayLap"] != null && dr["NgayLap"].GetType().Name != "DBNull") _ngayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            if (dr["NguoiLap"] != null && dr["NguoiLap"].GetType().Name != "DBNull") _nguoiLap = Convert.ToString(dr["NguoiLap"]);
            if (dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            if (dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
            if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
            if (dr["NgayHuy"] != null && dr["NgayHuy"].GetType().Name != "DBNull") _ngayHuy = Convert.ToDateTime(dr["NgayHuy"]).ToString("dd/MM/yyyy");
            if (dr["NguoiHuy"] != null && dr["NguoiHuy"].GetType().Name != "DBNull") _nguoiHuy = Convert.ToString(dr["NguoiHuy"]);
            if (dr["TenDVT"] != null && dr["TenDVT"].GetType().Name != "DBNull") _tenDVT = Convert.ToString(dr["TenDVT"]);
            if (dr["TenNhom"] != null && dr["TenNhom"].GetType().Name != "DBNull") _tenNhom = Convert.ToString(dr["TenNhom"]);
            if (dr["TenChungLoai"] != null && dr["TenChungLoai"].GetType().Name != "DBNull") _tenChungLoai = Convert.ToString(dr["TenChungLoai"]);
            if (dr["TenKho"] != null && dr["TenKho"].GetType().Name != "DBNull") _tenKho = Convert.ToString(dr["TenKho"]);
            if (dr["TenKhoa"] != null && dr["TenKhoa"].GetType().Name != "DBNull") _tenKhoa = Convert.ToString(dr["TenKhoa"]);
            if (dr["TenNoiSua"] != null && dr["TenNoiSua"].GetType().Name != "DBNull") _tenNoiSua = Convert.ToString(dr["TenNoiSua"]);
            if (dr["TenQG"] != null && dr["TenQG"].GetType().Name != "DBNull") _tenQG = Convert.ToString(dr["TenQG"]);
            if (dr["TenNSX"] != null && dr["TenNSX"].GetType().Name != "DBNull") _tenNSX = Convert.ToString(dr["TenNSX"]);
            if (dr["TenTrangThai"] != null && dr["TenTrangThai"].GetType().Name != "DBNull") _tenTrangThai = Convert.ToString(dr["TenTrangThai"]);
            if (dr["KeHoach"] != null && dr["KeHoach"].GetType().Name != "DBNull") _keHoach = Convert.ToString(dr["KeHoach"]);
            if (dr["ThoiGianTHKeHoach"] != null && dr["ThoiGianTHKeHoach"].GetType().Name != "DBNull") _thoiGianTHKeHoach = Convert.ToInt32(dr["ThoiGianTHKeHoach"]);
            if (dr["TenNCC"] != null && dr["TenNCC"].GetType().Name != "DBNull") _tenNCC = Convert.ToString(dr["TenNCC"]);
            if (dr["TenNguoiLap"] != null && dr["TenNguoiLap"].GetType().Name != "DBNull") _tenNguoiLap = Convert.ToString(dr["TenNguoiLap"]);
            if (dr["TenNguoiSD"] != null && dr["TenNguoiSD"].GetType().Name != "DBNull") _tenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            if (dr["TenNguoiHuy"] != null && dr["TenNguoiHuy"].GetType().Name != "DBNull") _tenNguoiHuy = Convert.ToString(dr["TenNguoiHuy"]);
            if (dr["TenNguon"] != null && dr["TenNguon"].GetType().Name != "DBNull") _tenNguon = Convert.ToString(dr["TenNguon"]);
        }
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }
        #endregion

    }
}
