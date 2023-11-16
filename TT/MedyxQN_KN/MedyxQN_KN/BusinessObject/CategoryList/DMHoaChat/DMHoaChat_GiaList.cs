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
    public class DMHoaChat_GiaList : BusinessListBase<DMHoaChat_GiaList, DMHoaChat_Gia>
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
        public static DMHoaChat_GiaList NewList()
        {
            return DataPortal.Fetch<DMHoaChat_GiaList>(new TemCriteria());
        }
        public static DMHoaChat_GiaList GetAllDMHoaChat_Gia(String madt, string DK)
        {
            return DataPortal.Fetch<DMHoaChat_GiaList>(new Criteria(madt, DK ));
        }
        public static DMHoaChat_GiaList GetAllDMHoaChat_GiaFilter( string dK, string dkfilter,String madt)
        {
            return DataPortal.Fetch<DMHoaChat_GiaList>(new CriteriaFilter(madt, dK, dkfilter));
        }
       
        public DMHoaChat_Gia NewTo()
        {
            DMHoaChat_Gia obj = DMHoaChat_Gia.NewDMHoaChat_Gia();
            return obj;
        }

        public void NewTo(DMHoaChat_Gia _DMHoaChat_Gia)
        {
            try
            {
                if (!Contains(_DMHoaChat_Gia.MaHC, _DMHoaChat_Gia.MaDT, _DMHoaChat_Gia.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMHoaChat_Gia.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMHoaChat_Gia);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMHoaChat_Gia.STT = ++_count;
                       
                        this.Add(_DMHoaChat_Gia);
                    }
                    else
                    {
                        _DMHoaChat_Gia.STT = 1;
                       
                        this.Add(_DMHoaChat_Gia);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
        public void UpdatedTo(DMHoaChat_Gia _DMHoaChat_Gia)
        {

            _DMHoaChat_Gia.STT = this.Items[this.IndexOf(_DMHoaChat_Gia)].STT;
            this.Items[this.IndexOf(_DMHoaChat_Gia)] = _DMHoaChat_Gia;
        }
        public DMHoaChat_Gia GetTo(decimal STT) //
        {
            foreach (DMHoaChat_Gia obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        public void RemoveTo(DMHoaChat_Gia _DMHoaChat_Gia)
        {
            this.Items.Remove(_DMHoaChat_Gia);

        }
        public DMHoaChat_Gia AssignTo(DMHoaChat_Gia _DMHoaChat_Gia)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMHoaChat_Gia.STT = ++_count;
                this.Add(_DMHoaChat_Gia);
            }
            else
            {
                _DMHoaChat_Gia.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMHoaChat_Gia);
            }
            //Add(_PhieuNhap_C);
            return _DMHoaChat_Gia;
        }
        public bool Contains(string MaHC, string MaDT, bool Huy)
        {
            foreach (DMHoaChat_Gia obj in this)
                if ((obj.MaHC == MaHC) && (obj.MaDT == MaDT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public DMHoaChat_Gia GetDMHoaChat_GiaById(string madt, decimal stt)
        {
            foreach (DMHoaChat_Gia item in this)
                if ((item.MaDT == madt) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMHoaChat_Gia item in this)
            {
                if ((item.MaDT == madt) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            DMHoaChat_Gia item = DMHoaChat_Gia.NewDMHoaChat_Gia();
            Add(item);
            return item;
        }

        private DMHoaChat_GiaList()
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
            private String _dK;
            public String DK
            {
                get
                {
                    return _dK;
                }
            }
            public Criteria(String MaDT, string DK)
            {
                _MaDT = MaDT;
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _dK = DK;

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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHoaChat_Gia()))
        //    {
        //        int i = 1;

        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMHoaChat_Gia item  = new DMHoaChat_Gia(
        // i,
        // dr.GetString("MaDT") ,
        // dr.GetDecimal("STT") ,
        // dr.GetString("MaHC") ,
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHoaChat_Gia(criteria.MaDT, criteria.qadmin, criteria.DK )))
            {
                while (dr.Read())
                {
                    this.Add(DMHoaChat_Gia.GetDMHoaChat_Gia(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHoaChat_GiaFilter(criteria.MaDT, criteria.DK, criteria.DKFilter, criteria.qadmin)))
            {
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                while (dr.Read())
                {
                    this.Add(DMHoaChat_Gia.GetDMHoaChat_Gia(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMHoaChat_Gia item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMHoaChat_Gia item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMHoaChat_GiaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMHoaChat_GiaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
