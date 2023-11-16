// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	ThongtinBNNoiTru_KhamBenh
// Kieu doi tuong  :	ThongtinBNNoiTru_KhamBenh
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
	/// This is a base generated class of <see cref="ThongtinBNNoiTru_KhamBenh" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class ThongtinBNNoiTru_KhamBenh : BusinessBase<ThongtinBNNoiTru_KhamBenh>
	{
		#region Business Methods
		
		#region State Fields
		
		private String _maSoKham = String.Empty;
        private int _OrderNumber;
        private SmartDate _ngaydk = new SmartDate(true);
        private String _TuoiThai = String.Empty;
        private String _CTCVB = String.Empty;
        private String _NgoiThai = String.Empty;
        private String _TimThai = String.Empty;
        private String _dauhieubatthuong = String.Empty;
        private String _xutri = String.Empty;
        private String _mach = String.Empty;
        private String _apHuyet = String.Empty;
        private String _nhietDo = String.Empty;
        private String _nhipTho = String.Empty;
        private String _canNang = String.Empty;
        private String _ChanDoan = String.Empty;
        private String _TienLuong = String.Empty;
        private String _HuongDT = String.Empty;
        private String _ChieuCaoTC = String.Empty;
        #endregion
		
		#region Business Properties and Methods
        public String TienLuong
        {
            get
            {
                CanReadProperty("TienLuong", true);
                return _TienLuong;
            }
            set
            {
                CanWriteProperty("TienLuong", true);
                if (_TienLuong != value)
                {
                    _TienLuong = value;
                    PropertyHasChanged("TienLuong");
                }
            }
        }
        public String ChieuCaoTC
        {
            get
            {
                CanReadProperty("ChieuCaoTC", true);
                return _ChieuCaoTC;
            }
            set
            {
                CanWriteProperty("ChieuCaoTC", true);
                if (_ChieuCaoTC != value)
                {
                    _ChieuCaoTC = value;
                    PropertyHasChanged("ChieuCaoTC");
                }
            }
        }
        public String ChanDoan
        {
            get
            {
                CanReadProperty("ChanDoan", true);
                return _ChanDoan;
            }
            set
            {
                CanWriteProperty("ChanDoan", true);
                if (_ChanDoan != value)
                {
                    _ChanDoan = value;
                    PropertyHasChanged("ChanDoan");
                }
            }
        }
        public String HuongDT
        {
            get
            {
                CanReadProperty("HuongDT", true);
                return _HuongDT;
            }
            set
            {
                CanWriteProperty("HuongDT", true);
                if (_HuongDT != value)
                {
                    _HuongDT = value;
                    PropertyHasChanged("HuongDT");
                }
            }
        }
        public String TuoiThai
        {
            get
            {
                CanReadProperty("TuoiThai", true);
                return _TuoiThai;
            }
            set
            {
                CanWriteProperty("TuoiThai", true);
                if (_TuoiThai != value)
                {
                    _TuoiThai = value;
                    PropertyHasChanged("TuoiThai");
                }
            }
        }
        public String CTCVB
        {
            get
            {
                CanReadProperty("CTCVB", true);
                return _CTCVB;
            }
            set
            {
                CanWriteProperty("CTCVB", true);
                if (_CTCVB != value)
                {
                    _CTCVB = value;
                    PropertyHasChanged("CTCVB");
                }
            }
        }
        public String NgoiThai
        {
            get
            {
                CanReadProperty("NgoiThai", true);
                return _NgoiThai;
            }
            set
            {
                CanWriteProperty("NgoiThai", true);
                if (_NgoiThai != value)
                {
                    _NgoiThai = value;
                    PropertyHasChanged("NgoiThai");
                }
            }
        }
        public String TimThai
        {
            get
            {
                CanReadProperty("TimThai", true);
                return _TimThai;
            }
            set
            {
                CanWriteProperty("TimThai", true);
                if (_TimThai != value)
                {
                    _TimThai = value;
                    PropertyHasChanged("TimThai");
                }
            }
        }
        public String dauhieubatthuong
        {
            get
            {
                CanReadProperty("dauhieubatthuong", true);
                return _dauhieubatthuong;
            }
            set
            {
                CanWriteProperty("dauhieubatthuong", true);
                if (_dauhieubatthuong != value)
                {
                    _dauhieubatthuong = value;
                    PropertyHasChanged("dauhieubatthuong");
                }
            }
        }
        public String xutri
        {
            get
            {
                CanReadProperty("xutri", true);
                return _xutri;
            }
            set
            {
                CanWriteProperty("xutri", true);
                if (_xutri != value)
                {
                    _xutri = value;
                    PropertyHasChanged("xutri");
                }
            }
        }
        public String NhietDo
        {
            get
            {
                CanReadProperty("NhietDo", true);
                return _nhietDo;
            }
            set
            {
                CanWriteProperty("NhietDo", true);
                if (_nhietDo != value)
                {
                    _nhietDo = value;
                    PropertyHasChanged("NhietDo");
                }
            }
        }
        public String Mach
        {
            get
            {
                CanReadProperty("Mach", true);
                return _mach;
            }
            set
            {
                CanWriteProperty("Mach", true);
                if (_mach != value)
                {
                    _mach = value;
                    PropertyHasChanged("Mach");
                }
            }
        }
        public String NhipTho
        {
            get
            {
                CanReadProperty("NhipTho", true);
                return _nhipTho;
            }
            set
            {
                CanWriteProperty("NhipTho", true);
                if (_nhipTho != value)
                {
                    _nhipTho = value;
                    PropertyHasChanged("NhipTho");
                }
            }
        }
        public String CanNang
        {
            get
            {
                CanReadProperty("CanNang", true);
                return _canNang;
            }
            set
            {
                CanWriteProperty("CanNang", true);
                if (_canNang != value)
                {
                    _canNang = value;
                    PropertyHasChanged("CanNang");
                }
            }
        }
        public String ApHuyet
        {
            get
            {
                CanReadProperty("ApHuyet", true);
                return _apHuyet;
            }
            set
            {
                CanWriteProperty("ApHuyet", true);
                if (_apHuyet != value)
                {
                    _apHuyet = value;
                    PropertyHasChanged("ApHuyet");
                }
            }
        }
		public String MaSoKham
		{
			get 
			{
				CanReadProperty("MaSoKham", true);
				return _maSoKham;
			}
			set 
			{
				CanWriteProperty("MaSoKham", true);
				if (_maSoKham != value) 
				{
					_maSoKham = value;
					PropertyHasChanged("MaSoKham");
				}
			}
		}
        public string NgayDK
        {
            get
            {
                CanReadProperty("Ngaydk", true);
                _ngaydk.FormatString = "dd/MM/yyyy";  
                return _ngaydk.Text;
            }
            set
            {
                CanWriteProperty("Ngaydk", true);
                if (_ngaydk.Text != value)
                {
                    _ngaydk.Text = value;
                    PropertyHasChanged("Ngaydk");
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
			return _maSoKham;
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
		protected internal ThongtinBNNoiTru_KhamBenh()
		{	
			// Prevent direct creation
		}
		
        internal ThongtinBNNoiTru_KhamBenh(  int ordernumber,
  String maSoKham ,
  SmartDate ngaydk, String TuoiThai, String CTCVB ,
            String NgoiThai ,
         String TimThai ,
         String dauhieubatthuong ,
         String xutri ,
         String mach ,
         String apHuyet ,
         String nhietDo ,
         String nhipTho ,
         String canNang,
         String chandoan,
         String tienluong,
         String huongdt ,
         String chieucaotc            
            )
        {
 _OrderNumber = ordernumber;
 _ChanDoan = chandoan;
 _ChieuCaoTC = chieucaotc;
 _TienLuong = tienluong;
 _HuongDT = huongdt;
   _maSoKham = maSoKham;		                                 
   _ngaydk = ngaydk;
   _TuoiThai = TuoiThai; _CTCVB = CTCVB;
   _NgoiThai = NgoiThai;
   _TimThai= TimThai;
   _dauhieubatthuong= dauhieubatthuong;
   _xutri = xutri;
   _mach= mach;
   _apHuyet= apHuyet;
   _nhietDo= nhietDo;
   _nhipTho = nhipTho;
   _canNang = canNang;
   
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
        ///// Load a <see cref="ThongtinBNNoiTru_KhamBenh" /> Object from given SafeDataReader.
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
        ///// Insert the new <see cref="ThongtinBNNoiTru_KhamBenh" /> Object to underlying database.
        ///// </summary>
        ////protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertThongtinBNNoiTru_KhamBenh
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //            }
		
        ///// <summary>
        ///// Update all changes made on <see cref="ThongtinBNNoiTru_KhamBenh" /> Object to underlying database.
        ///// </summary>
        ////protected override void DataPortal_Update()
        ////{
        ////    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateThongtinBNNoiTru_KhamBenh
        ////    if (IsDirty){
        ////        DataProvider.Instance().UpdateThongtinBNNoiTru_KhamBenh(_maSoKham, _maBN, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _gio, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _ngayLap, _nguoiSD , _ngaySD, _nguoiSD , _maMay, _huy, _nguoiSD , _ngayHuy, _ngaySD1, _nguoiSD1, _dienThoai, _diaChi, _tongTien, _tongBHTra, _tongTienBH);
        ////        // public abstract void UpdateThongtinBNNoiTru_KhamBenh(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, Byte _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, String _dienThoai, String _diaChi, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH);
        ////        // public override void UpdateThongtinBNNoiTru_KhamBenh(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, Byte _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, String _dienThoai, String _diaChi, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH);
        ////        // {
        ////        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _gio, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _ngayLap.DBValue, _nguoiSD , _ngaySD.DBValue, _nguoiSD , _maMay, _huy, _nguoiSD , _ngayHuy.DBValue, _ngaySD1.DBValue, _nguoiSD1, _dienThoai, _diaChi, _tongTien, _tongBHTra, _tongTienBH);
        ////        // }				
        ////    }
        ////}
        //#endregion
	}

}
