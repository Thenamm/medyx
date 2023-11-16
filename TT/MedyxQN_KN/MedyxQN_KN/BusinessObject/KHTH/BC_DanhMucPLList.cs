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
    public class BC_DanhMucPLList : BusinessListBase<BC_DanhMucPLList, BC_DanhMucPL>
    {
        #region Factory Methods
        public static BC_DanhMucPLList GetAllBC_DanhMucPL(String dk)
        {
            return DataPortal.Fetch<BC_DanhMucPLList>(new Criteria(dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_DanhMucPLList FindBC_DanhMucPLByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_DanhMucPLList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_DanhMucPLList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_DanhMucPLList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_DanhMucPL NewTo()
        {
            BC_DanhMucPL obj = BC_DanhMucPL.NewBC_DanhMucPL();
            return obj;
        }
        public void   NewTo(BC_DanhMucPL _BC_DanhMucPL)
        {
           
            try
            {
                if (!Contains(_BC_DanhMucPL.MaLoai,_BC_DanhMucPL.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_DanhMucPL.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_DanhMucPL);
                        int _count = 0;
                        _BC_DanhMucPL.OrderNumber = ++_count;
                        this.Add(_BC_DanhMucPL);
                    }
                    else
                    {
                        _BC_DanhMucPL.OrderNumber = 1;
                        this.Add(_BC_DanhMucPL);

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
        public void UpdatedTo(BC_DanhMucPL _BC_DanhMucPL)
        {

            _BC_DanhMucPL.OrderNumber = this.Items[this.IndexOf(_BC_DanhMucPL)].OrderNumber;
            this.Items[this.IndexOf(_BC_DanhMucPL)] = _BC_DanhMucPL;
        }
        public void RemoveTo(BC_DanhMucPL _BC_DanhMucPL)
        {
            this.Items.Remove(_BC_DanhMucPL);

        }
        public BC_DanhMucPL  AssignTo(BC_DanhMucPL  _BC_DanhMucPL)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _BC_DanhMucPL.OrderNumber = ++_count;
                this.Add(_BC_DanhMucPL);
            }
            else
            {
                _BC_DanhMucPL.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_DanhMucPL);
            }
            //Add(_PhieuNhap_C);
            return _BC_DanhMucPL;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_DanhMucPL item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string ma, bool Huy)
        {
            foreach (BC_DanhMucPL obj in this)
                if ((obj.MaLoai == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_DanhMucPL GetBC_DanhMucPLById(string ma)
        {
            foreach (BC_DanhMucPL item in this)
                if (item.MaLoai == ma)
                    return item;
            return null;
        }
        public void Remove(string ma)
        {
            foreach (BC_DanhMucPL  item in this)
            {
                if (item.MaLoai == ma)
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            BC_DanhMucPL item = BC_DanhMucPL.NewBC_DanhMucPL();
            Add(item);
            return item;
        }

        

        private BC_DanhMucPLList()
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
            private String _DK;
            private Boolean _qadmin = false ;
           
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
            public Criteria(String mDK)
            {
                _DK = mDK ;
                _qadmin = qadmin;
                
            }
        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_DanhMucPL(criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_DanhMucPL.GetBC_DanhMucPL(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_DanhMucPL item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_DanhMucPL item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_DanhMucPLList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_DanhMucPLList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
