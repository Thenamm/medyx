// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMNCC
// Kieu doi tuong  :	CslaObject
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	10/27/2008 9:40:15 AM
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
    /// This is a base generated class of <see cref="CslaObject" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMNCC : BusinessBase<DMNCC>
    {
        #region Business Methods

        #region State Fields

        private String _maNCC = String.Empty;
        private String _tenNCC = String.Empty;
        private String _tenta = String.Empty;
        private String _Ghichu = String.Empty;
        private String _maMay = String.Empty;
        private Byte _Loai;
        private Boolean _huy = false;
        private Boolean _KhongSD = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

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
        public String tenta
        {
            get
            {
                CanReadProperty("tenta", true);
                return _tenta;
            }
            set
            {
                CanWriteProperty("tenta", true);
                if (_tenta != value)
                {
                    _tenta = value;
                    PropertyHasChanged("tenta");
                }
            }
        }

        public String Ghichu
        {
            get
            {
                CanReadProperty("Ghichu", true);
                return _Ghichu;
            }
            set
            {
                CanWriteProperty("Ghichu", true);
                if (_Ghichu != value)
                {
                    _Ghichu = value;
                    PropertyHasChanged("Ghichu");
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
                return _Loai;
            }
            set
            {
                CanWriteProperty("Loai", true);
                if (_Loai != value)
                {
                    _Loai = value;
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
                return _KhongSD;
            }
            set
            {
                CanWriteProperty("KhongSD", true);
                if (_KhongSD != value)
                {
                    _KhongSD = value;
                    PropertyHasChanged("KhongSD");
                }
            }
        }

        public SmartDate NgaySD
        {
            get
            {
                CanReadProperty("NgaySD", true);
                _ngaySD.FormatString = "dd/MM/yyyy HH:mm:ss";
                return _ngaySD;
            }
            set
            {
                CanWriteProperty("NgaySD", true);
                if (_ngaySD != value)
                {
                    _ngaySD = value;
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
        public String hoten
        {
            get
            {
                CanReadProperty("hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("hoten");
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
            return _maNCC;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="CslaObject" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        public static DMNCC NewDMNCC()
        {
            //return DataPortal.Create<DMNCC>();
            return new DMNCC();
        }
        public static DMNCC GetDMNCC(String maNCC)
        {
            return DataPortal.Fetch<DMNCC>(new Criteria(maNCC));
        }

        /// <summary>
        /// Marks the <see cref="CslaObject" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMNCC(String _maNCC, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy, _maNCC));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMNCC()
        {
            // Prevent direct creation
        }

        internal DMNCC(int ordernumber, string MaQG, string TenQG, string Ghichu, string idmay, Byte Loai, bool huy, bool khongsd, SmartDate ngaySD, string NguoiSD, String tenta,string hoten)
        {
            _OrderNumber = ordernumber;
            _maNCC = MaQG;
            _tenNCC = TenQG;
            _Ghichu = Ghichu;
            _maMay = idmay;
            _Loai = Loai;
            _huy = huy;
            _KhongSD = khongsd;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _tenta = tenta;
            _hoten = hoten;
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maNCC;
            public String MaNCC
            {
                get
                {
                    return _maNCC;
                }
            }

            public Criteria(String maNCC)
            {
                _maNCC = maNCC;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maNCC.Equals(c._maNCC))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maNCC.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNCC;
            public String MaNCC
            {
                get
                {
                    return _maNCC;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maNCC)
            {
                _maNCC = maNCC;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }

            //public override bool Equals(object obj)
            //{
            //    if (obj is Criteria)
            //    {
            //        Criteria c = (Criteria)obj;
            //        if (!_maDV.Equals(c._maDV))
            //            return false;
            //        return true;
            //    }
            //    return false;
            //}

            //public override int GetHashCode()
            //{
            //    return string.Concat("Criteria", _maDV.ToString()).GetHashCode();
            //}
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
        /// Retrieve an existing <see cref="CslaObject" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetCslaObject(String _maVungLT);
            // public override IDataReader GetCslaObject(String _maVungLT)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMNCC(crit.MaNCC)))
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
        /// Load a <see cref="CslaObject" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaNCC") != null) _maNCC = dr.GetString("MaNCC");
            if (dr.GetString("TenNCC") != null) _tenNCC = dr.GetString("TenNCC");
            if (dr.GetString("Ghichu") != null) _Ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetByte("Loai") != null) _Loai = dr.GetByte("Loai");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("KhongSD") != null) _KhongSD = dr.GetBoolean("KhongSD");
            if (dr.GetSmartDate("NgaySD",false) != null) _ngaySD = dr.GetSmartDate("NgaySD",false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("Tenta") != null) _tenta = dr.GetString("Tenta");
            if (dr.GetString("HOTEN") != null) _hoten = dr.GetString("hoten");
        }

        /// <summary>
        /// Insert the new <see cref="CslaObject" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertCslaObject
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maNCC = DataProvider.Instance().InsertDMNCC(_tenNCC, _Ghichu, _maMay, _Loai, _nguoiSD , _tenta);
            // public abstract String InsertCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // public override String InsertCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="CslaObject" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMNCC(_maNCC, _tenNCC, _Ghichu, _maMay, _Loai, _huy, _KhongSD, _nguoiSD , _tenta);
                // public abstract void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // public override void UpdateCslaObject(String _maVungLT, String _tenVungLT, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT, _tenVungLT, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNCC));
        }

        /// <summary>
        /// Delete the <see cref="CslaObject" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateCslaObject
            DataProvider.Instance().DeleteDMNCC(crit.MaMay, crit.NguoiSD, crit.MaNCC);
            // public abstract void DeleteCslaObject(String _maVungLT);
            // public override void DeleteCslaObject(String _maVungLT);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVungLT);
            // }
        }

        #endregion
    }

}
