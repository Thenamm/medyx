// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_File
// Kieu doi tuong  :	BenhAn_File
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	9/29/2009 9:33:09 AM
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
    /// This is a base generated class of <see cref="BenhAn_File" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class BenhAn_File : BusinessBase<BenhAn_File>
    {
        #region Business Methods

        #region State Fields
        private String _maBA = String.Empty;
        private Int32 _STTF = 0;
        private Int32 _sTT = 0;
        private Int32 _STTKhoa = 0;

        private String _maBN = String.Empty;
        private String _DuongDan = String.Empty;
        private String _DuongDanDD = String.Empty;
        private String _DangFile = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngaySD = new SmartDate(true);
        private SmartDate _ngaySDD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _MaKhoa = String.Empty;
        private Int32 _loaiPhieuKem = 0;
        private int _OrderNumber;
        #endregion

        #region Business Properties and Methods
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }

        public String MaBA
        {
            get
            {
                CanReadProperty("MaBA", true);
                return _maBA;
            }
            set
            {
                CanWriteProperty("MaBA", true);
                if (_maBA != value)
                {
                    _maBA = value;
                    PropertyHasChanged("MaBA");
                }
            }
        }
        public String MaKhoa
        {
            get
            {
                CanReadProperty("MaKhoa", true);
                return _MaKhoa;
            }
            set
            {
                CanWriteProperty("MaKhoa", true);
                if (_MaKhoa != value)
                {
                    _MaKhoa = value;
                    PropertyHasChanged("MaKhoa");
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
        public String NgaySDD
        {
            get
            {
                CanReadProperty("NgaySDD", true);
                _ngaySDD = _ngaySD;
                this._ngaySDD.FormatString = "dd/MM/yyyy";
                return _ngaySDD.Text;
            }

        }

        public String MaBN
        {
            get
            {
                CanReadProperty("MaBN", true);
                return _maBN;
            }
            set
            {
                CanWriteProperty("MaBN", true);
                if (_maBN != value)
                {
                    _maBN = value;
                    PropertyHasChanged("MaBN");
                }
            }
        }


        public String DuongDan
        {
            get
            {
                CanReadProperty("DuongDan", true);
                return _DuongDan;
            }
            set
            {
                CanWriteProperty("DuongDan", true);
                if (_DuongDan != value)
                {
                    _DuongDan = value;
                    PropertyHasChanged("DuongDan");
                }
            }
        }
        public String DuongDanDD
        {
            get
            {
                CanReadProperty("DuongDanDD", true);
                return _DuongDanDD;
            }
            set
            {
                CanWriteProperty("DuongDanDD", true);
                if (_DuongDanDD != value)
                {
                    _DuongDanDD = value;
                    PropertyHasChanged("DuongDanDD");
                }
            }
        }
        public String DangFile
        {
            get
            {
                CanReadProperty("DangFile", true);
                return _DangFile;
            }
            set
            {
                CanWriteProperty("DangFile", true);
                if (_DangFile != value)
                {
                    _DangFile = value;
                    PropertyHasChanged("DangFile");
                }
            }
        }

        public Int32 STTF
        {
            get
            {
                CanReadProperty("STTF", true);
                return _STTF;
            }
            set
            {
                CanWriteProperty("STTF", true);
                if (_STTF != value)
                {
                    _STTF = value;
                    PropertyHasChanged("STTF");
                }
            }
        }
        public String MaMay
        {
            get
            {
                CanReadProperty("MaMay", true);
                return _maMay;
            }
            set
            {
                CanWriteProperty("MaMay", true);
                if (_maMay != value)
                {
                    _maMay = value;
                    PropertyHasChanged("MaMay");
                }
            }
        }

        public Boolean Huy
        {
            get
            {
                CanReadProperty("Huy", true);
                return _huy;
            }
            set
            {
                CanWriteProperty("Huy", true);
                if (_huy != value)
                {
                    _huy = value;
                    PropertyHasChanged("Huy");
                }
            }
        }
        public Int32 LoaiPhieuKem
        {
            get
            {
                CanReadProperty("LoaiPhieuKem", true);
                return _loaiPhieuKem;
            }
            set
            {
                CanWriteProperty("LoaiPhieuKem", true);
                if (_loaiPhieuKem != value)
                {
                    _loaiPhieuKem = value;
                    PropertyHasChanged("LoaiPhieuKem");
                }
            }
        }

        public string NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                return _ngayHuy.Text;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy.Text != value)
                {
                    _ngayHuy.Text = value;
                    PropertyHasChanged("NgayHuy");
                }
            }
        }

        public String NguoiHuy
        {
            get
            {
                CanReadProperty("NguoiHuy", true);
                return _nguoiHuy;
            }
            set
            {
                CanWriteProperty("NguoiHuy", true);
                if (_nguoiHuy != value)
                {
                    _nguoiHuy = value;
                    PropertyHasChanged("NguoiHuy");
                }
            }
        }

        public string NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                return _ngayLap.Text;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap.Text != value)
                {
                    _ngayLap.Text = value;
                    PropertyHasChanged("NgayLap");
                }
            }
        }

        public String NguoiLap
        {
            get
            {
                CanReadProperty("NguoiLap", true);
                return _nguoiLap;
            }
            set
            {
                CanWriteProperty("NguoiLap", true);
                if (_nguoiLap != value)
                {
                    _nguoiLap = value;
                    PropertyHasChanged("NguoiLap");
                }
            }
        }

        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                return _ngaySD.Text;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD.Text != value)
                {
                    _ngaySD.Text = value;
                    PropertyHasChanged("NgaySD");
                }
            }
        }

        public String NguoiSD
        {
            get
            {
                CanReadProperty("NguoiSD", true);
                return _nguoiSD;
            }
            set
            {
                CanWriteProperty("NguoiSD", true);
                if (_nguoiSD != value)
                {
                    _nguoiSD = value;
                    PropertyHasChanged("NguoiSD");
                }
            }
        }

        public string NgaySD1
        {
            get
            {
                CanReadProperty("NgaySD1", true);
                return _ngaySD1.Text;
            }
            set
            {
                CanWriteProperty("NgaySD1", true);
                if (_ngaySD1.Text != value)
                {
                    _ngaySD1.Text = value;
                    PropertyHasChanged("NgaySD1");
                }
            }
        }

        public String NguoiSD1
        {
            get
            {
                CanReadProperty("NguoiSD1", true);
                return _nguoiSD1;
            }
            set
            {
                CanWriteProperty("NguoiSD1", true);
                if (_nguoiSD1 != value)
                {
                    _nguoiSD1 = value;
                    PropertyHasChanged("NguoiSD1");
                }
            }
        }
        public int STTKhoa
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


        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }
        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tenNguoiSD != value)
                {
                    _tenNguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
                }
            }
        }
        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
                }
            }
        }


        protected override Object GetIdValue()
        {
            return _maBA.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="BenhAn_File" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhAn_File NewBenhAn_File()
        {
            return new BenhAn_File();
        }
        //public static BenhAn_File GetBenhAn_File(Int32 sTT, String maBA, Int32 sTTKhoa)
        //{
        //    return DataPortal.Fetch<BenhAn_File>(new Criteria(sTT, maBA, sTTKhoa));
        //}
        internal static BenhAn_File GetBenhAn_File(SafeDataReader dr, int i)
        {
            return new BenhAn_File(dr, i);
        }
        //public static BenhAn_File GetBenhAn_File(String maBA, Int32 sTT)
        //{
        //    return DataPortal.Fetch<BenhAn_File>(new Criteria(maBA, sTT));
        //}

        /// <summary>
        /// Marks the <see cref="BenhAn_File" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        //public static void DeleteBenhAn_File(String maBA, Int32 sTT)
        //{
        //    DataPortal.Delete(new Criteria(maBA, sTT));
        //}
        public BenhAn_File()
        {
            // MarkAsChild();
        }
        #endregion

        //#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BenhAn_File()
        //{	
        //    // Prevent direct creation
        //}

        //#endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            public Criteria(String maBA, Int32 sTT)
            {
                _maBA = maBA;
                _sTT = sTT;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maBA.Equals(c._maBA))
                        return false;
                    if (!_sTT.Equals(c._sTT))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maBA;
            public String MaBA
            {
                get
                {
                    return _maBA;
                }
            }

            private Int32 _sTT;
            public Int32 STT
            {
                get
                {
                    return _sTT;
                }
            }

            private String _maMay;
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }

            private String _NguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _NguoiSD;
                }
            }

            public OtherCriteria(String Mamay, String Nguoisd, String maBA, Int32 sTT)
            {
                _maBA = maBA;
                _sTT = sTT;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }
        }
        #endregion

        #region Authorization

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        /// <summary>
        /// Retrieve an existing <see cref="BenhAn_File" /> Object based on data in the database.
        /// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBenhAn_File(String _maBA, Int32 _sTT);
        //    // public override IDataReader GetBenhAn_File(String _maBA, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_File(crit.MaBA, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        /// <summary>
        /// Load a <see cref="BenhAn_File" /> Object from given SafeDataReader.
        /// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
        //    if (dr.GetSmartDate("NgayDK", true) != null) _ngayDK = dr.GetSmartDate("NgayDK", true);
        //    if (dr.GetString("DuongDan") != null) _DuongDan = dr.GetString("DuongDan");
        //    if (dr.GetString("DangFile") != null) _DangFile = dr.GetString("DangFile");
        //    if (dr.GetInt32("STTF") != null) _STTF = dr.GetInt32("STTF");
        //    if (dr.GetDecimal("TongThu") != null) _tongThu = dr.GetDecimal("TongThu");
        //    if (dr.GetDecimal("TongChi") != null) _tongChi = dr.GetDecimal("TongChi");
        //    if (dr.GetSmartDate("NgayThu", true) != null) _ngayThu = dr.GetSmartDate("NgayThu", true);
        //    if (dr.GetSmartDate("NgayChi", true) != null) _ngayChi = dr.GetSmartDate("NgayChi", true);
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
        //    if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
        //    if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
        //    if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //    if (dr.GetString("LYDOThu") != null) _lYDOThu = dr.GetString("LYDOThu");
        //    if (dr.GetString("NGUOITHU") != null) _nGUOITHU = dr.GetString("NGUOITHU");
        //    if (dr.GetString("NGUOICHI") != null) _nGUOICHI = dr.GetString("NGUOICHI");
        //    if (dr.GetByte("LanIn") != null) _lanIn = dr.GetByte("LanIn");
        //    if (dr.GetByte("STTKhoa") != null) _STTKhoa = dr.GetByte("STTKhoa");
        //    if (dr.GetString("LYDOChi") != null) _lYDOChi = dr.GetString("LYDOChi");
        //}

        /// <summary>
        /// Insert the new <see cref="BenhAn_File" /> Object to underlying database.
        /// </summary>
        /// 

        private BenhAn_File(SafeDataReader dr, int i)
        {
            //  MarkAsChild();
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetString("MaBN") != null) _maBN = dr.GetString("MaBN");
            if (dr.GetByte("stt") != null) _sTT = dr.GetByte("stt");
            if (dr.GetString("DuongDan") != null) _DuongDan = dr.GetString("DuongDan");
            if (dr.GetString("DuongDanDD") != null) _DuongDanDD = dr.GetString("DuongDanDD");
            if (dr.GetString("MaKhoa") != null) _MaKhoa = dr.GetString("MaKhoa");
            if (dr.GetString("DangFile") != null) _DangFile = dr.GetString("DangFile");
            if (dr.GetInt32("STTF") != null) _STTF = dr.GetInt32("STTF");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetInt32("LoaiPhieuKem") != null) _loaiPhieuKem = dr.GetInt32("LoaiPhieuKem");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetByte("STTKhoa") != null) _STTKhoa = dr.GetByte("STTKhoa");
            if (dr.GetString("tennguoiSD") != null) _tenNguoiSD = dr.GetString("tennguoiSD");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");

            MarkOld();
        }

        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;


            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_File
            // Copy & paste ham duoi day vao file DataProvider.cs
            _STTF = DataProvider.Instance().InsertBenhAn_File(_maBA, _maBN, STTKhoa, STT, _MaKhoa, _DuongDan, _DuongDanDD, _DangFile, _maMay, _nguoiSD, _loaiPhieuKem);
            // public abstract String InsertBenhAn_File(String _maBA, String _maBN, SmartDate _ngayDK, String _DuongDan, String _DangFile, Int32 _STTF, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, String _maMay, String _nguoiLap, String _lYDOThu, String _nGUOITHU, Byte _lanIn, Byte _STTKhoa, String _lYDOChi);
            // public override String InsertBenhAn_File(String _maBA, String _maBN, SmartDate _ngayDK, String _DuongDan, String _DangFile, Int32 _STTF, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, String _maMay, String _nguoiLap, String _lYDOThu, String _nGUOITHU, Byte _lanIn, Byte _STTKhoa, String _lYDOChi)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_File_Create", _maBA, _maBN, _ngayDK.DBValue, _DuongDan, _DangFile, _STTF, _tongThu, _tongChi, _ngayThu.DBValue, _maMay, _nguoiSD , _lYDOThu, _nGUOITHU, _lanIn, _STTKhoa, _lYDOChi), String);
            // }
            MarkOld();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;

            ////_nguoiLap = _nguoiLap != "" ? _nguoiLap : HTC.ShareVariables.pub_sNguoiSD;
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_File
            // Copy & paste ham duoi day vao file DataProvider.cs
            _STTF = DataProvider.Instance().InsertBenhAn_File(_maBA, _maBN, STTKhoa, STT, _MaKhoa, _DuongDan, _DuongDanDD, _DangFile, _maMay, _nguoiSD, _loaiPhieuKem);
            // public abstract String InsertBenhAn_File(String _maBA, String _maBN, SmartDate _ngayDK, String _DuongDan, String _DangFile, Int32 _STTF, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, String _maMay, String _nguoiLap, String _lYDOThu, String _nGUOITHU, Byte _lanIn, Byte _STTKhoa, String _lYDOChi);
            // public override String InsertBenhAn_File(String _maBA, String _maBN, SmartDate _ngayDK, String _DuongDan, String _DangFile, Int32 _STTF, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, String _maMay, String _nguoiLap, String _lYDOThu, String _nGUOITHU, Byte _lanIn, Byte _STTKhoa, String _lYDOChi)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_File_Create", _maBA, _maBN, _ngayDK.DBValue, _DuongDan, _DangFile, _STTF, _tongThu, _tongChi, _ngayThu.DBValue, _maMay, _nguoiSD , _lYDOThu, _nGUOITHU, _lanIn, _STTKhoa, _lYDOChi), String);
            // }
            MarkOld();
        }
        /// <summary>
        /// Update all changes made on <see cref="BenhAn_File" /> Object to underlying database.
        /// </summary>
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;


            DataProvider.Instance().UpdateBenhAn_File(_maBA, _STTF, _maBN, STTKhoa, STT, _MaKhoa, _DuongDan, _DuongDanDD, _DangFile, _maMay, _huy, _nguoiSD, _loaiPhieuKem);
            // public abstract void UpdateBenhAn_File(String _maBA, Int32 _sTT, String _maBN, SmartDate _ngayDK, String _DuongDan, String _DangFile, Int32 _STTF, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, SmartDate _ngayChi, String _maMay, Boolean _huy, String _nguoiSD, String _lYDOThu, String _nGUOITHU, String _nGUOICHI, Byte _lanIn, String _lYDOChi);
            // public override void UpdateBenhAn_File(String _maBA, Int32 _sTT, String _maBN, SmartDate _ngayDK, String _DuongDan, String _DangFile, Int32 _STTF, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, SmartDate _ngayChi, String _maMay, Boolean _huy, String _nguoiSD, String _lYDOThu, String _nGUOITHU, String _nGUOICHI, Byte _lanIn, String _lYDOChi)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_File_Update", _maBA, _sTT, _maBN, _ngayDK.DBValue, _DuongDan, _DangFile, _STTF, _tongThu, _tongChi, _ngayThu.DBValue, _ngayChi.DBValue, _maMay, _huy, _nguoiSD , _lYDOThu, _nGUOITHU, _nGUOICHI, _lanIn, _lYDOChi);
            // }				
            MarkOld();
        }
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;


            DataProvider.Instance().UpdateBenhAn_File(_maBA, _STTF, _maBN, STTKhoa, STT, _MaKhoa, _DuongDan, _DuongDanDD, _DangFile, _maMay, _huy, _nguoiSD, _loaiPhieuKem);
            // public abstract void UpdateBenhAn_File(String _maBA, Int32 _sTT, String _maBN, SmartDate _ngayDK, String _DuongDan, String _DangFile, Int32 _STTF, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, SmartDate _ngayChi, String _maMay, Boolean _huy, String _nguoiSD, String _lYDOThu, String _nGUOITHU, String _nGUOICHI, Byte _lanIn, String _lYDOChi);
            // public override void UpdateBenhAn_File(String _maBA, Int32 _sTT, String _maBN, SmartDate _ngayDK, String _DuongDan, String _DangFile, Int32 _STTF, Decimal _tongThu, Decimal _tongChi, SmartDate _ngayThu, SmartDate _ngayChi, String _maMay, Boolean _huy, String _nguoiSD, String _lYDOThu, String _nGUOITHU, String _nGUOICHI, Byte _lanIn, String _lYDOChi)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_File_Update", _maBA, _sTT, _maBN, _ngayDK.DBValue, _DuongDan, _DangFile, _STTF, _tongThu, _tongChi, _ngayThu.DBValue, _ngayChi.DBValue, _maMay, _huy, _nguoiSD , _lYDOThu, _nGUOITHU, _nGUOICHI, _lanIn, _lYDOChi);
            // }				
            MarkOld();
        }
        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            //_nguoiHuy = HTC.ShareVariables.pub_sNguoiSD;
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD, _maBA, _sTT));
            MarkNew();
        }

        /// <summary>
        /// Delete the <see cref="BenhAn_File" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_File
            DataProvider.Instance().DeleteBenhAn_File(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT);
            // public abstract void DeleteBenhAn_File(String _maBA, Int32 _sTT);
            // public override void DeleteBenhAn_File(String _maBA, Int32 _sTT)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_File_Deleted", _maBA, _sTT);
            // }
        }

        #endregion
    }

}
