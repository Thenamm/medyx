





using System;
using System.Data;
using System.Data.SqlClient;
using Csla;
using Csla.Data;
using HTC.Business.Duoc;
using HTC.Business;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public partial class DMKyHieu : BusinessBase<DMKyHieu>
    {

        #region Business Methods

        #region State Fields

        private String _makho = String.Empty;
        private String _sTT = String.Empty;
        private String _KyHieu = String.Empty;
        private Boolean _huy = false;
        private SmartDate _ngaySD = new SmartDate(true);
        private String _nguoiSD = String.Empty;
        private SmartDate _ngayLap = new SmartDate(true);
        private String _nguoiLap = String.Empty;
        private SmartDate _ngayHuy = new SmartDate(true);
        private String _nguoiHuy = String.Empty;
        private SmartDate _ngaySD1 = new SmartDate(true);
        private String _nguoiSD1 = String.Empty;
        private String _tenNguoiLap = String.Empty;
        private String _tenNguoiHuy = String.Empty;
        private String _tenNguoiSD = String.Empty;
        private String _tenNguoiSD1 = String.Empty;
        private SmartDate _ngayLapD = new SmartDate(true);
        private SmartDate _ngaySDD = new SmartDate(true);
        private int _OrderNumber;

        #endregion

        #region Business Properties and Methods

        public String Makho
        {
            get
            {
                CanReadProperty("Makho", true);
                return _makho;
            }
            set
            {
                CanWriteProperty("Makho", true);
                if (_makho != value)
                {
                    _makho = value;
                    PropertyHasChanged("Makho");
                }
            }
        }

        public String STT
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

        public String KyHieu
        {
            get
            {
                CanReadProperty("KyHieu", true);
                return _KyHieu;
            }
            set
            {
                CanWriteProperty("KyHieu", true);
                if (_KyHieu != value)
                {
                    _KyHieu = value;
                    PropertyHasChanged("KyHieu");
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

        public string NgayLap
        {
            get
            {
                CanReadProperty("NgayLap", true);
                return _ngayLap.Text;
            }
            set
            {
                CanWriteProperty("NgayLap", true);
                if (_ngayLap.Text != value)
                {
                    _ngayLap.Text = value;
                    PropertyHasChanged("NgayLap");
                }
            }
        }

        public String NguoiLap
        {
            get
            {
                CanReadProperty("NguoiLap", true);
                return _nguoiLap;
            }
            set
            {
                CanWriteProperty("NguoiLap", true);
                if (_nguoiLap != value)
                {
                    _nguoiLap = value;
                    PropertyHasChanged("NguoiLap");
                }
            }
        }

        public string NgayHuy
        {
            get
            {
                CanReadProperty("NgayHuy", true);
                return _ngayHuy.Text;
            }
            set
            {
                CanWriteProperty("NgayHuy", true);
                if (_ngayHuy.Text != value)
                {
                    _ngayHuy.Text = value;
                    PropertyHasChanged("NgayHuy");
                }
            }
        }

        public String NguoiHuy
        {
            get
            {
                CanReadProperty("NguoiHuy", true);
                return _nguoiHuy;
            }
            set
            {
                CanWriteProperty("NguoiHuy", true);
                if (_nguoiHuy != value)
                {
                    _nguoiHuy = value;
                    PropertyHasChanged("NguoiHuy");
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




        public String TenNguoiLap
        {
            get
            {
                CanReadProperty("TenNguoiLap", true);
                return _tenNguoiLap;
            }
            set
            {
                CanWriteProperty("TenNguoiLap", true);
                if (_tenNguoiLap != value)
                {
                    _tenNguoiLap = value;
                    PropertyHasChanged("TenNguoiLap");
                }
            }
        }

        public String TenNguoiHuy
        {
            get
            {
                CanReadProperty("TenNguoiHuy", true);
                return _tenNguoiHuy;
            }
            set
            {
                CanWriteProperty("TenNguoiHuy", true);
                if (_tenNguoiHuy != value)
                {
                    _tenNguoiHuy = value;
                    PropertyHasChanged("TenNguoiHuy");
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

        public String TenNguoiSD1
        {
            get
            {
                CanReadProperty("TenNguoiSD1", true);
                return _tenNguoiSD1;
            }
            set
            {
                CanWriteProperty("TenNguoiSD1", true);
                if (_tenNguoiSD1 != value)
                {
                    _tenNguoiSD1 = value;
                    PropertyHasChanged("TenNguoiSD1");
                }
            }
        }
        public String NgayLapD
        {
            get
            {
                CanReadProperty("NgayLapD", true);
                _ngayLapD = _ngayLap;
                this._ngayLapD.FormatString = "dd/MM/yyyy";
                return _ngayLapD.Text;
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
            return _sTT;
        }

        #endregion
        #endregion






        #region Factory Methods


        /// <summary>
        /// Factory method. New <see cref="DMDichVu_BC" /> Object is loaded from the database, based on given parameters.
        /// </summary> 
        /// 
        public static DMKyHieu NewDMKyHieu()
        {
            return DataPortal.Create<DMKyHieu>();
        }
        public static DMKyHieu GetDMKyHieu_Get(String makho, String sTT, bool qAdmin)
        {
            return DataPortal.Fetch<DMKyHieu>(new Criteria(makho, sTT,qAdmin ));
        }
        public static DMKyHieu GetDMKyHieu_Get(SafeDataReader dr)
        {
            DMKyHieu obj = new DMKyHieu();
            obj.Fetch(dr);
            return obj;
        }
        public static void DeleteDMKyHieu(String makho, String sTT)
        {
            DataPortal.Delete(new OtherCriteria(makho, sTT));
        }

        /// <summary>
        /// Marks the <see cref="DMDichVu_BC" /> Object for deletion. The Object will be deleted as part of the next save operation.
        /// </summary>//(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);

        #endregion

        #region Constructors
        // Chu y !!!
        // Neu mot doi tuong Collection sao do muon su dung CBO.FillCollection cho doi tuong nay
        // thi khai bao ham khoi tao duoi day voi tu khoa public !!!
         protected internal DMKyHieu()
        {
        }
           internal DMKyHieu(int ordernumber, String Makho ,String STT , String KyHieu , bool Huy , SmartDate  NgaySD , string nguoiSD ,SmartDate ngayLap , String nguoiLap , SmartDate ngayHuy , String nguoiHuy ,SmartDate ngaySD1 ,String nguoiSD1 ,String tenNguoiLap ,String tenNguoiHuy ,String tenNguoiSD ,String tenNguoiSD1 )
        {
           _OrderNumber = ordernumber ;
               _makho = Makho ;
               _sTT= STT;
               _KyHieu= KyHieu ;
               _huy= Huy ;
              _ngayLap =  NgaySD ;
               _nguoiSD =  nguoiSD;
               _ngayLap = ngayLap ;
               _nguoiLap = nguoiLap;
               _ngayHuy=  ngayHuy;
               _nguoiHuy = nguoiHuy;
               _ngaySD1 =  ngaySD1 ;
               _nguoiSD1 =  nguoiSD1;
               _tenNguoiLap = tenNguoiLap;
              _tenNguoiHuy = tenNguoiHuy;
               _tenNguoiSD = tenNguoiSD;
               _tenNguoiSD1 = tenNguoiSD1 ;

        }

        #endregion

        #region Criteria

        [Serializable()]
        protected class Criteria
        {
           
            private String _makho;
            public String Makho
            {
                get
                {
                    return _makho;
                }
            }

            private String _sTT;
            public String STT
            {
                get
                {
                    return _sTT;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String maKho, String sTT, bool Qadmin)
            {
                _makho = maKho;
                _sTT = sTT;
                _qadmin = Qadmin;
            }


            public override int GetHashCode()
            {
                return string.Concat("Criteria", _sTT.ToString()).GetHashCode();
            }
        }

        [Serializable()]
        protected class OtherCriteria
        {
            private String _maKho;
            public String MaKho
            {
                get
                {
                    return _maKho;
                }
            }
            private String _sTT;
            public String STT
            {
                get
                {
                    return _sTT;
                }
            }
           
            //DeleteDMKyHieu(String _maPN, SmartDate _ngaySD, String _maMay, String _nguoiSD);
            public OtherCriteria(String maKho, string sTT)
            {
                _maKho = maKho ;
                _sTT = sTT;
                

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
        /// Retrieve an existing <see cref="DMDichVu_BC" /> Object based on data in the database.
        /// </summary>
        /// 
       private void Fetch(SafeDataReader dr)
        {
            // Value properties
            if (dr.GetString("Makho") != null) _makho = dr.GetString("Makho");
            if (dr.GetString("STT") != null) _sTT = dr.GetString("STT");
            if (dr.GetString("KyHieu") != null) _KyHieu = dr.GetString("KyHieu");
            if (dr.GetBoolean("Huy") != null) _huy = dr.GetBoolean("Huy");
            if (dr.GetSmartDate("NgaySD", true) != null) _ngaySD = dr.GetSmartDate("NgaySD", true);
            if (dr.GetString("NguoiSD") != null) _nguoiSD = dr.GetString("NguoiSD");
            if (dr.GetSmartDate("NgayLap", true) != null) _ngayLap = dr.GetSmartDate("NgayLap", true);
            if (dr.GetString("NguoiLap") != null) _nguoiLap = dr.GetString("NguoiLap");
            if (dr.GetSmartDate("NgayHuy", true) != null) _ngayHuy = dr.GetSmartDate("NgayHuy", true);
            if (dr.GetString("NguoiHuy") != null) _nguoiHuy = dr.GetString("NguoiHuy");
            if (dr.GetSmartDate("NgaySD1", true) != null) _ngaySD1 = dr.GetSmartDate("NgaySD1", true);
            if (dr.GetString("NguoiSD1") != null) _nguoiSD1 = dr.GetString("NguoiSD1");
            if (dr.GetString("TenNguoiLap") != null) _tenNguoiLap = dr.GetString("TenNguoiLap");
            if (dr.GetString("TenNguoiHuy") != null) _tenNguoiHuy = dr.GetString("TenNguoiHuy");
            if (dr.GetString("TenNguoiSD") != null) _tenNguoiSD = dr.GetString("TenNguoiSD");
            if (dr.GetString("TenNguoiSD1") != null) _tenNguoiSD1 = dr.GetString("TenNguoiSD1");
             }


        protected void DataPortal_Fetch(Criteria crit)
        {

            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetDMKyHieu_Get(crit.Makho , crit.STT )))
            {
                if (dr.Read())
                {
                    Fetch(dr);
                    if (dr.NextResult())
                    {
                        // _DMKyHieu_Cs = DMKyHieu_Cs.GetDMKyHieu_Cs(dr);//////////////
                    }
                    //ValidationRules.CheckRules();
                }
            }
        }


        /// <summary>
        /// Insert the new <see cref="DMDichVu_BC" /> Object to underlying database.
        /// </summary>
        /// 
        protected override void DataPortal_Create()
        {
            _ngayLap.Date = DateTime.Now;
            ValidationRules.CheckRules();
        }
        protected override void DataPortal_Insert()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham InsertDMDichVu_BC
            // Copy & paste ham duoi day vao file DataProvider.cs
            //
             
            _sTT = DataProvider.Instance().InsertDMKyHieu(_makho, _KyHieu, _nguoiSD);


            // _DMKyHieu_Cs.Update(this);

        }


        /// <summary>
        /// Update all changes made on <see cref="DMDichVu_BC" /> Object to underlying database.
        /// </summary>
        protected override void DataPortal_Update()
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            if (IsDirty)
            {

                //
                ////_nguoiSuDung = HTC.ShareVariables.pub_sNguoiSD;

                  
                //_nguoiSD1 = HTC.ShareVariables.pub_sNguoiSD ;
                DataProvider.Instance().UpdateDMKyHieu(_makho,_sTT, _KyHieu,_huy , _nguoiSD, _nguoiSD1 );

            }
        }
        //protected override void DataPortal_DeleteSelf()
        //{
        //    DataPortal_Delete(new OtherCriteria(_maPN, _ngaySuDung, _maMay, _nguoiSuDung));
        //}


        protected void DataPortal_Delete(OtherCriteria crit)
        {
            // TODO: Kiem tra lai cac tham so truyen vao cho ham UpdateDMDichVu_BC
            DataProvider.Instance().DeleteDMKyHieu(crit.MaKho, crit.STT);

        }

        #endregion
    }


}
