using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.TBYT;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
////

namespace HTC.Business.TBYT
{
    [Serializable()]
    public partial class TBVTPhieuXuat
    {
        #region State Fields

        private String _maPX;
        private String _noixuat;
        private String _ngayxuat;
        private String _ngayXuatTT;
        private String _noinhap;
        private Byte _loaiphieu;
        private String _soCT;
        private String _nVXuat;
        private String _nVNhan;
        private String _ghichu;
        private Boolean _huy;
        private String _ngaySD;
        private String _nguoiSD;
        private String _ngayLap;
        private String _nguoiLap;
        private String _ngayHuy;
        private String _nguoiHuy;
        private String _ngaySD1;
        private String _nguoiSD1;
        private Boolean _daphat;
        private Boolean _khoaYC;
        private String _maMay;
        private Boolean _daDuyet;
        private String _doiTuong;
        private String _tenNoiXuat;
        private String _tenNoiNhap;
        private String _tenNVXuat;
        private String _tenNVNhan;
        private String _tenNguoiSD;
        private String _tenNguoiLap;
        private String _tenNguoiHuy;
        private String _tenNguoiSD1;
        private int _ordernumber;
        #endregion

        #region Business Properties and Methods
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
        public String Noixuat
        {
            get
            {
                return _noixuat;
            }
            set
            {
                _noixuat = value;
            }
        }
        public String Ngayxuat
        {
            get
            {
                return _ngayxuat;
            }
            set
            {
                _ngayxuat = value;
            }
        }
        public String NgayXuatTT
        {
            get
            {
                return _ngayXuatTT;
            }
            set
            {
                _ngayXuatTT = value;
            }
        }
        public String Noinhap
        {
            get
            {
                return _noinhap;
            }
            set
            {
                _noinhap = value;
            }
        }
        public Byte Loaiphieu
        {
            get
            {
                return _loaiphieu;
            }
            set
            {
                _loaiphieu = value;
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
        public String NVXuat
        {
            get
            {
                return _nVXuat;
            }
            set
            {
                _nVXuat = value;
            }
        }
        public String NVNhan
        {
            get
            {
                return _nVNhan;
            }
            set
            {
                _nVNhan = value;
            }
        }
        public String ghichu
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
        public Boolean Daphat
        {
            get
            {
                return _daphat;
            }
            set
            {
                _daphat = value;
            }
        }
        public Boolean KhoaYC
        {
            get
            {
                return _khoaYC;
            }
            set
            {
                _khoaYC = value;
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
        public Boolean DaDuyet
        {
            get
            {
                return _daDuyet;
            }
            set
            {
                _daDuyet = value;
            }
        }
        public String DoiTuong
        {
            get
            {
                return _doiTuong;
            }
            set
            {
                _doiTuong = value;
            }
        }
        public String TenNoiXuat
        {
            get
            {
                return _tenNoiXuat;
            }
            set
            {
                _tenNoiXuat = value;
            }
        }
        public String TenNoiNhap
        {
            get
            {
                return _tenNoiNhap;
            }
            set
            {
                _tenNoiNhap = value;
            }
        }
        public String TenNVXuat
        {
            get
            {
                return _tenNVXuat;
            }
            set
            {
                _tenNVXuat = value;
            }
        }
        public String TenNVNhan
        {
            get
            {
                return _tenNVNhan;
            }
            set
            {
                _tenNVNhan = value;
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
        public String TenNguoiSD1
        {
            get
            {
                return _tenNguoiSD1;
            }
            set
            {
                _tenNguoiSD1 = value;
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
        public TBVTPhieuXuat()
        {

        }
        public TBVTPhieuXuat(IDataReader dr, int Ordernumber)
        {
            _ordernumber = Ordernumber;
            if (dr["MaPX"] != null && dr["MaPX"].GetType().Name != "DBNull") _maPX = Convert.ToString(dr["MaPX"]);
            if (dr["Noixuat"] != null && dr["Noixuat"].GetType().Name != "DBNull") _noixuat = Convert.ToString(dr["Noixuat"]);
            if (dr["Ngayxuat"] != null && dr["Ngayxuat"].GetType().Name != "DBNull") _ngayxuat = Convert.ToDateTime(dr["Ngayxuat"]).ToString("dd/MM/yyyy");
            if (dr["NgayXuatTT"] != null && dr["NgayXuatTT"].GetType().Name != "DBNull") _ngayXuatTT = Convert.ToDateTime(dr["NgayXuatTT"]).ToString("dd/MM/yyyy");
            if (dr["Noinhap"] != null && dr["Noinhap"].GetType().Name != "DBNull") _noinhap = Convert.ToString(dr["Noinhap"]);
            if (dr["Loaiphieu"] != null && dr["Loaiphieu"].GetType().Name != "DBNull") _loaiphieu = Convert.ToByte(dr["Loaiphieu"]);
            if (dr["SoCT"] != null && dr["SoCT"].GetType().Name != "DBNull") _soCT = Convert.ToString(dr["SoCT"]);
            if (dr["NVXuat"] != null && dr["NVXuat"].GetType().Name != "DBNull") _nVXuat = Convert.ToString(dr["NVXuat"]);
            if (dr["NVNhan"] != null && dr["NVNhan"].GetType().Name != "DBNull") _nVNhan = Convert.ToString(dr["NVNhan"]);
            if (dr["ghichu"] != null && dr["ghichu"].GetType().Name != "DBNull") _ghichu = Convert.ToString(dr["ghichu"]);
            if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
            if (dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            if (dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
            if (dr["NgayLap"] != null && dr["NgayLap"].GetType().Name != "DBNull") _ngayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            if (dr["NguoiLap"] != null && dr["NguoiLap"].GetType().Name != "DBNull") _nguoiLap = Convert.ToString(dr["NguoiLap"]);
            if (dr["NgayHuy"] != null && dr["NgayHuy"].GetType().Name != "DBNull") _ngayHuy = Convert.ToDateTime(dr["NgayHuy"]).ToString("dd/MM/yyyy");
            if (dr["NguoiHuy"] != null && dr["NguoiHuy"].GetType().Name != "DBNull") _nguoiHuy = Convert.ToString(dr["NguoiHuy"]);
            if (dr["NgaySD1"] != null && dr["NgaySD1"].GetType().Name != "DBNull") _ngaySD1 = Convert.ToDateTime(dr["NgaySD1"]).ToString("dd/MM/yyyy");
            if (dr["NguoiSD1"] != null && dr["NguoiSD1"].GetType().Name != "DBNull") _nguoiSD1 = Convert.ToString(dr["NguoiSD1"]);
            if (dr["Daphat"] != null && dr["Daphat"].GetType().Name != "DBNull") _daphat = Convert.ToBoolean(dr["Daphat"]);
            if (dr["KhoaYC"] != null && dr["KhoaYC"].GetType().Name != "DBNull") _khoaYC = Convert.ToBoolean(dr["KhoaYC"]);
            if (dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
            if (dr["DaDuyet"] != null && dr["DaDuyet"].GetType().Name != "DBNull") _daDuyet = Convert.ToBoolean(dr["DaDuyet"]);
            if (dr["DoiTuong"] != null && dr["DoiTuong"].GetType().Name != "DBNull") _doiTuong = Convert.ToString(dr["DoiTuong"]);
            if (dr["TenNoiXuat"] != null && dr["TenNoiXuat"].GetType().Name != "DBNull") _tenNoiXuat = Convert.ToString(dr["TenNoiXuat"]);
            if (dr["TenNoiNhap"] != null && dr["TenNoiNhap"].GetType().Name != "DBNull") _tenNoiNhap = Convert.ToString(dr["TenNoiNhap"]);
            if (dr["TenNVXuat"] != null && dr["TenNVXuat"].GetType().Name != "DBNull") _tenNVXuat = Convert.ToString(dr["TenNVXuat"]);
            if (dr["TenNVNhan"] != null && dr["TenNVNhan"].GetType().Name != "DBNull") _tenNVNhan = Convert.ToString(dr["TenNVNhan"]);
            if (dr["TenNguoiSD"] != null && dr["TenNguoiSD"].GetType().Name != "DBNull") _tenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            if (dr["TenNguoiLap"] != null && dr["TenNguoiLap"].GetType().Name != "DBNull") _tenNguoiLap = Convert.ToString(dr["TenNguoiLap"]);
            if (dr["TenNguoiHuy"] != null && dr["TenNguoiHuy"].GetType().Name != "DBNull") _tenNguoiHuy = Convert.ToString(dr["TenNguoiHuy"]);
            if (dr["TenNguoiSD1"] != null && dr["TenNguoiSD1"].GetType().Name != "DBNull") _tenNguoiSD1 = Convert.ToString(dr["TenNguoiSD1"]);
        }
        #endregion

        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        #region Data Access

        public static TBVTPhieuXuat GetByMaPX(String MAPX, Byte Loai, Boolean DaDuyet, Boolean DaPhat)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_GET", MAPX, Loai, DaDuyet, DaPhat)))
            {
                while (dr.Read())
                {
                    return new TBVTPhieuXuat(dr, 1);
                }
            }
            return new TBVTPhieuXuat();
        }

        public String Add()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuXuat_CREATE", _noixuat, _ngayxuat, _ngayXuatTT, _noinhap, _loaiphieu, _soCT, _nVXuat, _nVNhan, _ghichu, _huy, _nguoiLap, _khoaYC, _maMay, _daphat, _daDuyet, _doiTuong));
        }

        public void Edit()
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuXuat_UPDATE", _maPX, _noixuat, _ngayxuat, _ngayXuatTT, _noinhap, _loaiphieu, _soCT, _nVXuat, _nVNhan, _ghichu, _huy, _nguoiSD, _maMay, _daphat, _daDuyet, _doiTuong);
        }

        public void Delete()
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuXuat_DELETED", _maPX, _maMay, _nguoiSD);
        }

        #endregion

    }
}
