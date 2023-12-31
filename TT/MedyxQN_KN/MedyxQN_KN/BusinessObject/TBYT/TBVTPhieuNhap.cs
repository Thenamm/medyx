using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.TBYT;
using HTC.Business;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
////

namespace HTC.Business.TBYT
{
    [Serializable()]
    public partial class TBVTPhieuNhap
    {
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        #region State Fields

        private String _maPN;
        private String _maNCC;
        private String _soHD;
        private String _soCT;
        private String _soHDon;
        private String _makho;
        private Boolean _thanhtoan;
        private String _ngayTToan;
        private String _ngayNhapTT;
        private String _nVNhap;
        private Decimal _vAT = 1;
        private Decimal _tong;
        private String _ghichu;
        private Boolean _huy;
        private String _ngaySD;
        private String _nguoiSD;
        private String _ngaySD1;
        private String _nguoiSD1;
        private String _nguoigiao;
        private String _ngayLap;
        private String _nguoiLap;
        private String _ngayhuy;
        private String _nguoihuy;
        private String _maMay;
        private String _maHinhThuc;
        private String _maNguon;
        private String _ngayHDon;
        private String _ngayPnhap;
        private Decimal _iD_LEDGER;
        private String _tenNCC;
        private String _tENKHO;
        private String _tENNVNHAP;
        private String _tENNGUOILAP;
        private String _tENNGUOISD;
        private String _tENNGUOIHUY;
        private String _tenHinhThuc;
        private String _tenNguon;
        private int _ordernumber;
        #endregion

        #region Business Properties and Methods
        public String MaPN
        {
            get
            {
                return _maPN;
            }
            set
            {
                _maPN = value;
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
        public String SoHD
        {
            get
            {
                return _soHD;
            }
            set
            {
                _soHD = value;
            }
        }
        public String SoCT
        {
            get
            {
                return _soCT;
            }
            set
            {
                _soCT = value;
            }
        }
        public String SoHDon
        {
            get
            {
                return _soHDon;
            }
            set
            {
                _soHDon = value;
            }
        }
        public String Makho
        {
            get
            {
                return _makho;
            }
            set
            {
                _makho = value;
            }
        }
        public Boolean Thanhtoan
        {
            get
            {
                return _thanhtoan;
            }
            set
            {
                _thanhtoan = value;
            }
        }
        public String NgayTToan
        {
            get
            {
                return _ngayTToan;
            }
            set
            {
                _ngayTToan = value;
            }
        }
        public String NgayNhapTT
        {
            get
            {
                return _ngayNhapTT;
            }
            set
            {
                _ngayNhapTT = value;
            }
        }
        public String NVNhap
        {
            get
            {
                return _nVNhap;
            }
            set
            {
                _nVNhap = value;
            }
        }
        public Decimal VAT
        {
            get
            {
                return _vAT;
            }
            set
            {
                _vAT = value;
            }
        }
        public Decimal Tong
        {
            get
            {
                return _tong;
            }
            set
            {
                _tong = value;
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
        public String NgaySD1
        {
            get
            {
                return _ngaySD1;
            }
            set
            {
                _ngaySD1 = value;
            }
        }
        public String NguoiSD1
        {
            get
            {
                return _nguoiSD1;
            }
            set
            {
                _nguoiSD1 = value;
            }
        }
        public String Nguoigiao
        {
            get
            {
                return _nguoigiao;
            }
            set
            {
                _nguoigiao = value;
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
        public String Ngayhuy
        {
            get
            {
                return _ngayhuy;
            }
            set
            {
                _ngayhuy = value;
            }
        }
        public String Nguoihuy
        {
            get
            {
                return _nguoihuy;
            }
            set
            {
                _nguoihuy = value;
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
        public String MaHinhThuc
        {
            get
            {
                return _maHinhThuc;
            }
            set
            {
                _maHinhThuc = value;
            }
        }
        public String MaNguon
        {
            get
            {
                return _maNguon;
            }
            set
            {
                _maNguon = value;
            }
        }
        public String NgayHDon
        {
            get
            {
                return _ngayHDon;
            }
            set
            {
                _ngayHDon = value;
            }
        }
        public String NgayPnhap
        {
            get
            {
                return _ngayPnhap;
            }
            set
            {
                _ngayPnhap = value;
            }
        }
        public Decimal ID_LEDGER
        {
            get
            {
                return _iD_LEDGER;
            }
            set
            {
                _iD_LEDGER = value;
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
        public String TENKHO
        {
            get
            {
                return _tENKHO;
            }
            set
            {
                _tENKHO = value;
            }
        }
        public String TENNVNHAP
        {
            get
            {
                return _tENNVNHAP;
            }
            set
            {
                _tENNVNHAP = value;
            }
        }
        public String TENNGUOILAP
        {
            get
            {
                return _tENNGUOILAP;
            }
            set
            {
                _tENNGUOILAP = value;
            }
        }
        public String TENNGUOISD
        {
            get
            {
                return _tENNGUOISD;
            }
            set
            {
                _tENNGUOISD = value;
            }
        }
        public String TENNGUOIHUY
        {
            get
            {
                return _tENNGUOIHUY;
            }
            set
            {
                _tENNGUOIHUY = value;
            }
        }
        public String TenHinhThuc
        {
            get
            {
                return _tenHinhThuc;
            }
            set
            {
                _tenHinhThuc = value;
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
        public TBVTPhieuNhap()
        {

        }
        public TBVTPhieuNhap(IDataReader dr, int Ordernumber)
        {
            _ordernumber = Ordernumber;
            if (dr["MaPN"] != null && dr["MaPN"].GetType().Name != "DBNull") _maPN = Convert.ToString(dr["MaPN"]);
            if (dr["MaNCC"] != null && dr["MaNCC"].GetType().Name != "DBNull") _maNCC = Convert.ToString(dr["MaNCC"]);
            if (dr["SoHD"] != null && dr["SoHD"].GetType().Name != "DBNull") _soHD = Convert.ToString(dr["SoHD"]);
            if (dr["SoCT"] != null && dr["SoCT"].GetType().Name != "DBNull") _soCT = Convert.ToString(dr["SoCT"]);
            if (dr["SoHDon"] != null && dr["SoHDon"].GetType().Name != "DBNull") _soHDon = Convert.ToString(dr["SoHDon"]);
            if (dr["Makho"] != null && dr["Makho"].GetType().Name != "DBNull") _makho = Convert.ToString(dr["Makho"]);
            if (dr["Thanhtoan"] != null && dr["Thanhtoan"].GetType().Name != "DBNull") _thanhtoan = Convert.ToBoolean(dr["Thanhtoan"]);
            if (dr["NgayTToan"] != null && dr["NgayTToan"].GetType().Name != "DBNull") _ngayTToan = Convert.ToDateTime(dr["NgayTToan"]).ToString("dd/MM/yyyy");
            if (dr["NgayNhapTT"] != null && dr["NgayNhapTT"].GetType().Name != "DBNull") _ngayNhapTT = Convert.ToDateTime(dr["NgayNhapTT"]).ToString("dd/MM/yyyy");
            if (dr["NVNhap"] != null && dr["NVNhap"].GetType().Name != "DBNull") _nVNhap = Convert.ToString(dr["NVNhap"]);
            if (dr["VAT"] != null && dr["VAT"].GetType().Name != "DBNull") _vAT = Convert.ToDecimal(dr["VAT"]);
            if (dr["Tong"] != null && dr["Tong"].GetType().Name != "DBNull") _tong = Convert.ToDecimal(dr["Tong"]);
            if (dr["Ghichu"] != null && dr["Ghichu"].GetType().Name != "DBNull") _ghichu = Convert.ToString(dr["Ghichu"]);
            if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
            if (dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            if (dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
            if (dr["NgaySD1"] != null && dr["NgaySD1"].GetType().Name != "DBNull") _ngaySD1 = Convert.ToDateTime(dr["NgaySD1"]).ToString("dd/MM/yyyy");
            if (dr["NguoiSD1"] != null && dr["NguoiSD1"].GetType().Name != "DBNull") _nguoiSD1 = Convert.ToString(dr["NguoiSD1"]);
            if (dr["Nguoigiao"] != null && dr["Nguoigiao"].GetType().Name != "DBNull") _nguoigiao = Convert.ToString(dr["Nguoigiao"]);
            if (dr["NgayLap"] != null && dr["NgayLap"].GetType().Name != "DBNull") _ngayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            if (dr["NguoiLap"] != null && dr["NguoiLap"].GetType().Name != "DBNull") _nguoiLap = Convert.ToString(dr["NguoiLap"]);
            if (dr["Ngayhuy"] != null && dr["Ngayhuy"].GetType().Name != "DBNull") _ngayhuy = Convert.ToDateTime(dr["Ngayhuy"]).ToString("dd/MM/yyyy");
            if (dr["Nguoihuy"] != null && dr["Nguoihuy"].GetType().Name != "DBNull") _nguoihuy = Convert.ToString(dr["Nguoihuy"]);
            if (dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
            if (dr["MaHinhThuc"] != null && dr["MaHinhThuc"].GetType().Name != "DBNull") _maHinhThuc = Convert.ToString(dr["MaHinhThuc"]);
            if (dr["MaNguon"] != null && dr["MaNguon"].GetType().Name != "DBNull") _maNguon = Convert.ToString(dr["MaNguon"]);
            if (dr["NgayHDon"] != null && dr["NgayHDon"].GetType().Name != "DBNull") _ngayHDon = Convert.ToDateTime(dr["NgayHDon"]).ToString("dd/MM/yyyy");
            if (dr["NgayPnhap"] != null && dr["NgayPnhap"].GetType().Name != "DBNull") _ngayPnhap = Convert.ToDateTime(dr["NgayPnhap"]).ToString("dd/MM/yyyy");
            if (dr["ID_LEDGER"] != null && dr["ID_LEDGER"].GetType().Name != "DBNull") _iD_LEDGER = Convert.ToDecimal(dr["ID_LEDGER"]);
            if (dr["TenNCC"] != null && dr["TenNCC"].GetType().Name != "DBNull") _tenNCC = Convert.ToString(dr["TenNCC"]);
            if (dr["TENKHO"] != null && dr["TENKHO"].GetType().Name != "DBNull") _tENKHO = Convert.ToString(dr["TENKHO"]);
            if (dr["TENNVNHAP"] != null && dr["TENNVNHAP"].GetType().Name != "DBNull") _tENNVNHAP = Convert.ToString(dr["TENNVNHAP"]);
            if (dr["TENNGUOILAP"] != null && dr["TENNGUOILAP"].GetType().Name != "DBNull") _tENNGUOILAP = Convert.ToString(dr["TENNGUOILAP"]);
            if (dr["TENNGUOISD"] != null && dr["TENNGUOISD"].GetType().Name != "DBNull") _tENNGUOISD = Convert.ToString(dr["TENNGUOISD"]);
            if (dr["TENNGUOIHUY"] != null && dr["TENNGUOIHUY"].GetType().Name != "DBNull") _tENNGUOIHUY = Convert.ToString(dr["TENNGUOIHUY"]);
            if (dr["TenHinhThuc"] != null && dr["TenHinhThuc"].GetType().Name != "DBNull") _tenHinhThuc = Convert.ToString(dr["TenHinhThuc"]);
            if (dr["TenNguon"] != null && dr["TenNguon"].GetType().Name != "DBNull") _tenNguon = Convert.ToString(dr["TenNguon"]);
        }

        public static TBVTPhieuNhap GetByMaPN(String MaPN)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuNhap_GET", MaPN)))
            {
                while (dr.Read())
                {
                    return new TBVTPhieuNhap(dr, 1);
                }
            }
            return new TBVTPhieuNhap();
        }

        public String Add()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuNhap_CREATE", _maNCC, _soHD, _soCT, string.IsNullOrEmpty(_ngayPnhap) ? new Nullable<DateTime>() : DateTime.Parse(_ngayPnhap), _makho, _vAT, _thanhtoan, string.IsNullOrEmpty(_ngayTToan) ? new Nullable<DateTime>() : DateTime.Parse(_ngayTToan), string.IsNullOrEmpty(_ngayNhapTT) ? new Nullable<DateTime>() : DateTime.Parse(_ngayNhapTT), _nVNhap, _tong, _ghichu, _huy, _nguoiLap, _maMay, _nguoigiao, _maNguon, _maHinhThuc, _soHDon, string.IsNullOrEmpty(_ngayHDon) ? new Nullable<DateTime>() : DateTime.Parse(_ngayHDon)));
        }

        public void Edit()
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuNhap_UPDATE", _maPN, _maNCC, _soHD, _soCT, string.IsNullOrEmpty(_ngayPnhap) ? new Nullable<DateTime>() : DateTime.Parse(_ngayPnhap), _makho, _vAT, _thanhtoan, string.IsNullOrEmpty(_ngayTToan) ? new Nullable<DateTime>() : DateTime.Parse(_ngayTToan), string.IsNullOrEmpty(_ngayNhapTT) ? new Nullable<DateTime>() : DateTime.Parse(_ngayNhapTT), _nVNhap, _tong, _ghichu, _huy, _nguoiSD, _ngaySD1, _nguoiSD1, _nguoigiao, _maNguon, _maHinhThuc, _soHDon, string.IsNullOrEmpty(_ngayHDon) ? new Nullable<DateTime>() : DateTime.Parse(_ngayHDon));
        }

        public void Delete()
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuNhap_DELETED", _maPN, string.IsNullOrEmpty(_ngaySD) ? new Nullable<DateTime>() : DateTime.Parse(_ngaySD), _maMay, _nguoiSD);
        }
        #endregion
	}

    
}
