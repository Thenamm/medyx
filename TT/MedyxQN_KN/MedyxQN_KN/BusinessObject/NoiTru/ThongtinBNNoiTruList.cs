using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class ThongtinBNNoiTruList : BusinessListBase<ThongtinBNNoiTruList, ThongtinBNNoiTru>
    {
        #region Factory Methods
        public static ThongtinBNNoiTruList GetAllThongtinBNNoiTru(DateTime tungay, DateTime denngay,string madt, string dk )
        {
            return DataPortal.Fetch<ThongtinBNNoiTruList>(new Criteria(tungay , denngay , madt ,dk));
        }
        public static ThongtinBNNoiTruList FindThongtinBNNoiTruByMaBN(string maBN)
        {
            return DataPortal.Fetch<ThongtinBNNoiTruList>(new CriteriaSearch(1,maBN));
        }
        // tim theo dieu kien ten
        public static ThongtinBNNoiTruList FindThongtinBNNoiTru( Byte _Loai,
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
  string _MaBANgoaiT,
  string _MABENH,
  string _MAKHOA,
  string _MABS,
  DateTime _TuNgayYC,
  DateTime _DenNgayYC,
  string _DK,
  DateTime mDenNgaysinh,
  bool mYCDANGDK,
  bool mYCNGAYSINH)
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
            return DataPortal.Fetch<ThongtinBNNoiTruList>(new CriteriaOther( _Loai,
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
   _MaBANgoaiT,
   _MABENH,
   _MAKHOA,
   _MABS,
   _TuNgayYC,
   _DenNgayYC,
   _DK, 
   mDenNgaysinh, 
   mYCDANGDK,
   mYCNGAYSINH  ));
        }
        //public static ThongtinBNNoiTruList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<ThongtinBNNoiTruList>(new CriteriaOther(1, MaChungLoai));
        //}
        public void NewTo(ThongtinBNNoiTru _ThongtinBNNoiTru)
        {
            _ThongtinBNNoiTru.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_ThongtinBNNoiTru);
        }
        public void UpdatedTo(ThongtinBNNoiTru _ThongtinBNNoiTru)
        {

            _ThongtinBNNoiTru.OrderNumber = this.Items[this.IndexOf(_ThongtinBNNoiTru)].OrderNumber;
            this.Items[this.IndexOf(_ThongtinBNNoiTru)] = _ThongtinBNNoiTru;
        }
        public void RemoveTo(ThongtinBNNoiTru _ThongtinBNNoiTru)
        {
            this.Items.Remove(_ThongtinBNNoiTru);

        }

        private ThongtinBNNoiTruList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _MaDT;         
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            private DateTime  _TuNgay;
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
            public Criteria(DateTime tungay, DateTime denngay, string madt, string dk)
            {
                _TuNgay = tungay;
                _DenNgay = denngay;
                _MaDT = madt;
                _DK = dk;
                
                
            }
        }

        private class CriteriaSearch
        {
             private Boolean _qadmin = false ;
            
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            private byte _idFind;
            public byte idFind
            {
                get
                {
                    return _idFind;
                }
            }

            public CriteriaSearch(byte midFind, string mdk)
            {
                _idFind = midFind;
                _DK = "";
                if (midFind == 1 )
                {
                    _DK = "and a.MaBN like N'" + mdk + "%'";

                }


            }
        }

        // tim kiem theo ten
        #region CriteriaOther
        [Serializable()]
        private class CriteriaOther
        {         
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
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
            private string _MaBANgoaiT;
            public string MaBANgoaiT
            {
                get
                {
                    return _MaBANgoaiT;
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
            private string _MAKHOA;
            public string MAKHOA
            {
                get
                {
                    return _MAKHOA;
                }
            }
            private string _MABS;
            public string MABS
            {
                get
                {
                    return _MABS;
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
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther( 
                   Byte mLOAI ,
                   String mMABN,
                   String mHoten    ,
                   bool  mDUNGTEN ,
                   String  mSothe  ,
                   String mMaBV  ,
                   DateTime   mGiaTriDN ,
                   String mDiaChi  ,
                   String mDienThoai   ,
                   String  mDTDD  ,
                   String mDTCQ   ,
                  String  mMail  ,
                  Byte  mTuoi   ,
                  DateTime  mNgaySinh  ,
                  bool  mGT     ,
                  String  mBaoTin  ,
                  String  mMaQG   ,
                  String  mMaTinh   ,
                  String  mMaHuyen  ,
                  String  mMaNN   ,
                  String  mMaBANgoaiT ,
                  String  mMABENH ,
                  String  mMAKHOA ,
                  String  mMABS ,
                  DateTime  mTUNGAYYC ,
                  DateTime  mDENNGAYYC ,
                  String  mDK,
                  DateTime mDenNgaysinh,
                  bool mYCDANGDK ,
	              bool mYCNGAYSINH
                    )
            {
                   _Loai  = mLOAI ;
                   _MaBN   =   mMABN;
                   _Hoten    =  mHoten    ;
                   _DungTen     =  mDUNGTEN ;
                   _SoThe     =  mSothe ; 
                   _MaBV     = mMaBV  ;
                   if (mGiaTriDN == DateTime.MinValue)
                       _GiaTriDN = DateTime.Parse("01/01/1753"); //mGiaTriDN ;
                   else
                       _GiaTriDN = mGiaTriDN;
                   _DiaChi    = mDiaChi  ;
                   _DienThoai  = mDienThoai   ;
                   _DTDD   =  mDTDD  ;
                   _YCDANGDK = mYCDANGDK;
                   _YCNGAYSINH = mYCNGAYSINH;
                   _DTCQ   = mDTCQ   ;
                    _Mail   =  mMail  ;
                    _Tuoi   =  mTuoi   ;
                    if (mNgaySinh == DateTime.MinValue)
                        _NgaySinh = DateTime.Parse("01/01/1753"); // mNgaySinh  ;
                    else
                        _NgaySinh = mNgaySinh;
                    _GT   =  mGT     ;
                    _BaoTin   =  mBaoTin  ;
                    _MaQG   =  mMaQG   ;
                    _MaTinh   =  mMaTinh   ;
                    _MaHuyen   =  mMaHuyen  ;
                    _MaNN   =  mMaNN   ;
                    _MaBANgoaiT   =  mMaBANgoaiT ;
                    _MABENH   =  mMABENH ;
                    _MAKHOA  =  mMAKHOA ;
                    _MABS   =  mMABS ;
                    if (mTUNGAYYC == DateTime.MinValue)
                        _TuNgayYC = DateTime.Parse("01/01/1753"); //mDenNgaysinh;
                    else
                      
                    _TuNgayYC   =  mTUNGAYYC ;
                if (mDENNGAYYC == DateTime.MinValue)
                    _DenNgayYC = DateTime.Parse("01/01/1753"); //mDenNgaysinh;
                    else

                   
                    _DenNgayYC   =  mDENNGAYYC ;
                    _DK   =   mDK              ;
                    if (mDenNgaysinh == DateTime.MinValue)
                    _DenNgaySinh =    DateTime.Parse("01/01/1753"); //mDenNgaysinh;
                    else
                    _DenNgaySinh = mDenNgaysinh;

                   

            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllThongtinBNNoiTru(criteria.TuNgay,criteria.DenNgay,criteria.MaDT,criteria.DK,criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    ThongtinBNNoiTru item = new ThongtinBNNoiTru(
         i,                                
         dr.GetString("MaBN") ,
         dr.GetString("Hoten") ,
         dr.GetSmartDate("NgaySinh", true) ,
         dr.GetString("TENDT") ,
         dr.GetByte("Tuoi") ,
         dr.GetString("Diachi") ,
         dr.GetString("Dienthoai"),
         dr.GetBoolean("GT") ,
         dr.GetString("NhomMau"),
         dr.GetString("TIENSUBenh"),
         dr.GetString("TienSuThuoc") ,
         dr.GetString("DTCQ") ,
         dr.GetString("DTDD") ,
         dr.GetString("Mail") ,
         dr.GetString("DiachiCT") ,
         dr.GetString("Ghichu") ,
         dr.GetString("SoThe") ,
         dr.GetString("Baotin"),
         dr.GetSmartDate("GIATRIDN", true) ,
         dr.GetString("TENBV") ,
         dr.GetString("MABHXH") ,
         dr.GetString("TENTINH") ,
         dr.GetString("TENQH") ,
         dr.GetString("TENNN") ,
         dr.GetString("TENQG")

              );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaSearch criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindThongtinBNNoiTruByMaBN(criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    ThongtinBNNoiTru item = new ThongtinBNNoiTru(
          i,
         dr.GetString("MaBN"),
         dr.GetString("Hoten"),
         dr.GetSmartDate("NgaySinh", true),
         dr.GetString("TENDT"),
         dr.GetByte("Tuoi"),
         dr.GetString("Diachi"),
         dr.GetString("Dienthoai"),
         dr.GetBoolean("GT"),
         dr.GetString("NhomMau"),
         dr.GetString("TIENSUBenh"),
         dr.GetString("TienSuThuoc"),
         dr.GetString("DTCQ"),
         dr.GetString("DTDD"),
         dr.GetString("Mail"),
         dr.GetString("DiachiCT"),
         dr.GetString("Ghichu"),
         dr.GetString("SoThe"),
         dr.GetString("Baotin"),
         dr.GetSmartDate("GIATRIDN", true),
         dr.GetString("TENBV"),
         dr.GetString("MABHXH"),
         dr.GetString("TENTINH"),
         dr.GetString("TENQH"),
         dr.GetString("TENNN"),
         dr.GetString("TENQG")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindThongtinBNNoiTru(
                      criteria.Loai,
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
                      criteria.MaBANgoaiT,
                      criteria.MABENH,
                      criteria.MAKHOA,
                      criteria.MABS,
                      criteria.TuNgayYC,
                      criteria.DenNgayYC,
                      criteria.DK, 
                      criteria.qadmin,
                      criteria.DenNgaySinh,
                      criteria.YCDANGDK,
                      criteria.YCNGAYSINH
                      )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    ThongtinBNNoiTru item = new ThongtinBNNoiTru(
     i,
         dr.GetString("MaBN"),
         dr.GetString("Hoten"),
         dr.GetSmartDate("NgaySinh", true),
         dr.GetString("TENDT"),
         dr.GetByte("Tuoi"),
         dr.GetString("Diachi"),
         dr.GetString("Dienthoai"),
         dr.GetBoolean("GT"),
         dr.GetString("NhomMau"),
         dr.GetString("TIENSUBenh"),
         dr.GetString("TienSuThuoc"),
         dr.GetString("DTCQ"),
         dr.GetString("DTDD"),
         dr.GetString("Mail"),
         dr.GetString("DiachiCT"),
         dr.GetString("Ghichu"),
         dr.GetString("SoThe"),
         dr.GetString("Baotin"),
         dr.GetSmartDate("GIATRIDN", true),
         dr.GetString("TENBV"),
         dr.GetString("MABHXH"),
         dr.GetString("TENTINH"),
         dr.GetString("TENQH"),
         dr.GetString("TENNN"),
         dr.GetString("TENQG")
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
