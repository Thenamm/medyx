// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	Account
// Kieu doi tuong  :	Account
// Kieu CSLA       :	EditableRoot
// Ngay tao        :	4/14/2009 2:39:34 PM
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

namespace HTC.Business.Officer
{

    /// <summary>
    /// This is a base generated class of <see cref="Account" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class Account : BusinessBase<Account>
    {
        #region Business Methods

        #region State Fields

        private String _maNV = String.Empty;
        private String _account = String.Empty;
        private String _password = String.Empty;
        private String _maKhoaLS = String.Empty;
        private String _maKhoaCLS = String.Empty;
        private String _maKho = String.Empty;
        private Boolean _allMaKho = false;
        private Boolean _allMaKhoaCLS = false;
        private Boolean _allMaKhoaLS = false;
        private String _quyenDTuong = String.Empty;
        private Boolean _allQuyenDTuong = false;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _hoten = String.Empty;
        private Boolean _qadmin = false;
        private Boolean _qsgia = false;
        private int _OrderNumber;
        private String _TenNguoiSD = String.Empty;
        private String _accountold = String.Empty;
        #endregion

        #region Business Properties and Methods

        public String MaNV
        {
            get
            {
                CanReadProperty("MaNV", true);
                return _maNV;
            }
            set
            {
                CanWriteProperty("MaNV", true);
                if (_maNV != value)
                {
                    _maNV = value;
                    PropertyHasChanged("MaNV");
                }
            }
        }

        public String account
        {
            get
            {
                CanReadProperty("Account", true);
                return _account;
            }
            set
            {
                CanWriteProperty("Account", true);
                if (_account != value)
                {
                    _account = value;
                    PropertyHasChanged("Account");
                }
            }
        }
        public String accountold
        {
            get
            {
                CanReadProperty("accountold", true);
                return _accountold;
            }
            set
            {
                CanWriteProperty("accountold", true);
                if (_accountold != value)
                {
                    _accountold = value;
                    PropertyHasChanged("accountold");
                }
            }
        }
        public String Password
        {
            get
            {
                CanReadProperty("Password", true);
                return _password;
            }
            set
            {
                CanWriteProperty("Password", true);
                if (_password != value)
                {
                    _password = value;
                    PropertyHasChanged("Password");
                }
            }
        }

        public String MaKhoaLS
        {
            get
            {
                CanReadProperty("MaKhoaLS", true);
                return _maKhoaLS;
            }
            set
            {
                CanWriteProperty("MaKhoaLS", true);
                if (_maKhoaLS != value)
                {
                    _maKhoaLS = value;
                    PropertyHasChanged("MaKhoaLS");
                }
            }
        }

        public String MaKhoaCLS
        {
            get
            {
                CanReadProperty("MaKhoaCLS", true);
                return _maKhoaCLS;
            }
            set
            {
                CanWriteProperty("MaKhoaCLS", true);
                if (_maKhoaCLS != value)
                {
                    _maKhoaCLS = value;
                    PropertyHasChanged("MaKhoaCLS");
                }
            }
        }

        public String MaKho
        {
            get
            {
                CanReadProperty("MaKho", true);
                return _maKho;
            }
            set
            {
                CanWriteProperty("MaKho", true);
                if (_maKho != value)
                {
                    _maKho = value;
                    PropertyHasChanged("MaKho");
                }
            }
        }

        public Boolean AllMaKho
        {
            get
            {
                CanReadProperty("AllMaKho", true);
                return _allMaKho;
            }
            set
            {
                CanWriteProperty("AllMaKho", true);
                if (_allMaKho != value)
                {
                    _allMaKho = value;
                    PropertyHasChanged("AllMaKho");
                }
            }
        }

        public Boolean AllMaKhoaCLS
        {
            get
            {
                CanReadProperty("AllMaKhoaCLS", true);
                return _allMaKhoaCLS;
            }
            set
            {
                CanWriteProperty("AllMaKhoaCLS", true);
                if (_allMaKhoaCLS != value)
                {
                    _allMaKhoaCLS = value;
                    PropertyHasChanged("AllMaKhoaCLS");
                }
            }
        }

        public Boolean AllMaKhoaLS
        {
            get
            {
                CanReadProperty("AllMaKhoaLS", true);
                return _allMaKhoaLS;
            }
            set
            {
                CanWriteProperty("AllMaKhoaLS", true);
                if (_allMaKhoaLS != value)
                {
                    _allMaKhoaLS = value;
                    PropertyHasChanged("AllMaKhoaLS");
                }
            }
        }

        public String QuyenDTuong
        {
            get
            {
                CanReadProperty("QuyenDTuong", true);
                return _quyenDTuong;
            }
            set
            {
                CanWriteProperty("QuyenDTuong", true);
                if (_quyenDTuong != value)
                {
                    _quyenDTuong = value;
                    PropertyHasChanged("QuyenDTuong");
                }
            }
        }

        public Boolean AllQuyenDTuong
        {
            get
            {
                CanReadProperty("AllQuyenDTuong", true);
                return _allQuyenDTuong;
            }
            set
            {
                CanWriteProperty("AllQuyenDTuong", true);
                if (_allQuyenDTuong != value)
                {
                    _allQuyenDTuong = value;
                    PropertyHasChanged("AllQuyenDTuong");
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

        public String Hoten
        {
            get
            {
                CanReadProperty("Hoten", true);
                return _hoten;
            }
            set
            {
                CanWriteProperty("Hoten", true);
                if (_hoten != value)
                {
                    _hoten = value;
                    PropertyHasChanged("Hoten");
                }
            }
        }

        public Boolean Qadmin
        {
            get
            {
                CanReadProperty("Qadmin", true);
                return _qadmin;
            }
            set
            {
                CanWriteProperty("Qadmin", true);
                if (_qadmin != value)
                {
                    _qadmin = value;
                    PropertyHasChanged("Qadmin");
                }
            }
        }
        public Boolean qsgia
        {
            get
            {
                CanReadProperty("qsgia", true);
                return _qsgia;
            }
            set
            {
                CanWriteProperty("qsgia", true);
                if (_qsgia != value)
                {
                    _qsgia = value;
                    PropertyHasChanged("qsgia");
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


        RolesList _RolesList = RolesList.NewRolesList();

        public RolesList RolesList
        {
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            get
            {
                //CanReadProperty(true);
                return _RolesList;
            }
            [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
            set
            {
                //CanWriteProperty(true);
                if (!_RolesList.Equals(value))
                {
                    _RolesList = value;
                    PropertyHasChanged();
                }
            }
        }

        protected override Object GetIdValue()
        {
            return _maNV.ToString() + "!" + _account.ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString().ToString();
        }
        public override bool IsDirty
        {
            get
            {
                return base.IsDirty || _RolesList.IsDirty;
            }
        }

        public override bool IsValid
        {
            get
            {
                return base.IsValid && _RolesList.IsValid;
            }
        }
        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="Account" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static Account NewAccount()
        {
            return DataPortal.Create<Account>();
        }
        public static Account NewAccount(string manv)
        {
            return DataPortal.Create<Account>(new CriteriaNew(manv));
        }
        public static Account GetAccount(String account)
        {
            return DataPortal.Fetch<Account>(new Criteria(account));
        }

        /// <summary>
        /// Marks the <see cref="Account" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteAccount(String maNV, String account, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maNV, account));
        }
        private Account(string manv)
        {
            _maNV = manv;
        }
        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal Account()
        {
            // Prevent direct creation
        }
        internal Account(int _OrderNumber,
                                 String maNV,
                                 String account,
                                 String password,
                                 String maKhoaLS,
                                 String maKhoaCLS,
                                 String maKho,
                                 Boolean allMaKho,
                                 Boolean allMaKhoaCLS,
                                 Boolean allMaKhoaLS,
                                 String quyenDTuong,
                                 Boolean allQuyenDTuong,
                                 String maMay,
                                 Boolean huy,
                                 SmartDate ngaySD,
                                 String nguoiSD,
                                 Boolean qadmin,
                                String hoten,
                                String TenNguoiSD,
                                 Boolean qsgia
         )
        {
            _OrderNumber = OrderNumber;
            _maNV = maNV;
            _account = account;
            _password = password;
            _maKhoaLS = maKhoaLS;
            _maKhoaCLS = maKhoaCLS;
            _maKho = maKho;
            _allMaKho = allMaKho;
            _allMaKhoaCLS = allMaKhoaCLS;
            _allMaKhoaLS = allMaKhoaLS;
            _quyenDTuong = quyenDTuong;
            _allQuyenDTuong = allQuyenDTuong;
            _maMay = maMay;
            _huy = huy;
            _qadmin = qsgia;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD;
            _qadmin = qadmin;
            _hoten = hoten;
            _TenNguoiSD = TenNguoiSD;
            _accountold = account;
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {


            private String _account;
            public String Account
            {
                get
                {
                    return _account;
                }
            }

            public Criteria(String account)
            {
                _account = account;
            }


        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maNV;
            public String MaNV
            {
                get
                {
                    return _maNV;
                }
            }

            private String _account;
            public String Account
            {
                get
                {
                    return _account;
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
            public OtherCriteria(String Mamay, String Nguoisd, String maNV, String account)
            {
                _maNV = maNV;
                _account = account;
                _maMay = Mamay;
                _NguoiSD = Nguoisd;
            }
        }

        protected class CriteriaNew
        {
            private String _maNV;
            public String maNV
            {
                get
                {
                    return _maNV;
                }
            }

            public CriteriaNew(String maNV)
            {
                _maNV = maNV;


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
        /// Retrieve an existing <see cref="Account" /> Object based on data in the database.
        /// </summary>
        /// 

        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetAccount(String _account);
            // public override IDataReader GetAccount(String _account)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "spACCOUNT_Get", _account));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAccount(crit.Account)))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        _RolesList = RolesList.GetRolesList(dr);
                    }
                    MarkOld();
                    ValidationRules.CheckRules();
                }
            }
        }
        /// <summary>
        /// Load a <see cref="Account" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaNV") != null) _maNV = dr.GetString("MaNV");
            if (dr.GetString("Account") != null) _account = dr.GetString("Account");
            if (dr.GetString("Account") != null) _accountold = dr.GetString("Account");
            if (dr.GetString("Password") != null) _password = dr.GetString("Password");
            if (dr.GetString("MaKhoaLS") != null) _maKhoaLS = dr.GetString("MaKhoaLS");
            if (dr.GetString("MaKhoaCLS") != null) _maKhoaCLS = dr.GetString("MaKhoaCLS");
            if (dr.GetString("MaKho") != null) _maKho = dr.GetString("MaKho");
            if (dr.GetBoolean("AllMaKho") != null) _allMaKho = dr.GetBoolean("AllMaKho");
            if (dr.GetBoolean("AllMaKhoaCLS") != null) _allMaKhoaCLS = dr.GetBoolean("AllMaKhoaCLS");
            if (dr.GetBoolean("AllMaKhoaLS") != null) _allMaKhoaLS = dr.GetBoolean("AllMaKhoaLS");
            if (dr.GetString("QuyenDTuong") != null) _quyenDTuong = dr.GetString("QuyenDTuong");
            if (dr.GetBoolean("AllQuyenDTuong") != null) _allQuyenDTuong = dr.GetBoolean("AllQuyenDTuong");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetBoolean("Qadmin") != null) _qadmin = dr.GetBoolean("Qadmin");
            if (dr.GetBoolean("qsgia") != null) _qsgia = dr.GetBoolean("qsgia");
            if (dr.GetString("Hoten") != null) _hoten = dr.GetString("Hoten");
            if (dr.GetString("TenNguoiSD") != null) _nguoiSD = dr.GetString("TenNguoiSD");

        }

        /// <summary>
        /// Insert the new <see cref="Account" /> Object to underlying database.
        /// </summary>
        /// 

        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected void DataPortal_Create(CriteriaNew param)
        {
            _maNV = param.maNV;
            //NameRoot = param.RootName;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertAccount
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maNV = DataProvider.Instance().InsertAccount(_maNV, _account, _password, _maKhoaLS, _maKhoaCLS, _maKho, _allMaKho, _allMaKhoaCLS, _allMaKhoaLS, _quyenDTuong, _allQuyenDTuong, _maMay, _nguoiSD , _qadmin, _qsgia);
            _RolesList.Update(this);
            // public abstract String InsertAccount(String _maNV, String _account, String _password, String _maKhoaLS, String _maKhoaCLS, String _maKho, Boolean _allMaKho, Boolean _allMaKhoaCLS, Boolean _allMaKhoaLS, String _quyenDTuong, Boolean _allQuyenDTuong, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, Boolean _qadmin);
            // public override String InsertAccount(String _maNV, String _account, String _password, String _maKhoaLS, String _maKhoaCLS, String _maKho, Boolean _allMaKho, Boolean _allMaKhoaCLS, Boolean _allMaKhoaLS, String _quyenDTuong, Boolean _allQuyenDTuong, String _maMay, Boolean _huy, SmartDate _ngaySD, String _nguoiSD, Boolean _qadmin)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spAccount_CREATE", _maNV, _account, _password, _maKhoaLS, _maKhoaCLS, _maKho, _allMaKho, _allMaKhoaCLS, _allMaKhoaLS, _quyenDTuong, _allQuyenDTuong, _maMay, _nguoiSD , _qadmin));
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="Account" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateAccount
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateAccount(_maNV, _account, _password, _maKhoaLS, _maKhoaCLS, _maKho, _allMaKho, _allMaKhoaCLS, _allMaKhoaLS, _quyenDTuong, _allQuyenDTuong, _maMay, _huy, _nguoiSD , _qadmin, _qsgia,_accountold );
                _RolesList.Update(this);
                // public abstract void UpdateAccount(String _maNV, String _account, String _password, String _maKhoaLS, String _maKhoaCLS, String _maKho, Boolean _allMaKho, Boolean _allMaKhoaCLS, Boolean _allMaKhoaLS, String _quyenDTuong, Boolean _allQuyenDTuong, String _maMay, Boolean _huy, String _nguoiSD, Boolean _qadmin);
                // public override void UpdateAccount(String _maNV, String _account, String _password, String _maKhoaLS, String _maKhoaCLS, String _maKho, Boolean _allMaKho, Boolean _allMaKhoaCLS, Boolean _allMaKhoaLS, String _quyenDTuong, Boolean _allQuyenDTuong, String _maMay, Boolean _huy, String _nguoiSD, Boolean _qadmin)
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spACCOUNT_UPDATE", _maNV, _account, _password, _maKhoaLS, _maKhoaCLS, _maKho, _allMaKho, _allMaKhoaCLS, _allMaKhoaLS, _quyenDTuong, _allQuyenDTuong, _maMay, _huy, _nguoiSD , _qadmin);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maNV, _account));
        }

        /// <summary>
        /// Delete the <see cref="Account" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateAccount
            DataProvider.Instance().DeleteAccount(crit.MaMay, crit.NguoiSD, crit.MaNV, crit.Account);
            // public abstract void DeleteAccount(String _maNV, String _account);
            // public override void DeleteAccount(String _maNV, String _account)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spACCOUNT_DELETED", _maNV, _account);
            // }
        }

        #endregion
    }

}

