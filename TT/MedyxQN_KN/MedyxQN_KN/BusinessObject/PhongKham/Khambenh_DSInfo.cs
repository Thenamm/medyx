// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Khambenh_DSInfo
// Kieu doi tuong  :	Khambenh_DSInfo
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
	/// This is a base generated class of <see cref="Khambenh_DSInfo" /> Business Object.
	/// </summary>
	
	[Serializable()]
	public partial class Khambenh_DSInfo : BusinessBase<Khambenh_DSInfo>
	{
		#region Business Methods
		
		#region State Fields
         private String _hOTEN = String.Empty;
        private Boolean _gt = false;
        private String _mABN = String.Empty;
        private String _dIACHI = String.Empty;
        private String _mASOKHAM = String.Empty;
        private String _mADT = String.Empty;
        private String _tENDT = String.Empty;
        private SmartDate _nGAYDK = new SmartDate(true);
        private int _OrderNumber;
        private Byte _tuoi = 0;
       
        private SmartDate _ngaySinh = new SmartDate(true);
      
       
		#endregion
		
		#region Business Properties and Methods


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

        public String MaSoKham
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
            return _mASOKHAM;
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
		protected internal Khambenh_DSInfo()
		{	
			// Prevent direct creation
		}
		
        internal Khambenh_DSInfo(  int ordernumber,
  String hOTEN ,
		                                 Boolean gt ,
		                                 String mABN ,
		                                 String dIACHI ,
		                                 String mASOKHAM ,
		                               
		                                 String mADT ,
		                                 String tENDT ,
		                               
      Byte tuoi,
  SmartDate ngaySinh,
   SmartDate nGAYDK
     
            )
        {
 _OrderNumber = ordernumber;
 
   _hOTEN = hOTEN;
   
		                                  _gt = gt;
  
		                                  _mABN = mABN;
		                                  _dIACHI = dIACHI;
		                                  _mASOKHAM = mASOKHAM;
		                               
		                                 
		                                  _mADT = mADT;
		                                  _tENDT = tENDT;
		                                
   _tuoi = tuoi  ;
		                                  _ngaySinh = ngaySinh  ;
   _nGAYDK = nGAYDK ;
  
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
        ///// Load a <see cref="Khambenh_DSInfo" /> Object from given SafeDataReader.
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
        ///// Insert the new <see cref="Khambenh_DSInfo" /> Object to underlying database.
        ///// </summary>
        ////protected override void DataPortal_Insert()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertKhambenh_DSInfo
        //    // Copy & paste ham duoi day vao file DataProvider.cs
        //            }
		
        ///// <summary>
        ///// Update all changes made on <see cref="Khambenh_DSInfo" /> Object to underlying database.
        ///// </summary>
        ////protected override void DataPortal_Update()
        ////{
        ////    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateKhambenh_DSInfo
        ////    if (IsDirty){
        ////        DataProvider.Instance().UpdateKhambenh_DSInfo(_maSoKham, _maBN, _maDT, _sothe, _giatriDN, _maBV, _maTinh, _ngayKT, _gio, _ngayduyet, _nguoiduyet, _ngayQT, _ngayQTTT, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _ngayLap, _nguoiSD , _ngaySD, _nguoiSD , _maMay, _huy, _nguoiSD , _ngayHuy, _ngaySD1, _nguoiSD1, _dienThoai, _diaChi, _tongTien, _tongBHTra, _tongTienBH);
        ////        // public abstract void UpdateKhambenh_DSInfo(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, Byte _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, String _dienThoai, String _diaChi, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH);
        ////        // public override void UpdateKhambenh_DSInfo(String _maSoKham, String _maBN, String _maDT, String _sothe, SmartDate _giatriDN, String _maBV, String _maTinh, SmartDate _ngayKT, String _gio, SmartDate _ngayduyet, String _nguoiduyet, SmartDate _ngayQT, SmartDate _ngayQTTT, String _nguoiQT, String _maBenhNoiGT, String _maNoiGT, String _cDNoiGT, String _ghichu, Byte _loaiKham, Boolean _cungtra, Decimal _ck, SmartDate _ngayLap, String _nguoiLap, SmartDate _ngaySD, String _nguoiSD, String _maMay, Boolean _huy, Byte _nguoiHuy, SmartDate _ngayHuy, SmartDate _ngaySD1, String _nguoiSD1, String _dienThoai, String _diaChi, Decimal _tongTien, Decimal _tongBHTra, Decimal _tongTienBH);
        ////        // {
        ////        //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maSoKham, _maBN, _maDT, _sothe, _giatriDN.DBValue, _maBV, _maTinh, _ngayKT.DBValue, _gio, _ngayduyet.DBValue, _nguoiduyet, _ngayQT.DBValue, _ngayQTTT.DBValue, _nguoiQT, _maBenhNoiGT, _maNoiGT, _cDNoiGT, _ghichu, _loaiKham, _cungtra, _ck, _ngayLap.DBValue, _nguoiSD , _ngaySD.DBValue, _nguoiSD , _maMay, _huy, _nguoiSD , _ngayHuy.DBValue, _ngaySD1.DBValue, _nguoiSD1, _dienThoai, _diaChi, _tongTien, _tongBHTra, _tongTienBH);
        ////        // }				
        ////    }
        ////}
        //#endregion
	}

}
