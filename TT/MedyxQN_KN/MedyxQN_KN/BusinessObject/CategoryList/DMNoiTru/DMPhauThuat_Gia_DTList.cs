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

    public class DMPhauThuat_Gia_DTList : BusinessListBase<DMPhauThuat_Gia_DTList, DMPhauThuat_Gia_DT>
    {
        #region Factory Methods
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByTenPT(string TenPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(2, TenPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByTenPTD(string TenPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(3, TenPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByMaPT(string MaPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(1, MaPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByMa(string MaPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(13, MaPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByTen(string MaPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(14, MaPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByTenD(string MaPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(15, MaPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByGoiTenPT(string TenPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(5, TenPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByGoiTenPTD(string TenPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(6, TenPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByGoiMaPT(string MaPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(4, MaPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByTenTT(string TenPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(8, TenPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByTenTTD(string TenPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(9, TenPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByMaTT(string MaPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(7, MaPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByGoiTenTT(string TenPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(11, TenPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByGoiTenTTD(string TenPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(12, TenPT, madt));
        }
        public static DMPhauThuat_Gia_DTList FindDMPhauThuat_Gia_DTByGoiMaTT(string MaPT, string madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new OtherCriteria(10, MaPT, madt));
        }
        public DMPhauThuat_Gia_DT NewTo()
        {
            DMPhauThuat_Gia_DT obj = DMPhauThuat_Gia_DT.NewDMPhauThuat_Gia_DT();
            return obj;
        }
        public void NewTo(DMPhauThuat_Gia_DT _DMPhauThuat_Gia_DT)
        {
            try
            {
                if (!Contains(_DMPhauThuat_Gia_DT.MaPT, _DMPhauThuat_Gia_DT.MaDT))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMPhauThuat_Gia_DT.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMPhauThuat_Gia_DT);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMPhauThuat_Gia_DT.STT = ++_count;
                        this.Add(_DMPhauThuat_Gia_DT);
                    }
                    else
                    {
                        _DMPhauThuat_Gia_DT.STT = 1;
                        this.Add(_DMPhauThuat_Gia_DT);

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

        //public void UpdatedTo(DMPhauThuat_Gia_DT _DMPhauThuat_Gia_DT)
        //{

        //    _DMPhauThuat_Gia_DT.OrderNumber = this.Items[this.IndexOf(_DMPhauThuat_Gia_DT)].OrderNumber;
        //    this.Items[this.IndexOf(_DMPhauThuat_Gia_DT)] = _DMPhauThuat_Gia_DT;
        //}
        public void UpdatedTo(DMPhauThuat_Gia_DT _DMPhauThuat_Gia_DT)
        {

            _DMPhauThuat_Gia_DT.STT = this.Items[this.IndexOf(_DMPhauThuat_Gia_DT)].STT;
            this.Items[this.IndexOf(_DMPhauThuat_Gia_DT)] = _DMPhauThuat_Gia_DT;
        }
        public void RemoveTo(DMPhauThuat_Gia_DT _DMPhauThuat_Gia_DT)
        {
            this.Items.Remove(_DMPhauThuat_Gia_DT);

        }
        public DMPhauThuat_Gia_DT AssignTo(DMPhauThuat_Gia_DT _DMPhauThuat_Gia_DT)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMPhauThuat_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMPhauThuat_Gia_DT.STT = ++_count;
                this.Add(_DMPhauThuat_Gia_DT);
            }
            else
            {
                _DMPhauThuat_Gia_DT.STT = 1;
                //_DMPhauThuat_VT.HanSDD = _DMPhauThuat_VT.HanSD;
                this.Add(_DMPhauThuat_Gia_DT);
            }
            //Add(_PhieuNhap_C);
            return _DMPhauThuat_Gia_DT;
        }
        public bool Contains(string MaPT, string MaDT)
        {
            foreach (DMPhauThuat_Gia_DT obj in this)
                if ((obj.MaPT == MaPT) && (obj.MaDT == MaDT) )
                    return true;
            return false;
        }
        public DMPhauThuat_Gia_DT GetDMPhauThuat_Gia_DTById(string madt, decimal stt)
        {
            foreach (DMPhauThuat_Gia_DT item in this)
                if ((item.MaDT == madt) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMPhauThuat_Gia_DT item in this)
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
            DMPhauThuat_Gia_DT item = DMPhauThuat_Gia_DT.NewDMPhauThuat_Gia_DT();
            Add(item);
            return item;
        }

        public static DMPhauThuat_Gia_DTList GetAllDMPhauThuat_Gia_DT(String madt)
        {
            return DataPortal.Fetch<DMPhauThuat_Gia_DTList>(new Criteria(madt));
        }
        private DMPhauThuat_Gia_DTList()
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
            public Criteria(String mMaDT)
            {
                _MaDT = mMaDT;

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
            public OtherCriteria(byte mIdFind, string mDK, String mMaDT)
            {
                _MaDT = mMaDT;
                if (mIdFind == 13)
                    _DK = " and (b.MAPT like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                else if (mIdFind == 14)
                    _DK = " and ltrim(rtrim(b.TenPT)) like N'" + mDK + "%'";
                else if (mIdFind == 15)
                    _DK = " and ltrim(rtrim(b.TenPT)) like N'" + mDK + "'";
                else
                {
                    if ((mIdFind == 1) || (mIdFind == 7))
                        _DK = " and (b.MAPT like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                    else if ((mIdFind == 2) || (mIdFind == 8))
                        _DK = " and ltrim(rtrim(b.TenPT)) like N'" + mDK + "%'";
                    else if ((mIdFind == 3) || (mIdFind == 9))
                        _DK = " and ltrim(rtrim(b.TenPT)) like N'" + mDK + "'";
                    if ((mIdFind == 4) || (mIdFind == 10))
                        _DK = " and (b.MAPT like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%') and isnull(b.goidichvu,0) = 1 ";
                    else if ((mIdFind == 5) || (mIdFind == 11))
                        _DK = " and ltrim(rtrim(b.TenPT)) like N'" + mDK + "%' and isnull(b.goidichvu,0) = 1 ";
                    else if ((mIdFind == 6) || (mIdFind == 12))
                        _DK = " and ltrim(rtrim(b.TenPT)) like N'" + mDK + "' and isnull(b.goidichvu,0) = 1 ";
                   
                    if (mIdFind <= 6) 
                        _DK = _DK + " and b.machungloai ='00011'";
                    else if (mIdFind >=7)
                        _DK = _DK + " and b.machungloai ='00012'";
                }
            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMPhauThuat_Gia_DT(criteria.MaDT, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMPhauThuat_Gia_DT.GetDMPhauThuat_Gia_DT(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMPhauThuat_Gia_DT(criteria.DK, criteria.MaDT, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMPhauThuat_Gia_DT.GetDMPhauThuat_Gia_DT(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMPhauThuat_Gia_DT item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMPhauThuat_Gia_DT item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMPhauThuat_Gia_DTList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMPhauThuat_Gia_DTList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
