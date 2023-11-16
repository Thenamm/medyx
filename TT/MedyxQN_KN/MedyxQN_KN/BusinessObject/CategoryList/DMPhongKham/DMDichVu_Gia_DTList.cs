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

    public class DMDichVu_Gia_DTList : BusinessListBase<DMDichVu_Gia_DTList, DMDichVu_Gia_DT>
    {
        #region Factory Methods
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByTen(string TenDV, string madt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new OtherCriteria(2, TenDV, madt));
        }
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByDK(string DK, string madt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new OtherCriteria(10, DK, madt));
        }
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByTenD(string TenDV, string madt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new OtherCriteria(3, TenDV, madt));
        }
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByMa(string MaDV, string madt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new OtherCriteria(1, MaDV, madt));
        }
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByMaPK(string MaDV, string madt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new OtherCriteria(5, MaDV, madt));
        }
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByMaNT(string MaDV, string madt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new OtherCriteria(6, MaDV, madt));
        }
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByTenNT(string TenDV, string madt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new OtherCriteria(7, TenDV, madt));
        }
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByPhong(string MaPhong, string madt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new OtherCriteria(4, MaPhong, madt));
        }
      
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByTen(string TenDV, string madt, string noitt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new CriteriaOther(2, TenDV, madt,noitt));
        }
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByTenD(string TenDV, string madt, string noitt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new CriteriaOther(3, TenDV, madt, noitt));
        }
        public static DMDichVu_Gia_DTList FindDMDichVu_Gia_DTByMa(string MaDV, string madt, string noitt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new CriteriaOther(1, MaDV, madt, noitt));
        }
       
        public DMDichVu_Gia_DT NewTo()
        {
            DMDichVu_Gia_DT obj = DMDichVu_Gia_DT.NewDMDichVu_Gia_DT();
            return obj;
        }
        public void NewTo(DMDichVu_Gia_DT _DMDichVu_Gia_DT)
        {
            try
            {
                if (!Contains(_DMDichVu_Gia_DT.MaDV, _DMDichVu_Gia_DT.MaDT))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMDichVu_Gia_DT.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMDichVu_Gia_DT);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMDichVu_Gia_DT.STT = ++_count;
                        this.Add(_DMDichVu_Gia_DT);
                    }
                    else
                    {
                        _DMDichVu_Gia_DT.STT = 1;
                        this.Add(_DMDichVu_Gia_DT);

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

        //public void UpdatedTo(DMDichVu_Gia_DT _DMDichVu_Gia_DT)
        //{

        //    _DMDichVu_Gia_DT.OrderNumber = this.Items[this.IndexOf(_DMDichVu_Gia_DT)].OrderNumber;
        //    this.Items[this.IndexOf(_DMDichVu_Gia_DT)] = _DMDichVu_Gia_DT;
        //}
        public void UpdatedTo(DMDichVu_Gia_DT _DMDichVu_Gia_DT)
        {

            _DMDichVu_Gia_DT.STT = this.Items[this.IndexOf(_DMDichVu_Gia_DT)].STT;
            this.Items[this.IndexOf(_DMDichVu_Gia_DT)] = _DMDichVu_Gia_DT;
        }
        public void RemoveTo(DMDichVu_Gia_DT _DMDichVu_Gia_DT)
        {
            this.Items.Remove(_DMDichVu_Gia_DT);

        }
        public DMDichVu_Gia_DT AssignTo(DMDichVu_Gia_DT _DMDichVu_Gia_DT)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMDichVu_Gia_DT.STT = ++_count;
                this.Add(_DMDichVu_Gia_DT);
            }
            else
            {
                _DMDichVu_Gia_DT.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMDichVu_Gia_DT);
            }
            //Add(_PhieuNhap_C);
            return _DMDichVu_Gia_DT;
        }
        public bool Contains(string MaDV, string MaDT)
        {
            foreach (DMDichVu_Gia_DT obj in this)
                if ((obj.MaDV == MaDV) && (obj.MaDT == MaDT) )
                    return true;
            return false;
        }
        public DMDichVu_Gia_DT GetDMDichVu_Gia_DTById(string madt, decimal stt)
        {
            foreach (DMDichVu_Gia_DT item in this)
                if ((item.MaDT == madt) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMDichVu_Gia_DT item in this)
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
            DMDichVu_Gia_DT item = DMDichVu_Gia_DT.NewDMDichVu_Gia_DT();
            Add(item);
            return item;
        }

        public static DMDichVu_Gia_DTList GetAllDMDichVu_Gia_DT(String madt)
        {
            return DataPortal.Fetch<DMDichVu_Gia_DTList>(new Criteria(madt));
        }
        private DMDichVu_Gia_DTList()
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

                if (mIdFind == 1) //
                    _DK = " and (b.MADV like '" + mDK + "%' OR b.TENTAT LIKE N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(b.TenDV)) like N'" + mDK + "%'";
                else if (mIdFind == 3)
                    _DK = " and ltrim(rtrim(b.TenDV)) like N'" + mDK + "'";
                else if (mIdFind == 4) //
                    _DK = " and (b.MAkhoa = '" + mDK + "')";
                else if (mIdFind == 5) //
                   _DK = " and (b.MADV like '" + mDK + "%' OR b.TENTAT LIKE N'" + mDK + "%') and (isnull(b.apdungpk,0)=1 or isnull(b.apdungnk,0)=1)";
                   // _DK = " and (b.MADV like '" + mDK + "%' OR b.TENTAT LIKE N'" + mDK + "%' or ltrim(rtrim(b.TenDV)) like N'%" + mDK + "%') and (isnull(b.apdungpk,0)=1 or isnull(b.apdungnk,0)=1)";
                else if (mIdFind == 6) //
                    _DK = " and (b.MADV like '" + mDK + "%' OR b.TENTAT LIKE N'" + mDK + "%') and isnull(b.apdungnt,0)=1"; 
                   //   _DK = " and (b.MADV like '" + mDK + "%' OR b.TENTAT LIKE N'" + mDK + "%' or ltrim(rtrim(b.TenDV)) like N'%" + mDK + "%') and isnull(b.apdungnt,0)=1";
                else if (mIdFind == 10)
                    _DK = mDK +" and (isnull(b.apdungpk,0)=1 or isnull(b.apdungnk,0)=1)";
            }
        }
        private class CriteriaOther
        {
            private String _MaDT;
             private String _noitt;
             private Boolean _qadmin = false ;
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
             public String noitt
            {
                get
                {
                    return _noitt;
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
            public CriteriaOther(byte mIdFind, string mDK, String mMaDT,string mnoitt)
            {
                _MaDT = mMaDT;
                _noitt = mnoitt;
                if (mIdFind == 1) //
                    _DK = " and (b.MADV like '" + mDK + "%' OR b.TENTAT LIKE N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(b.TenDV)) like N'" + mDK + "%'";
                else if (mIdFind == 3)
                    _DK = " and ltrim(rtrim(b.TenDV)) like N'" + mDK + "'";
                else if (mIdFind == 4) //
                    _DK = " and (b.MAkhoa = '" + mDK + "')";

            }
        }
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_Gia_DT(criteria.MaDT, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMDichVu_Gia_DT.GetDMDichVu_Gia_DT(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_Gia_DT(criteria.DK, criteria.MaDT, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMDichVu_Gia_DT.GetDMDichVu_Gia_DT(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_Gia_DT(criteria.DK, criteria.MaDT, criteria.qadmin,criteria.noitt )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMDichVu_Gia_DT.GetDMDichVu_Gia_DT(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMDichVu_Gia_DT item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMDichVu_Gia_DT item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMDichVu_Gia_DTList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMDichVu_Gia_DTList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
