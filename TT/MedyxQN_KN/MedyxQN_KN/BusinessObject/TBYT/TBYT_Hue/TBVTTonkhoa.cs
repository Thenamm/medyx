using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.ApplicationBlocks.Data;

/// <summary>
/// Summary description for TBVTTonkhoa
/// </summary>
/// 
namespace Dzual.CategoryList
{
    [Serializable()]
    public class TBVTTonkhoa
    {

        #region State Fields

        private String _makhoa;
        private String _maVT;
        private String _thang;
        private Decimal _soDK;
        private Decimal _sLN;
        private Decimal _sLX;
        private Decimal _sLNT;
        private Decimal _sLXT;
        private Decimal _sLDC;
        private Decimal _tonCK;
        private Decimal _giaNhap;
        private String _ngaySD;
        private String _nguoiSD;
        private String _maMay;
        private Boolean _huy;
        private String _ngayhuy;
        private String _nguoihuy;
        private String _tenTM;
        private String _tenNSX;
        private String _tenDVT;
        private String _tenHamLuong;
        private String _tenKhoa;
        private int _ordernumber;
        #endregion

        #region Business Properties and Methods
        public String Makhoa
        {
            get
            {
                return _makhoa;
            }
            set
            {
                _makhoa = value;
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
        public String Thang
        {
            get
            {
                return _thang;
            }
            set
            {
                _thang = value;
            }
        }
        public Decimal SoDK
        {
            get
            {
                return _soDK;
            }
            set
            {
                _soDK = value;
            }
        }
        public Decimal SLN
        {
            get
            {
                return _sLN;
            }
            set
            {
                _sLN = value;
            }
        }
        public Decimal SLX
        {
            get
            {
                return _sLX;
            }
            set
            {
                _sLX = value;
            }
        }
        public Decimal SLNT
        {
            get
            {
                return _sLNT;
            }
            set
            {
                _sLNT = value;
            }
        }
        public Decimal SLXT
        {
            get
            {
                return _sLXT;
            }
            set
            {
                _sLXT = value;
            }
        }
        public Decimal SLDC
        {
            get
            {
                return _sLDC;
            }
            set
            {
                _sLDC = value;
            }
        }
        public Decimal TonCK
        {
            get
            {
                return _tonCK;
            }
            set
            {
                _tonCK = value;
            }
        }
        public Decimal GiaNhap
        {
            get
            {
                return _giaNhap;
            }
            set
            {
                _giaNhap = value;
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
        public String TenTM
        {
            get
            {
                return _tenTM;
            }
            set
            {
                _tenTM = value;
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
        public TBVTTonkhoa()
        {

        }
        public TBVTTonkhoa(IDataReader dr, int Ordernumber)
        {
            _ordernumber = Ordernumber;
            if (dr["Makhoa"] != null && dr["Makhoa"].GetType().Name != "DBNull") _makhoa = Convert.ToString(dr["Makhoa"]);
            if (dr["MaVT"] != null && dr["MaVT"].GetType().Name != "DBNull") _maVT = Convert.ToString(dr["MaVT"]);
            if (dr["Thang"] != null && dr["Thang"].GetType().Name != "DBNull") _thang = Convert.ToDateTime(dr["Thang"]).ToString("dd/MM/yyyy");
            if (dr["SoDK"] != null && dr["SoDK"].GetType().Name != "DBNull") _soDK = Convert.ToDecimal(dr["SoDK"]);
            if (dr["SLN"] != null && dr["SLN"].GetType().Name != "DBNull") _sLN = Convert.ToDecimal(dr["SLN"]);
            if (dr["SLX"] != null && dr["SLX"].GetType().Name != "DBNull") _sLX = Convert.ToDecimal(dr["SLX"]);
            if (dr["SLNT"] != null && dr["SLNT"].GetType().Name != "DBNull") _sLNT = Convert.ToDecimal(dr["SLNT"]);
            if (dr["SLXT"] != null && dr["SLXT"].GetType().Name != "DBNull") _sLXT = Convert.ToDecimal(dr["SLXT"]);
            if (dr["SLDC"] != null && dr["SLDC"].GetType().Name != "DBNull") _sLDC = Convert.ToDecimal(dr["SLDC"]);
            if (dr["TonCK"] != null && dr["TonCK"].GetType().Name != "DBNull") _tonCK = Convert.ToDecimal(dr["TonCK"]);
            if (dr["GiaNhap"] != null && dr["GiaNhap"].GetType().Name != "DBNull") _giaNhap = Convert.ToDecimal(dr["GiaNhap"]);
            if (dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            if (dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
            if (dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
            if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
            if (dr["Ngayhuy"] != null && dr["Ngayhuy"].GetType().Name != "DBNull") _ngayhuy = Convert.ToDateTime(dr["Ngayhuy"]).ToString("dd/MM/yyyy");
            if (dr["Nguoihuy"] != null && dr["Nguoihuy"].GetType().Name != "DBNull") _nguoihuy = Convert.ToString(dr["Nguoihuy"]);
            if (dr["TenTM"] != null && dr["TenTM"].GetType().Name != "DBNull") _tenTM = Convert.ToString(dr["TenTM"]);
            if (dr["TenNSX"] != null && dr["TenNSX"].GetType().Name != "DBNull") _tenNSX = Convert.ToString(dr["TenNSX"]);
            if (dr["TenDVT"] != null && dr["TenDVT"].GetType().Name != "DBNull") _tenDVT = Convert.ToString(dr["TenDVT"]);
            if (dr["TenHamLuong"] != null && dr["TenHamLuong"].GetType().Name != "DBNull") _tenHamLuong = Convert.ToString(dr["TenHamLuong"]);
            if (dr["TenKhoa"] != null && dr["TenKhoa"].GetType().Name != "DBNull") _tenKhoa = Convert.ToString(dr["TenKhoa"]);
        }

        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        public static TBVTTonkhoa Get(DateTime dthang, String sMaKhoa, String sMaVT)
        {
            using (IDataReader dr = (IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTTonkhoa_Get", dthang, sMaKhoa, sMaVT))
            {
                while (dr.Read())
                {
                    return new TBVTTonkhoa(dr, 1);
                }
            }
            return new TBVTTonkhoa();
        }

        #endregion

    }
}