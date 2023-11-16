using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_GiaoNhanList  : ReadOnlyListBase<BenhAn_GiaoNhanList, BenhAn_GiaoNhan >
    {
        #region Factory Methods
        public  BenhAn_GiaoNhan GetTo(string maba) //
        {
            foreach (BenhAn_GiaoNhan obj in this)
                if (obj.MaBANoiT == maba)
                    return obj;
            return null;

        }
        public static BenhAn_GiaoNhanList FindBenhAn_Search(string _MaDT,
  string _MaBN,
  string _Hoten,
  bool _DungTen,
  string _SoThe,
  string _MaBV,
  DateTime _GiaTriDN,
  string _DiaChi,
  string _DienThoai,
  string _DTDD,
  string _DTCQ,
  string _Mail,
  Byte _Tuoi,
  DateTime _NgaySinh,
  bool _GT,
  string _BaoTin,
  string _MaQG,
  string _MaTinh,
  string _MaHuyen,
  string _MaNN,
  string _MaBA,
  string _MABENH,
  string _MABAQL,
  string _MaLoaiBA,
  DateTime _TuNgayYC,
  DateTime _DenNgayYC,
  string _DK,
  bool _qadmin,
  DateTime mDenNgaysinh,
  bool YCDANGDK,
  bool YCNGAYSINH, int pageSize, int pageIndex, 
  bool NoiTru, bool CoSoLuuTru, bool DaMuon, string SoLuuTru, DateTime NgayRVTu, DateTime NgayRVDen)
        {
            if (_GiaTriDN == DateTime.MinValue)
                _GiaTriDN = DateTime.Parse("01/01/1753"); //mGiaTriDN ;

            if (_NgaySinh == DateTime.MinValue)
                _NgaySinh = DateTime.Parse("01/01/1753"); // mNgaySinh  ;

            if (_NgaySinh == DateTime.MinValue)
                _NgaySinh = DateTime.Parse("01/01/1753"); //mDenNgaysinh;


            if (_TuNgayYC == DateTime.MinValue)
                _TuNgayYC = DateTime.Parse("01/01/1753");
            if (_DenNgayYC == DateTime.MinValue)
                _DenNgayYC = DateTime.Parse("01/01/1753");
            return DataPortal.Fetch<BenhAn_GiaoNhanList>(new CriteriaOther(_MaDT,
   _MaBN,
   _Hoten,
   _DungTen,
   _SoThe,
   _MaBV,
   _GiaTriDN,
   _DiaChi,
   _DienThoai,
   _DTDD,
   _DTCQ,
   _Mail,
   _Tuoi,
   _NgaySinh,
   _GT,
   _BaoTin,
   _MaQG,
   _MaTinh,
   _MaHuyen,
   _MaNN,
   _MaBA,
   _MABENH,
   _MABAQL,
   _MaLoaiBA,
   _TuNgayYC,
   _DenNgayYC,
   _DK,
   _qadmin,
   mDenNgaysinh,
   YCDANGDK,
   YCNGAYSINH, pageSize, pageIndex,
   NoiTru, CoSoLuuTru, DaMuon, SoLuuTru, NgayRVTu, NgayRVDen));
        }
        public static BenhAn_GiaoNhanList BenhAn_GetPhieuGN(String MaPhieuGN, Boolean Tra)
        {
            return DataPortal.Fetch<BenhAn_GiaoNhanList>(new CriteriaGN(MaPhieuGN, Tra));
        }
        public static BenhAn_GiaoNhanList BenhAn_GetPhieuGNByICD(String MaICD, DateTime TuNgay, DateTime DenNgay)
        {
            return DataPortal.Fetch<BenhAn_GiaoNhanList>(new CriteriaICD(MaICD,TuNgay,DenNgay));
        }
        private BenhAn_GiaoNhanList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class CriteriaOther
        {
            private string _MaDT;
            public string MADT
            {
                get
                {
                    return _MaDT;
                }
            }
            private int _PageSize;
            public int PageSize
            {
                get
                {
                    return _PageSize;
                }
            }
            private int _PageIndex;
            public int PageIndex
            {
                get
                {
                    return _PageIndex;
                }
            }
            private string _MaBN;
            public string MaBN
            {
                get
                {
                    return _MaBN;
                }
            }
            private string _Hoten;
            public string Hoten
            {
                get
                {
                    return _Hoten;
                }
            }
            private bool _DungTen;
            public bool DungTen
            {
                get
                {
                    return _DungTen;
                }
            }
            private string _SoThe;
            public string SoThe
            {
                get
                {
                    return _SoThe;
                }
            }
            private string _MaBV;
            public string MaBV
            {
                get
                {
                    return _MaBV;
                }
            }
            private DateTime _GiaTriDN;
            public DateTime GiaTriDN
            {
                get
                {
                    return _GiaTriDN;
                }
            }
            private string _DiaChi;
            public string DiaChi
            {
                get
                {
                    return _DiaChi;
                }
            }
            private string _DienThoai;
            public string DienThoai
            {
                get
                {
                    return _DienThoai;
                }
            }
            private string _DTDD;
            public string DTDD
            {
                get
                {
                    return _DTDD;
                }
            }
            private string _DTCQ;
            public string DTCQ
            {
                get
                {
                    return _DTCQ;
                }
            }
            private string _Mail;
            public string Mail
            {
                get
                {
                    return _Mail;
                }
            }
            private Byte _Tuoi;
            public Byte Tuoi
            {
                get
                {
                    return _Tuoi;
                }
            }
            private DateTime _NgaySinh;
            public DateTime NgaySinh
            {
                get
                {
                    return _NgaySinh;
                }
            }
            private bool _GT;
            public bool GT
            {
                get
                {
                    return _GT;
                }
            }
            private string _BaoTin;
            public string BaoTin
            {
                get
                {
                    return _BaoTin;
                }
            }
            private string _MaQG;
            public string MaQG
            {
                get
                {
                    return _MaQG;
                }
            }
            private string _MaTinh;
            public string MaTinh
            {
                get
                {
                    return _MaTinh;
                }
            }
            private string _MaHuyen;
            public string MaHuyen
            {
                get
                {
                    return _MaHuyen;
                }
            }
            private string _MaNN;
            public string MaNN
            {
                get
                {
                    return _MaNN;
                }
            }
            private string _MaBA;
            public string MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
            private string _MABENH;
            public string MABENH
            {
                get
                {
                    return _MABENH;
                }
            }
            private string _MABAQL;
            public string MABAQL
            {
                get
                {
                    return _MABAQL;
                }
            }
            private string _MaLoaiBA;
            public string MaLoaiBA
            {
                get
                {
                    return _MaLoaiBA;
                }
            }
            private DateTime _TuNgayYC;
            public DateTime TuNgayYC
            {
                get
                {
                    return _TuNgayYC;
                }
            }
            private DateTime _DenNgayYC;
            public DateTime DenNgayYC
            {
                get
                {
                    return _DenNgayYC;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }

            private DateTime _DenNgaySinh;
            public DateTime DenNgaySinh
            {
                get
                {
                    return _DenNgaySinh;
                }
            }
            private bool _YCDANGDK;
            public bool YCDANGDK
            {
                get
                {
                    return _YCDANGDK;
                }
            }
            private bool _YCNGAYSINH;
            public bool YCNGAYSINH
            {
                get
                {
                    return _YCNGAYSINH;
                }
            }
            private int _pageSize;
            public int pageSize
            {
                get {
                    return _pageSize;
                }
            }
            private int _pageIndex;
            public int pageIndex
            {
                get
                {
                    return _pageIndex;
                }
            }
            private bool _NoiTru;
            public bool NoiTru
            {
                get {
                    return _NoiTru;
                }
            }
            private bool _CoSoLuuTru;
            public bool CoSoLuuTru
            {
                get { return _CoSoLuuTru; }
            }
            private bool _DaMuon;
            public bool DaMuon
            {
                get { return _DaMuon; }
            }
            private string _SoLuuTru;
            public string SoLuuTru
            {
                get { return _SoLuuTru; }
            }
            private DateTime _NgayRVTu;
            public DateTime NgayRVTu
            {
                get { return _NgayRVTu; }
            }
            private DateTime _NgayRVDen;
            public DateTime NgayRVDen
            {
                get { return _NgayRVDen; }
            }
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(
                   String mMaDT,
                   String mMABN,
                   String mHoten,
                   bool mDUNGTEN,
                   String mSothe,
                   String mMaBV,
                   DateTime mGiaTriDN,
                   String mDiaChi,
                   String mDienThoai,
                   String mDTDD,
                   String mDTCQ,
                  String mMail,
                  Byte mTuoi,
                  DateTime mNgaySinh,
                  bool mGT,
                  String mBaoTin,
                  String mMaQG,
                  String mMaTinh,
                  String mMaHuyen,
                  String mMaNN,
                  String mMaBA,
                  String mMABENH,
                  String mMABAQL,
                  String mMaLoaiBA,
                  DateTime mTUNGAYYC,
                  DateTime mDENNGAYYC,
                  String mDK,
                  bool mQadmin,
                  DateTime mDenNgaysinh,
                  bool YCDANGDK,
                  bool YCNGAYSINH, int pageSize, int pageIndex,
                bool NoiTru, bool CoSoLuuTru, bool DaMuon, string SoLuuTru, DateTime NgayRVTu, DateTime NgayRVDen
                    )
            {
                _MaDT = mMaDT;
                _MaBN = mMABN;
                _Hoten = mHoten;
                _DungTen = mDUNGTEN;
                _SoThe = mSothe;
                _MaBV = mMaBV;
                if (mGiaTriDN == DateTime.MinValue)
                    _GiaTriDN = DateTime.Parse("01/01/1753"); //mGiaTriDN ;
                else
                    _GiaTriDN = mGiaTriDN;
                _DiaChi = mDiaChi;
                _DienThoai = mDienThoai;
                _DTDD = mDTDD;
                _YCDANGDK = YCDANGDK;
                _YCNGAYSINH = YCNGAYSINH;
                _DTCQ = mDTCQ;
                _Mail = mMail;
                _Tuoi = mTuoi;
                if (mNgaySinh == DateTime.MinValue)
                    _NgaySinh = DateTime.Parse("01/01/1753"); // mNgaySinh  ;
                else
                    _NgaySinh = mNgaySinh;
                _GT = mGT;
                _BaoTin = mBaoTin;
                _MaQG = mMaQG;
                _MaTinh = mMaTinh;
                _MaHuyen = mMaHuyen;
                _MaNN = mMaNN;
                _MaBA = mMaBA;
                _MABENH = mMABENH;
                _MABAQL = mMABAQL;
                _MaLoaiBA = mMaLoaiBA;
                if (mTUNGAYYC == DateTime.MinValue)
                    _TuNgayYC = DateTime.Parse("01/01/1753"); //mDenNgaysinh;
                else

                    _TuNgayYC = mTUNGAYYC;
                if (mDENNGAYYC == DateTime.MinValue)
                    _DenNgayYC = DateTime.Parse("01/01/1753"); //mDenNgaysinh;
                else


                    _DenNgayYC = mDENNGAYYC;
                _DK = mDK;
                _qadmin = mQadmin;
                if (mDenNgaysinh == DateTime.MinValue)
                    _DenNgaySinh = DateTime.Parse("01/01/1753"); //mDenNgaysinh;
                else
                    _DenNgaySinh = mDenNgaysinh;
                _pageSize = pageSize;
                _pageIndex = pageIndex;
                _NoiTru = NoiTru;
                _CoSoLuuTru = CoSoLuuTru;
                _DaMuon = DaMuon;
                _SoLuuTru = SoLuuTru;
                _NgayRVTu = NgayRVTu;
                _NgayRVDen = NgayRVDen;
            }
        }
        [Serializable()]
        private class CriteriaGN
        {
            private string _MaPhieuGN;
            public string MaPhieuGN
            {
                get
                {
                    return _MaPhieuGN;
                }
            }
            private Boolean _Tra;
            public Boolean Tra
            {
                get
                {
                    return _Tra;
                }
            }
            public CriteriaGN(String MaPhieuGN, Boolean Tra)
            {
                _MaPhieuGN = MaPhieuGN;
                _Tra = Tra;
            }
        }
        [Serializable()]
        private class CriteriaICD
        {
            private string _MaICD;
            public string MaICD
            {
                get
                {
                    return _MaICD;
                }
            }
            private DateTime _TuNgay;
            public DateTime TuNgay
            {
                get
                {
                    return _TuNgay;
                }
            }
            private DateTime _DenNgay;
            public DateTime DenNgay
            {
                get
                {
                    return _DenNgay;
                }
            }
            public CriteriaICD(String MaICD, DateTime tungay, DateTime denngay)
            {
                _MaICD = MaICD;
                _TuNgay = tungay;
                _DenNgay = denngay;
            }
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindBenhAn_GiaoNhan(
                      criteria.MADT,
                      criteria.MaBN,
                      criteria.Hoten,
                      criteria.DungTen,
                      criteria.SoThe,
                      criteria.MaBV,
                      criteria.GiaTriDN,
                      criteria.DiaChi,
                      criteria.DienThoai,
                      criteria.DTDD,
                      criteria.DTCQ,
                      criteria.Mail,
                      criteria.Tuoi,
                      criteria.NgaySinh,
                      criteria.GT,
                      criteria.BaoTin,
                      criteria.MaQG,
                      criteria.MaTinh,
                      criteria.MaHuyen,
                      criteria.MaNN,
                      criteria.MaBA,
                      criteria.MABENH,
                      criteria.MABAQL,
                      criteria.MaLoaiBA,
                      criteria.TuNgayYC,
                      criteria.DenNgayYC,
                      criteria.DK,
                      criteria.qadmin,
                      criteria.DenNgaySinh,
                      criteria.YCDANGDK,
                      criteria.YCNGAYSINH,
                      criteria.pageIndex,
                      criteria.pageSize,
                      criteria.NoiTru,
                      criteria.CoSoLuuTru,
                      criteria.DaMuon,
                      criteria.SoLuuTru,
                      criteria.NgayRVTu,
                      criteria.NgayRVDen
                      )))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_GiaoNhan item = new BenhAn_GiaoNhan(i,
                        dr.GetString("MaPhieuGN"),
                        dr.GetString("MaPhieuGN_C"),
                        dr.GetString("MaKhoa"),
         dr.GetString("MaDT"),
         dr.GetString("Hoten"),
         dr.GetString("Sothe"),
         dr.GetString("MaBV"),
         dr.GetSmartDate("GiaTriDN", true),
         dr.GetString("DiaChi"),
         dr.GetString("DiaChiC"),
         dr.GetString("DienThoai"),
         dr.GetString("DTDD"),
         dr.GetString("DTCQ"),
         dr.GetString("Mail"),
         dr.GetByte("Tuoi"),
         dr.GetSmartDate("NgaySinh", true),
         dr.GetBoolean("GT"),
         dr.GetString("BaoTin"),
         dr.GetString("MaQG"),
         dr.GetString("MaTinh"),
         dr.GetString("MaHuyen"),
         dr.GetString("MaNN"),
         dr.GetString("TienSu"),
         dr.GetString("TienSuThuoc"),
         dr.GetString("TienSuGiaDinh"),
         dr.GetString("NhomMau"),
         dr.GetString("MaBANoiT"),
         dr.GetString("MaBAQL"),
         dr.GetString("Ghichu"),
         dr.GetString("MaMay"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("NgayHuy", true),
         dr.GetString("NguoiHuy"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
         dr.GetSmartDate("NgayVV", true),

         dr.GetBoolean("Huy"),
         dr.GetString("mabhxh"),
         dr.GetString("maBN"),
         dr.GetString("tenbv"),
         dr.GetSmartDate("giatritn", true),
         dr.GetString("mabaluu"),
         dr.GetString("TENKHOAHT"),
         dr.GetSmartDate("NGAYRAVIEN"),
         dr.GetString("MAICDRAVIEN"),
         dr.GetString("tenbenhRAVIEN"),
         dr.GetInt32("ToTal"),
         dr.GetString("MaQL"),
         dr.GetString("thoihan"),
         dr.GetInt32("NgayQuaHan")
         );
                    this.Add(item);
                    i += 1;
                }
                dr.Close(); dr.Dispose();  //IsReadOnly = true;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaGN criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().BenhAn_GetPhieuGN(criteria.MaPhieuGN, criteria.Tra)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_GiaoNhan item = new BenhAn_GiaoNhan(i,
                        dr.GetString("MaPhieuGN"),
                        dr.GetString("MaPhieuGN_C"),
                        dr.GetString("MaKhoa"),
         dr.GetString("MaDT"),
         dr.GetString("Hoten"),
         dr.GetString("Sothe"),
         dr.GetString("MaBV"),
         dr.GetSmartDate("GiaTriDN", true),
         dr.GetString("DiaChi"),
         dr.GetString("DiaChiC"),
         dr.GetString("DienThoai"),
         dr.GetString("DTDD"),
         dr.GetString("DTCQ"),
         dr.GetString("Mail"),
         dr.GetByte("Tuoi"),
         dr.GetSmartDate("NgaySinh", true),
         dr.GetBoolean("GT"),
         dr.GetString("BaoTin"),
         dr.GetString("MaQG"),
         dr.GetString("MaTinh"),
         dr.GetString("MaHuyen"),
         dr.GetString("MaNN"),
         dr.GetString("TienSu"),
         dr.GetString("TienSuThuoc"),
         dr.GetString("TienSuGiaDinh"),
         dr.GetString("NhomMau"),
         dr.GetString("MaBANoiT"),
         dr.GetString("MaBAQL"),
         dr.GetString("Ghichu"),
         dr.GetString("MaMay"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("NgayHuy", true),
         dr.GetString("NguoiHuy"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
         dr.GetSmartDate("NgayVV", true),
         dr.GetBoolean("Huy"),
         dr.GetString("mabhxh"),
         dr.GetString("maBN"),
         dr.GetString("tenbv"),
         dr.GetSmartDate("giatritn", true),
         dr.GetString("mabaluu"),
         dr.GetString("TENKHOAHT"),
         dr.GetSmartDate("NGAYRAVIEN"),
         dr.GetString("MAICDRAVIEN"),
         dr.GetString("tenbenhRAVIEN"),
         dr.GetInt32("ToTal"),
         dr.GetString("MaQL"),
         dr.GetString("thoihan"),
         dr.GetInt32("NgayQuaHan")
         );
                    this.Add(item);
                    i += 1;
                }
                dr.Close(); dr.Dispose();  //IsReadOnly = true;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaICD criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().BenhAn_GetPhieuGNByICD(criteria.MaICD,criteria.TuNgay,criteria.DenNgay)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_GiaoNhan item = new BenhAn_GiaoNhan(i,
                        dr.GetString("MaPhieuGN"),
                        dr.GetString("MaPhieuGN_C"),
                        dr.GetString("MaKhoa"),
         dr.GetString("MaDT"),
         dr.GetString("Hoten"),
         dr.GetString("Sothe"),
         dr.GetString("MaBV"),
         dr.GetSmartDate("GiaTriDN", true),
         dr.GetString("DiaChi"),
         dr.GetString("DiaChiC"),
         dr.GetString("DienThoai"),
         dr.GetString("DTDD"),
         dr.GetString("DTCQ"),
         dr.GetString("Mail"),
         dr.GetByte("Tuoi"),
         dr.GetSmartDate("NgaySinh", true),
         dr.GetBoolean("GT"),
         dr.GetString("BaoTin"),
         dr.GetString("MaQG"),
         dr.GetString("MaTinh"),
         dr.GetString("MaHuyen"),
         dr.GetString("MaNN"),
         dr.GetString("TienSu"),
         dr.GetString("TienSuThuoc"),
         dr.GetString("TienSuGiaDinh"),
         dr.GetString("NhomMau"),
         dr.GetString("MaBANoiT"),
         dr.GetString("MaBAQL"),
         dr.GetString("Ghichu"),
         dr.GetString("MaMay"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("NgayHuy", true),
         dr.GetString("NguoiHuy"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
         dr.GetSmartDate("NgayVV", true),
         dr.GetBoolean("Huy"),
         dr.GetString("mabhxh"),
         dr.GetString("maBN"),
         dr.GetString("tenbv"),
         dr.GetSmartDate("giatritn", true),
         dr.GetString("mabaluu"),
         dr.GetString("TENKHOAHT"),
         dr.GetSmartDate("NGAYRAVIEN"),
         dr.GetString("MAICDRAVIEN"),
         dr.GetString("tenbenhRAVIEN"),
         dr.GetInt32("ToTal"),
         dr.GetString("MaQL"),
         dr.GetString("thoihan"),
         dr.GetInt32("NgayQuaHan")
         );
                    this.Add(item);
                    i += 1;
                }
                dr.Close(); dr.Dispose();  //IsReadOnly = true;
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
