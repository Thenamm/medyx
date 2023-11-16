// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMVaiTro_PhuCap
// Kieu doi tuong  :	DMVaiTro_PhuCap
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
    /// This is a base generated class of <see cref="DMVaiTro_PhuCap" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMVaiTro_PhuCap : BusinessBase<DMVaiTro_PhuCap>
    {
        #region Business Methods

        #region State Fields

        private Byte _maVaiTro = 0;
        private String _maChungLoai = String.Empty;
        private String _maLH = String.Empty;
        private String _ghiChu = String.Empty;
        private String _maMay = String.Empty;
        private Byte _loai = 0;
        private Boolean _huy = false;
        private Boolean _khongSD = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private SmartDate _ngaySDD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private Decimal _soTien = 0;
        private Decimal _soTienTN = 0;
        private String _tENCHUNGLOAI = String.Empty;
        private String _tENNGUOISD = String.Empty;
        private String _tENLH = String.Empty;
        private String _tENVAITRO = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods
        public Byte MaVaiTro
        {
            get
            {
                CanReadProperty("MaVaiTro", true);
                return _maVaiTro;
            }
            set
            {
                CanWriteProperty("MaVaiTro", true);
                if (_maVaiTro != value)
                {
                    _maVaiTro = value;
                    PropertyHasChanged("MaVaiTro");
                }
            }
        }

        public String MaChungLoai
        {
            get
            {
                CanReadProperty("MaChungLoai", true);
                return _maChungLoai;
            }
            set
            {
                CanWriteProperty("MaChungLoai", true);
                if (_maChungLoai != value)
                {
                    _maChungLoai = value;
                    PropertyHasChanged("MaChungLoai");
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
        public String MaLH
        {
            get
            {
                CanReadProperty("MaLH", true);
                return _maLH;
            }
            set
            {
                CanWriteProperty("MaLH", true);
                if (_maLH != value)
                {
                    _maLH = value;
                    PropertyHasChanged("MaLH");
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

        public Byte Loai
        {
            get
            {
                CanReadProperty("Loai", true);
                return _loai;
            }
            set
            {
                CanWriteProperty("Loai", true);
                if (_loai != value)
                {
                    _loai = value;
                    PropertyHasChanged("Loai");
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

        public Boolean KhongSD
        {
            get
            {
                CanReadProperty("KhongSD", true);
                return _khongSD;
            }
            set
            {
                CanWriteProperty("KhongSD", true);
                if (_khongSD != value)
                {
                    _khongSD = value;
                    PropertyHasChanged("KhongSD");
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

        public string SoTien
        {
            get
            {
                CanReadProperty("SoTien", true);
                //  _thanhTien = (_soLuong * _donGia * (100 + _chietKhau)) / 100; 
                return _soTien.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("SoTien", true);

                if (_soTien.ToString() != value)
                {
                    _soTien = decimal.Parse(value);
                    PropertyHasChanged("SoTien");
                }
            }
        }
        public string SoTienNT
        {
            get
            {
                CanReadProperty("SoTienNT", true);
                //  _thanhTien = (_soLuong * _donGia * (100 + _chietKhau)) / 100; 
                return _soTienTN.ToString("###,###.00");
            }
            set
            {
                CanWriteProperty("SoTienNT", true);

                if (_soTienTN.ToString() != value)
                {
                    _soTienTN = decimal.Parse(value);
                    PropertyHasChanged("SoTienNT");
                }
            }
        }

        public String TENCHUNGLOAI
        {
            get
            {
                CanReadProperty("TENCHUNGLOAI", true);
                return _tENCHUNGLOAI;
            }
            set
            {
                CanWriteProperty("TENCHUNGLOAI", true);
                if (_tENCHUNGLOAI != value)
                {
                    _tENCHUNGLOAI = value;
                    PropertyHasChanged("TENCHUNGLOAI");
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

        public String TENLH
        {
            get
            {
                CanReadProperty("TENLH", true);
                return _tENLH;
            }
            set
            {
                CanWriteProperty("TENLH", true);
                if (_tENLH != value)
                {
                    _tENLH = value;
                    PropertyHasChanged("TENLH");
                }
            }
        }

        public String TENVAITRO
        {
            get
            {
                CanReadProperty("TENVAITRO", true);
                return _tENVAITRO;
            }
            set
            {
                CanWriteProperty("TENVAITRO", true);
                if (_tENVAITRO != value)
                {
                    _tENVAITRO = value;
                    PropertyHasChanged("TENVAITRO");
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
            return _maVaiTro.ToString() + "!" + _maChungLoai.ToString().ToString() + "!" + _maLH.ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion

        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMVaiTro_PhuCap" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMVaiTro_PhuCap NewDMVaiTro_PhuCap()
        {
            return new DMVaiTro_PhuCap();
            //return DataPortal.Create<DMVaiTro_PhuCap>();
        }
        public static DMVaiTro_PhuCap GetDMVaiTro_PhuCap( byte MaVaiTro,string MaChungLoai, string MaLH)
        {
            return DataPortal.Fetch<DMVaiTro_PhuCap>(new Criteria( MaVaiTro, MaChungLoai,  MaLH  ));
        }
        internal static DMVaiTro_PhuCap GetDMVaiTro_PhuCap(SafeDataReader dr,int i)
        {
            return new DMVaiTro_PhuCap(dr,i);
        }
        /// <summary>
        /// Marks the <see cref="DMVaiTro_PhuCap" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        //public static void DeleteDMVaiTro_PhuCap(String MaThuoc, Decimal NamThau, String MaNCC)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maThuoc, NamThau, MaNCC));
        //}
        public DMVaiTro_PhuCap()
        {
            MarkAsChild();
        }

        #endregion

        ////#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        ////protected internal DMVaiTro_PhuCap()
        ////{	
        ////     Prevent direct creation
        ////}

        ////internal DMVaiTro_PhuCap(Decimal ordernumber, String MaThuoc,
        ////                             String MaNCC ,
        ////                             String maThuoc ,
        ////                             Boolean huy ,
        ////                             SmartDate ngaySD ,
        ////                             String nguoiSD ,
        ////                             String maMay ,
        ////                             String tenKho ,
        ////                             String tenKhoa,
        ////                             string tenTM)
        ////{
        ////                               _NamThau = ordernumber;
        ////                               _MaThuoc = MaThuoc ;
        ////                              _MaNCC = MaNCC  ;
        ////                              _maThuoc = maThuoc  ;
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
        protected class Criteria
        {
            private String _maChungLoai;
            public String MaChungLoai
            {
                get
                {
                    return _maChungLoai;
                }
            }

            private String _maLH;
            public String MaLH
            {
                get
                {
                    return _maLH;
                }
            }

            private byte _maVaiTro;
            public byte MaVaiTro
            {
                get
                {
                    return _maVaiTro;
                }
            }
            public Criteria( Byte MaVaiTro,String MaChungLoai, string MaLH)
            {
                _maVaiTro = MaVaiTro;
                _maChungLoai = MaChungLoai;
                _maLH = MaLH;   
            }


        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maChungLoai;
            public String MaChungLoai
            {
                get
                {
                    return _maChungLoai;
                }
            }

            private String _maLH;
            public String MaLH
            {
                get
                {
                    return _maLH;
                }
            }

            private byte _maVaiTro;
            public byte MaVaiTro
            {
                get
                {
                    return _maVaiTro;
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

            public OtherCriteria(String MaChungLoai, string MaLH, Byte MaVaiTro, String Mamay, String Nguoisd)
            {
                _maChungLoai = MaChungLoai;
                _maLH = MaLH;
                _maVaiTro = MaVaiTro;
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
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMThuoc_GiaQuay56(String _maThuoc);
            // public override IDataReader GetDMThuoc_GiaQuay56(String _maThuoc)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maThuoc));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMVaiTro_PhuCap( crit.MaVaiTro, crit.MaChungLoai , crit.MaLH)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        private void Fetch(SafeDataReader dr )
        {

         
            if (dr.GetByte("MaVaiTro") != null) _maVaiTro = dr.GetByte("MaVaiTro");
            if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
            if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("KhongSD") != null) _khongSD = dr.GetBoolean("KhongSD");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetDecimal("SoTien") != null) _soTien = dr.GetDecimal("SoTien");
            if (dr.GetDecimal("SoTienTN") != null) _soTienTN = dr.GetDecimal("SoTienTN");
            if (dr.GetString("TENCHUNGLOAI") != null) _tENCHUNGLOAI = dr.GetString("TENCHUNGLOAI");
            if (dr.GetString("TENNGUOISD") != null) _tENNGUOISD = dr.GetString("TENNGUOISD");
            if (dr.GetString("TENLH") != null) _tENLH = dr.GetString("TENLH");
            if (dr.GetString("TENVAITRO") != null) _tENVAITRO = dr.GetString("TENVAITRO");
        }
        #region Data Access

        private DMVaiTro_PhuCap(SafeDataReader dr, int i)
        {
            MarkAsChild();
            _OrderNumber = i;
         
            if (dr.GetByte("MaVaiTro") != null) _maVaiTro = dr.GetByte("MaVaiTro");
            if (dr.GetString("MaChungLoai") != null) _maChungLoai = dr.GetString("MaChungLoai");
            if (dr.GetString("MaLH") != null) _maLH = dr.GetString("MaLH");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetByte("Loai") != null) _loai = dr.GetByte("Loai");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("KhongSD") != null) _khongSD = dr.GetBoolean("KhongSD");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetDecimal("SoTien") != null) _soTien = dr.GetDecimal("SoTien");
            if (dr.GetDecimal("SoTienTN") != null) _soTienTN = dr.GetDecimal("SoTienTN");
            if (dr.GetString("TENCHUNGLOAI") != null) _tENCHUNGLOAI = dr.GetString("TENCHUNGLOAI");
            if (dr.GetString("TENNGUOISD") != null) _tENNGUOISD = dr.GetString("TENNGUOISD");
            if (dr.GetString("TENLH") != null) _tENLH = dr.GetString("TENLH");
            if (dr.GetString("TENVAITRO") != null) _tENVAITRO = dr.GetString("TENVAITRO");
            MarkOld();
        }
        /// <summary>
        /// Insert the new <see cref="DMVaiTro_PhuCap" /> Object to underlying database.
        /// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMVaiTro_PhuCap
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
            _maChungLoai  = DataProvider.Instance().InsertDMVaiTro_PhuCap( _maVaiTro,  _maChungLoai,  _maLH,  _ghiChu,  _maMay,  _loai,  _nguoiSD,  _soTien, _soTienTN );
            // public abstract String InsertDMVaiTro_PhuCap(String _MaThuoc, String _MaNCC, String _maThuoc, String _nguoiSD, String _maMay);
            // public override String InsertDMVaiTro_PhuCap(String _MaThuoc, String _MaNCC, String _maThuoc, String _nguoiSD, String _maMay)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVaiTro_PhuCap_Create", _MaThuoc, _MaNCC, _maThuoc, _nguoiSD , _maMay), String);
            // }
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="DMVaiTro_PhuCap" /> Object to underlying database.
        /// </summary>
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVaiTro_PhuCap
            if (!this.IsDirty)
                return;
            //
              
            DataProvider.Instance().UpdateDMVaiTro_PhuCap( _maVaiTro,  _maChungLoai,  _maLH,  _ghiChu,  _maMay,  _loai,  _huy,  _khongSD,  _nguoiSD,  _soTien, _soTienTN );
            // public abstract void UpdateDMVaiTro_PhuCap(String _MaThuoc, Decimal _NamThau, String _MaNCC, String _maThuoc, Boolean _huy, String _nguoiSD, String _maMay);
            // public override void UpdateDMVaiTro_PhuCap(String _MaThuoc, Decimal _NamThau, String _MaNCC, String _maThuoc, Boolean _huy, String _nguoiSD, String _maMay)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVaiTro_PhuCap_Update", _MaThuoc, _NamThau, _MaNCC, _maThuoc, _huy, _nguoiSD , _maMay);
            // }				
            MarkOld();
        }
        //internal void Delete()
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVaiTro_PhuCap
        //    if (!this.IsDirty)
        //        return;
        //    
        //      
        //    DataProvider.Instance().DeleteDMVaiTro_PhuCap(_MaThuoc, _NamThau, _MaNCC);
        //    // public abstract void UpdateDMVaiTro_PhuCap(String _MaThuoc, Decimal _NamThau, String _MaNCC, String _maThuoc, Boolean _huy, String _nguoiSD, String _maMay);
        //    // public override void UpdateDMVaiTro_PhuCap(String _MaThuoc, Decimal _NamThau, String _MaNCC, String _maThuoc, Boolean _huy, String _nguoiSD, String _maMay)
        //    // {
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVaiTro_PhuCap_Update", _MaThuoc, _NamThau, _MaNCC, _maThuoc, _huy, _nguoiSD , _maMay);
        //    // }				
        //    MarkOld();
        //}
        //internal void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaThuoc, _NamThau, _MaNCC));
        //}

        /// <summary>
        /// Delete the <see cref="DMVaiTro_PhuCap" />.
        /// </summary>
        //internal void DataPortal_Delete(OtherCriteria crit)
        //{
        //    // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVaiTro_PhuCap
        //    DataProvider.Instance().DeleteDMVaiTro_PhuCap(crit.MaMay, crit.NguoiSD, crit.MaThuoc, crit.NamThau, crit.MaNCC);
        //    // public abstract void DeleteDMVaiTro_PhuCap(String _MaThuoc, Decimal _NamThau, String _MaNCC);
        //    // public override void DeleteDMVaiTro_PhuCap(String _MaThuoc, Decimal _NamThau, String _MaNCC)
        //    // {DeleteDMVaiTro_PhuCap(String _maChungLoai, String _maLH, Byte _maVaiTro, String _maMay, String _MguoiSD);
        //    //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMVaiTro_PhuCap_Deleted", _MaThuoc, _NamThau, _MaNCC);
        //    // }
        //}

        internal void DeleteSelf()
        {
            if (!this.IsDirty)
                return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_maChungLoai, _maLH, _maVaiTro, _maMay,_nguoiSD));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteDMVaiTro_PhuCap(crit.MaChungLoai , crit.MaLH, crit.MaVaiTro , crit.MaMay,crit.NguoiSD );
        }

        #endregion
    }

}
