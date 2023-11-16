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
    public class DMVTYT_GiaList : BusinessListBase<DMVTYT_GiaList, DMVTYT_Gia>
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
        public static DMVTYT_GiaList GetAllDMVTYT_Gia(String madt , String DK)
        {
            return DataPortal.Fetch<DMVTYT_GiaList>(new Criteria(madt, DK ));
        }
        public static DMVTYT_GiaList GetAllDMVTYT_GiaFilter( string dK, string dkfilter,String madt)
        {
            return DataPortal.Fetch<DMVTYT_GiaList>(new CriteriaFilter(madt, dK, dkfilter));
        }
        public DMVTYT_Gia NewTo()
        {
            DMVTYT_Gia obj = DMVTYT_Gia.NewDMVTYT_Gia();
            return obj;
        }

        public void NewTo(DMVTYT_Gia _DMVTYT_Gia)
        {
            try
            {
                if (!Contains(_DMVTYT_Gia.MaVT, _DMVTYT_Gia.MaDT, _DMVTYT_Gia.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMVTYT_Gia.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMVTYT_Gia);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMVTYT_Gia.STT = ++_count;
                        this.Add(_DMVTYT_Gia);
                    }
                    else
                    {
                        _DMVTYT_Gia.STT = 1;
                        this.Add(_DMVTYT_Gia);

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
        public void UpdatedTo(DMVTYT_Gia _DMVTYT_Gia)
        {

            _DMVTYT_Gia.STT = this.Items[this.IndexOf(_DMVTYT_Gia)].STT;
            this.Items[this.IndexOf(_DMVTYT_Gia)] = _DMVTYT_Gia;
        }
        public void RemoveTo(DMVTYT_Gia _DMVTYT_Gia)
        {
            this.Items.Remove(_DMVTYT_Gia);

        }
        public DMVTYT_Gia AssignTo(DMVTYT_Gia _DMVTYT_Gia)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMVTYT_Gia.STT = ++_count;
                this.Add(_DMVTYT_Gia);
            }
            else
            {
                _DMVTYT_Gia.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMVTYT_Gia);
            }
            //Add(_PhieuNhap_C);
            return _DMVTYT_Gia;
        }
        public bool Contains(string MaVT, string MaDT, bool Huy)
        {
            foreach (DMVTYT_Gia obj in this)
                if ((obj.MaVT == MaVT) && (obj.MaDT == MaDT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public DMVTYT_Gia GetDMVTYT_GiaById(string madt, decimal stt)
        {
            foreach (DMVTYT_Gia item in this)
                if ((item.MaDT == madt) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMVTYT_Gia item in this)
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
            DMVTYT_Gia item = DMVTYT_Gia.NewDMVTYT_Gia();
            Add(item);
            return item;
        }

        private DMVTYT_GiaList()
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
            private String _DK;
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
            public String dK
            {
                get
                {
                    return _DK;
                }
            }

            public Criteria(String MaDT, String DK)
            {
                _MaDT = MaDT;
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _DK = DK;
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVTYT_Gia()))
        //    {
        //        int i = 1;

        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMVTYT_Gia item  = new DMVTYT_Gia(
        // i,
        // dr.GetString("MaDT") ,
        // dr.GetDecimal("STT") ,
        // dr.GetString("MaVT") ,
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVTYT_Gia(criteria.MaDT, criteria.qadmin, criteria.dK  )))
            {
                while (dr.Read())
                {
                    this.Add(DMVTYT_Gia.GetDMVTYT_Gia(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVTYT_GiaFilter(criteria.MaDT, criteria.qadmin, criteria.DK, criteria.DKFilter)))
            {
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                while (dr.Read())
                {
                    this.Add(DMVTYT_Gia.GetDMVTYT_Gia(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMVTYT_Gia item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMVTYT_Gia item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMVTYT_GiaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMVTYT_GiaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
