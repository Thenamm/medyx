// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMVTYT_Thau
// Kieu doi tuong  :	DMVTYT_Thau
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	3/17/2009 3:10:21 PM
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

namespace HTC.Business.CategoryList
{

    /// <summary>
    /// This is a base generated class of <see cref="DMVTYT_Thau" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMVTYT_Thau : BusinessBase<DMVTYT_Thau>
    {
        #region Business Methods

        #region State Fields

        private String _maVT = String.Empty;
        private String _maNCC = String.Empty;
        private String _namThau = String.Empty;
        private Decimal _soLuong = 0;
        private Decimal _slnhap = 0;
        private String _ghiChu = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private SmartDate _ngaySDD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private Decimal _canhBao = 0;
        private String _tenTM = String.Empty;
        private String _tenNCC = String.Empty;
        private String _TenNguoiSD = String.Empty;
        private String _maMay = String.Empty;
        private Byte _loai = 0;
        private int _OrderNumber;
        private String _TenDVT = String.Empty;
        private Decimal _donGiaTT = 0;
        #endregion

        #region Business Properties and Methods
        public string DonGiaTT
        {
            get
            {
                CanReadProperty("DonGiaTT", true);
                if (_donGiaTT == 0)
                {
                    return "0";
                }
                else if ((_donGiaTT - int.Parse(_donGiaTT.ToString("###"))) == 0)
                {
                    return _donGiaTT.ToString("###,###");
                }
                else
                {
                    return _donGiaTT.ToString("###,###.##");
                }
            }
            set
            {
                CanWriteProperty("DonGiaTT", true);

                if (_donGiaTT.ToString() != value)
                {
                    _donGiaTT = decimal.Parse(value);
                    PropertyHasChanged("DonGiaTT");
                }
            }
        }
        public String TenDVT
        {
            get
            {
                CanReadProperty("TenDVT", true);
                return _TenDVT;
            }
            set
            {
                CanWriteProperty("TenDVT", true);
                if (_TenDVT != value)
                {
                    _TenDVT = value;
                    PropertyHasChanged("TenDVT");
                }
            }
        }
        public Decimal slnhap
        {
            get
            {
                CanReadProperty("slnhap", true);
                return _slnhap;
            }
            set
            {
                CanWriteProperty("slnhap", true);
                if (_slnhap != value)
                {
                    _slnhap = value;
                    PropertyHasChanged("slnhap");
                }
            }
        }
       

        public Byte loai
        {
            get
            {
                CanReadProperty("loai", true);
                return _loai;
            }
            set
            {
                CanWriteProperty("loai", true);
                if (_loai != value)
                {
                    _loai = value;
                    PropertyHasChanged("loai");
                }
            }
        }
        public String MaVT
        {
            get
            {
                CanReadProperty("MaVT", true);
                return _maVT;
            }
            set
            {
                CanWriteProperty("MaVT", true);
                if (_maVT != value)
                {
                    _maVT = value;
                    PropertyHasChanged("MaVT");
                }
            }
        }

        public String MaNCC
        {
            get
            {
                CanReadProperty("MaNCC", true);
                return _maNCC;
            }
            set
            {
                CanWriteProperty("MaNCC", true);
                if (_maNCC != value)
                {
                    _maNCC = value;
                    PropertyHasChanged("MaNCC");
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
        public String NamThau
        {
            get
            {
                CanReadProperty("NamThau", true);
                return _namThau;
            }
            set
            {
                CanWriteProperty("NamThau", true);
                if (_namThau != value)
                {
                    _namThau = value;
                    PropertyHasChanged("NamThau");
                }
            }
        }

        public string SoLuong
        {
            get
            {
                CanReadProperty("SoLuong", true);
                if (_soLuong == 0)
                {
                    return "0";
                }
                else if (_soLuong - (int)(_soLuong) != 0)
                {
                    return _soLuong.ToString("###,###.###");
                }
                else
                {
                    return _soLuong.ToString("###,###");
                }
            }
            set
            {
                CanWriteProperty("SoLuong", true);

                if (_soLuong.ToString() != value)
                {
                    _soLuong = decimal.Parse(value);
                    PropertyHasChanged("SoLuong");
                }
            }
        }

        public String GhiChu
        {
            get
            {
                CanReadProperty("GhiChu", true);
                return _ghiChu;
            }
            set
            {
                CanWriteProperty("GhiChu", true);
                if (_ghiChu != value)
                {
                    _ghiChu = value;
                    PropertyHasChanged("GhiChu");
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

        public Decimal CanhBao
        {
            get
            {
                CanReadProperty("CanhBao", true);
                return _canhBao;
            }
            set
            {
                CanWriteProperty("CanhBao", true);
                if (_canhBao != value)
                {
                    _canhBao = value;
                    PropertyHasChanged("CanhBao");
                }
            }
        }

        public String TenTM
        {
            get
            {
                CanReadProperty("TenTM", true);
                return _tenTM;
            }
            set
            {
                CanWriteProperty("TenTM", true);
                if (_tenTM != value)
                {
                    _tenTM = value;
                    PropertyHasChanged("TenTM");
                }
            }
        }

        public String TenNCC
        {
            get
            {
                CanReadProperty("TenNCC", true);
                return _tenNCC;
            }
            set
            {
                CanWriteProperty("TenNCC", true);
                if (_tenNCC != value)
                {
                    _tenNCC = value;
                    PropertyHasChanged("TenNCC");
                }
            }
        }

        public String TenNguoiSD
        {
            get
            {
                CanReadProperty("TenNguoiSD", true);
                return _TenNguoiSD;
            }
            set
            {
                CanWriteProperty("TenNguoiSD", true);
                if (_TenNguoiSD != value)
                {
                    _TenNguoiSD = value;
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
            return _maVT.ToString() + "!" + _namThau.ToString().ToString() + "!" + _maNCC.ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMVTYT_Thau" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMVTYT_Thau NewDMVTYT_Thau()
        {
            return new DMVTYT_Thau();
            //return DataPortal.Create<DMVTYT_Thau>();
        }
        public static DMVTYT_Thau GetDMVTYT_Thau(String MaVT, Decimal NamThau, String MaNCC, String DK)
        {
            return DataPortal.Fetch<DMVTYT_Thau>(new Criteria(MaVT, NamThau, MaNCC, DK));
        }
        internal static DMVTYT_Thau GetDMVTYT_Thau(SafeDataReader dr)
        {
            return new DMVTYT_Thau(dr);
        }
        internal static DMVTYT_Thau GetDMVTYT_Thau(SafeDataReader dr,int i)
        {
            return new DMVTYT_Thau(dr,i);
        }
        /// <summary>
        /// Marks the <see cref="DMVTYT_Thau" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        //public static void DeleteDMVTYT_Thau(String MaVT, Decimal NamThau, String MaNCC)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maVT, NamThau, MaNCC));
        //}
        public DMVTYT_Thau()
        {
            MarkAsChild();
        }

        #endregion

        ////#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        ////protected internal DMVTYT_Thau()
        ////{	
        ////     Prevent direct creation
        ////}

        ////internal DMVTYT_Thau(Decimal ordernumber, String MaVT,
        ////                             String MaNCC ,
        ////                             String maVT ,
        ////                             Boolean huy ,
        ////                             SmartDate ngaySD ,
        ////                             String nguoiSD ,
        ////                             String maMay ,
        ////                             String tenKho ,
        ////                             String tenKhoa,
        ////                             string tenTM)
        ////{
        ////                               _NamThau = ordernumber;
        ////                               _MaVT = MaVT ;
        ////                              _MaNCC = MaNCC  ;
        ////                              _maVT = maVT  ;
        ////                              _huy = huy  ;
        ////                              _ngaySD = ngaySD  ;
        ////                              _nguoiSD = nguoiSD  ;
        ////                              _maMay = maMay  ;
        ////                              _tenKho = tenKho  ;
        ////                              _tenKhoa = tenKhoa;
        ////                              _tenTM = TenTM;

        ////}

        ////#endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _MaVT;
            public String MaVT
            {
                get
                {
                    return _MaVT;
                }
            }

            private Decimal _NamThau;
            public Decimal NamThau
            {
                get
                {
                    return _NamThau;
                }
            }

            private String _MaNCC;
            public String MaNCC
            {
                get
                {
                    return _MaNCC;
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

            public Criteria(String MaVT, Decimal NamThau, String MaNCC, String DK)
            {
                _MaVT = MaVT;
                _NamThau = NamThau;
                _MaNCC = MaNCC;
                _DK = DK;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaVT.Equals(c._MaVT))
                        return false;
                    if (!_NamThau.Equals(c._NamThau))
                        return false;
                    if (!_MaNCC.Equals(c._MaNCC))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaVT.ToString(), _NamThau.ToString(), _MaNCC.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        private class OtherCriteria
        {
            private string  _maMay =  "";
            public String MaMay
            {
                get
                {
                    return _maMay;
                }
            }

            private String _maVT;
            public String MaVT
            {
                get
                {
                    return _maVT;
                }

            }
            private String _maNCC;
            public String MaNCC
            {
                get
                {
                    return _maNCC;
                }

            }
            private String _namThau;
            public String NamThau
            {
                get
                {
                    return _namThau;
                }

            }

            public OtherCriteria(String MaVT, String MaNCC, String NamThau)
            {
                _maVT = MaVT;
                _maNCC = MaNCC;
                _namThau = NamThau;


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
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMVTYT_GiaQuay56(String _maVT);
            // public override IDataReader GetDMVTYT_GiaQuay56(String _maVT)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVT));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMVTYT_Thau(crit.MaVT, crit.NamThau, crit.MaNCC, crit.DK)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        private void Fetch(SafeDataReader dr)
        {

            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            if (dr.GetString("MaNCC") != null) _maNCC = dr.GetString("MaNCC");
            if (dr.GetString("NamThau") != null) _namThau = dr.GetString("NamThau");
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetDecimal("slnhap") != null) _slnhap = dr.GetDecimal("slnhap");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetDecimal("CanhBao") != null) _canhBao = dr.GetDecimal("CanhBao");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("TenNCC") != null) _tenNCC = dr.GetString("TenNCC");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetDecimal("DonGiaTT") != null) _donGiaTT = dr.GetDecimal("DonGiaTT");
           
        }
        #region Data Access

        private DMVTYT_Thau(SafeDataReader dr)
        {
            MarkAsChild();
            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            if (dr.GetString("MaNCC") != null) _maNCC = dr.GetString("MaNCC");
            if (dr.GetString("NamThau") != null) _namThau = dr.GetString("NamThau");
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetDecimal("slnhap") != null) _slnhap = dr.GetDecimal("slnhap");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetDecimal("CanhBao") != null) _canhBao = dr.GetDecimal("CanhBao");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("TenNCC") != null) _tenNCC = dr.GetString("TenNCC");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetDecimal("DonGiaTT") != null) _donGiaTT = dr.GetDecimal("DonGiaTT");
            MarkOld();
        }
        private DMVTYT_Thau(SafeDataReader dr,int i)
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("MaVT") != null) _maVT = dr.GetString("MaVT");
            if (dr.GetString("MaNCC") != null) _maNCC = dr.GetString("MaNCC");
            if (dr.GetString("NamThau") != null) _namThau = dr.GetString("NamThau");
            if (dr.GetDecimal("SoLuong") != null) _soLuong = dr.GetDecimal("SoLuong");
            if (dr.GetDecimal("slnhap") != null) _slnhap = dr.GetDecimal("slnhap");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetDecimal("CanhBao") != null) _canhBao = dr.GetDecimal("CanhBao");
            if (dr.GetString("TenTM") != null) _tenTM = dr.GetString("TenTM");
            if (dr.GetString("TenNCC") != null) _tenNCC = dr.GetString("TenNCC");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("TenDVT") != null) _TenDVT = dr.GetString("TenDVT");
            if (dr.GetDecimal("DonGiaTT") != null) _donGiaTT = dr.GetDecimal("DonGiaTT");
            MarkOld();
        }
        /// <summary>
        /// Insert the new <see cref="DMVTYT_Thau" /> Object to underlying database.
        /// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMVTYT_Thau
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
            _maVT = DataProvider.Instance().InsertDMVTYT_Thau(_maVT, _maNCC, _namThau, _soLuong, _ghiChu, _canhBao, _nguoiSD, _maMay, _loai);
            // public abstract String InsertDMVTYT_Thau(String _MaVT, String _MaNCC, String _maVT, String _nguoiSD, String _maMay);
            // public override String InsertDMVTYT_Thau(String _MaVT, String _MaNCC, String _maVT, String _nguoiSD, String _maMay)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_Thau_Create", _MaVT, _MaNCC, _maVT, _nguoiSD , _maMay), String);
            // }
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="DMVTYT_Thau" /> Object to underlying database.
        /// </summary>
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVTYT_Thau
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateDMVTYT_Thau(_maVT, _maNCC, _namThau, _soLuong, _ghiChu, _huy, _canhBao, _nguoiSD, _maMay);
            // public abstract void UpdateDMVTYT_Thau(String _MaVT, Decimal _NamThau, String _MaNCC, String _maVT, Boolean _huy, String _nguoiSD, String _maMay);
            // public override void UpdateDMVTYT_Thau(String _MaVT, Decimal _NamThau, String _MaNCC, String _maVT, Boolean _huy, String _nguoiSD, String _maMay)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_Thau_Update", _MaVT, _NamThau, _MaNCC, _maVT, _huy, _nguoiSD , _maMay);
            // }				
            MarkOld();
        }
        //internal void Delete()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVTYT_Thau
        //    if (!this.IsDirty)
        //        return;
        //    
        //      
        //    DataProvider.Instance().DeleteDMVTYT_Thau(_MaVT, _NamThau, _MaNCC);
        //    // public abstract void UpdateDMVTYT_Thau(String _MaVT, Decimal _NamThau, String _MaNCC, String _maVT, Boolean _huy, String _nguoiSD, String _maMay);
        //    // public override void UpdateDMVTYT_Thau(String _MaVT, Decimal _NamThau, String _MaNCC, String _maVT, Boolean _huy, String _nguoiSD, String _maMay)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_Thau_Update", _MaVT, _NamThau, _MaNCC, _maVT, _huy, _nguoiSD , _maMay);
        //    // }				
        //    MarkOld();
        //}
        //internal void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaVT, _NamThau, _MaNCC));
        //}

        /// <summary>
        /// Delete the <see cref="DMVTYT_Thau" />.
        /// </summary>
        //internal void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVTYT_Thau
        //    DataProvider.Instance().DeleteDMVTYT_Thau(crit.MaMay, crit.NguoiSD, crit.MaVT, crit.NamThau, crit.MaNCC);
        //    // public abstract void DeleteDMVTYT_Thau(String _MaVT, Decimal _NamThau, String _MaNCC);
        //    // public override void DeleteDMVTYT_Thau(String _MaVT, Decimal _NamThau, String _MaNCC)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVTYT_Thau_Deleted", _MaVT, _NamThau, _MaNCC);
        //    // }
        //}

        internal void DeleteSelf()
        {
            //if (!this.IsDirty)
            //    return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maVT, _maNCC, _namThau));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteDMVTYT_Thau(crit.MaVT, crit.MaNCC, crit.NamThau, _nguoiSD , crit.MaMay);
        }

        #endregion
    }

}
