// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMHTKyLuat
// Kieu doi tuong  :	DMHTKyLuat
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	11/20/2008 2:34:50 PM
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
    /// This is a base generated class of <see cref="DMHTKyLuat" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMHTKyLuat : BusinessBase<DMHTKyLuat>
    {
        #region Business Methods

        #region State Fields

        private String _maHTKyLuat = String.Empty;
        private String _tenHTKyLuat = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String maHTKyLuat
        {
            get
            {
                CanReadProperty("maHTKyLuat", true);
                return _maHTKyLuat;
            }
            set
            {
                CanWriteProperty("maHTKyLuat", true);
                if (_maHTKyLuat != value)
                {
                    _maHTKyLuat = value;
                    PropertyHasChanged("maHTKyLuat");
                }
            }
        }

        public String TenHTKyLuat
        {
            get
            {
                CanReadProperty("TenHTKyLuat", true);
                return _tenHTKyLuat;
            }
            set
            {
                CanWriteProperty("TenHTKyLuat", true);
                if (_tenHTKyLuat != value)
                {
                    _tenHTKyLuat = value;
                    PropertyHasChanged("TenHTKyLuat");
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
            return _maHTKyLuat;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenHTKyLuat", 150));
            ValidationRules.AddRule<DMHTKyLuat>(StringRequired<DMHTKyLuat>, "TenHTKyLuat");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMHTKyLuat
        {

            if (target._tenHTKyLuat == null || target._tenHTKyLuat.Trim().Length == 0)
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
        /// Factory method. New <see cref="DMHTKyLuat" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMHTKyLuat NewDMHTKyLuat()
        {
            return DataPortal.Create<DMHTKyLuat>();
        }
        public static DMHTKyLuat GetDMHTKyLuat(String maHTKyLuat)
        {
            return DataPortal.Fetch<DMHTKyLuat>(new Criteria(maHTKyLuat));
        }

        /// <summary>
        /// Marks the <see cref="DMHTKyLuat" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMHTKyLuat(String maHTKyLuat, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maHTKyLuat));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMHTKyLuat()
        {
            // Prevent direct creation
        }
        internal DMHTKyLuat(int ordernumber, string MaQG, string TenQG, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _maHTKyLuat = MaQG;
            _tenHTKyLuat = TenQG;
            _maMay = idmay;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = NguoiSD;
            _ghiChu = ghichu;
            _hoten = hoten;
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maHTKyLuat;
            public String maHTKyLuat
            {
                get
                {
                    return _maHTKyLuat;
                }
            }

            public Criteria(String maHTKyLuat)
            {
                _maHTKyLuat = maHTKyLuat;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maHTKyLuat.Equals(c._maHTKyLuat))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maHTKyLuat.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maHTKyLuat;
            public String maHTKyLuat
            {
                get
                {
                    return _maHTKyLuat;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maHTKyLuat)
            {
                _maHTKyLuat = maHTKyLuat;
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
        /// Retrieve an existing <see cref="DMHTKyLuat" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMHTKyLuat(String _maHTKyLuat);
            // public override IDataReader GetDMHTKyLuat(String _maHTKyLuat)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHTKyLuat));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMHTKyLuat(crit.maHTKyLuat)))
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
        /// Load a <see cref="DMHTKyLuat" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("maHTKyLuat") != null) _maHTKyLuat = dr.GetString("maHTKyLuat");
            if (dr.GetString("TenHTKyLuat") != null) _tenHTKyLuat = dr.GetString("TenHTKyLuat");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
        }

        /// <summary>
        /// Insert the new <see cref="DMHTKyLuat" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMHTKyLuat
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maHTKyLuat = DataProvider.Instance().InsertDMHTKyLuat(_tenHTKyLuat, _ghiChu, _maMay, _nguoiSD);
            // public abstract String InsertDMHTKyLuat(String _tenHTKyLuat, String _maMay, String _nguoiSD);
            // public override String InsertDMHTKyLuat(String _tenHTKyLuat, String _maMay, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _tenHTKyLuat, _maMay,  _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="DMHTKyLuat" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHTKyLuat
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMHTKyLuat(_maHTKyLuat, _tenHTKyLuat, _ghiChu, _maMay, _nguoiSD , _huy);
                // public abstract void UpdateDMHTKyLuat(String _maHTKyLuat, String _tenHTKyLuat, String _maMay, String _nguoiSD);
                // public override void UpdateDMHTKyLuat(String _maHTKyLuat, String _tenHTKyLuat, String _maMay, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHTKyLuat, _tenHTKyLuat, _maMay,  _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maHTKyLuat));
        }

        /// <summary>
        /// Delete the <see cref="DMHTKyLuat" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMHTKyLuat
            DataProvider.Instance().DeleteDMHTKyLuat(crit.MaMay, crit.NguoiSD, crit.maHTKyLuat);
            // public abstract void DeleteDMHTKyLuat(String _maHTKyLuat);
            // public override void DeleteDMHTKyLuat(String _maHTKyLuat);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maHTKyLuat);
            // }
        }

        #endregion
    }

}
