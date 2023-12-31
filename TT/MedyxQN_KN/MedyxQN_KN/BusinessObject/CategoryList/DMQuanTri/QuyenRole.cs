using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business;
using HTC.Business.CategoryList;


namespace HTC.Business.CategoryList
{
    [Serializable()]
    public partial class QuyenRole : BusinessBase<QuyenRole>
    {
        #region Business Methods

        #region State Fields
        private String _maMN = String.Empty;
        private String _maRole = String.Empty;
        private Byte _quyenMN = 0;
        private String _maMay = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private String _hOTEN = String.Empty;
        private String _tenmn = String.Empty;
      
        private int _OrderNumber;


        #endregion

        #region Business Properties and Methods

        public String MaMN
        {
            get
            {
                CanReadProperty("MaMN", true);
                return _maMN;
            }
            set
            {
                CanWriteProperty("MaMN", true);
                if (_maMN != value)
                {
                    _maMN = value;
                    PropertyHasChanged("MaMN");
                }
            }
        }

        public String MaRole
        {
            get
            {
                CanReadProperty("MaRole", true);
                return _maRole;
            }
            set
            {
                CanWriteProperty("MaRole", true);
                if (_maRole != value)
                {
                    _maRole = value;
                    PropertyHasChanged("MaRole");
                }
            }
        }
        public String TenQuyen
        {
            get
            {
                if (_quyenMN == 0)
                    return "Xem";
                else if (_quyenMN == 1)
                    return "Thêm";
                else if (_quyenMN == 2)
                    return "Sửa";
                else if (_quyenMN == 3)
                    return "Xóa";
                else 
                    return "Không truy cập";
            }
           
        }
        public Byte QuyenMN
        {
            get
            {
                CanReadProperty("QuyenMN", true);
                return _quyenMN;
            }
            set
            {
                CanWriteProperty("QuyenMN", true);
                if (_quyenMN != value)
                {
                    _quyenMN = value;
                    PropertyHasChanged("QuyenMN");
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

        public String HOTEN
        {
            get
            {
                CanReadProperty("HOTEN", true);
                return _hOTEN;
            }
            set
            {
                CanWriteProperty("HOTEN", true);
                if (_hOTEN != value)
                {
                    _hOTEN = value;
                    PropertyHasChanged("HOTEN");
                }
            }
        }

        public String Tenmn
        {
            get
            {
                CanReadProperty("Tenmn", true);
                return _tenmn;
            }
            set
            {
                CanWriteProperty("Tenmn", true);
                if (_tenmn != value)
                {
                    _tenmn = value;
                    PropertyHasChanged("Tenmn");
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
            return _maMN;
        }

        #endregion
        #endregion

        #region Business Object Rules and Validation


        #endregion

        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMDichVu_PhieuIn_C" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static QuyenRole NewQuyenRole()
        {
            return new QuyenRole();

        }
        public static QuyenRole GetQuyenRole(String maDMRole, string maMN)
        {
            return DataPortal.Fetch<QuyenRole>(new Criteria(maDMRole, maMN));
        }
        public static QuyenRole GetQuyenRole(SafeDataReader dr)
        {
            return new QuyenRole(dr);
        }
        public static QuyenRole GetQuyenRole(SafeDataReader dr, int i)
        {
            return new QuyenRole(dr, i);
        }
        public static void DeleteQuyenRole(String _maRole, String _maMN)
        {
            DataPortal.Delete(new OtherCriteria(_maRole, _maMN));
        }

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public-++++ !!!
        protected internal QuyenRole()
        {
            // Prevent direct creation
        }
        protected QuyenRole(SafeDataReader dr, int i)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();

            Fetch(dr, i);
            MarkOld();
        }
        protected QuyenRole(SafeDataReader dr)//lay nhung thang hien ra tren luoi
        {
            MarkAsChild();

            Fetch(dr);
            MarkOld();
        }
        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
            private String _maRole;
            public String maRole
            {
                get
                {
                    return _maRole;
                }
            }
            private String _maMN;
            public String maMN
            {
                get
                {
                    return _maMN;
                }
            }

            public Criteria(String maRole, String maMN)
            {
                _maRole = maRole;
                _maMN = maMN;
            }

            public override bool Equals(object obj)
            {
                if (obj is Criteria)
                {
                    Criteria c = (Criteria)obj;
                    if (!_maRole.Equals(c._maRole))
                        return false;
                    return true;
                }
                return false;
            }

            public override int GetHashCode()
            {
                return string.Concat("Criteria", _maRole.ToString()).GetHashCode();
            }
        }

        [Serializable()]

        protected class OtherCriteria
        {
            private String _maRole;
            public String maRole
            {
                get
                {
                    return _maRole;
                }
            }

            private String _maMN;
            public String maMN
            {
                get
                {
                    return _maMN;
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
            // public OtherCriteria(String Mamay, String Nguoisd, String maPhieu, Byte sTT)
            public OtherCriteria(String maRole, String maMN)
            {
                _maRole = maRole;
                _maMN = maMN;

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
        /// Retrieve an existing <see cref="DMDichVu_PhieuIn_C" /> Object based on data in the database.
        /// </summary>
        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetQuyenRole(crit.maRole, crit.maMN)))
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
        /// Load a <see cref="DMDichVu_PhieuIn_C" /> Object from given SafeDataReader.
        /// </summary>
        private void Fetch(SafeDataReader dr)//lay o chi tiet thu tuc spQuyenRole_Get
        {
            // Value properties

            if (dr.GetString("MaMN") != null) _maMN = dr.GetString("MaMN");
            if (dr.GetString("MaRole") != null) _maRole = dr.GetString("MaRole");
            if (dr.GetByte("QuyenMN") != null) _quyenMN = dr.GetByte("QuyenMN");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("HOTEN") != null) _hOTEN = dr.GetString("HOTEN");
            if (dr.GetString("tenmn") != null) _tenmn = dr.GetString("tenmn");
            try
            {
                //if (dr.GetByte("STT") != null) _OrderNumber = dr.GetByte("STT");
                //_OrderNumber = dr.GetByte("STT");

            }
            catch (Exception ex)
            { }


        }
        private void Fetch(SafeDataReader dr, int i)//lay o chi tiet thu tuc spQuyenRole_Get
        {
            // Value properties
            _OrderNumber = i;
            if (dr.GetString("MaMN") != null) _maMN = dr.GetString("MaMN");
            if (dr.GetString("MaRole") != null) _maRole = dr.GetString("MaRole");
            if (dr.GetByte("QuyenMN") != null) _quyenMN = dr.GetByte("QuyenMN");
            if (dr.GetString("MaMay") != null) _maMay = dr.GetString("MaMay");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetString("HOTEN") != null) _hOTEN = dr.GetString("HOTEN");
            if (dr.GetString("tenmn") != null) _tenmn = dr.GetString("tenmn");
            try
            {
                //if (dr.GetByte("STT") != null) _OrderNumber = dr.GetByte("STT");
                //_OrderNumber = dr.GetByte("STT");

            }
            catch (Exception ex)
            { }


        }
        /// <summary>
        /// Insert the new <see cref="DMDichVu_PhieuIn_C" /> Object to underlying database.
        /// </summary>
        /// 
        //protected override void DataPortal_Create()
        //{
        //    ValidationRules.CheckRules();
        //}
        //protected override void DataPortal_Insert()

        internal virtual void Insert(DMRole bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_PhieuIn_C
            // Copy & paste ham duoi day vao file DataProvider.cs
            //_maPhieu = DataProvider.Instance().InsertDMDichVu_PhieuIn_C(_maDV, _maMay, _nguoiSD);
            if (this.IsDirty)
            {
                
                  
                //_maRole = 
                    DataProvider.Instance().InsertQuyenRole(_maMN, bill.MaRole, _quyenMN, _maMay, _nguoiSD);
            }
        }

        /// Update all changes made on <see cref="DMDichVu_PhieuIn_C" /> Object to underlying database.
        /// </summary>
        //protected override void DataPortal_Update()
        internal virtual void Update(DMRole bill)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_PhieuIn_C
            if (IsDirty)
            {
                
                  
                DataProvider.Instance().UpdateQuyenRole(_maMN, _maRole, _quyenMN, _maMay, _huy, _nguoiSD);

            }
        }



        internal void DeleteSelf(DMRole bill)
        {
            // if we're not dirty then don't update the database
            if (!this.IsDirty)
                return;

            // if we're new then don't update the database
            if (this.IsNew)
                return;

            DataProvider.Instance().DeleteQuyenRole(_maRole, _maMN, _maMay, _nguoiSD);
            MarkNew();
        }
        #endregion
    }


}
