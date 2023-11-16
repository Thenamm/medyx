using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//

namespace HTC.Business.CategoryList
{
    [Serializable()]

    public class DMPhauThuat_GiaList : BusinessListBase<DMPhauThuat_GiaList, DMPhauThuat_Gia>
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
        public static DMPhauThuat_GiaList FindDMPhauThuat_GiaByTen(string TenPT,string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_GiaList>(new OtherCriteria(2, TenPT,madt));
        }
        public static DMPhauThuat_GiaList FindDMPhauThuat_GiaByMa(string MaPT,string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_GiaList>(new OtherCriteria(1, MaPT,madt));
        }
        public static DMPhauThuat_GiaList FindDMPhauThuat_GiaByFilter(string dk, string dkfilter, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_GiaList>(new CriteriaFilter(1,dk, dkfilter, madt));
        }
        public DMPhauThuat_Gia NewTo() 
        {
            DMPhauThuat_Gia obj = DMPhauThuat_Gia.NewDMPhauThuat_Gia();
            return obj;
        }
        public void NewTo(DMPhauThuat_Gia _DMPhauThuat_Gia)
        {
            try
            {
                if (!Contains(_DMPhauThuat_Gia.MAPT,_DMPhauThuat_Gia.MaDT ,_DMPhauThuat_Gia.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMPhauThuat_Gia.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMPhauThuat_Gia);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMPhauThuat_Gia.STT = ++_count;
                        this.Add(_DMPhauThuat_Gia);
                    }
                    else
                    {
                        _DMPhauThuat_Gia.STT = 1;
                        this.Add(_DMPhauThuat_Gia);

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
       
        
        public void UpdatedTo(DMPhauThuat_Gia _DMPhauThuat_Gia)
        {

            _DMPhauThuat_Gia.STT = this.Items[this.IndexOf(_DMPhauThuat_Gia)].STT;
            this.Items[this.IndexOf(_DMPhauThuat_Gia)] = _DMPhauThuat_Gia;
        }
        public void RemoveTo(DMPhauThuat_Gia _DMPhauThuat_Gia)
        {
            this.Items.Remove(_DMPhauThuat_Gia);

        }
        public DMPhauThuat_Gia  AssignTo(DMPhauThuat_Gia  _DMPhauThuat_Gia)//add mot hang PhieuNhap_C
        {
            if (!Contains(_DMPhauThuat_Gia.MAPT, _DMPhauThuat_Gia.MaDT, _DMPhauThuat_Gia.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMPhauThuat_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _DMPhauThuat_Gia.STT = ++_count;
                    this.Add(_DMPhauThuat_Gia);
                }
                else
                {
                    _DMPhauThuat_Gia.STT = 1;
                    //_DMPhauThuat_VT.HanSDD = _DMPhauThuat_VT.HanSD;
                    this.Add(_DMPhauThuat_Gia);
                }
            }
            //Add(_PhieuNhap_C);
            return _DMPhauThuat_Gia;
        }
        public bool Contains(string MaPT,string MaDT,bool Huy)
        {
            foreach (DMPhauThuat_Gia  obj in this)
                if ((obj.MAPT == MaPT )&&(obj.MaDT ==MaDT )&&(obj.Huy ==Huy ))
                    return true;
            return false;
        }
        public DMPhauThuat_Gia  GetDMPhauThuat_GiaById(string madt, decimal stt)
        {
            foreach (DMPhauThuat_Gia  item in this)
                if ((item.MaDT  == madt ) &&  (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMPhauThuat_Gia  item in this)
            {
                if ((item.MaDT  == madt ) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            DMPhauThuat_Gia  item = DMPhauThuat_Gia.NewDMPhauThuat_Gia();
            Add(item);
            return item;
        }

        public static DMPhauThuat_GiaList  GetAllDMPhauThuat_Gia(String madt, String  DK)
        {
            return DataPortal.Fetch<DMPhauThuat_GiaList >(new Criteria(madt, DK ));
        }
        private DMPhauThuat_GiaList()
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
        private class Criteria
        {
            private String  _MaDT;
            private Boolean _qadmin = false ;
            private String _DK;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            public Criteria(String mMaDT, String DK)
            {
                _MaDT = mMaDT;
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _DK = DK;
                
            }
        }
        private class OtherCriteria
        {
            private String _MaDT;
             private Boolean _qadmin = false ;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
            public OtherCriteria(byte mIdFind,string mDK, String mMaDT)
            {
                _MaDT = mMaDT;
               
                if (mIdFind == 1)
                    _DK = " and (b.MaPT like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(b.TenPT)) like N'" + mDK + "%'";
               

            }
        }
        private class CriteriaFilter
        {
            private String _MaDT;
             private Boolean _qadmin = false ;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
               private string _DKFilter;
            public string DKFilter
            {
                get
                {
                    return _DKFilter;
                }
            }
            public CriteriaFilter(byte mIdFind, string mDK, string mDKFilter, String mMaDT)
            {
                _MaDT = mMaDT;

                //if (mIdFind == 1)
                //    _DK = " and (b.MaPT like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                //else if (mIdFind == 2)
                //    _DK = " and ltrim(rtrim(b.TenPT)) like N'" + mDK + "%'";
                _DK =mDK;
                _DKFilter = mDKFilter;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMPhauThuat_Gia(criteria.MaDT, criteria.qadmin, criteria.DK  )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMPhauThuat_Gia .GetDMPhauThuat_Gia(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMPhauThuat_Gia(criteria.DK ,  criteria.MaDT, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMPhauThuat_Gia.GetDMPhauThuat_Gia(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMPhauThuat_GiaFilter(criteria.DK, criteria.DKFilter, criteria.MaDT, criteria.qadmin)))
            {
                int i = 1;
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                while (dr.Read())
                {
                    this.Add(DMPhauThuat_Gia.GetDMPhauThuat_Gia(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMPhauThuat_Gia  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMPhauThuat_Gia  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMPhauThuat_GiaList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMPhauThuat_GiaList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
