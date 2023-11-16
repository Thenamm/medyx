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

    public class DMDichVu_NhomList : BusinessListBase<DMDichVu_NhomList, DMDichVu_Nhom>
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
        public static DMDichVu_NhomList NewList()
        {
            return DataPortal.Fetch<DMDichVu_NhomList>(new TemCriteria());
        }
        public static DMDichVu_NhomList FindDMDichVu_NhomByTen(string TenDV,string MaNhom)
        {
            return DataPortal.Fetch<DMDichVu_NhomList>(new OtherCriteria(2, TenDV,MaNhom));
        }
        public static DMDichVu_NhomList FindDMDichVu_NhomByMa(string MaDV,string MaNhom)
        {
            return DataPortal.Fetch<DMDichVu_NhomList>(new OtherCriteria(1, MaDV,MaNhom));
        }
        public static DMDichVu_NhomList FindDMDichVu_NhomByFilter(string dk, string sql, string MaNhom)
        {
            return DataPortal.Fetch<DMDichVu_NhomList>(new CriteriaFilter(3, dk,sql, MaNhom));
        }
        public DMDichVu_Nhom NewTo() {
            DMDichVu_Nhom obj = DMDichVu_Nhom.NewDMDichVu_Nhom();
            return obj;
        }
        public void NewTo(DMDichVu_Nhom _DMDichVu_Nhom)
        {
            try
            {
                if (!Contains(_DMDichVu_Nhom.MaDV,_DMDichVu_Nhom.MaNhom ,_DMDichVu_Nhom.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMDichVu_Nhom.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMDichVu_Nhom);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMDichVu_Nhom.OrderNumber = ++_count;
                        
                        this.Add(_DMDichVu_Nhom);
                    }
                    else
                    {
                        _DMDichVu_Nhom.OrderNumber = 1;
                       
                        this.Add(_DMDichVu_Nhom);

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
       
      
        public void UpdatedTo(DMDichVu_Nhom _DMDichVu_Nhom)
        {

            _DMDichVu_Nhom.OrderNumber = this.Items[this.IndexOf(_DMDichVu_Nhom)].OrderNumber;
            this.Items[this.IndexOf(_DMDichVu_Nhom)] = _DMDichVu_Nhom;
        }
        public DMDichVu_Nhom GetTo(decimal OrderNumber) //
        {
            foreach (DMDichVu_Nhom obj in this)
                if (obj.OrderNumber == OrderNumber)
                    return obj;
            return null;

        }
        //public void RemoveTo(DMDichVu_Nhom _DMDichVu_Nhom)
        //{
        //    this.Items.Remove(_DMDichVu_Nhom);

        //}
        public DMDichVu_Nhom  AssignTo(DMDichVu_Nhom  _DMDichVu_Nhom)//add mot hang PhieuNhap_C
        {
            if (!Contains(_DMDichVu_Nhom.MaDV, _DMDichVu_Nhom.MaNhom, _DMDichVu_Nhom.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _DMDichVu_Nhom.OrderNumber = ++_count;
                    this.Add(_DMDichVu_Nhom);
                }
                else
                {
                    _DMDichVu_Nhom.OrderNumber = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_DMDichVu_Nhom);
                }
            }
            //Add(_PhieuNhap_C);
            return _DMDichVu_Nhom;
        }
        public bool Contains(string MaDV,string MaNhom,bool Huy)
        {
            foreach (DMDichVu_Nhom  obj in this)
                if ((obj.MaDV == MaDV )&&(obj.MaNhom ==MaNhom )&&(obj.Huy ==Huy ))
                    return true;
            return false;
        }
        public DMDichVu_Nhom  GetDMDichVu_NhomById(string MaNhom, decimal stt)
        {
            foreach (DMDichVu_Nhom  item in this)
                if ((item.MaNhom  == MaNhom ) &&  (item.OrderNumber == stt))
                    return item;
            return null;
        }
        public void Remove(string MaNhom, int stt)
        {
            foreach (DMDichVu_Nhom item in this)
            {
                if ((item.MaNhom == MaNhom) && (item.OrderNumber == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(DMDichVu_Nhom obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        protected override object AddNewCore()
        {
            DMDichVu_Nhom  item = DMDichVu_Nhom .NewDMDichVu_Nhom();
            Add(item);
            return item;
        }

        public static DMDichVu_NhomList  GetAllDMDichVu_Nhom(String MaNhom, String DK)
        {
            return DataPortal.Fetch<DMDichVu_NhomList >(new Criteria(MaNhom, DK ));
        }
        private DMDichVu_NhomList()
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
            private String  _MaNhom;
            private Boolean _qadmin = false ;
            public String MaNhom
            {
                get
                {
                    return _MaNhom;
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
            public Criteria(String mMaNhom, String Dk)
            {
                _MaNhom = mMaNhom;
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _DK = Dk;
                
            }
        }
        private class OtherCriteria
        {
            private String _MaNhom;
             private Boolean _qadmin = false ;
            public String MaNhom
            {
                get
                {
                    return _MaNhom;
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
            public OtherCriteria(byte mIdFind,string mDK, String mMaNhom)
            {
                _MaNhom = mMaNhom;
               
                if (mIdFind == 1)
                    _DK = " and (A.MADV like '%" + mDK + "' OR b.TENTAT LIKE N'" + mDK + "%')";
                else if (mIdFind == 2)
                    _DK = " and ltrim(rtrim(b.TenDV)) like N'" + mDK + "%'";
               

            }
        }
        private class CriteriaFilter
        {
            private String _MaNhom;
             private Boolean _qadmin = false ;
            public String MaNhom
            {
                get
                {
                    return _MaNhom;
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
            public CriteriaFilter(byte mIdFind, string mDK, string mDKFilter, String mMaNhom)
            {
                _MaNhom = mMaNhom;

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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_Nhom (criteria.MaNhom, criteria.qadmin, criteria.DK )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMDichVu_Nhom .GetDMDichVu_Nhom(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_Nhom(criteria.DK, criteria.MaNhom, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(DMDichVu_Nhom.GetDMDichVu_Nhom(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaFilter criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_NhomFilter(criteria.DK, criteria.DKFilter, criteria.MaNhom, criteria.qadmin)))
            {
                int i = 1;
                if (dr.Read())
                {
                    _record = dr.GetInt32("record");
                }
                if (dr.NextResult())
                while (dr.Read())
                {
                    this.Add(DMDichVu_Nhom.GetDMDichVu_Nhom(dr, i));
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
            foreach (DMDichVu_Nhom  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMDichVu_Nhom  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMDichVu_NhomList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMDichVu_NhomList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
