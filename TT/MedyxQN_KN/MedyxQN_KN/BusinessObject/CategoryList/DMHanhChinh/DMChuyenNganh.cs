using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
//


namespace HTC.Business.CategoryList
{

    /// <summary>
    /// This is a base generated class of <see cref="DMChuyenNganh" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMChuyenNganh : BusinessBase<DMChuyenNganh>
    {
        #region Business Methods

        #region State Fields

        private String _maChuyenNganh = String.Empty;
        private String _tenChuyenNganh = String.Empty;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private int _OrderNumber;

        private Byte _cap = 0;
        private String _loai = String.Empty;
        private String _idparent = String.Empty;
        #endregion

        #region Business Properties and Methods

        public String MaChuyenNganh
        {
            get
            {
                CanReadProperty("MaChuyenNganh", true);
                return _maChuyenNganh;
            }
            set
            {
                CanWriteProperty("MaChuyenNganh", true);
                if (_maChuyenNganh != value)
                {
                    _maChuyenNganh = value;
                    PropertyHasChanged("MaChuyenNganh");
                }
            }
        }

        public String TenChuyenNganh
        {
            get
            {
                CanReadProperty("TenChuyenNganh", true);
                return _tenChuyenNganh;
            }
            set
            {
                CanWriteProperty("TenChuyenNganh", true);
                if (_tenChuyenNganh != value)
                {
                    _tenChuyenNganh = value;
                    PropertyHasChanged("TenChuyenNganh");
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
        public String loai
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
        public Byte Cap
        {
            get
            {
                CanReadProperty("Cap", true);
                return _cap;
            }
            set
            {
                CanWriteProperty("Cap", true);
                if (_cap != value)
                {
                    _cap = value;
                    PropertyHasChanged("Cap");
                }
            }
        }
        public String idparent
        {
            get
            {
                CanReadProperty("idparent", true);
                return _idparent;
            }
            set
            {
                CanWriteProperty("idparent", true);
                if (_idparent != value)
                {
                    _idparent = value;
                    PropertyHasChanged("idparent");
                }
            }
        }

        protected override Object GetIdValue()
        {
            return _maChuyenNganh;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            //ValidationRules.AddRule(Csla.Validation.CommonRules.StringRequired, "TenNT");
            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenChuyenNganh", 150));
            ValidationRules.AddRule<DMChuyenNganh>(StringRequired<DMChuyenNganh>, "TenChuyenNganh");


        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMChuyenNganh
        {

            if (target._tenChuyenNganh == null || target._tenChuyenNganh.Trim().Length == 0)
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
        /// Factory method. New <see cref="DMChuyenNganh" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        public static DMChuyenNganh NewDMChuyenNganh()
        {
            //return new DMChuyenNganh();
            return DataPortal.Create<DMChuyenNganh>();
        }
        public static DMChuyenNganh NewDMChuyenNganh(string idparent)
        {
            //return new DMChuyenNganh(idparent);
            return DataPortal.Create<DMChuyenNganh>(new Criteria(idparent));
        }
        public static DMChuyenNganh GetDMChuyenNganh(String maChuyenNganh)
        {
            return DataPortal.Fetch<DMChuyenNganh>(new Criteria(maChuyenNganh));
        }

        /// <summary>
        /// Marks the <see cref="DMChuyenNganh" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMChuyenNganh(String maChuyenNganh, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maChuyenNganh));
        }
        private DMChuyenNganh(string idparent)
        {
            _idparent = idparent;
        }
        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMChuyenNganh()
        {
            // Prevent direct creation
        }
        internal DMChuyenNganh(
                                int ordernumber, 
                                string maChuyenNganh, 
                                string tenChuyenNganh, 
                                string maMay, 
                                bool huy, 
                                SmartDate ngaySD, 
                                string nguoiSD, 
                                string loai, 
                                byte cap, 
                                string idparent)
        {
            _OrderNumber = ordernumber;
            _maChuyenNganh = maChuyenNganh ;
            _tenChuyenNganh = tenChuyenNganh ;
            _maMay = maMay ;
            _huy = huy;
            _ngaySD = ngaySD;
            _nguoiSD = nguoiSD ;
            _loai = loai;
            _cap = cap;
            _idparent = idparent;
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maChuyenNganh;
            public String MaChuyenNganh
            {
                get
                {
                    return _maChuyenNganh;
                }
            }

            public Criteria(String maChuyenNganh)
            {
                _maChuyenNganh = maChuyenNganh;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maChuyenNganh.Equals(c._maChuyenNganh))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maChuyenNganh.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _maChuyenNganh;
            public String MaChuyenNganh
            {
                get
                {
                    return _maChuyenNganh ;
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

            private String _nguoiSD;
            public String NguoiSD
            {
                get
                {
                    return _nguoiSD;
                }
            }


            public OtherCriteria(String maMay, String nguoiSD, String maChuyenNganh)
            {
                _maChuyenNganh = maChuyenNganh ;
                _maMay  = maMay ;
                _nguoiSD = nguoiSD ;
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
        /// Retrieve an existing <see cref="DMChuyenNganh" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMChuyenNganh(String _maChuyenMon);
            // public override IDataReader GetDMChuyenNganh(String _maChuyenMon)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChuyenMon));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMChuyenNganh(crit.MaChuyenNganh)))
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
        /// Load a <see cref="DMChuyenNganh" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaChuyenNganh") != null) _maChuyenNganh = dr.GetString("MaChuyenNganh");
            if (dr.GetString("TenChuyenNganh") != null) _tenChuyenNganh = dr.GetString("TenChuyenNganh");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("loai") != null) _loai = dr.GetString("loai");
            if (dr.GetByte("Cap") != null) _cap = dr.GetByte("Cap");
            if (dr.GetString("idparent") != null) _idparent = dr.GetString("idparent");
        }

        /// <summary>
        /// Insert the new <see cref="DMChuyenNganh" /> Object to underlying database.
        /// </summary>
        /// 
        protected void DataPortal_Create(Criteria param)
        {
            _idparent = param.MaChuyenNganh;
            //NameRoot = param.RootName;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMChuyenNganh
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _maChuyenNganh = DataProvider.Instance().InsertDMChuyenNganh(_tenChuyenNganh, _maMay, _nguoiSD , _loai, _idparent);
            // public abstract String InsertDMChuyenNganh( String _tenChuyenMon, String _maMay,  String _nguoiSD);
            // public override String InsertDMChuyenNganh( String _tenChuyenMon, String _maMay, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChuyenMon, _tenChuyenMon, _maMay, _huy, _ngaySD.DBValue, _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="DMChuyenNganh" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChuyenNganh
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMChuyenNganh(_maChuyenNganh, _tenChuyenNganh, _maMay, _huy, _nguoiSD , _loai);
                // public abstract void UpdateDMChuyenNganh(String _maChuyenMon, String _tenChuyenMon, String _maMay, String _nguoiSD);
                // public override void UpdateDMChuyenNganh(String _maChuyenMon, String _tenChuyenMon, String _maMay,  String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChuyenMon, _tenChuyenMon, _maMay, _huy, _ngaySD.DBValue, _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _maChuyenNganh));
        }

        /// <summary>
        /// Delete the <see cref="DMChuyenNganh" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMChuyenNganh
            DataProvider.Instance().DeleteDMChuyenNganh(crit.MaMay, crit.NguoiSD, crit.MaChuyenNganh );
            // public abstract void DeleteDMChuyenNganh(String _maChuyenMon);
            // public override void DeleteDMChuyenNganh(String _maChuyenMon);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _maChuyenMon);
            // }
        }

        #endregion
    }

}