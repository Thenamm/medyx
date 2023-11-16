using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//

namespace HTC.Business.KHTH
{
    [Serializable()]
    public class BC_KeHoachList : BusinessListBase<BC_KeHoachList, BC_KeHoach>
    {
        #region Factory Methods
        public static BC_KeHoachList GetAllBC_KeHoach(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_KeHoachList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_KeHoachList FindBC_KeHoachByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_KeHoachList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_KeHoachList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_KeHoachList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_KeHoach NewTo()
        {
            BC_KeHoach obj = BC_KeHoach.NewBC_KeHoach();
            return obj;
        }
        public void   NewTo(BC_KeHoach _BC_KeHoach)
        {
           
            try
            {
                if (!Contains(_BC_KeHoach.MaBC, _BC_KeHoach.Ma,_BC_KeHoach.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_KeHoach.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_KeHoach);
                        int _count = 0;
                        _BC_KeHoach.OrderNumber = ++_count;
                        this.Add(_BC_KeHoach);
                    }
                    else
                    {
                        _BC_KeHoach.OrderNumber = 1;
                        this.Add(_BC_KeHoach);

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
        public void UpdatedTo(BC_KeHoach _BC_KeHoach)
        {

            _BC_KeHoach.OrderNumber = this.Items[this.IndexOf(_BC_KeHoach)].OrderNumber;
            this.Items[this.IndexOf(_BC_KeHoach)] = _BC_KeHoach;
        }
        public void RemoveTo(BC_KeHoach _BC_KeHoach)
        {
            this.Items.Remove(_BC_KeHoach);

        }
        public BC_KeHoach  AssignTo(BC_KeHoach  _BC_KeHoach)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_KeHoach.OrderNumber = ++_count;
                this.Add(_BC_KeHoach);
            }
            else
            {
                _BC_KeHoach.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_KeHoach);
            }
            //Add(_PhieuNhap_C);
            return _BC_KeHoach;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_KeHoach item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaBC, string ma, bool Huy)
        {
            foreach (BC_KeHoach obj in this)
                if ((obj.MaBC == MaBC) && (obj.Ma == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_KeHoach GetBC_KeHoachById(string MaBC, string ma)
        {
            foreach (BC_KeHoach item in this)
                if ((item.MaBC == MaBC) && (item.Ma == ma))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_KeHoach  item in this)
            {
                if ((item.MaBC == MaBC)  && (item.Ma == ma))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            BC_KeHoach item = BC_KeHoach.NewBC_KeHoach();
            Add(item);
            return item;
        }

        

        private BC_KeHoachList()
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
            private String _MaBC;
            private String _DK;
            private Boolean _qadmin = false ;
            public String MaBC
            {
                get
                {
                    return _MaBC;
                }
            }
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String mMaBC, String mDK)
            {
                _MaBC  = mMaBC  ;
                _DK = mDK ;
                _qadmin = qadmin;
                
            }
        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_KeHoach(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_KeHoach.GetBC_KeHoach(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_KeHoach item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_KeHoach item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_KeHoachList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_KeHoachList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
