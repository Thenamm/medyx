using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;
////


namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBVTPhieuNhap_C
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
        private Decimal _sTT;
        private String _maVT;
        private Decimal _vat;
        private Decimal _soluong;
        private String _hanSD;
        private Decimal _donGia;
        private String _soLo;
        private Boolean _huy;
        private String _ghichu;
        private String _ngaySD;
        private String _nguoiSD;
        private String _ngayLap;
        private String _nguoiLap;
        private String _maMay;
        private String _tENTM;
        private String _tenHamLuong;
        private String _tENDVT;
        private String _tenNguoiLap;
        private String _tenNguoiSD;
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
        public String MaVT
        {
            get
            {
                return _maVT;
            }
            set
            {
                _maVT = value;
            }
        }
        public Decimal vat
        {
            get
            {
                return _vat;
            }
            set
            {
                _vat = value;
            }
        }
        public Decimal Soluong
        {
            get
            {
                return _soluong;
            }
            set
            {
                _soluong = value;
            }
        }

        public Decimal ThanhTien
        {
            get
            {
                if (_vat == 0)
                {
                    return _soluong * _donGia;
                }
                else
                {
                    return (_soluong * _donGia) + _soluong * _donGia * _vat / 100;
                }
            }
        }

        public String HanSD
        {
            get
            {
                return _hanSD;
            }
            set
            {
                _hanSD = value;
            }
        }
        public Decimal DonGia
        {
            get
            {
                return _donGia;
            }
            set
            {
                _donGia = value;
            }
        }
        public String SoLo
        {
            get
            {
                return _soLo;
            }
            set
            {
                _soLo = value;
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
        public String TENTM
        {
            get
            {
                return _tENTM;
            }
            set
            {
                _tENTM = value;
            }
        }
        public String TenHamLuong
        {
            get
            {
                return _tenHamLuong;
            }
            set
            {
                _tenHamLuong = value;
            }
        }
        public String TENDVT
        {
            get
            {
                return _tENDVT;
            }
            set
            {
                _tENDVT = value;
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
        public TBVTPhieuNhap_C()
        {

        }
        public TBVTPhieuNhap_C(IDataReader dr, int Ordernumber)
        {
            _ordernumber = Ordernumber;
            if (dr["MaPN"] != null && dr["MaPN"].GetType().Name != "DBNull") _maPN = Convert.ToString(dr["MaPN"]);
            if (dr["STT"] != null && dr["STT"].GetType().Name != "DBNull") _sTT = Convert.ToDecimal(dr["STT"]);
            if (dr["MaVT"] != null && dr["MaVT"].GetType().Name != "DBNull") _maVT = Convert.ToString(dr["MaVT"]);
            if (dr["vat"] != null && dr["vat"].GetType().Name != "DBNull") _vat = Convert.ToDecimal(dr["vat"]);
            if (dr["Soluong"] != null && dr["Soluong"].GetType().Name != "DBNull") _soluong = Convert.ToDecimal(dr["Soluong"]);
            if (dr["HanSD"] != null && dr["HanSD"].GetType().Name != "DBNull") _hanSD = Convert.ToDateTime(dr["HanSD"]) == DateTime.MinValue ? "" : Convert.ToDateTime(dr["HanSD"]).ToString("dd/MM/yyyy");
            if (dr["DonGia"] != null && dr["DonGia"].GetType().Name != "DBNull") _donGia = Convert.ToDecimal(dr["DonGia"]);
            if (dr["SoLo"] != null && dr["SoLo"].GetType().Name != "DBNull") _soLo = Convert.ToString(dr["SoLo"]);
            if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
            if (dr["Ghichu"] != null && dr["Ghichu"].GetType().Name != "DBNull") _ghichu = Convert.ToString(dr["Ghichu"]);
            if (dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]) == DateTime.MinValue ? "" : Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            if (dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
            if (dr["NgayLap"] != null && dr["NgayLap"].GetType().Name != "DBNull") _ngayLap = Convert.ToDateTime(dr["NgayLap"]) == DateTime.MinValue ? "" : Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            if (dr["NguoiLap"] != null && dr["NguoiLap"].GetType().Name != "DBNull") _nguoiLap = Convert.ToString(dr["NguoiLap"]);
            if (dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
            if (dr["TENTM"] != null && dr["TENTM"].GetType().Name != "DBNull") _tENTM = Convert.ToString(dr["TENTM"]);
            if (dr["TenHamLuong"] != null && dr["TenHamLuong"].GetType().Name != "DBNull") _tenHamLuong = Convert.ToString(dr["TenHamLuong"]);
            if (dr["TENDVT"] != null && dr["TENDVT"].GetType().Name != "DBNull") _tENDVT = Convert.ToString(dr["TENDVT"]);
            if (dr["TenNguoiLap"] != null && dr["TenNguoiLap"].GetType().Name != "DBNull") _tenNguoiLap = Convert.ToString(dr["TenNguoiLap"]);
            if (dr["TenNguoiSD"] != null && dr["TenNguoiSD"].GetType().Name != "DBNull") _tenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
        }

        public static TBVTPhieuNhap_C GetBySTT(String MaPN, Decimal STT)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuNhap_C_GET", MaPN, STT)))
            {
                while (dr.Read())
                {
                    return new TBVTPhieuNhap_C(dr, 1);
                }
            }
            return new TBVTPhieuNhap_C();
        }

        public String Add()
        {
           return Convert.ToString(SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuNhap_C_CREATE", _maPN, _maVT, _soluong, (string.IsNullOrEmpty(_hanSD)? new Nullable<DateTime>(): Convert.ToDateTime(_hanSD)), _donGia, _vat, _soLo, _huy, _ghichu, _maMay, _nguoiLap));
        }

        public void Edit()
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuNhap_C_UPDATE", _maPN, _sTT, _maVT, _soluong, (string.IsNullOrEmpty(_hanSD) ? new Nullable<DateTime>() : Convert.ToDateTime(_hanSD)), _donGia, _vat, _soLo, _huy, _ghichu, _maMay, _nguoiSD);
        }

        public void Delete()
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuNhap_C_DELETED", _maPN, _sTT, _nguoiSD, _maMay);
        }
        #endregion
    }
}
