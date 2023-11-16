using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.TBYT;
using HTC.Business.CategoryList;
using Microsoft.ApplicationBlocks.Data;

namespace HTC.Business.TBYT
{	
	
	[Serializable()]
	public partial class TBVTPhieuXuat_C
	{
        private static string ConnectString
        {
            get
            {
                return HTC.Business.DataProvider.Instance().DuanConnectString();
            }
        }

        #region State Fields

        private String _maPX;
        private Decimal _sTT;
        private String _maVT;
        private Decimal _soluong;
        private String _hanSD;
        private String _solo;
        private Decimal _dongia;
        private Decimal _sLyc;
        private Decimal _giaban;
        private String _ghichu;
        private Boolean _huy;
        private String _maMay;
        private String _ngayLap;
        private String _nguoiLap;
        private String _ngaySD;
        private String _nguoiSD;
        private String _tenTM;
        private String _tenDVT;
        private String _tenDVTHL;
        private String _tenNSX;
        private String _tenNguoiLap;
        private String _tenNguoiSD;
        private Decimal _tonCKDT;
        private Decimal _tonCK;
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
        public String Solo
        {
            get
            {
                return _solo;
            }
            set
            {
                _solo = value;
            }
        }
        public Decimal Dongia
        {
            get
            {
                return _dongia;
            }
            set
            {
                _dongia = value;
            }
        }
        public Decimal SLyc
        {
            get
            {
                return _sLyc;
            }
            set
            {
                _sLyc = value;
            }
        }
        public Decimal Giaban
        {
            get
            {
                return _giaban;
            }
            set
            {
                _giaban = value;
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
        public String TenDVTHL
        {
            get
            {
                return _tenDVTHL;
            }
            set
            {
                _tenDVTHL = value;
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
        public Decimal TonCKDT
        {
            get
            {
                return _tonCKDT;
            }
            set
            {
                _tonCKDT = value;
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
        public TBVTPhieuXuat_C()
        {

        }
        public TBVTPhieuXuat_C(IDataReader dr, int Ordernumber)
        {
            _ordernumber = Ordernumber;
            if (dr["MaPX"] != null && dr["MaPX"].GetType().Name != "DBNull") _maPX = Convert.ToString(dr["MaPX"]);
            if (dr["STT"] != null && dr["STT"].GetType().Name != "DBNull") _sTT = Convert.ToDecimal(dr["STT"]);
            if (dr["MaVT"] != null && dr["MaVT"].GetType().Name != "DBNull") _maVT = Convert.ToString(dr["MaVT"]);
            if (dr["Soluong"] != null && dr["Soluong"].GetType().Name != "DBNull") _soluong = Convert.ToDecimal(dr["Soluong"]);
            if (dr["HanSD"] != null && dr["HanSD"].GetType().Name != "DBNull") _hanSD = Convert.ToDateTime(dr["HanSD"]).ToString("dd/MM/yyyy");
            if (dr["Solo"] != null && dr["Solo"].GetType().Name != "DBNull") _solo = Convert.ToString(dr["Solo"]);
            if (dr["Dongia"] != null && dr["Dongia"].GetType().Name != "DBNull") _dongia = Convert.ToDecimal(dr["Dongia"]);
            if (dr["SLyc"] != null && dr["SLyc"].GetType().Name != "DBNull") _sLyc = Convert.ToDecimal(dr["SLyc"]);
            if (dr["Giaban"] != null && dr["Giaban"].GetType().Name != "DBNull") _giaban = Convert.ToDecimal(dr["Giaban"]);
            if (dr["Ghichu"] != null && dr["Ghichu"].GetType().Name != "DBNull") _ghichu = Convert.ToString(dr["Ghichu"]);
            if (dr["Huy"] != null && dr["Huy"].GetType().Name != "DBNull") _huy = Convert.ToBoolean(dr["Huy"]);
            if (dr["MaMay"] != null && dr["MaMay"].GetType().Name != "DBNull") _maMay = Convert.ToString(dr["MaMay"]);
            if (dr["NgayLap"] != null && dr["NgayLap"].GetType().Name != "DBNull") _ngayLap = Convert.ToDateTime(dr["NgayLap"]).ToString("dd/MM/yyyy");
            if (dr["NguoiLap"] != null && dr["NguoiLap"].GetType().Name != "DBNull") _nguoiLap = Convert.ToString(dr["NguoiLap"]);
            if (dr["NgaySD"] != null && dr["NgaySD"].GetType().Name != "DBNull") _ngaySD = Convert.ToDateTime(dr["NgaySD"]).ToString("dd/MM/yyyy");
            if (dr["NguoiSD"] != null && dr["NguoiSD"].GetType().Name != "DBNull") _nguoiSD = Convert.ToString(dr["NguoiSD"]);
            if (dr["TenTM"] != null && dr["TenTM"].GetType().Name != "DBNull") _tenTM = Convert.ToString(dr["TenTM"]);
            if (dr["TenDVT"] != null && dr["TenDVT"].GetType().Name != "DBNull") _tenDVT = Convert.ToString(dr["TenDVT"]);
            if (dr["TenDVTHL"] != null && dr["TenDVTHL"].GetType().Name != "DBNull") _tenDVTHL = Convert.ToString(dr["TenDVTHL"]);
            if (dr["TenNSX"] != null && dr["TenNSX"].GetType().Name != "DBNull") _tenNSX = Convert.ToString(dr["TenNSX"]);
            if (dr["TenNguoiLap"] != null && dr["TenNguoiLap"].GetType().Name != "DBNull") _tenNguoiLap = Convert.ToString(dr["TenNguoiLap"]);
            if (dr["TenNguoiSD"] != null && dr["TenNguoiSD"].GetType().Name != "DBNull") _tenNguoiSD = Convert.ToString(dr["TenNguoiSD"]);
            if (dr["TonCKDT"] != null && dr["TonCKDT"].GetType().Name != "DBNull") _tonCKDT = Convert.ToDecimal(dr["TonCKDT"]);
            if (dr["TonCK"] != null && dr["TonCK"].GetType().Name != "DBNull") _tonCK = Convert.ToDecimal(dr["TonCK"]);
        }
        #endregion

		#region Factory Methods

        public static TBVTPhieuXuat_C GetBySTT(String MAPX, Decimal STT)
        {
            using (IDataReader dr = ((IDataReader)SqlHelper.ExecuteReader(ConnectString, "dbo.spTBVTPhieuXuat_C_GET", MAPX, STT)))
            {
                while (dr.Read())
                {
                    return new TBVTPhieuXuat_C(dr, 1);
                }
            }
            return new TBVTPhieuXuat_C();
        }

        public String Add()
        {
            return Convert.ToString(SqlHelper.ExecuteScalar(ConnectString, "dbo.spTBVTPhieuXuat_C_CREATE", _maPX, _maVT, _soluong, (string.IsNullOrEmpty(_hanSD) ? new Nullable<DateTime>() : Convert.ToDateTime(_hanSD)), _solo, _dongia, _sLyc, _giaban, _ghichu, _nguoiLap, _maMay));
        }

        public void Edit()
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuXuat_C_UPDATE", _maPX, _sTT, _maVT, _soluong, (string.IsNullOrEmpty(_hanSD) ? new Nullable<DateTime>() : Convert.ToDateTime(_hanSD)), _solo, _dongia, _sLyc, _giaban, _huy, _ghichu, _nguoiSD, _maMay);
        }

        public void Delete()
        {
            SqlHelper.ExecuteNonQuery(ConnectString, "dbo.spTBVTPhieuXuat_C_DELETED", _maPX, _sTT, _nguoiSD, _maMay);
        }

        public static DataSet CRPhieuXuat_Get(String MaPX, Byte Loai, Boolean Daduyet, Boolean Daphat, Boolean qAdmin)
        {
            DataSet ds = new DataSet();
            string[] s = { "PhieuXuat", "DanhSachPhieuXuat_C" };
            SqlHelper.FillDataset(ConnectString, "dbo.CRPhieuXuat_C_GetMaPhieu", ds, s, MaPX, Loai, Daduyet, Daphat, qAdmin);
            //ds.WriteXmlSchema("E:\\PhieuXuat.xsd");
            return ds;
        }

		#endregion
	}

}
