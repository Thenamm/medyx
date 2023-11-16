using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
 //using System.Windows.Forms;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThuoc_GiaDuyetList : BusinessListBase<DMThuoc_GiaDuyetList, DMThuoc_GiaDuyet>
    {
        #region Business Methods
        #region State Fields
        public int _record = 0;

        #endregion
        #region Business Properties and Methods
        public int record
        {
            get
            {

                return _record;
            }

        }
        #endregion
        #endregion
        #region Factory Methods
        public static DMThuoc_GiaDuyetList NewList()
        {
            return DataPortal.Fetch<DMThuoc_GiaDuyetList>(new TemCriteria());
        }
        public static DMThuoc_GiaDuyetList GetAllDMThuoc_GiaDuyet(String madt, string dK)
        {
            return DataPortal.Fetch<DMThuoc_GiaDuyetList>(new Criteria(madt, dK ));
        }
        public static DMThuoc_GiaDuyetList GetAllDMThuoc_GiaDuyet(String madt)
        {
            return DataPortal.Fetch<DMThuoc_GiaDuyetList>(new Criteria(madt,"" ));
        }
        public static DMThuoc_GiaDuyetList GetAllDMThuoc_GiaDuyetFilter( string dK, string dkfilter,String madt)
        {
            return DataPortal.Fetch<DMThuoc_GiaDuyetList>(new CriteriaFilter(madt, dK, dkfilter));
        }
        public static DMThuoc_GiaDuyetList GetAllDMThuoc_GiaDuyetFilter(String madt, string dkfilter)
        {
            return DataPortal.Fetch<DMThuoc_GiaDuyetList>(new CriteriaFilter(madt, "", dkfilter));
        }
        public DMThuoc_GiaDuyet NewTo() {
            DMThuoc_GiaDuyet obj = DMThuoc_GiaDuyet.NewDMThuoc_GiaDuyet();
            return obj ;
        }
        
        public void NewTo(DMThuoc_GiaDuyet _DMThuoc_GiaDuyet)
        {
            try
            {
                if (!Contains(_DMThuoc_GiaDuyet.MaThuoc ,_DMThuoc_GiaDuyet.MaDT,_DMThuoc_GiaDuyet.Huy  ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMThuoc_GiaDuyet.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMThuoc_GiaDuyet);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMThuoc_GiaDuyet.STT = ++_count;
                        this.Add(_DMThuoc_GiaDuyet);
                    }
                    else
                    {
                        _DMThuoc_GiaDuyet.STT = 1;
                        this.Add(_DMThuoc_GiaDuyet);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
               //MessageBox.Show(ex.Message)   ;
            }
        }
        public void UpdatedTo(DMThuoc_GiaDuyet _DMThuoc_GiaDuyet)
        {

            _DMThuoc_GiaDuyet.STT = this.Items[this.IndexOf(_DMThuoc_GiaDuyet)].STT;
            this.Items[this.IndexOf(_DMThuoc_GiaDuyet)] = _DMThuoc_GiaDuyet;
        }
        public DMThuoc_GiaDuyet GetTo(decimal STT) //
        {
            foreach (DMThuoc_GiaDuyet obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        //public void RemoveTo(DMThuoc_GiaDuyet _DMThuoc_GiaDuyet)
        //{
        //    this.Items.Remove(_DMThuoc_GiaDuyet);

        //}
        public void RemoveTo(DMThuoc_GiaDuyet obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public DMThuoc_GiaDuyet  AssignTo(DMThuoc_GiaDuyet  _DMThuoc_GiaDuyet)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMThuoc_GiaDuyet.STT = ++_count;
                this.Add(_DMThuoc_GiaDuyet);
            }
            else
            {
                _DMThuoc_GiaDuyet.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMThuoc_GiaDuyet);
            }
            //Add(_PhieuNhap_C);
            return _DMThuoc_GiaDuyet;
        }
        public bool Contains(string MaThuoc, string MaDT,bool Huy)
        {
            foreach (DMThuoc_GiaDuyet  obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.MaDT == MaDT)&&(obj.Huy ==Huy ))
                    return true;
            return false;
        }
        public DMThuoc_GiaDuyet  GetDMThuoc_GiaDuyetById(string madt, decimal stt)
        {
            foreach (DMThuoc_GiaDuyet  item in this)
                if ((item.MaDT   == madt ) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMThuoc_GiaDuyet  item in this)
            {
                if ((item.MaDT   == madt ) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            DMThuoc_GiaDuyet item = DMThuoc_GiaDuyet.NewDMThuoc_GiaDuyet();
            Add(item);
            return item;
        }

        private DMThuoc_GiaDuyetList()
        {  /* Require use of factory methods */
            this.AllowNew = true;
        }

        #endregion

        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion

        #region Data Access

        [Serializable()]
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class Criteria
        {
            
            private String _MaDT;
             private Boolean _qadmin = false ;
            public Boolean qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            private String  _dK;
            public String DK
            {
                get
                {
                    return _dK;
                }
            }
            public Criteria(String MaDT, string dK)
            {
                _MaDT = MaDT ;
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _dK = dK;
            }   
        }
        private class CriteriaFilter
        {

            private String _MaDT;
             private Boolean _qadmin = false ;
            public Boolean qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            private String _dK;
            public String DK
            {
                get
                {
                    return _dK;
                }
            }
            private String _dKFilter;
            public String DKFilter
            {
                get
                {
                    return _dKFilter;
                }
            }
            public CriteriaFilter(String MaDT, string dK, string dKFilter)
            {
                _MaDT = MaDT;
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _dK = dK;
                _dKFilter = dKFilter;
            }
        }

        //#region CriteriaOther

        //[Serializable()]
        //private class CriteriaOther
        //{

        //    private Byte _IdFind;
        //    public Byte IdFind
        //    {
        //        get
        //        {
        //            return _IdFind;
        //        }
        //    }
        //    private string _DK;
        //    public string DK
        //    {
        //        get
        //        {
        //            return _DK;
        //        }
        //    }
        //     private Boolean _qadmin = false ;
        //    public bool qadmin
        //    {
        //        get
        //        {
        //            return _qadmin;
        //        }
        //    }
        //    //public Criteria(Boolean mqadmin)
        //    //{

        //    //    _qadmin = mqadmin;
        //    //}
        //    public CriteriaOther(Byte mIdFind, String mDK)
        //    {

        //        //_IdFind = mIdFind;
        //        //if (mIdFind == 1)
        //        //    _DK = "MaDT like '%" + mDK + "'";
        //        //else if (mIdFind == 2)
        //        //    _DK = "ltrim(rtrim(TenDTsudung)) like N'" + mDK + "%'";


        //    }
        //}
        //#endregion

        //private void DataPortal_Fetch(Criteria criteria)
        //{
        //    RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuoc_GiaDuyet()))
        //    {
        //        int i = 1;

        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMThuoc_GiaDuyet item  = new DMThuoc_GiaDuyet(
        // i,
        // dr.GetString("MaDT") ,
        // dr.GetDecimal("STT") ,
        // dr.GetString("MaThuoc") ,
        // dr.GetDecimal("DonGiaBH") ,
        // dr.GetDecimal("DonGiaThuT") ,
        // dr.GetDecimal("DonGiaPhauT") ,
        // dr.GetDecimal("DonGiaCLS") ,
        // dr.GetDecimal("GiaChenhLech"),
        // dr.GetBoolean("ADChenhLech") ,
        // dr.GetBoolean("DTBH"),
        // dr.GetBoolean("ADPhongMo") ,
        // dr.GetDecimal("DonGia1") ,
        // dr.GetDecimal("GiachenhLech1") ,
        // dr.GetSmartDate("Ngay1", true) ,
        // dr.GetString("Ghichu") ,
        // dr.GetString("MaMay") ,
        // dr.GetBoolean("Huy") ,
        // dr.GetSmartDate("NgayLap", false) ,
        // dr.GetString("NguoiLap") ,
        // dr.GetSmartDate("NgayHuy", false) ,
        // dr.GetString("NguoiHuy") ,
        // dr.GetSmartDate("NgaySD1", false) ,
        // dr.GetString("NguoiSD1") ,
        // dr.GetSmartDate("NgaySD",false) ,
        // dr.GetString("NguoiSD") 
    
        // );
        //            this.Add(item);
        //            i += 1;

        //        }
        //        //IsReadOnly = true;
        //    }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

        //    RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuoc_GiaDuyet(criteria.MaDT,criteria.DK,  criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(DMThuoc_GiaDuyet .GetDMThuoc_GiaDuyet(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuoc_GiaDuyetFilter(criteria.MaDT, criteria.DK, criteria.DKFilter,  criteria.qadmin)))
            {
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                while (dr.Read())
                {
                    this.Add(DMThuoc_GiaDuyet.GetDMThuoc_GiaDuyet(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMThuoc_GiaDuyet item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMThuoc_GiaDuyet item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMThuoc_GiaDuyetList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMThuoc_GiaDuyetList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
