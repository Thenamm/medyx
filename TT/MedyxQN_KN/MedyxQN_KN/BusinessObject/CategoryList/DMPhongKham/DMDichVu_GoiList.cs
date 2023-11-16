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

    public class DMDichVu_GoiList : BusinessListBase<DMDichVu_GoiList, DMDichVu_Goi>
    {
        #region Factory Methods
        public static DMDichVu_GoiList FindDMDichVu_GoiByTen(string TenDV,string madvgoi)
        {
            return DataPortal.Fetch<DMDichVu_GoiList>(new OtherCriteria(2, TenDV,madvgoi));
        }
        public static DMDichVu_GoiList FindDMDichVu_GoiByMa(string MaDV,string madvgoi)
        {
            return DataPortal.Fetch<DMDichVu_GoiList>(new OtherCriteria(1, MaDV,madvgoi));
        }
        public DMDichVu_Goi NewTo() 
        {
            DMDichVu_Goi obj = DMDichVu_Goi.NewDMDichVu_Goi();
            return obj;
        }
        public void NewTo(DMDichVu_Goi _DMDichVu_Goi)
        {
            try
            {
                
                    if (this.Items.Count > 0)
                    {
                        //_DMDichVu_Goi.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMDichVu_Goi);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMDichVu_Goi.STT = ++_count;
                        this.Add(_DMDichVu_Goi);
                    }
                    else
                    {
                        _DMDichVu_Goi.STT = 1;
                        this.Add(_DMDichVu_Goi);

                    }
                
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
       
      
        public void UpdatedTo(DMDichVu_Goi _DMDichVu_Goi)
        {

            _DMDichVu_Goi.STT = this.Items[this.IndexOf(_DMDichVu_Goi)].STT;
            this.Items[this.IndexOf(_DMDichVu_Goi)] = _DMDichVu_Goi;
        }
        public DMDichVu_Goi GetTo(decimal STT) //
        {
            foreach (DMDichVu_Goi obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        //public void RemoveTo(DMDichVu_Goi _DMDichVu_Goi)
        //{
        //    this.Items.Remove(_DMDichVu_Goi);

        //}
        public DMDichVu_Goi  AssignTo(DMDichVu_Goi  _DMDichVu_Goi)//add mot hang PhieuNhap_C
        {
            //if (!Contains(_DMDichVu_Goi.MaDV, _DMDichVu_Goi.MaDVGoi, _DMDichVu_Goi.Huy))
            //{
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _DMDichVu_Goi.STT = ++_count;
                    this.Add(_DMDichVu_Goi);
                }
                else
                {
                    _DMDichVu_Goi.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_DMDichVu_Goi);
                }
            //}
            //Add(_PhieuNhap_C);
            return _DMDichVu_Goi;
        }
        public bool Contains(string MaDV,string madvgoi,bool Huy)
        {
            foreach (DMDichVu_Goi  obj in this)
                if ((obj.MaDV == MaDV) && (obj.MaDVGoi == madvgoi) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public DMDichVu_Goi  GetDMDichVu_GoiById(string madvgoi, decimal stt)
        {
            foreach (DMDichVu_Goi  item in this)
                if ((item.MaDVGoi  == madvgoi ) &&  (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madvgoi, int stt)
        {
            foreach (DMDichVu_Goi item in this)
            {
                if ((item.MaDVGoi == madvgoi) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(DMDichVu_Goi obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        protected override object AddNewCore()
        {
            DMDichVu_Goi  item = DMDichVu_Goi.NewDMDichVu_Goi();
            Add(item);
            return item;
        }

        public static DMDichVu_GoiList GetAllDMDichVu_Goi(String madvgoi)
        {
            return DataPortal.Fetch<DMDichVu_GoiList>(new Criteria(madvgoi));
        }
        private DMDichVu_GoiList()
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
            private String  _madvgoi;
            private Boolean _qadmin = false ;
            public String madvgoi
            {
                get
                {
                    return _madvgoi;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String mmadvgoi)
            {
                _madvgoi = mmadvgoi;
                
            }
        }
        private class OtherCriteria
        {
            private String _madvgoi;
             private Boolean _qadmin = false ;
            public String madvgoi
            {
                get
                {
                    return _madvgoi;
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
            public OtherCriteria(byte mIdFind,string mDK, String mmadvgoi)
            {
                _madvgoi = mmadvgoi;
               
                if (mIdFind == 1)
                    _DK = " and (b.MADV like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(b.TenDV)) like N'" + mDK + "%'";
               

            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_Goi(criteria.madvgoi, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMDichVu_Goi.GetDMDichVu_Goi(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_Goi(criteria.madvgoi, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMDichVu_Goi.GetDMDichVu_Goi(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMDichVu_Goi  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMDichVu_Goi  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMDichVu_GoiList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMDichVu_GoiList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
