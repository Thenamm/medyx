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

    public class DMDichVu_GiaList : BusinessListBase<DMDichVu_GiaList, DMDichVu_Gia>
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
        public static DMDichVu_GiaList NewList()
        {
            return DataPortal.Fetch<DMDichVu_GiaList>(new TemCriteria());
        }
        public static DMDichVu_GiaList FindDMDichVu_GiaByTen(string TenDV,string madt)
        {
            return DataPortal.Fetch<DMDichVu_GiaList>(new OtherCriteria(2, TenDV,madt));
        }
        public static DMDichVu_GiaList FindDMDichVu_GiaByMa(string MaDV,string madt)
        {
            return DataPortal.Fetch<DMDichVu_GiaList>(new OtherCriteria(1, MaDV,madt));
        }
        public static DMDichVu_GiaList FindDMDichVu_GiaByFilter(string dk, string sql, string madt)
        {
            return DataPortal.Fetch<DMDichVu_GiaList>(new CriteriaFilter(3, dk,sql, madt));
        }
        public DMDichVu_Gia NewTo() {
            DMDichVu_Gia obj = DMDichVu_Gia.NewDMDichVu_Gia();
            return obj;
        }
        public void NewTo(DMDichVu_Gia _DMDichVu_Gia)
        {
            try
            {
                if (!Contains(_DMDichVu_Gia.MaDV,_DMDichVu_Gia.MaDT ,_DMDichVu_Gia.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMDichVu_Gia.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMDichVu_Gia);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMDichVu_Gia.STT = ++_count;
                        
                        this.Add(_DMDichVu_Gia);
                    }
                    else
                    {
                        _DMDichVu_Gia.STT = 1;
                       
                        this.Add(_DMDichVu_Gia);

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
       
      
        public void UpdatedTo(DMDichVu_Gia _DMDichVu_Gia)
        {

            _DMDichVu_Gia.STT = this.Items[this.IndexOf(_DMDichVu_Gia)].STT;
            this.Items[this.IndexOf(_DMDichVu_Gia)] = _DMDichVu_Gia;
        }
        public DMDichVu_Gia GetTo(decimal STT) //
        {
            foreach (DMDichVu_Gia obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        //public void RemoveTo(DMDichVu_Gia _DMDichVu_Gia)
        //{
        //    this.Items.Remove(_DMDichVu_Gia);

        //}
        public DMDichVu_Gia  AssignTo(DMDichVu_Gia  _DMDichVu_Gia)//add mot hang PhieuNhap_C
        {
            if (!Contains(_DMDichVu_Gia.MaDV, _DMDichVu_Gia.MaDT, _DMDichVu_Gia.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _DMDichVu_Gia.STT = ++_count;
                    this.Add(_DMDichVu_Gia);
                }
                else
                {
                    _DMDichVu_Gia.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_DMDichVu_Gia);
                }
            }
            //Add(_PhieuNhap_C);
            return _DMDichVu_Gia;
        }
        public bool Contains(string MaDV,string MaDT,bool Huy)
        {
            foreach (DMDichVu_Gia  obj in this)
                if ((obj.MaDV == MaDV )&&(obj.MaDT ==MaDT )&&(obj.Huy ==Huy ))
                    return true;
            return false;
        }
        public DMDichVu_Gia  GetDMDichVu_GiaById(string madt, decimal stt)
        {
            foreach (DMDichVu_Gia  item in this)
                if ((item.MaDT  == madt ) &&  (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMDichVu_Gia item in this)
            {
                if ((item.MaDT == madt) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(DMDichVu_Gia obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        protected override object AddNewCore()
        {
            DMDichVu_Gia  item = DMDichVu_Gia .NewDMDichVu_Gia();
            Add(item);
            return item;
        }

        public static DMDichVu_GiaList  GetAllDMDichVu_Gia(String madt, String DK)
        {
            return DataPortal.Fetch<DMDichVu_GiaList >(new Criteria(madt, DK ));
        }
        private DMDichVu_GiaList()
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
        private class Criteria
        {
            private String  _MaDT;
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
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK; 
                }
            }
            public Criteria(String mMaDT, String Dk)
            {
                _MaDT = mMaDT;
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _DK = Dk;
                
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
                    _DK = " and (A.MADV like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(b.TenDV)) like N'" + mDK + "%'";
               

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
                //    _DK = " and (b.MADV like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                //else if (mIdFind == 2)
                //    _DK = " and ltrim(rtrim(b.TenDV)) like N'" + mDK + "%'";

                //else
                //    _DK = mDK;
                _DK = mDK;
                _DKFilter = mDKFilter;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_Gia (criteria.MaDT, criteria.qadmin, criteria.DK )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMDichVu_Gia .GetDMDichVu_Gia(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_Gia(criteria.DK, criteria.MaDT, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMDichVu_Gia.GetDMDichVu_Gia(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_GiaFilter(criteria.DK, criteria.DKFilter, criteria.MaDT, criteria.qadmin)))
            {
                int i = 1;
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                while (dr.Read())
                {
                    this.Add(DMDichVu_Gia.GetDMDichVu_Gia(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMDichVu_Gia  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMDichVu_Gia  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMDichVu_GiaList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMDichVu_GiaList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
