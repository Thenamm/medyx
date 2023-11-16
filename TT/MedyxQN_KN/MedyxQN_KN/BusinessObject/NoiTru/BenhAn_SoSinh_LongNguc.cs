// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	BenhAn_SoSinh_LongNguc
// Kieu doi tuong  :	BenhAn_SoSinh_LongNguc
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	04/03/2010 11:17:56 AM
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
    /// This is a base generated class of <see cref="BenhAn_SoSinh_LongNguc" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class BenhAn_SoSinh_LongNguc : BusinessBase<BenhAn_SoSinh_LongNguc>
    {
        #region Business Methods

        #region State Fields

        private String _maBA = String.Empty;
        private Int32 _sTTKhoa = 0;
        private Int32 _sTTK = 0;
        private Int32 _sTT = 0;
        private String _maLongNguc = String.Empty;
        private Byte _tim = 0;
        private Byte _tho = 0;
        private Byte _mauDa = 0;
        private Byte _truongLucCo = 0;
        private Byte _phanXa = 0;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private String _ten = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private Byte _TongCong = 0;
        #endregion

        #region Business Properties and Methods

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
        public Int32 STTK
        {
            get
            {
                CanReadProperty("STTK", true);
                return _sTTK;
            }
            set
            {
                CanWriteProperty("STTK", true);
                if (_sTTK != value)
                {
                    _sTTK = value;
                    PropertyHasChanged("STTK");
                }
            }
        }

        public String MaLongNguc
        {
            get
            {
                CanReadProperty("MaLongNguc", true);
                return _maLongNguc;
            }
            set
            {
                CanWriteProperty("MaLongNguc", true);
                if (_maLongNguc != value)
                {
                    _maLongNguc = value;
                    PropertyHasChanged("MaLongNguc");
                }
            }
        }

        public Byte Tim
        {
            get
            {
                CanReadProperty("Tim", true);
                return _tim;
            }
            set
            {
                CanWriteProperty("Tim", true);
                if (_tim != value)
                {
                    _tim = value;
                    PropertyHasChanged("Tim");
                }
            }
        }
        public Byte TongCong
        {
            get
            {
                CanReadProperty("TongCong", true);
                return _TongCong;
            }
            set
            {
                CanWriteProperty("TongCong", true);
                int a;
                a = _tim + _tho + _phanXa + _mauDa + _truongLucCo;
                _TongCong = byte.Parse(a.ToString());
                if (_TongCong != value)
                {
                    _TongCong = value;
                    PropertyHasChanged("TongCong");
                }
            }
        }
        public Byte Tho
        {
            get
            {
                CanReadProperty("Tho", true);
                return _tho;
            }
            set
            {
                CanWriteProperty("Tho", true);
                if (_tho != value)
                {
                    _tho = value;
                    PropertyHasChanged("Tho");
                }
            }
        }

        public Byte MauDa
        {
            get
            {
                CanReadProperty("MauDa", true);
                return _mauDa;
            }
            set
            {
                CanWriteProperty("MauDa", true);
                if (_mauDa != value)
                {
                    _mauDa = value;
                    PropertyHasChanged("MauDa");
                }
            }
        }

        public Byte TruongLucCo
        {
            get
            {
                CanReadProperty("TruongLucCo", true);
                return _truongLucCo;
            }
            set
            {
                CanWriteProperty("TruongLucCo", true);
                if (_truongLucCo != value)
                {
                    _truongLucCo = value;
                    PropertyHasChanged("TruongLucCo");
                }
            }
        }

        public Byte PhanXa
        {
            get
            {
                CanReadProperty("PhanXa", true);
                return _phanXa;
            }
            set
            {
                CanWriteProperty("PhanXa", true);
                if (_phanXa != value)
                {
                    _phanXa = value;
                    PropertyHasChanged("PhanXa");
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
        protected override Object GetIdValue()
        {
            return _maBA.ToString() + "!" + _sTTKhoa.ToString() + "!" + _sTTK.ToString() + "!" + _sTT.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="BenhAn_SoSinh_LongNguc" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static BenhAn_SoSinh_LongNguc NewBenhAn_SoSinh_LongNguc()
        {
            return new BenhAn_SoSinh_LongNguc();
            // return DataPortal.Create<BC_DuocBV>();
        }

        internal static BenhAn_SoSinh_LongNguc GetBenhAn_SoSinh_LongNguc(SafeDataReader dr)
        {
            return new BenhAn_SoSinh_LongNguc(dr);
        }
        //public static BenhAn_SoSinh_LongNguc GetBenhAn_SoSinh_LongNguc(String maBA, Int32 sTT)
        //{
        //    return DataPortal.Fetch<BenhAn_SoSinh_LongNguc>(new Criteria(maBA, sTT));
        //}

        /// <summary>
        /// Marks the <see cref="BenhAn_SoSinh_LongNguc" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        //public static void DeleteBenhAn_SoSinh_LongNguc(String maBA, Int32 sTT)
        //{
        //    DataPortal.Delete(new Criteria(maBA, sTT));
        //}
        public BenhAn_SoSinh_LongNguc()
        {
            MarkAsChild();
        }
        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        //protected internal BenhAn_SoSinh_LongNguc()
        //{	
        // Prevent direct creation
        //}

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
            private Int32 _sTTK;
            public Int32 STTK
            {
                get
                {
                    return _sTTK;
                }
            }
            public Criteria(String maBA, Int32 sTTkhoa, Int32 sTTk, Int32 sTT)
            {
                _maBA = maBA;
                _sTT = sTT;
                _sTTKhoa = sTTkhoa;
                _sTTK = sTTk;
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
                    if (!_sTTK.Equals(c._sTTK))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maBA.ToString(), _sTTKhoa.ToString(), _sTTK.ToString(), _sTT.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class CriteriaOther
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
            private Int32 _sTTK;
            public Int32 STTK
            {
                get
                {
                    return _sTTK;
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
            public CriteriaOther(String Mamay, String Nguoisd, String maba, Int32 sTT, Int32 sTTKhoa, Int32 sTTK)
            {
                _maBA = maba;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
                _sTTK = sTTK;
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
        /// Retrieve an existing <see cref="BenhAn_SoSinh_LongNguc" /> Object based on data in the database.
        /// </summary>
        //protected void DataPortal_Fetch(Criteria crit)
        //{
        //    // public abstract IDataReader GetBenhAn_SoSinh_LongNguc(String _maBA, Int32 _sTT);
        //    // public override IDataReader GetBenhAn_SoSinh_LongNguc(String _maBA, Int32 _sTT)
        //    // {
        //    //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maBA, _sTT));
        //    // }
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetBenhAn_SoSinh_LongNguc(crit.MaBA, crit.STT)))
        //    {
        //        if (dr.Read()){
        //            Fetch(dr);
        //            MarkOld();
        //            ValidationRules.CheckRules();
        //        }
        //    }
        //}
        /// <summary>
        /// Load a <see cref="BenhAn_SoSinh_LongNguc" /> Object from given SafeDataReader.
        /// </summary>
        //private void Fetch(SafeDataReader dr)
        //{
        //    // Value properties
        //    if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
        //    if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
        //    if (dr.GetString("MaLongNguc") != null) _maLongNguc = dr.GetString("MaLongNguc");
        //    if (dr.GetByte("Tim") != null) _tim = dr.GetByte("Tim");
        //    if (dr.GetByte("Tho") != null) _tho = dr.GetByte("Tho");
        //    if (dr.GetByte("MauDa") != null) _mauDa = dr.GetByte("MauDa");
        //    if (dr.GetByte("TruongLucCo") != null) _truongLucCo = dr.GetByte("TruongLucCo");
        //    if (dr.GetByte("PhanXa") != null) _phanXa = dr.GetByte("PhanXa");
        //    if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
        //    if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
        //    if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
        //    if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
        //    if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
        //    if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
        //}
        private BenhAn_SoSinh_LongNguc(SafeDataReader dr)
        {
            MarkAsChild();
            // Value properties
            if (dr.GetString("MaBA") != null) _maBA = dr.GetString("MaBA");
            if (dr.GetInt32("STT") != null) _sTT = dr.GetInt32("STT");
            try
            {
                if (dr.GetString("MaLongNguc") != null) _maLongNguc = dr.GetString("MaLongNguc");
            }
            catch (Exception ex)
            { }
            if (dr.GetInt32("sTTKhoa") != null) _sTTKhoa = dr.GetInt32("sTTKhoa");
            if (dr.GetInt32("STTK") != null) _sTTK = dr.GetInt32("STTK");
            if (dr.GetByte("Tim") != null) _tim = dr.GetByte("Tim");
            if (dr.GetByte("Tho") != null) _tho = dr.GetByte("Tho");
            if (dr.GetByte("MauDa") != null) _mauDa = dr.GetByte("MauDa");
            if (dr.GetByte("TruongLucCo") != null) _truongLucCo = dr.GetByte("TruongLucCo");
            if (dr.GetByte("PhanXa") != null) _phanXa = dr.GetByte("PhanXa");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            _ten = dr.GetString("Ten");
            _tenNguoiSD = dr.GetString("TenNguoiSD");


            MarkOld();
        }
        /// <summary>
        /// Insert the new <see cref="BenhAn_SoSinh_LongNguc" /> Object to underlying database.
        /// </summary>
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThuoc_KhoKhoa
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
            _sTT = DataProvider.Instance().InsertBenhAn_SoSinh_LongNguc(_maBA, _maLongNguc, _tim, _tho, _mauDa, _truongLucCo, _phanXa, _maMay, _nguoiSD, _sTTKhoa,_sTTK );
            // public abstract String InsertBenhAn_SoSinh_LongNguc(String _maBA, String _maLongNguc, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, String _nguoiSD);
            // public override String InsertBenhAn_SoSinh_LongNguc(String _maBA, String _maLongNguc, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, String _nguoiSD)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_LongNguc_CREATE", _maBA, _sTT, _maLongNguc, _tim, _tho, _mauDa, _truongLucCo, _phanXa, _maMay, _nguoiSD));
            // }
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="BenhAn_SoSinh_LongNguc" /> Object to underlying database.
        /// </summary>
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThuoc_KhoKhoa
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateBenhAn_SoSinh_LongNguc(_maBA, _sTT, _maLongNguc, _tim, _tho, _mauDa, _truongLucCo, _phanXa, _maMay, _huy, _nguoiSD, _sTTKhoa,_sTTK );
            // public abstract void UpdateBenhAn_SoSinh_LongNguc(String _maBA, Int32 _sTT, String _maLongNguc, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, Boolean _huy, String _nguoiSD);
            // public override void UpdateBenhAn_SoSinh_LongNguc(String _maBA, Int32 _sTT, String _maLongNguc, Byte _tim, Byte _tho, Byte _mauDa, Byte _truongLucCo, Byte _phanXa, String _maMay, Boolean _huy, String _nguoiSD)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_LongNguc_UPDATE", _maBA, _sTT, _maLongNguc, _tim, _tho, _mauDa, _truongLucCo, _phanXa, _maMay, _huy, _nguoiSD);
            // }				
            MarkOld();
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new CriteriaOther(_maMay, _nguoiSD , _maBA, _sTT, _sTTKhoa,_sTTK ));
        }

        /// <summary>
        /// Delete the <see cref="BenhAn_SoSinh_LongNguc" />.
        /// </summary>
        protected void DataPortal_Delete(CriteriaOther crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateBenhAn_SoSinh_LongNguc
            DataProvider.Instance().DeleteBenhAn_SoSinh_LongNguc(crit.MaMay, crit.NguoiSD, crit.MaBA, crit.STT, crit.STTKhoa,crit.STTK);
            // public abstract void DeleteBenhAn_SoSinh_LongNguc(String _maBA, Int32 _sTT);
            // public override void DeleteBenhAn_SoSinh_LongNguc(String _maBA, Int32 _sTT)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spBenhAn_SoSinh_LongNguc_Deleted", _maBA, _sTT);
            // }
        }

        #endregion
    }

}
