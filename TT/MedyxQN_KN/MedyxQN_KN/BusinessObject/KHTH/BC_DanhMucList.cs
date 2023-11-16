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
    public class BC_DanhMucList : BusinessListBase<BC_DanhMucList, BC_DanhMuc>
    {
        #region Factory Methods
        public static BC_DanhMucList GetAllBC_DanhMuc(String dk)
        {
            return DataPortal.Fetch<BC_DanhMucList>(new Criteria(dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_DanhMucList FindBC_DanhMucByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_DanhMucList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_DanhMucList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_DanhMucList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_DanhMuc NewTo()
        {
            BC_DanhMuc obj = BC_DanhMuc.NewBC_DanhMuc();
            return obj;
        }
        public void   NewTo(BC_DanhMuc _BC_DanhMuc)
        {
           
            try
            {
                if (!Contains(_BC_DanhMuc.Ma,_BC_DanhMuc.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_DanhMuc.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_DanhMuc);
                        int _count = 0;
                        _BC_DanhMuc.OrderNumber = ++_count;
                        this.Add(_BC_DanhMuc);
                    }
                    else
                    {
                        _BC_DanhMuc.OrderNumber = 1;
                        this.Add(_BC_DanhMuc);

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
        public void UpdatedTo(BC_DanhMuc _BC_DanhMuc)
        {

            _BC_DanhMuc.OrderNumber = this.Items[this.IndexOf(_BC_DanhMuc)].OrderNumber;
            this.Items[this.IndexOf(_BC_DanhMuc)] = _BC_DanhMuc;
        }
        public void RemoveTo(BC_DanhMuc _BC_DanhMuc)
        {
            this.Items.Remove(_BC_DanhMuc);

        }
        public BC_DanhMuc  AssignTo(BC_DanhMuc  _BC_DanhMuc)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _BC_DanhMuc.OrderNumber = ++_count;
                this.Add(_BC_DanhMuc);
            }
            else
            {
                _BC_DanhMuc.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_DanhMuc);
            }
            //Add(_PhieuNhap_C);
            return _BC_DanhMuc;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_DanhMuc item in this)
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
            foreach (BC_DanhMuc obj in this)
                if ((obj.Ma == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_DanhMuc GetBC_DanhMucById(string ma)
        {
            foreach (BC_DanhMuc item in this)
                if (item.Ma == ma)
                    return item;
            return null;
        }
        public void Remove(string ma)
        {
            foreach (BC_DanhMuc  item in this)
            {
                if (item.Ma == ma)
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            BC_DanhMuc item = BC_DanhMuc.NewBC_DanhMuc();
            Add(item);
            return item;
        }

        

        private BC_DanhMucList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_DanhMuc(criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_DanhMuc.GetBC_DanhMuc(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_DanhMuc item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_DanhMuc item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_DanhMucList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_DanhMucList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
