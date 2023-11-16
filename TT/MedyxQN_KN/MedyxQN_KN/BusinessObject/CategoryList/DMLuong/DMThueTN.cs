// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMThueTN
// Kieu doi tuong  :	DMThueTN
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
    /// This is a base generated class of <see cref="DMThueTN" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMThueTN : BusinessBase<DMThueTN>
    {
        #region Business Methods

        #region State Fields

        private String _MaThueTN = String.Empty;
        private String _TenThueTN = String.Empty;
        private decimal _MucLuongTu=0;
        private decimal _MucLuongDen;
        private decimal _Heso;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(false);
        private String _nguoiSD = String.Empty;
        private String _ghiChu = String.Empty;
        private String _hoten = String.Empty;
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String MaThueTN
        {
            get
            {
                CanReadProperty("MaThueTN", true);
                return _MaThueTN;
            }
            set
            {
                CanWriteProperty("MaThueTN", true);
                if (_MaThueTN != value)
                {
                    _MaThueTN = value;
                    PropertyHasChanged("MaThueTN");
                }
            }
        }

        public String TenThueTN
        {
            get
            {
                CanReadProperty("TenThueTN", true);
                return _TenThueTN;
            }
            set
            {
                CanWriteProperty("TenThueTN", true);
                if (_TenThueTN != value)
                {
                    _TenThueTN = value;
                    PropertyHasChanged("TenThueTN");
                }
            }
        }

        public string MucLuongTu
        {
            get
            {
                CanReadProperty("MucLuongTu", true);
                return _MucLuongTu.ToString("###,###");
            }
            set
            {
                CanWriteProperty("MucLuongTu", true);
                if (_MucLuongTu.ToString() != value)
                {
                    _MucLuongTu = decimal.Parse(value);
                    PropertyHasChanged("MucLuongTu");
                }
            }
        }


        //public String MucLuongDen
        //{
        //    get
        //    {
        //        CanReadProperty("MucLuongDen", true);
        //        return _MucLuongDen;
        //    }
        //    set
        //    {
        //        CanWriteProperty("MucLuongDen", true);
        //        if (_MucLuongDen != value)
        //        {
        //            _MucLuongDen = value;
        //            PropertyHasChanged("MucLuongDen");
        //        }
        //    }
        //}

        public string MucLuongDen
        {
            get
            {
                CanReadProperty("MucLuongDen", true);
                return _MucLuongDen.ToString("###,###");
            }
            set
            {
                CanWriteProperty("MucLuongDen", true);
                if (_MucLuongDen.ToString() != value)
                {
                    _MucLuongDen = decimal.Parse(value);
                    PropertyHasChanged("MucLuongDen");
                }
            }
        }

        public string Heso
        {
            get
            {
                CanReadProperty("Heso", true);
                return _Heso.ToString("###,###");
            }
            set
            {
                CanWriteProperty("Heso", true);
                if (_Heso.ToString() != value)
                {
                    _Heso = decimal.Parse(value);
                    PropertyHasChanged("Heso");
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
                _ngaySD.FormatString = "dd/MM/yyyy hh:mm:ss";
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
            return _MaThueTN;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation
        protected override void AddBusinessRules()
        {

            ValidationRules.AddRule(Csla.Validation.CommonRules.StringMaxLength, new Csla.Validation.CommonRules.MaxLengthRuleArgs("TenThueTN", 150));
            ValidationRules.AddRule<DMThueTN>(StringRequired<DMThueTN>, "TenThueTN");

        }

        private static bool StringRequired<T>(T target, Csla.Validation.RuleArgs e) where T : DMThueTN
        {

            if (target._TenThueTN == null || target._TenThueTN.Trim().Length == 0)
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
        /// Factory method. New <see cref="DMThueTN" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMThueTN NewDMThueTN()
        {
            return DataPortal.Create<DMThueTN>();
        }
        public static DMThueTN GetDMThueTN(String MaThueTN)
        {
            return DataPortal.Fetch<DMThueTN>(new Criteria(MaThueTN));
        }

        /// <summary>
        /// Marks the <see cref="DMThueTN" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        public static void DeleteDMThueTN(String MaThueTN, string mamay, string nguoihuy)
        {
            DataPortal.Delete(new OtherCriteria(mamay, nguoihuy, MaThueTN));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        protected internal DMThueTN()
        {
            // Prevent direct creation
        }
        internal DMThueTN(int ordernumber, string MaThueTN, string TenThueTN,decimal MucLuongTu,decimal MucLuongDen,decimal Heso, string idmay, bool huy, SmartDate ngaySD, string NguoiSD, string ghichu, string hoten)
        {
            _OrderNumber = ordernumber;
            _MaThueTN = MaThueTN;
            _TenThueTN = TenThueTN;
            _MucLuongTu = MucLuongTu;
            _MucLuongDen = MucLuongDen;
            _Heso = Heso;
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
            private String _MaThueTN;
            public String MaThueTN
            {
                get
                {
                    return _MaThueTN;
                }
            }

            public Criteria(String MaThueTN)
            {
                _MaThueTN = MaThueTN;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaThueTN.Equals(c._MaThueTN))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaThueTN.ToString()).GetHashCode();
            }
        }
        [Serializable()]
        protected class OtherCriteria
        {
            private String _MaThueTN;
            public String MaThueTN
            {
                get
                {
                    return _MaThueTN;
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
            public OtherCriteria(String Mamay, String Nguoisd, String MaThueTN)
            {
                _MaThueTN = MaThueTN;
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
        /// Retrieve an existing <see cref="DMThueTN" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {
            // public abstract IDataReader GetDMThueTN(String _MaThueTN);
            // public override IDataReader GetDMThueTN(String _MaThueTN)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaThueTN));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMThueTN(crit.MaThueTN)))
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
        /// Load a <see cref="DMThueTN" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("MaThueTN") != null) _MaThueTN = dr.GetString("MaThueTN");
            if (dr.GetString("TenThueTN") != null) _TenThueTN = dr.GetString("TenThueTN");
            if (dr.GetDecimal("MucLuongTu") != null) _MucLuongTu = dr.GetDecimal("MucLuongTu");
            if (dr.GetDecimal("MucLuongDen") != null) _MucLuongDen = dr.GetDecimal("MucLuongDen");
            if (dr.GetDecimal("Heso") != null) _Heso = dr.GetDecimal("Heso");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", false) != null) _ngaySD = dr.GetSmartDate("NgaySD", false);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetString("HoTen") != null) _hoten = dr.GetString("HoTen");
        }

        /// <summary>
        /// Insert the new <see cref="DMThueTN" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMThueTN
            // Copy & paste ham duoi day vao file DataProvider.cs
            
              
            _MaThueTN = DataProvider.Instance().InsertDMThueTN(_TenThueTN, _ghiChu,_MucLuongTu ,_MucLuongDen ,_Heso , _maMay, _nguoiSD);
            // public abstract String InsertDMThueTN(String _TenThueTN, String _maMay, String _nguoiSD);
            // public override String InsertDMThueTN(String _TenThueTN, String _maMay, String _nguoiSD);
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "", _TenThueTN, _maMay,  _nguoiSD), String);
            // }
        }

        /// <summary>
        /// Update all changes made on <see cref="DMThueTN" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThueTN
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateDMThueTN(_MaThueTN, _TenThueTN, _ghiChu, _MucLuongTu, _MucLuongDen, _Heso, _maMay, _huy, _nguoiSD);
                // public abstract void UpdateDMThueTN(String _MaThueTN, String _TenThueTN, String _maMay, String _nguoiSD);
                // public override void UpdateDMThueTN(String _MaThueTN, String _TenThueTN, String _maMay, String _nguoiSD);
                // {
                //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaThueTN, _TenThueTN, _maMay,  _nguoiSD);
                // }				
            }
        }
        protected override void DataPortal_DeleteSelf()
        {
            DataPortal_Delete(new OtherCriteria(_maMay, _nguoiSD , _MaThueTN));
        }

        /// <summary>
        /// Delete the <see cref="DMThueTN" />.
        /// </summary>
        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMThueTN
            DataProvider.Instance().DeleteDMThueTN(crit.MaMay, crit.NguoiSD, crit.MaThueTN);
            // public abstract void DeleteDMThueTN(String _MaThueTN);
            // public override void DeleteDMThueTN(String _MaThueTN);
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaThueTN);
            // }
        }

        #endregion
    }

}
