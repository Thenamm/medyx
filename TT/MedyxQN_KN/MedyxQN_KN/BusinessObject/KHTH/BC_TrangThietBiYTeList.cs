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
    public class BC_TrangThietBiYTeList : BusinessListBase<BC_TrangThietBiYTeList, BC_TrangThietBiYTe>
    {
        #region Factory Methods
        public static BC_TrangThietBiYTeList GetAllBC_TrangThietBiYTe(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_TrangThietBiYTeList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_TrangThietBiYTeList FindBC_TrangThietBiYTeByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_TrangThietBiYTeList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_TrangThietBiYTeList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_TrangThietBiYTeList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_TrangThietBiYTe NewTo()
        {
            BC_TrangThietBiYTe obj = BC_TrangThietBiYTe.NewBC_TrangThietBiYTe();
            return obj;
        }
        public void   NewTo(BC_TrangThietBiYTe _BC_TrangThietBiYTe)
        {
           
            try
            {
                if (!Contains(_BC_TrangThietBiYTe.MaBC, _BC_TrangThietBiYTe.MaTB ,_BC_TrangThietBiYTe.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_TrangThietBiYTe.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_TrangThietBiYTe);
                        int _count = 0;
                        _BC_TrangThietBiYTe.OrderNumber = ++_count;
                        this.Add(_BC_TrangThietBiYTe);
                    }
                    else
                    {
                        _BC_TrangThietBiYTe.OrderNumber = 1;
                        this.Add(_BC_TrangThietBiYTe);

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
        public void UpdatedTo(BC_TrangThietBiYTe _BC_TrangThietBiYTe)
        {

            _BC_TrangThietBiYTe.OrderNumber = this.Items[this.IndexOf(_BC_TrangThietBiYTe)].OrderNumber;
            this.Items[this.IndexOf(_BC_TrangThietBiYTe)] = _BC_TrangThietBiYTe;
        }
        public void RemoveTo(BC_TrangThietBiYTe _BC_TrangThietBiYTe)
        {
            this.Items.Remove(_BC_TrangThietBiYTe);

        }
        public BC_TrangThietBiYTe  AssignTo(BC_TrangThietBiYTe  _BC_TrangThietBiYTe)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_TrangThietBiYTe.OrderNumber = ++_count;
                this.Add(_BC_TrangThietBiYTe);
            }
            else
            {
                _BC_TrangThietBiYTe.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_TrangThietBiYTe);
            }
            //Add(_PhieuNhap_C);
            return _BC_TrangThietBiYTe;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_TrangThietBiYTe item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string maBC,string maTB,  bool Huy)
        {
            foreach (BC_TrangThietBiYTe obj in this)
                if ((obj.MaBC == maBC) && (obj.MaTB == maTB) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_TrangThietBiYTe GetBC_TrangThietBiYTeById(string maBC, string maTB)
        {
            foreach (BC_TrangThietBiYTe item in this)
                if ((item.MaBC == maBC) && (item.MaTB == maTB))
                    return item;
            return null;
        }
        public void Remove(string maBC, string maTB)
        {
            foreach (BC_TrangThietBiYTe  item in this)
            {
                if ((item.MaBC == maBC) && (item.MaTB == maTB))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            BC_TrangThietBiYTe item = BC_TrangThietBiYTe.NewBC_TrangThietBiYTe();
            Add(item);
            return item;
        }

        

        private BC_TrangThietBiYTeList()
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
                _MaBC = mMaBC;
                _DK = mDK;
                _qadmin = qadmin;

            }
        }


        

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_TrangThietBiYTe(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_TrangThietBiYTe.GetBC_TrangThietBiYTe(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_TrangThietBiYTe item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_TrangThietBiYTe item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_TrangThietBiYTeList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_TrangThietBiYTeList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
