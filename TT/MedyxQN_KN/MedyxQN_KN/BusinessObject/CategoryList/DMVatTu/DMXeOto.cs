// *****************************************************************************************************
//  File nay duoc sinh tu dong boi chuong trinh CSLA Object Generator 1.0
//
// Ten file        :	DMXeOto
// Kieu doi tuong  :	DMXeOto
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
    /// This is a base generated class of <see cref="DMXeOto" /> Business Object.
    /// </summary>

    [Serializable()]
    public partial class DMXeOto : BusinessBase<DMXeOto>
    {
        #region Business Methods

        #region State Fields

        private String _MaNVQL = String.Empty;
        private String _MaXeOto = String.Empty;
        private String _TenXeOto = String.Empty;
       
        private String _ghiChu = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private SmartDate _ngaySDD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _TenNVQL = String.Empty;
       
        private String _TenNguoiSD = String.Empty;
        private String _maMay = String.Empty;
        private String _mota = String.Empty;
       
        private int _OrderNumber;
       
        #endregion

        #region Business Properties and Methods
      
        public String mota
        {
            get
            {
                CanReadProperty("mota", true);
                return _mota;
            }
            set
            {
                CanWriteProperty("mota", true);
                if (_mota != value)
                {
                    _mota = value;
                    PropertyHasChanged("mota");
                }
            }
        }
      
        public String MaXeOto
        {
            get
            {
                CanReadProperty("MaXeOto", true);
                return _MaXeOto;
            }
            set
            {
                CanWriteProperty("MaXeOto", true);
                if (_MaXeOto != value)
                {
                    _MaXeOto = value;
                    PropertyHasChanged("MaXeOto");
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

        public String TenXeOto
        {
            get
            {
                CanReadProperty("TenXeOto", true);
                return _TenXeOto;
            }
            set
            {
                CanWriteProperty("TenXeOto", true);
                if (_TenXeOto != value)
                {
                    _TenXeOto = value;
                    PropertyHasChanged("TenXeOto");
                }
            }
        }
       

        public String TenNVQL
        {
            get
            {
                CanReadProperty("TenNVQL", true);
                return _TenNVQL;
            }
            set
            {
                CanWriteProperty("TenNVQL", true);
                if (_TenNVQL != value)
                {
                    _TenNVQL = value;
                    PropertyHasChanged("TenNVQL");
                }
            }
        }
        public String MaNVQL
        {
            get
            {
                CanReadProperty("MaNVQL", true);
                return _MaNVQL;
            }
            set
            {
                CanWriteProperty("MaNVQL", true);
                if (_MaNVQL != value)
                {
                    _MaNVQL = value;
                    PropertyHasChanged("MaNVQL");
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
            return _MaXeOto.ToString() ;
        }

        #endregion
        #endregion


        #region Business Object Rules and Validation

        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMXeOto" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMXeOto NewDMXeOto()
        {
            return new DMXeOto();
            //return DataPortal.Create<DMXeOto>();
        }
        public static DMXeOto GetDMXeOto(String MaXeOto)
        {
            return DataPortal.Fetch<DMXeOto>(new Criteria(MaXeOto));
        }
        internal static DMXeOto GetDMXeOto(SafeDataReader dr)
        {
            return new DMXeOto(dr);
        }
        internal static DMXeOto GetDMXeOto(SafeDataReader dr,int i)
        {
            return new DMXeOto(dr,i);
        }
        /// <summary>
        /// Marks the <see cref="DMXeOto" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>
        //public static void DeleteDMXeOto(String MaXeOto, Decimal NamThau, String MaNCC)
        //{
        //    DataPortal.Delete(new OtherCriteria(mamay,nguoihuy ,maXeOto, NamThau, MaNCC));
        //}
        public DMXeOto()
        {
            MarkAsChild();
        }

        #endregion

        ////#region Constructors
        //// Chu y !!!
        //// Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        //// thi khai bao ham khoi tao duoi day voi tu khoa public !!!
        ////protected internal DMXeOto()
        ////{	
        ////     Prevent direct creation
        ////}

        ////internal DMXeOto(Decimal ordernumber, String MaXeOto,
        ////                             String MaNCC ,
        ////                             String MaXeOto ,
        ////                             Boolean huy ,
        ////                             SmartDate ngaySD ,
        ////                             String nguoiSD ,
        ////                             String maMay ,
        ////                             String tenKho ,
        ////                             String tenKhoa,
        ////                             string TenNVQL)
        ////{
        ////                               _NamThau = ordernumber;
        ////                               _MaXeOto = MaXeOto ;
        ////                              _MaNCC = MaNCC  ;
        ////                              _MaXeOto = MaXeOto  ;
        ////                              _huy = huy  ;
        ////                              _ngaySD = ngaySD  ;
        ////                              _nguoiSD = nguoiSD  ;
        ////                              _maMay = maMay  ;
        ////                              _tenKho = tenKho  ;
        ////                              _tenKhoa = tenKhoa;
        ////                              _TenNVQL = TenNVQL;

        ////}

        ////#endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _MaXeOto;
            public String MaXeOto
            {
                get
                {
                    return _MaXeOto;
                }
            }

         

            public Criteria(String MaXeOto)
            {
                _MaXeOto = MaXeOto;
               
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_MaXeOto.Equals(c._MaXeOto))
                        return false;
                  
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _MaXeOto.ToString()).GetHashCode();
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

            private String _MaXeOto;
            public String MaXeOto
            {
                get
                {
                    return _MaXeOto;
                }

            }
        
            public OtherCriteria(String MaXeOto)
            {
                _MaXeOto = MaXeOto;
               


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
            // public abstract IDataReader GetDMVTYT_GiaQuay56(String _MaXeOto);
            // public override IDataReader GetDMVTYT_GiaQuay56(String _MaXeOto)
            // {
            //	   return ((IDataReader)SqlHelper.ExecuteReader(ConnectionString, DatabaseOwner + ObjectQualifier + "", _MaXeOto));
            // }
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMXeOto(crit.MaXeOto)))
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

            if (dr.GetString("MaXeOto") != null) _MaXeOto = dr.GetString("MaXeOto");         
         
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("maNVQL") != null) _MaNVQL = dr.GetString("maNVQL");
            if (dr.GetString("TenNVQL") != null) _TenNVQL = dr.GetString("TenNVQL");
            if (dr.GetString("TenXeOto") != null) _TenXeOto = dr.GetString("TenXeOto");
            if (dr.GetString("MaXeOto") != null) _MaXeOto = dr.GetString("MaXeOto");     
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("mota") != null) _mota = dr.GetString("mota");
          
        }
        #region Data Access

        private DMXeOto(SafeDataReader dr)
        {
            MarkAsChild();
            if (dr.GetString("MaXeOto") != null) _MaXeOto = dr.GetString("MaXeOto");
            if (dr.GetString("TenXeOto") != null) _TenXeOto = dr.GetString("TenXeOto");
            if (dr.GetString("maNVQL") != null) _MaNVQL = dr.GetString("maNVQL");
            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
           
            if (dr.GetString("TenNVQL") != null) _TenNVQL = dr.GetString("TenNVQL");

            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("mota") != null) _mota = dr.GetString("mota");
            MarkOld();
        }
        private DMXeOto(SafeDataReader dr,int i)
        {
            MarkAsChild();
            _OrderNumber = i;
            if (dr.GetString("MaXeOto") != null) _MaXeOto = dr.GetString("MaXeOto");

            if (dr.GetString("GhiChu") != null) _ghiChu = dr.GetString("GhiChu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("maNVQL") != null) _MaNVQL = dr.GetString("maNVQL");
            if (dr.GetString("TenNVQL") != null) _TenNVQL = dr.GetString("TenNVQL");
            if (dr.GetString("TenXeOto") != null) _TenXeOto = dr.GetString("TenXeOto");
            if (dr.GetString("TenNguoiSD") != null) _TenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetString("mota") != null) _mota = dr.GetString("mota");
            MarkOld();
        }
        /// <summary>
        /// Insert the new <see cref="DMXeOto" /> Object to underlying database.
        /// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
        internal void Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMXeOto
            // Copy & paste ham duoi day vao file DataProvider.cs
            if (!this.IsDirty)
                return;
            
              
            _MaXeOto = DataProvider.Instance().InsertDMXeOto(_TenXeOto,_MaNVQL ,_mota, _ghiChu,  _nguoiSD, _maMay);
            // public abstract String InsertDMXeOto(String _MaXeOto, String _MaNCC, String _MaXeOto, String _nguoiSD, String _maMay);
            // public override String InsertDMXeOto(String _MaXeOto, String _MaNCC, String _MaXeOto, String _nguoiSD, String _maMay)
            // {
            //		return CType(SqlHelper.ExecuteScalar(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMXeOto_Create", _MaXeOto, _MaNCC, _MaXeOto, _nguoiSD , _maMay), String);
            // }
            MarkOld();
        }

        /// <summary>
        /// Update all changes made on <see cref="DMXeOto" /> Object to underlying database.
        /// </summary>
        internal void Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMXeOto
            if (!this.IsDirty)
                return;
            
              
            DataProvider.Instance().UpdateDMXeOto(_MaXeOto, _TenXeOto, _MaNVQL, _mota, _ghiChu, _huy, _nguoiSD, _maMay);
            // public abstract void UpdateDMXeOto(String _MaXeOto, Decimal _NamThau, String _MaNCC, String _MaXeOto, Boolean _huy, String _nguoiSD, String _maMay);
            // public override void UpdateDMXeOto(String _MaXeOto, Decimal _NamThau, String _MaNCC, String _MaXeOto, Boolean _huy, String _nguoiSD, String _maMay)
            // {
            //		SqlHelper.ExecuteNonQuery(ConnectionString, DatabaseOwner + ObjectQualifier + "spDMXeOto_Update", _MaXeOto, _NamThau, _MaNCC, _MaXeOto, _huy, _nguoiSD , _maMay);
            // }				
            MarkOld();
        }
     

        /// <summary>
        /// Delete the <see cref="DMXeOto" />.
        /// </summary>
      

        internal void DeleteSelf()
        {
            //if (!this.IsDirty)
            //    return;
            if (this.IsNew)
                return;
            DataPortal_Delete(new OtherCriteria(_MaXeOto));
            MarkNew();
        }

        private void DataPortal_Delete(OtherCriteria crit)
        {
            DataProvider.Instance().DeleteDMXeOto(crit.MaXeOto, _nguoiSD , crit.MaMay);
        }

        #endregion
    }

}
