// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_Chamsoc
// Kieu doi tuong  :	BenhAn_Chamsoc
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	6/16/2009 11:29:01 AM
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
    /// This is a base generated class of <see cref="BenhAn_Chamsoc" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class BenhAn_Chamsoc : BusinessBase<BenhAn_Chamsoc>
    {
        #region Business Methods

        #region State Fields

        private String _maBA = String.Empty;
        private Int32 _sTT = 0;
        private Int32 _sTTKhoa = 0;
        private SmartDate _tuNgay = new SmartDate(DateTime.Now);
        private SmartDate _tuNgayD = new SmartDate(DateTime.Now);
        private SmartDate _denNgay = new SmartDate(DateTime.Now);
        private SmartDate _denNgayD = new SmartDate(DateTime.Now);
        private String _mach = String.Empty;
        private String _apHuyet = String.Empty;
        private String _nhietDo = String.Empty;
        private String _TT = String.Empty;
        private String _NuocTieu = String.Empty;
        private String _dienbien = String.Empty;
        private String _yLenh = String.Empty;
        private String _yta = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _tenYTa = String.Empty;
        private String _tennguoiSD = String.Empty;
        private bool _chon = false;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods
        public String TT
        {
            get
            {
                CanReadProperty("TT", true);
                return _TT;
            }
            set
            {
                CanWriteProperty("TT", true);
                if (_TT != value)
                {
                    _TT = value;
                    PropertyHasChanged("TT");
                }
            }
        }

        public String NuocTieu
        {
            get
            {
                CanReadProperty("NuocTieu", true);
                return _NuocTieu;
            }
            set
            {
                CanWriteProperty("NuocTieu", true);
                if (_NuocTieu != value)
                {
                    _NuocTieu = value;
                    PropertyHasChanged("NuocTieu");
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

        public Int32 STTKhoa
        {
            get
            {
                CanReadProperty("STTKhoa", true);
                return _sTTKhoa;
            }
            set
            {
                CanWriteProperty("STTKhoa", true);
                if (_sTTKhoa != value)
                {
                    _sTTKhoa = value;
                    PropertyHasChanged("STTKhoa");
                }
            }
        }

        public string TuNgay
        {
            get
            {
                CanReadProperty("TuNgay", true);
                _tuNgay.FormatString = "dd/MM/yyyy HH:mm";
                return _tuNgay.Text;
            }
            set
            {
                CanWriteProperty("TuNgay", true);
                if (_tuNgay.Text != value)
                {
                    _tuNgay.Text = value;

                    PropertyHasChanged("TuNgay");
                }
            }
        }
        public string TuNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _tuNgayD = _tuNgay;
                this._tuNgayD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _tuNgayD.Text;
            }

        }

        public string DenNgay
        {
            get
            {
                CanReadProperty("DenNgay", true);
                _denNgay.FormatString = "dd/MM/yyyy HH:mm";
                return _denNgay.Text;
            }
            set
            {
                CanWriteProperty("DenNgay", true);
                if (_denNgay.Text != value)
                {
                    _denNgay.Text = value;

                    PropertyHasChanged("DenNgay");
                }
            }
        }
        public string DenNgayD
        {
            get
            {
                CanReadProperty("TuNgayD", true);
                _denNgayD = _denNgay;
                this._denNgayD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _denNgayD.Text;
            }

        }

        public String Dienbien
        {
            get
            {
                CanReadProperty("Dienbien", true);
                return _dienbien;
            }
            set
            {
                CanWriteProperty("Dienbien", true);
                if (_dienbien != value)
                {
                    _dienbien = value;
                    PropertyHasChanged("Dienbien");
                }
            }
        }

        public String YLenh
        {
            get
            {
                CanReadProperty("YLenh", true);
                return _yLenh;
            }
            set
            {
                CanWriteProperty("YLenh", true);
                if (_yLenh != value)
                {
                    _yLenh = value;
                    PropertyHasChanged("YLenh");
                }
            }
        }

        public String Yta
        {
            get
            {
                CanReadProperty("Yta", true);
                return _yta;
            }
            set
            {
                CanWriteProperty("Yta", true);
                if (_yta != value)
                {
                    _yta = value;
                    PropertyHasChanged("Yta");
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

        public string NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy";
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

        public String TenYTa
        {
            get
            {
                CanReadProperty("TenYTa", true);
                return _tenYTa;
            }
            set
            {
                CanWriteProperty("TenYTa", true);
                if (_tenYTa != value)
                {
                    _tenYTa = value;
                    PropertyHasChanged("TenYTa");
                }
            }
        }

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _tennguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_tennguoiSD != value)
                {
                    _tennguoiSD = value;
                    PropertyHasChanged("TenNguoiSD");
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
                if (!_OrderNumber.Equals(value))
                {
                    _OrderNumber = value;
                }
            }
        }
        public bool chon
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                CanReadProperty(true);
                return _chon;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_chon.Equals(value))
                {
                    _chon = value;
                    //PropertyHasChanged();
                }
            }
        }
        protected override Object GetIdValue()
        {
            return _maBA.ToString() + "!" + _sTT.ToString().ToString() + "!" + _sTTKhoa.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {
            //TODO: add validation rules

            //ValidationRules.AddRule<BenhAn_Chamsoc>(ValidationNgaySinh<BenhAn_Chamsoc>, "TuNgay");
            ValidationRules.AddDependantProperty("TuNgay", "DenNgay");

        }

        //private static bool ValidationNgaySinh<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_Chamsoc
        //{
        //    if (target._tuNgay.Date > System.DateTime.Now.AddDays(1))
        //    {
        //        e.Description = "VALIDATION_NOW";
        //        return false;
        //    }
        //    else
        //        return true;
        //}
        private static bool ValidationNgaySinhNgayHC<T>(T target, Csla.Validation.RuleArgs e) where T : BenhAn_Chamsoc
        {
            if (target._tuNgay > target._denNgay)
            {
                e.Description = "Từ ngày không được lớn hơn đến ngày";
                return false;
            }
            else
                return true;
        }
        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="BenhAn_Chamsoc" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 

        public static BenhAn_Chamsoc NewBenhAn_Chamsoc()
        {
            return DataPortal.Create<BenhAn_Chamsoc>();
        }
        public static BenhAn_Chamsoc GetBenhAn_Chamsoc(String maBA, Int32 sTT, Int32 sTTKhoa)
        {
            return DataPortal.Fetch<BenhAn_Chamsoc>(new Criteria(maBA, sTT, sTTKhoa));
        }

        /// <summary>
        /// Marks the <see cref="BenhAn_Chamsoc" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteBenhAn_Chamsoc(String maBA, Int32 sTT, Int32 sTTKhoa, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(maBA, sTT, sTTKhoa,mamay,nguoihuy));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal BenhAn_Chamsoc()
        {
            // Prevent direct creation
        }

        internal BenhAn_Chamsoc(
  int OrderNumber,
  String maBA,
  Int32 sTT,
  Int32 sTTKhoa,
  SmartDate tuNgay,
  SmartDate denNgay,
  String dienbien,
  String yLenh,
  String yta,
  String maMay,
  Boolean huy,
  SmartDate ngaySD,
  String nguoiSD,
  String tenYTa,
  String tennguoiSD,
  String mach,
  String aphuyet,
  String nhietdo,
  String tt,
  String nuoctieu

                                )
        {
            _OrderNumber = OrderNumber;
            _maBA = maBA;
            _sTT = sTT;
            _mach = mach;
            _apHuyet = aphuyet;
            _TT = tt;
            _NuocTieu = nuoctieu;
            _sTTKhoa = sTTKhoa;
            _tuNgay = tuNgay;
            _denNgay = denNgay;
            _dienbien = dienbien;
            _yLenh = yLenh;
            _yta = yta;
            _maMay = maMay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = tennguoiSD;
            _tenYTa = tenYTa;
            _tennguoiSD = tennguoiSD;
        }

        #endregion

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

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
                }
            }

            public Criteria(String maBA, Int32 sTT, Int32 sTTKhoa)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;
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
                    if (!_sTTKhoa.Equals(c._sTTKhoa))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maBA.ToString(), _sTT.ToString(), _sTTKhoa.ToString()).GetHashCode();
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

            private Int32 _sTTKhoa;
            public Int32 STTKhoa
            {
                get
                {
                    return _sTTKhoa;
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
            public OtherCriteria( String maba, Int32 sTT, Int32 sTTKhoa,String Mamay, String Nguoisd)
            {
                _maBA = maba;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTT = sTT;
                _sTTKhoa = sTTKhoa;

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
        /// Retrieve an existing <see cref="BenhAn_Chamsoc" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetBenhAn_Chamsoc(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override IDataReader GetBenhAn_Chamsoc(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Chamsoc_GET", _maBA, _sTT, _sTTKhoa));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_Chamsoc(crit.MaBA, crit.STT, crit.STTKhoa)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        /// <summary>
        /// Load a <see cref="BenhAn_Chamsoc" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            if (dr.GetInt32("STTKhoa") != null) _sTTKhoa = dr.GetInt32("STTKhoa");
            if (dr.GetSmartDate("TuNgay", true) != null) _tuNgay = dr.GetSmartDate("TuNgay", true);
            if (dr.GetSmartDate("DenNgay", true) != null) _denNgay = dr.GetSmartDate("DenNgay", true);
            if (dr.GetString("Dienbien") != null) _dienbien = dr.GetString("Dienbien");
            if (dr.GetString("YLenh") != null) _yLenh = dr.GetString("YLenh");
            if (dr.GetString("Yta") != null) _yta = dr.GetString("Yta");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("TenYta") != null) _tenYTa = dr.GetString("TenYta");
            if (dr.GetString("TenNguoiSD") != null) _tennguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("mach") != null) _mach = dr.GetString("mach");
            if (dr.GetString("aphuyet") != null) _apHuyet = dr.GetString("aphuyet");
            if (dr.GetString("nhietdo") != null) _nhietDo = dr.GetString("nhietdo");
            if (dr.GetString("tt") != null) _TT = dr.GetString("tt");
            if (dr.GetString("nuoctieu") != null) _NuocTieu = dr.GetString("nuoctieu");
        }

        /// <summary>
        /// Insert the new <see cref="BenhAn_Chamsoc" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertBenhAn_Chamsoc
            // Copy & paste ham duoi day vao file DataProvider.cs
              
            _maBA = DataProvider.Instance().InsertBenhAn_Chamsoc(_maBA, _sTTKhoa, _tuNgay, _denNgay, _dienbien, _yLenh, _yta, _maMay, _nguoiSD, _mach, _apHuyet, _nhietDo, _TT, _NuocTieu);
            // public abstract String InsertBenhAn_Chamsoc(String _maBA, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD);
            // public override String InsertBenhAn_Chamsoc(String _maBA, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Chamsoc_CREATE", _maBA, _sTT, _sTTKhoa, _tuNgay.DBValue, _denNgay.DBValue, _dienbien, _yLenh, _yta, _maMay, _nguoiSD));
            // }
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="BenhAn_Chamsoc" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Chamsoc
              
            if (IsDirty)
            {
                DataProvider.Instance().UpdateBenhAn_Chamsoc(_maBA, _sTT, _sTTKhoa, _tuNgay, _denNgay, _dienbien, _yLenh, _yta, _huy, _maMay, _nguoiSD, _mach, _apHuyet, _nhietDo, _TT, _NuocTieu);
                // public abstract void UpdateBenhAn_Chamsoc(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, String _maMay, Boolean _huy, String _nguoiSD);
                // public override void UpdateBenhAn_Chamsoc(String _maBA, Int32 _sTT, Int32 _sTTKhoa, SmartDate _tuNgay, SmartDate _denNgay, String _dienbien, String _yLenh, String _yta, String _maMay, Boolean _huy, String _nguoiSD)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Chamsoc_UPDATE", _maBA, _sTT, _sTTKhoa, _tuNgay.DBValue, _denNgay.DBValue, _dienbien, _yLenh, _yta, _maMay, _huy, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria( _maBA, _sTT, _sTTKhoa,_maMay, _nguoiSD ));
        }

        /// <summary>
        /// Delete the <see cref="BenhAn_Chamsoc" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_Chamsoc
            DataProvider.Instance().DeleteBenhAn_Chamsoc(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa);
            // public abstract void DeleteBenhAn_Chamsoc(String _maBA, Int32 _sTT, Int32 _sTTKhoa);
            // public override void DeleteBenhAn_Chamsoc(String _maBA, Int32 _sTT, Int32 _sTTKhoa)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_Chamsoc_DELETED", _maBA, _sTT, _sTTKhoa);
            // }
        }

        #endregion
    }

}
