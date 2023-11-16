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

    public class DMGiuong_GiaList : BusinessListBase<DMGiuong_GiaList, DMGiuong_Gia>
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
        public static DMGiuong_GiaList NewList()
        {
            return DataPortal.Fetch<DMGiuong_GiaList>(new TemCriteria());
        }
        public static DMGiuong_GiaList FindDMGiuong_GiaByTen(string TenGiuong,string madt)
        {
            return DataPortal.Fetch<DMGiuong_GiaList>(new OtherCriteria(2, TenGiuong,madt));
        }
        public static DMGiuong_GiaList FindDMGiuong_GiaByMa(string MaGiuong,string madt)
        {
            return DataPortal.Fetch<DMGiuong_GiaList>(new OtherCriteria(1, MaGiuong,madt));
        }
        public static DMGiuong_GiaList FindDMGiuong_GiaByTen(string TenGiuong, string madt,string makhoa)
        {
            return DataPortal.Fetch<DMGiuong_GiaList>(new CriteriaOther(2, TenGiuong, madt, makhoa));
        }
        public static DMGiuong_GiaList FindDMGiuong_GiaByMa(string MaGiuong, string madt, string makhoa)
        {
            return DataPortal.Fetch<DMGiuong_GiaList>(new CriteriaOther(1, MaGiuong, madt,makhoa));
        }
        public static DMGiuong_GiaList FindDMGiuong_GiaByFilter(string dk, string sql, string madt)
        {
            return DataPortal.Fetch<DMGiuong_GiaList>(new CriteriaFilter(1, dk, sql, madt));
        }
        public DMGiuong_Gia NewTo() 
        {
            DMGiuong_Gia obj = DMGiuong_Gia.NewDMGiuong_Gia();
            return obj;
        }
        public void NewTo(DMGiuong_Gia _DMGiuong_Gia)
        {
            try
            {
                if (!Contains(_DMGiuong_Gia.MaGiuong,_DMGiuong_Gia.MaDT ,_DMGiuong_Gia.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMGiuong_Gia.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMGiuong_Gia);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMGiuong_Gia.STT = ++_count;
                        this.Add(_DMGiuong_Gia);
                    }
                    else
                    {
                        _DMGiuong_Gia.STT = 1;
                        this.Add(_DMGiuong_Gia);

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
       
    
        public void UpdatedTo(DMGiuong_Gia _DMGiuong_Gia)
        {

            _DMGiuong_Gia.STT = this.Items[this.IndexOf(_DMGiuong_Gia)].STT;
            this.Items[this.IndexOf(_DMGiuong_Gia)] = _DMGiuong_Gia;
        }
        public void RemoveTo(DMGiuong_Gia _DMGiuong_Gia)
        {
            this.Items.Remove(_DMGiuong_Gia);

        }
        public DMGiuong_Gia  AssignTo(DMGiuong_Gia  _DMGiuong_Gia)//add mot hang PhieuNhap_C
        {
            if (!Contains(_DMGiuong_Gia.MaGiuong, _DMGiuong_Gia.MaDT, _DMGiuong_Gia.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _DMGiuong_Gia.STT = ++_count;
                    this.Add(_DMGiuong_Gia);
                }
                else
                {
                    _DMGiuong_Gia.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_DMGiuong_Gia);
                }
            }
            //Add(_PhieuNhap_C);
            return _DMGiuong_Gia;
        }
        public bool Contains(string MaGiuong,string MaDT,bool Huy)
        {
            foreach (DMGiuong_Gia  obj in this)
                if ((obj.MaGiuong == MaGiuong )&&(obj.MaDT ==MaDT )&&(obj.Huy ==Huy ))
                    return true;
            return false;
        }
        public DMGiuong_Gia  GetDMGiuong_GiaById(string madt, decimal stt)
        {
            foreach (DMGiuong_Gia  item in this)
                if ((item.MaDT  == madt ) &&  (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMGiuong_Gia  item in this)
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
            DMGiuong_Gia  item = DMGiuong_Gia .NewDMGiuong_Gia();
            Add(item);
            return item;
        }

        public static DMGiuong_GiaList GetAllDMGiuong_Gia(String madt , String DK)
        {
            return DataPortal.Fetch<DMGiuong_GiaList >(new Criteria(madt, DK ));
        }
        private DMGiuong_GiaList()
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
                    _DK = " and (b.MaGiuong like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(b.TenGiuong)) like N'" + mDK + "%'";
               

            }
        }

        private class CriteriaOther
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
            private String _Makhoa;
            public String Makhoa
            {
                get
                {
                    return _Makhoa;
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
            public CriteriaOther(byte mIdFind, string mDK, String mMaDT, String makhoa)
            {
                _MaDT = mMaDT;

                if (mIdFind == 1)
                    _DK = " and (b.MaGiuong like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(b.TenGiuong)) like N'" + mDK + "%'";
                _Makhoa = makhoa;

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
            public CriteriaFilter(byte mIdFind, string mDK, string mDKfilter, String mMaDT)
            {
                _MaDT = mMaDT;

                //if (mIdFind == 1)
                //    _DK = " and (b.MaGiuong like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                //else if (mIdFind == 2)
                //    _DK = " and ltrim(rtrim(b.TenGiuong)) like N'" + mDK + "%'";
                _DK = mDK;
                _DKFilter = mDKfilter;

            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMGiuong_Gia (criteria.MaDT, criteria.qadmin, criteria .DK )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMGiuong_Gia .GetDMGiuong_Gia(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMGiuong_Gia(criteria.DK ,  criteria.MaDT, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMGiuong_Gia.GetDMGiuong_Gia(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMGiuong_Gia(criteria.DK, criteria.MaDT, criteria.Makhoa, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMGiuong_Gia.GetDMGiuong_Gia(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMGiuong_GiaFilter(criteria.DK, criteria.DKFilter, criteria.MaDT, criteria.qadmin)))
            {
                int i = 1;
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                while (dr.Read())
                {
                    this.Add(DMGiuong_Gia.GetDMGiuong_Gia(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMGiuong_Gia  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMGiuong_Gia  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMGiuong_GiaList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMGiuong_GiaList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
