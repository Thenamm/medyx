// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	KhamBenh_C_GetsInfo
// Kieu doi tuong  :	KhamBenh_C_GetsInfo
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/1/2009 2:46:27 PM
// Nguoi tao       :	HCABXT
//
// *****************************************************************************************************

// TODO:
// 1. Kiem tra lai su dung dan cua cac ham DataProvider.Instance()
// 2. Viet them cac ham tuong ung trong file DataProvider.cs
// 3. Viet them cac ham tuong ung trong file SqlDataProvider.cs
// 4. Viet Stored Procedure tuong ung voi ca c ham can lay ra.
// *****************************************************************************************************
using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{	
	
	/// <summary>
	/// This is a base generated class of <see cref="KhamBenh_C_GetsInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class KhamBenh_C_GetsInfo : BusinessBase<KhamBenh_C_GetsInfo>
	{
		#region Business Methods
		
		#region State Fields
        private String _machuyenkhoa = String.Empty;
        private String _hOTEN = String.Empty;
        private Boolean _gt = false;
        private String _mABN = String.Empty;
        private String _dIACHI = String.Empty;
        private String _mASOKHAM = String.Empty;
        private String _maDV = String.Empty;
        private String _tENDV = String.Empty;
        private Int32 _sTT = 0;
        private String _KQ = String.Empty;
        private Boolean _DaCoKQXN = false;
        private String _mADT = String.Empty;
        private String _tENDT = String.Empty;
        private Int32 _sOTT = 0;
        private Byte _tRANGTHAI = 0;
        private SmartDate _nGAYYC = new SmartDate(true);
        private SmartDate _nGAYYCD = new SmartDate(true);
        private SmartDate _nGAYLAP = new SmartDate(true);
        private String _nGUOILAP = String.Empty;
        private String _nGUOISD = String.Empty;
        private SmartDate _nGAYSD = new SmartDate(true);
        private SmartDate _nGAYHUY = new SmartDate(true);
        private String _nGUOIHUY = String.Empty;
        private String _tENNGUOILAP = String.Empty;
        private String _tENNGUOISD = String.Empty;
        private String _tENNGUOIHUY = String.Empty;
        private SmartDate _nGAYDK = new SmartDate(true);
        private int _OrderNumber;
        private Byte _tuoi = 0;
        private Byte _loaikq = 0;
        private Byte _bn = 0;
        private int _STTKhoa = 0;
        private SmartDate _ngaySinh = new SmartDate(true);
        private String _TenKhoa = String.Empty;
        private String _MaKhoa = String.Empty;
        private String _maLH = String.Empty;  //
       
		#endregion
		
		#region Business Properties and Methods
        public String maLH
        {
            get
            {
                CanReadProperty("maLH", true);
                return _maLH;
            }
            set
            {
                CanWriteProperty("maLH", true);
                if (_maLH != value)
                {
                    _maLH = value;
                    PropertyHasChanged("maLH");
                }
            }
        }
     
        public string machuyenkhoa
        {
            get
            {
                CanReadProperty("machuyenkhoa", true);
                return _machuyenkhoa;
            }
            set
            {
                CanWriteProperty("machuyenkhoa", true);
                if (_machuyenkhoa != value)
                {
                    _machuyenkhoa = value;
                    PropertyHasChanged("machuyenkhoa");
                }
            }
        }
        public string KQ
        {
            get
            {
                CanReadProperty("KQ", true);
                if (_DaCoKQXN == true)
                    return "Đã có kết quả";
                else
                    return "";
            }
            
        }
        public string NgaySinh
        {
            get
            {
                CanReadProperty("NgaySinh", true);
                return _ngaySinh.Text;
            }
            set
            {
                CanWriteProperty("NgaySinh", true);
                if (_ngaySinh.Text != value)
                {
                    _ngaySinh.Text = value;
                    PropertyHasChanged("NgaySinh");
                }
            }
        }
        public byte Tuoi
        {
            get
            {
                byte _Age = 0;
                //CanReadProperty("Tuoi", true);
                if (_ngaySinh.Date.Year != 1)
                    _Age = Convert.ToByte(Convert.ToInt32(DateTime.Now.Year) - _ngaySinh.Date.Year);
                return _Age;
            }
            set
            {
                CanWriteProperty("Tuoi", true);
                if (_tuoi != value)
                {
                    _tuoi = value;
                    PropertyHasChanged("Tuoi");
                }
            }
        }
        public byte loaikq
        {
            get
            {
                
                CanReadProperty("loaikq", true);
                
                return _loaikq;
            }
            set
            {
                CanWriteProperty("loaikq", true);
                if (_loaikq != value)
                {
                    _loaikq = value;
                    PropertyHasChanged("loaikq");
                }
            }
        }
        public byte bn
        {
            get
            {

                CanReadProperty("bn", true);

                return _bn;
            }
            set
            {
                CanWriteProperty("bn", true);
                if (_bn != value)
                {
                    _bn = value;
                    PropertyHasChanged("bn");
                }
            }
        }
        public String HOTEN
        {
            get
            {
                CanReadProperty("HOTEN", true);
                return _hOTEN;
            }
            set
            {
                CanWriteProperty("HOTEN", true);
                if (_hOTEN != value)
                {
                    _hOTEN = value;
                    PropertyHasChanged("HOTEN");
                }
            }
        }

        public string GT
        {
            get
            {
                CanReadProperty("GT", true);
                if (_gt == false)
                    return "Nữ";
                else
                    return "Nam";
            }
            //set
            //{
            //    CanWriteProperty("GT", true);
            //    if (_gt != value)
            //    {
            //        _gt = value;
            //        PropertyHasChanged("GT");
            //    }
            //}
        }

        public String MABN
        {
            get
            {
                CanReadProperty("MABN", true);
                return _mABN;
            }
            set
            {
                CanWriteProperty("MABN", true);
                if (_mABN != value)
                {
                    _mABN = value;
                    PropertyHasChanged("MABN");
                }
            }
        }
        public String MaKhoa
        {
            get
            {
                CanReadProperty("Makhoa", true);
                return _MaKhoa;
            }
            set
            {
                CanWriteProperty("Makhoa", true);
                if (_MaKhoa != value)
                {
                    _MaKhoa = value;
                    PropertyHasChanged("Makhoa");
                }
            }
        }
        public String TenKhoa
        {
            get
            {
                CanReadProperty("TenKhoa", true);
                return _TenKhoa;
            }
            set
            {
                CanWriteProperty("TenKhoa", true);
                if (_TenKhoa != value)
                {
                    _TenKhoa = value;
                    PropertyHasChanged("TenKhoa");
                }
            }
        }
        public String DIACHI
        {
            get
            {
                CanReadProperty("DIACHI", true);
                return _dIACHI;
            }
            set
            {
                CanWriteProperty("DIACHI", true);
                if (_dIACHI != value)
                {
                    _dIACHI = value;
                    PropertyHasChanged("DIACHI");
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

        public String MaDV
        {
            get
            {
                CanReadProperty("MaDV", true);
                return _maDV;
            }
            set
            {
                CanWriteProperty("MaDV", true);
                if (_maDV != value)
                {
                    _maDV = value;
                    PropertyHasChanged("MaDV");
                }
            }
        }

        public String TENDV
        {
            get
            {
                CanReadProperty("TENDV", true);
                return _tENDV;
            }
            set
            {
                CanWriteProperty("TENDV", true);
                if (_tENDV != value)
                {
                    _tENDV = value;
                    PropertyHasChanged("TENDV");
                }
            }
        }

        public Int32 STT
        {
            get
            {
                CanReadProperty("STT", true);
                return _sTT;
            }
            set
            {
                CanWriteProperty("STT", true);
                if (_sTT != value)
                {
                    _sTT = value;
                    PropertyHasChanged("STT");
                }
            }
        }
        public int  STTKhoa
        {
            get
            {
                CanReadProperty("STTKhoa", true);
                return _STTKhoa;
            }
            set
            {
                CanWriteProperty("STTKhoa", true);
                if (_STTKhoa != value)
                {
                    _STTKhoa = value;
                    PropertyHasChanged("STTKhoa");
                }
            }
        }
        public String MADT
        {
            get
            {
                CanReadProperty("MADT", true);
                return _mADT;
            }
            set
            {
                CanWriteProperty("MADT", true);
                if (_mADT != value)
                {
                    _mADT = value;
                    PropertyHasChanged("MADT");
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

        public Int32 SOTT
        {
            get
            {
                CanReadProperty("SOTT", true);
                return _sOTT;
            }
            set
            {
                CanWriteProperty("SOTT", true);
                if (_sOTT != value)
                {
                    _sOTT = value;
                    PropertyHasChanged("SOTT");
                }
            }
        }

        public Byte TRANGTHAI
        {
            get
            {
                CanReadProperty("TRANGTHAI", true);
                return _tRANGTHAI;
            }
            set
            {
                CanWriteProperty("TRANGTHAI", true);
                if (_tRANGTHAI != value)
                {
                    _tRANGTHAI = value;
                    PropertyHasChanged("TRANGTHAI");
                }
            }
        }

        public string NGAYYC
        {
            get
            {
                CanReadProperty("NGAYYC", true);
                return _nGAYYC.Text;
            }
            set
            {
                CanWriteProperty("NGAYYC", true);
                if (_nGAYYC.Text != value)
                {
                    _nGAYYC.Text = value;
                    PropertyHasChanged("NGAYYC");
                }
            }
        }
        public string NGAYYCD
        {
            get
            {
                CanReadProperty("NGAYYCD", true);
                _nGAYYCD = _nGAYYC;
                _nGAYYCD.FormatString ="dd/MM/yyyy";  
                return _nGAYYCD.Text;
            }
            //set
            //{
            //    CanWriteProperty("NGAYYCD", true);
            //    if (_nGAYYCD.Text != value)
            //    {
            //        _nGAYYCD.Text = value;
            //        PropertyHasChanged("NGAYYCD");
            //    }
            //}
        }
        public string NGAYDK
        {
            get
            {
                CanReadProperty("NGAYDK", true);
                return _nGAYDK.Text;
            }
            set
            {
                CanWriteProperty("NGAYDK", true);
                if (_nGAYDK.Text != value)
                {
                    _nGAYDK.Text = value;
                    PropertyHasChanged("NGAYDK");
                }
            }
        }
        public string NGAYLAP
        {
            get
            {
                CanReadProperty("NGAYLAP", true);
                _nGAYLAP.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _nGAYLAP.Text;
            }
            set
            {
                CanWriteProperty("NGAYLAP", true);
                if (_nGAYLAP.Text != value)
                {
                    _nGAYLAP.Text = value;
                    PropertyHasChanged("NGAYLAP");
                }
            }
        }

        public String NGUOILAP
        {
            get
            {
                CanReadProperty("NGUOILAP", true);
                return _nGUOILAP;
            }
            set
            {
                CanWriteProperty("NGUOILAP", true);
                if (_nGUOILAP != value)
                {
                    _nGUOILAP = value;
                    PropertyHasChanged("NGUOILAP");
                }
            }
        }

        public String NGUOISD
        {
            get
            {
                CanReadProperty("NGUOISD", true);
                return _nGUOISD;
            }
            set
            {
                CanWriteProperty("NGUOISD", true);
                if (_nGUOISD != value)
                {
                    _nGUOISD = value;
                    PropertyHasChanged("NGUOISD");
                }
            }
        }

        public string NGAYSD
        {
            get
            {
                CanReadProperty("NGAYSD", true);
                return _nGAYSD.Text;
            }
            set
            {
                CanWriteProperty("NGAYSD", true);
                if (_nGAYSD.Text != value)
                {
                    _nGAYSD.Text = value;
                    PropertyHasChanged("NGAYSD");
                }
            }
        }

        public string NGAYHUY
        {
            get
            {
                CanReadProperty("NGAYHUY", true);
                return _nGAYHUY.Text;
            }
            set
            {
                CanWriteProperty("NGAYHUY", true);
                if (_nGAYHUY.Text != value)
                {
                    _nGAYHUY.Text = value;
                    PropertyHasChanged("NGAYHUY");
                }
            }
        }

        public String NGUOIHUY
        {
            get
            {
                CanReadProperty("NGUOIHUY", true);
                return _nGUOIHUY;
            }
            set
            {
                CanWriteProperty("NGUOIHUY", true);
                if (_nGUOIHUY != value)
                {
                    _nGUOIHUY = value;
                    PropertyHasChanged("NGUOIHUY");
                }
            }
        }

        public String TENNGUOILAP
        {
            get
            {
                CanReadProperty("TENNGUOILAP", true);
                return _tENNGUOILAP;
            }
            set
            {
                CanWriteProperty("TENNGUOILAP", true);
                if (_tENNGUOILAP != value)
                {
                    _tENNGUOILAP = value;
                    PropertyHasChanged("TENNGUOILAP");
                }
            }
        }

        public String TENNGUOISD
        {
            get
            {
                CanReadProperty("TENNGUOISD", true);
                return _tENNGUOISD;
            }
            set
            {
                CanWriteProperty("TENNGUOISD", true);
                if (_tENNGUOISD != value)
                {
                    _tENNGUOISD = value;
                    PropertyHasChanged("TENNGUOISD");
                }
            }
        }

        public String TENNGUOIHUY
        {
            get
            {
                CanReadProperty("TENNGUOIHUY", true);
                return _tENNGUOIHUY;
            }
            set
            {
                CanWriteProperty("TENNGUOIHUY", true);
                if (_tENNGUOIHUY != value)
                {
                    _tENNGUOIHUY = value;
                    PropertyHasChanged("TENNGUOIHUY");
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
            return _mASOKHAM + "!" + _STTKhoa.ToString().ToString().ToString().ToString() + "!" + _sTT.ToString().ToString().ToString().ToString();
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
		protected internal KhamBenh_C_GetsInfo()
		{	
			// Prevent direct creation
		}
		
        internal KhamBenh_C_GetsInfo(  int ordernumber,
  String hOTEN ,
		                                 Boolean gt ,
		                                 String mABN ,
		                                 String dIACHI ,
		                                 String mASOKHAM ,
		                                 String maDV ,
		                                 String tENDV ,
		                                 Int32 sTT ,
		                                 String mADT ,
		                                 String tENDT ,
		                                 Int32 sOTT ,
		                                 Byte tRANGTHAI ,
		                                 SmartDate nGAYYC ,
		                                 SmartDate nGAYLAP ,
		                                 String nGUOILAP ,
		                                 String nGUOISD ,
		                                 SmartDate nGAYSD ,
		                                 SmartDate nGAYHUY ,
		                                 String nGUOIHUY ,
		                                 String tENNGUOILAP ,
		                                 String tENNGUOISD ,
		                                 String tENNGUOIHUY ,
      Byte tuoi,
  SmartDate ngaySinh,
   SmartDate nGAYDK,
      Byte loaikq,
    string makhoa,
    string tenkhoa,
     int sttkhoa,
      Byte bn,
  Boolean dacokqxn,
    string machuyenkhoa, string malh
            )
        {
 _OrderNumber = ordernumber;
 _machuyenkhoa = machuyenkhoa;
 _maLH = malh;
   _hOTEN = hOTEN;
   _bn = bn;
		                                  _gt = gt;
   _DaCoKQXN = dacokqxn;
		                                  _mABN = mABN;
		                                  _dIACHI = dIACHI;
		                                  _mASOKHAM = mASOKHAM;
		                                  _maDV = maDV;
		                                  _tENDV = tENDV;
		                                  _sTT = sTT;
		                                  _mADT = mADT;
		                                  _tENDT = tENDT;
		                                  _sOTT = sOTT;
		                                  _tRANGTHAI = tRANGTHAI;
		                                  _nGAYYC = nGAYYC;
		                                  _nGAYLAP = nGAYLAP;
		                                  _nGUOILAP = nGUOILAP;
		                                  _nGUOISD = nGUOISD;
		                                  _nGAYSD = nGAYSD;
		                                  _nGAYHUY = nGAYHUY;
		                                  _nGUOIHUY = nGUOIHUY;
		                                  _tENNGUOILAP = tENNGUOILAP;
		                                  _tENNGUOISD = tENNGUOISD;
   _tENNGUOIHUY = tENNGUOIHUY;
   _tuoi = tuoi  ;
		                                  _ngaySinh = ngaySinh  ;
   _nGAYDK = nGAYDK ;
   _loaikq = loaikq;
   _TenKhoa = tenkhoa;
   _MaKhoa = makhoa;
   _STTKhoa = sttkhoa;
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
        ///// Load a <see cref="KhamBenh_C_GetsInfo" /> Object from given SafeDataReader.
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
        ///// Insert the new <see cref="KhamBenh_C_GetsInfo" /> Object to underlying database.
        ///// </summary>
        ////protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhamBenh_C_GetsInfo
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //            }
		
        ///// <summary>
        ///// Update all changes made on <see cref="KhamBenh_C_GetsInfo" /> Object to underlying database.
        ///// </summary>
        ////protected override void DataPortal_Update()
        ////{
        ////    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhamBenh_C_GetsInfo
        ////    if (IsDirty){
        ////        DataProvider.Instance().UpdateKhamBenh_C_GetsInfo(_maSoKham, _maBN, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _gio, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _ngayLap, _nguoiSD , _ngaySD, _nguoiSD , _maMay, _huy, _nguoiSD , _ngayHuy, _ngaySD1, _nguoiSD1, _dienThoai, _diaChi, _tongTien, _tongBHTra, _tongTienBH);
        ////        // public abstract void UpdateKhamBenh_C_GetsInfo(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, Byte _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, String _dienThoai, String _diaChi, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH);
        ////        // public override void UpdateKhamBenh_C_GetsInfo(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, Byte _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, String _dienThoai, String _diaChi, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH);
        ////        // {
        ////        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _gio, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _ngayLap.DBValue, _nguoiSD , _ngaySD.DBValue, _nguoiSD , _maMay, _huy, _nguoiSD , _ngayHuy.DBValue, _ngaySD1.DBValue, _nguoiSD1, _dienThoai, _diaChi, _tongTien, _tongBHTra, _tongTienBH);
        ////        // }				
        ////    }
        ////}
        //#endregion
	}

}
