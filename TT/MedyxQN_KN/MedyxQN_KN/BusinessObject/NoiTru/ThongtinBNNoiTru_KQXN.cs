// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThongtinBNNoiTru_KQXN
// Kieu doi tuong  :	ThongtinBNNoiTru_KQXN
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/1/2009 2:46:27 PM
// Nguoi tao       :	HCABXT
//
// *****************************************************************************************************

// TODO:
// 1. Kiem tra lai su dung dan cua cac ham DataProvider.Instance()
// 2. Viet them cac ham tuong ung trong file DataProvider.cs
// 3. Viet them cac ham tuong ung trong file SqlDataProvider.cs
// 4. Viet Stored Procedure tuong ung voi cac ham can lay ra.
// *****************************************************************************************************
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="ThongtinBNNoiTru_KQXN" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ThongtinBNNoiTru_KQXN : BusinessBase<ThongtinBNNoiTru_KQXN>
	{
		#region Business Methods
		
		#region State Fields		
        private int _OrderNumber;
        private String _dATT = String.Empty;
        private String _ten = String.Empty;
        private Int32 _dongia = 0;
        private Int32 _sl = 0;
        private Decimal _ck = 0;
        private Decimal _tt = 0;
        private String _mAKHOA = String.Empty;
        private String _tENKHOA = String.Empty;
        private Int32 _mABS = 0;
        private String _tENBS = String.Empty;
        private String _tENXN = String.Empty;
        private String _ketQua = String.Empty;
        private Decimal _sTTDV = 0;
        private String _ma = String.Empty;
        private Int32 _lOAI = 0;
        private String _mASOKHAM = String.Empty;
        private String _tENDT = String.Empty;
        private Int32 _dONGIABH = 0;
        private Byte _tINHTIEN = 0;
        private Byte _tHUTHUAT = 0;
		#endregion
		
		#region Business Properties and Methods


        public String DATT
        {
            get
            {
                CanReadProperty("DATT", true);
                return _dATT;
            }
            set
            {
                CanWriteProperty("DATT", true);
                if (_dATT != value)
                {
                    _dATT = value;
                    PropertyHasChanged("DATT");
                }
            }
        }

        public String Ten
        {
            get
            {
                CanReadProperty("Ten", true);
                return _ten;
            }
            set
            {
                CanWriteProperty("Ten", true);
                if (_ten != value)
                {
                    _ten = value;
                    PropertyHasChanged("Ten");
                }
            }
        }

        public Int32 Dongia
        {
            get
            {
                CanReadProperty("Dongia", true);
                return _dongia;
            }
            set
            {
                CanWriteProperty("Dongia", true);
                if (_dongia != value)
                {
                    _dongia = value;
                    PropertyHasChanged("Dongia");
                }
            }
        }

        public Int32 SL
        {
            get
            {
                CanReadProperty("SL", true);
                return _sl;
            }
            set
            {
                CanWriteProperty("SL", true);
                if (_sl != value)
                {
                    _sl = value;
                    PropertyHasChanged("SL");
                }
            }
        }

        public Decimal CK
        {
            get
            {
                CanReadProperty("CK", true);
                return _ck;
            }
            set
            {
                CanWriteProperty("CK", true);
                if (_ck != value)
                {
                    _ck = value;
                    PropertyHasChanged("CK");
                }
            }
        }

        public Decimal TT
        {
            get
            {
                CanReadProperty("TT", true);
                return _tt;
            }
            set
            {
                CanWriteProperty("TT", true);
                if (_tt != value)
                {
                    _tt = value;
                    PropertyHasChanged("TT");
                }
            }
        }

        public String MAKHOA
        {
            get
            {
                CanReadProperty("MAKHOA", true);
                return _mAKHOA;
            }
            set
            {
                CanWriteProperty("MAKHOA", true);
                if (_mAKHOA != value)
                {
                    _mAKHOA = value;
                    PropertyHasChanged("MAKHOA");
                }
            }
        }

        public String TENKHOA
        {
            get
            {
                CanReadProperty("TENKHOA", true);
                return _tENKHOA;
            }
            set
            {
                CanWriteProperty("TENKHOA", true);
                if (_tENKHOA != value)
                {
                    _tENKHOA = value;
                    PropertyHasChanged("TENKHOA");
                }
            }
        }

        public Int32 MABS
        {
            get
            {
                CanReadProperty("MABS", true);
                return _mABS;
            }
            set
            {
                CanWriteProperty("MABS", true);
                if (_mABS != value)
                {
                    _mABS = value;
                    PropertyHasChanged("MABS");
                }
            }
        }

        public String TENBS
        {
            get
            {
                CanReadProperty("TENBS", true);
                return _tENBS;
            }
            set
            {
                CanWriteProperty("TENBS", true);
                if (_tENBS != value)
                {
                    _tENBS = value;
                    PropertyHasChanged("TENBS");
                }
            }
        }

        public String TENXN
        {
            get
            {
                CanReadProperty("TENXN", true);
                return _tENXN;
            }
            set
            {
                CanWriteProperty("TENXN", true);
                if (_tENXN != value)
                {
                    _tENXN = value;
                    PropertyHasChanged("TENXN");
                }
            }
        }

        public String KetQua
        {
            get
            {
                CanReadProperty("KetQua", true);
                return _ketQua;
            }
            set
            {
                CanWriteProperty("KetQua", true);
                if (_ketQua != value)
                {
                    _ketQua = value;
                    PropertyHasChanged("KetQua");
                }
            }
        }

        public Decimal STTDV
        {
            get
            {
                CanReadProperty("STTDV", true);
                return _sTTDV;
            }
            set
            {
                CanWriteProperty("STTDV", true);
                if (_sTTDV != value)
                {
                    _sTTDV = value;
                    PropertyHasChanged("STTDV");
                }
            }
        }

        public String MA
        {
            get
            {
                CanReadProperty("MA", true);
                return _ma;
            }
            set
            {
                CanWriteProperty("MA", true);
                if (_ma != value)
                {
                    _ma = value;
                    PropertyHasChanged("MA");
                }
            }
        }

        public Int32 LOAI
        {
            get
            {
                CanReadProperty("LOAI", true);
                return _lOAI;
            }
            set
            {
                CanWriteProperty("LOAI", true);
                if (_lOAI != value)
                {
                    _lOAI = value;
                    PropertyHasChanged("LOAI");
                }
            }
        }

        public String MASOKHAM
        {
            get
            {
                CanReadProperty("MASOKHAM", true);
                return _mASOKHAM;
            }
            set
            {
                CanWriteProperty("MASOKHAM", true);
                if (_mASOKHAM != value)
                {
                    _mASOKHAM = value;
                    PropertyHasChanged("MASOKHAM");
                }
            }
        }

        public String TENDT
        {
            get
            {
                CanReadProperty("TENDT", true);
                return _tENDT;
            }
            set
            {
                CanWriteProperty("TENDT", true);
                if (_tENDT != value)
                {
                    _tENDT = value;
                    PropertyHasChanged("TENDT");
                }
            }
        }

        public Int32 DONGIABH
        {
            get
            {
                CanReadProperty("DONGIABH", true);
                return _dONGIABH;
            }
            set
            {
                CanWriteProperty("DONGIABH", true);
                if (_dONGIABH != value)
                {
                    _dONGIABH = value;
                    PropertyHasChanged("DONGIABH");
                }
            }
        }

        public Byte TINHTIEN
        {
            get
            {
                CanReadProperty("TINHTIEN", true);
                return _tINHTIEN;
            }
            set
            {
                CanWriteProperty("TINHTIEN", true);
                if (_tINHTIEN != value)
                {
                    _tINHTIEN = value;
                    PropertyHasChanged("TINHTIEN");
                }
            }
        }

        public Byte THUTHUAT
        {
            get
            {
                CanReadProperty("THUTHUAT", true);
                return _tHUTHUAT;
            }
            set
            {
                CanWriteProperty("THUTHUAT", true);
                if (_tHUTHUAT != value)
                {
                    _tHUTHUAT = value;
                    PropertyHasChanged("THUTHUAT");
                }
            }
        }
		
	
        public int OrderNumber
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _OrderNumber;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                    //PropertyHasChanged();
                }
            }
        }

		protected override Object GetIdValue()
		{
			return _ma ;
		}
		#endregion
		#endregion

				
        //#region Business Object Rules and Validation
	
        //#endregion
		
        //#region Factory Methods
		
		
        //#endregion
		
		#region Constructors
		// Chu y !!!
		// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
		// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
		protected internal ThongtinBNNoiTru_KQXN()
		{	
			// Prevent direct creation
		}
		
        internal ThongtinBNNoiTru_KQXN(     int ordernumber,
     String dATT ,
     String ten ,
     Int32 dongia ,
     Int32 sl ,
     Decimal ck ,
     Decimal tt ,
     String mAKHOA ,
     String tENKHOA ,
     Int32 mABS ,
     String tENBS ,
     String tENXN ,
     String ketQua ,
     Decimal sTTDV,
     String ma ,
     Int32 lOAI,
     String mASOKHAM ,
     String tENDT ,
     Int32 dONGIABH ,
     Byte tINHTIEN ,
     Byte tHUTHUAT 
            )
        {
 _OrderNumber = ordernumber;
 _dATT = dATT;
    _ten =  ten ;
     _dongia = dongia ;
     _sl =  sl ;
     _ck = ck ;
     _tt = tt ;
     _mAKHOA = mAKHOA ;
      _tENKHOA =  tENKHOA ;
     _mABS = mABS ;
      _tENBS =  tENBS ;
      _tENXN = tENXN  ;
      _ketQua = ketQua ;
     _sTTDV = sTTDV;
      _ma = ma ;
     _lOAI =  lOAI;
      _mASOKHAM = mASOKHAM ;
     _tENDT =  tENDT ;
     _dONGIABH =  dONGIABH ;
     _tINHTIEN = tINHTIEN ;
     _tHUTHUAT = tHUTHUAT;
   
        }
		#endregion
		
        //#region Authorization

        //public static bool CanGetObject()
        //{
        //    return true;
        //}
		
        //public static bool CanDeleteObject()
        //{
        //    return true;
        //}

        //public static bool CanAddObject()
        //{
        //    return true;
        //}

        //public static bool CanEditObject()
        //{
        //    return true;
        //}
		
        //#endregion

        //#region Data Access
        ///// <summary>
        ///// Load a <see cref="ThongtinBNNoiTru_KQXN" /> Object from given SafeDataReader.
        ///// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaSoKham") != null) _maSoKham = dr.GetString("MaSoKham");
        //    if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
        //    if (dr.GetString("MaDT") != null) _maDT = dr.GetString("MaDT");
        //    if (dr.GetString("Sothe") != null) _sothe = dr.GetString("Sothe");
        //    if (dr.GetSmartDate("GiatriDN", true) != null) _giatriDN = dr.GetSmartDate("GiatriDN", true);
        //    if (dr.GetString("MaBV") != null) _maBV = dr.GetString("MaBV");
        //    if (dr.GetString("MaTinh") != null) _maTinh = dr.GetString("MaTinh");
        //    if (dr.GetSmartDate("NgayKT", true) != null) _ngayKT = dr.GetSmartDate("NgayKT", true);
        //    if (dr.GetString("Gio") != null) _gio = dr.GetString("Gio");
        //    if (dr.GetSmartDate("Ngayduyet", true) != null) _ngayduyet = dr.GetSmartDate("Ngayduyet", true);
        //    if (dr.GetString("Nguoiduyet") != null) _nguoiduyet = dr.GetString("Nguoiduyet");
        //    if (dr.GetSmartDate("NgayQT", true) != null) _ngayQT = dr.GetSmartDate("NgayQT", true);
        //    if (dr.GetSmartDate("NgayQTTT", true) != null) _ngayQTTT = dr.GetSmartDate("NgayQTTT", true);
        //    if (dr.GetString("NguoiQT") != null) _nguoiQT = dr.GetString("NguoiQT");
        //    if (dr.GetString("MaBenhNoiGT") != null) _maBenhNoiGT = dr.GetString("MaBenhNoiGT");
        //    if (dr.GetString("MaNoiGT") != null) _maNoiGT = dr.GetString("MaNoiGT");
        //    if (dr.GetString("CDNoiGT") != null) _cDNoiGT = dr.GetString("CDNoiGT");
        //    if (dr.GetString("Ghichu") != null) _ghichu = dr.GetString("Ghichu");
        //    if (dr.GetByte("LoaiKham") != null) _loaiKham = dr.GetByte("LoaiKham");
        //    if (dr.GetBoolean("Cungtra") != null) _cungtra = dr.GetBoolean("Cungtra");
        //    if (dr.GetDecimal("CK") != null) _ck = dr.GetDecimal("CK");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetByte("NguoiHuy") != null) _nguoiHuy = dr.GetByte("NguoiHuy");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetString("DienThoai") != null) _dienThoai = dr.GetString("DienThoai");
        //    if (dr.GetString("DiaChi") != null) _diaChi = dr.GetString("DiaChi");
        //    if (dr.GetDecimal("TongTien") != null) _tongTien = dr.GetDecimal("TongTien");
        //    if (dr.GetDecimal("TongBHTra") != null) _tongBHTra = dr.GetDecimal("TongBHTra");
        //    if (dr.GetDecimal("TongTienBH") != null) _tongTienBH = dr.GetDecimal("TongTienBH");
        //}
		
        ///// <summary>
        ///// Insert the new <see cref="ThongtinBNNoiTru_KQXN" /> Object to underlying database.
        ///// </summary>
        ////protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertThongtinBNNoiTru_KQXN
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //            }
		
        ///// <summary>
        ///// Update all changes made on <see cref="ThongtinBNNoiTru_KQXN" /> Object to underlying database.
        ///// </summary>
        ////protected override void DataPortal_Update()
        ////{
        ////    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongtinBNNoiTru_KQXN
        ////    if (IsDirty){
        ////        DataProvider.Instance().UpdateThongtinBNNoiTru_KQXN(_maSoKham, _maBN, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _gio, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _ngayLap, _nguoiSD , _ngaySD, _nguoiSD , _maMay, _huy, _nguoiSD , _ngayHuy, _ngaySD1, _nguoiSD1, _dienThoai, _diaChi, _tongTien, _tongBHTra, _tongTienBH);
        ////        // public abstract void UpdateThongtinBNNoiTru_KQXN(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, Byte _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, String _dienThoai, String _diaChi, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH);
        ////        // public override void UpdateThongtinBNNoiTru_KQXN(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, Byte _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, String _dienThoai, String _diaChi, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH);
        ////        // {
        ////        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _gio, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _ngayLap.DBValue, _nguoiSD , _ngaySD.DBValue, _nguoiSD , _maMay, _huy, _nguoiSD , _ngayHuy.DBValue, _ngaySD1.DBValue, _nguoiSD1, _dienThoai, _diaChi, _tongTien, _tongBHTra, _tongTienBH);
        ////        // }				
        ////    }
        ////}
        //#endregion
	}

}
