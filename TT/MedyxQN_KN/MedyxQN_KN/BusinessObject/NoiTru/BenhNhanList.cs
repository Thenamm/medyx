using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhNhanList : BusinessListBase<BenhNhanList, BenhNhan>
    {
        #region Factory Methods
        public static BenhNhanList GetAllBenhNhan(DateTime tungay, DateTime denngay,string madt, string dk )
        {
            return DataPortal.Fetch<BenhNhanList>(new Criteria(tungay , denngay , madt ,dk));
        }
        // tim theo dieu kien ten
        public static BenhNhanList FindBenhNhan( Byte _Loai,
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
  DateTime _tuNgaySinh,
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
  Boolean _qadmin,
  DateTime _DenNgaysinh,
  bool _YCDANGDK,
  bool _YCNGAYSINH)
        {
            return DataPortal.Fetch<BenhNhanList>(new CriteriaOther( _Loai,
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
   _tuNgaySinh,
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
    
   _DenNgaysinh,
   _YCDANGDK,
   _YCNGAYSINH  ));
        }
       
        public void NewTo(BenhNhan _BenhNhan)
        {
            if (this.Count == 0)
                _BenhNhan.OrderNumber = 1;
            else
            _BenhNhan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhNhan);
        }
        public void UpdatedTo(BenhNhan _BenhNhan)
        {

            _BenhNhan.OrderNumber = this.Items[this.IndexOf(_BenhNhan)].OrderNumber;
            this.Items[this.IndexOf(_BenhNhan)] = _BenhNhan;
        }
        public void RemoveTo(BenhNhan _BenhNhan)
        {
            this.Items.Remove(_BenhNhan);

        }

        private BenhNhanList()
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
                   _GiaTriDN    =   mGiaTriDN ;
                   _DiaChi    = mDiaChi  ;
                   _DienThoai  = mDienThoai   ;
                   _DTDD   =  mDTDD  ;
                   _DTCQ   = mDTCQ   ;
                    _Mail   =  mMail  ;
                    _Tuoi   =  mTuoi   ;
                    _NgaySinh   =  mNgaySinh  ;
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
                    _TuNgayYC   =  mTUNGAYYC ;
                    _DenNgayYC   =  mDENNGAYYC ;
                    _DK   =   mDK              ;
                    _DenNgaySinh = mDenNgaysinh;
                    _YCDANGDK = mYCDANGDK;
                    _YCNGAYSINH = mYCNGAYSINH;
                

            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhNhan(criteria.TuNgay,criteria.DenNgay,criteria.MaDT,criteria.DK,criteria.qadmin )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhNhan item = new BenhNhan(
         i,
         dr.GetString("MaBN") ,
			 dr.GetString("Hoten") ,
			 dr.GetString("Sothe") ,
			 dr.GetString("MaBV") ,
			 dr.GetSmartDate("GiaTriDN", true),
			 dr.GetString("DiaChi") ,
			 dr.GetString("DienThoai") ,
			 dr.GetString("DTDD") ,
			 dr.GetString("DTCQ") ,
			 dr.GetString("Mail") ,
			 dr.GetByte("Tuoi") ,
			 dr.GetSmartDate("NgaySinh", true),
			 dr.GetBoolean("GT") ,
			 dr.GetString("BaoTin") ,
			 dr.GetString("MaQG") ,
			 dr.GetString("MaTinh") ,
			 dr.GetString("MaHuyen") ,
              dr.GetString("MaPXa"),
			 dr.GetString("MaNN") ,
			 dr.GetString("TienSu") ,
			 dr.GetString("TienSuThuoc") ,
			 dr.GetString("TienSuGiaDinh") ,
			 dr.GetString("NhomMau") ,
			 dr.GetString("Ghichu") ,
			 dr.GetString("MaMay") ,
			 dr.GetSmartDate("NgayLap", true) ,
			 dr.GetString("NguoiLap") ,
			 dr.GetSmartDate("NgayHuy", true) ,
			 dr.GetString("NguoiHuy") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD") ,
			 dr.GetSmartDate("NgaySD1", true) ,
			 dr.GetString("NguoiSD1") ,
			 dr.GetBoolean("Huy") ,
			 dr.GetString("MaDT") ,
			 dr.GetString("HoTenBoMe") ,
			 dr.GetString("MaDanToc") ,
         dr.GetString("TenBV") ,
         dr.GetString("mabhxh") ,
         dr.GetString("TenTinh"),
         dr.GetString("TenQH") ,
            dr.GetString("TenPXa"),
         dr.GetString("TenNN"),
         dr.GetString("TenQG") ,
         dr.GetString("tenNguoiLap") ,
         dr.GetString("tenNguoiSD") ,
         dr.GetString("tenNguoiHuy"),
          dr.GetSmartDate("giatridn", true),
         dr.GetString("madonvi"),
         dr.GetString("maquanham"),
         dr.GetString("maquanheqd"),
         dr.GetString("socmt")
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindBenhNhan(
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
                    BenhNhan item = new BenhNhan(
     i,
        dr.GetString("MaBN"),
         dr.GetString("Hoten"),
         dr.GetString("Sothe"),
         dr.GetString("MaBV"),
         dr.GetSmartDate("GiaTriDN", true),
         dr.GetString("DiaChi"),
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
           dr.GetString("MaPXa"),
         dr.GetString("MaNN"),
         dr.GetString("TienSu"),
         dr.GetString("TienSuThuoc"),
         dr.GetString("TienSuGiaDinh"),
         dr.GetString("NhomMau"),
         dr.GetString("Ghichu"),
         dr.GetString("MaMay"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("NgayHuy", true),
         dr.GetString("NguoiHuy"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
         dr.GetSmartDate("NgaySD1", true),
         dr.GetString("NguoiSD1"),
         dr.GetBoolean("Huy"),
         dr.GetString("MaDT"),
         dr.GetString("HoTenBoMe"),
         dr.GetString("MaDanToc"),
         dr.GetString("TenBV"),
         dr.GetString("mabhxh"),
         dr.GetString("TenTinh"),
         dr.GetString("TenQH"),
            dr.GetString("TenPXa"),
         dr.GetString("TenNN"),
         dr.GetString("TenQG"),
         dr.GetString("tenNguoiLap"),
         dr.GetString("tenNguoiSD"),
         dr.GetString("tenNguoiHuy"),
          dr.GetSmartDate("giatritn", true),
         dr.GetString("madonvi"),
         dr.GetString("maquanham"),
         dr.GetString("maquanheqd"),
         dr.GetString("socmt")
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
