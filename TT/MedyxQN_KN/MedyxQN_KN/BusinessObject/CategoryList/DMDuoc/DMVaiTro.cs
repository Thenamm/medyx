// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMVaiTro
// Kieu doi tuong  :	DMVaiTro
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/7/2008 9:56:20 AM
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
//

namespace HTC.Business.CategoryList
{

    /// <summary>
    /// This is a base generated class of <see cref="DMVaiTro" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMVaiTro : BusinessBase<DMVaiTro>
    {
        #region Business Methods

        #region State Fields

        private byte _maVaiTro = 0;
        private String _tenVaiTro = String.Empty;
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

        public String TenVaiTro
        {
            get
            {
                CanReadProperty("TenVaiTro", true);
                return _tenVaiTro;
            }
            set
            {
                CanWriteProperty("TenVaiTro", true);
                if (_tenVaiTro != value)
                {
                    _tenVaiTro = value;
                    PropertyHasChanged("TenVaiTro");
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
            return _maVaiTro;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenVaiTro", 150));
            ValidationRules.AddRule<DMVaiTro>(StringRequired<DMVaiTro>, "TenVaiTro");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMVaiTro
        {

            if (target._tenVaiTro == null || target._tenVaiTro.Trim().Length == 0)
            {
                e.Description = HTC.ShareVariables.VAR_STRINGREQUIRED;
                return false;
            }
            else
                return true;
        }
        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMVaiTro" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMVaiTro NewDMVaiTro()
        {
            //return new DMVaiTro();
            return DataPortal.Create<DMVaiTro>();
        }
        public static DMVaiTro GetDMVaiTro(Byte maVaiTro)
        {
            return DataPortal.Fetch<DMVaiTro>(new Criteria(maVaiTro));
        }

        /// <summary>
        /// Marks the <see cref="DMVaiTro" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMVaiTro(Byte maVaiTro, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maVaiTro));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham VaiTroi tao duoi day voi tu VaiTroa public !!!
        protected internal DMVaiTro()
        {
            // Prevent direct creation
        }

        internal DMVaiTro(int ordernumber, byte MaQG, string TenQG, string Ghichu, string idmay, Byte Loai, bool huy, bool khongsd, SmartDate ngaySD, string NguoiSD, String tenta, string hoten)
        {
            _OrderNumber = ordernumber;
            _maVaiTro = MaQG;
            _tenVaiTro = TenQG;
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
            private Byte _maVaiTro;
            public Byte MaVaiTro
            {
                get
                {
                    return _maVaiTro;
                }
            }

            public Criteria(Byte maVaiTro)
            {
                _maVaiTro = maVaiTro;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maVaiTro.Equals(c._maVaiTro))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maVaiTro.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private Byte _maVaiTro;
            public Byte MaVaiTro
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
            public OtherCriteria(String Mamay, String Nguoisd, Byte maVaiTro)
            {
                _maVaiTro = maVaiTro;
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
        /// Retrieve an existing <see cref="DMVaiTro" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMVaiTro(Byte  _maVaiTro);
            // public override IDataReader GetDMVaiTro(Byte  _maVaiTro)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVaiTro));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMVaiTro(crit.MaVaiTro)))
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
        /// Load a <see cref="DMVaiTro" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetByte("MaVaiTro") != null) _maVaiTro = dr.GetByte("MaVaiTro");
            if (dr.GetString("TenVaiTro") != null) _tenVaiTro = dr.GetString("TenVaiTro");
            if (dr.GetString("Ghichu") != null) _Ghichu = dr.GetString("Ghichu");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetByte("Loai") != null) _Loai = dr.GetByte("Loai");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetBoolean("KhongSD") != null) _KhongSD = dr.GetBoolean("KhongSD");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("Tenta") != null) _tenta = dr.GetString("Tenta");

        }

        /// <summary>
        /// Insert the new <see cref="DMVaiTro" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMVaiTro
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maVaiTro = DataProvider.Instance().InsertDMVaiTro(_tenVaiTro, _Ghichu, _maMay, _Loai, _nguoiSD , _tenta);
            // public abstract String InsertDMVaiTro(Byte  _maVaiTro, String _tenVaiTro, Boolean _VaiTrochinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // public override String InsertDMVaiTro(Byte  _maVaiTro, String _tenVaiTro, Boolean _VaiTrochinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVaiTro, _tenVaiTro, _VaiTrochinh, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="DMVaiTro" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVaiTro
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMVaiTro(_maVaiTro, _tenVaiTro, _Ghichu, _maMay, _Loai, _huy, _KhongSD, _nguoiSD , _tenta);
                // public abstract void UpdateDMVaiTro(Byte  _maVaiTro, String _tenVaiTro, Boolean _VaiTrochinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // public override void UpdateDMVaiTro(Byte  _maVaiTro, String _tenVaiTro, Boolean _VaiTrochinh, String _ghichu, String _maMay, Boolean _huy,SmartDate _ngaySD, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVaiTro, _tenVaiTro, _VaiTrochinh, _ghichu, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maVaiTro));
        }

        /// <summary>
        /// Delete the <see cref="DMVaiTro" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMVaiTro
            DataProvider.Instance().DeleteDMVaiTro(crit.MaMay, crit.NguoiSD, crit.MaVaiTro);
            // public abstract void DeleteDMVaiTro(Byte  _maVaiTro);
            // public override void DeleteDMVaiTro(Byte  _maVaiTro);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maVaiTro);
            // }
        }

        #endregion
    }

}
