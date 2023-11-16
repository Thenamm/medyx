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
    public class BC_HDPhauThuatList : BusinessListBase<BC_HDPhauThuatList, BC_HDPhauThuat>
    {
        #region Factory Methods
        public static BC_HDPhauThuatList GetAllBC_HDPhauThuat(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_HDPhauThuatList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_HDPhauThuatList FindBC_HDPhauThuatByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDPhauThuatList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_HDPhauThuatList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDPhauThuatList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_HDPhauThuat NewTo()
        {
            BC_HDPhauThuat obj = BC_HDPhauThuat.NewBC_HDPhauThuat();
            return obj;
        }
        public void   NewTo(BC_HDPhauThuat _BC_HDPhauThuat)
        {
           
            try
            {
                if (!Contains(_BC_HDPhauThuat.MaBC, _BC_HDPhauThuat.Ma ,_BC_HDPhauThuat.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_HDPhauThuat.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_HDPhauThuat);
                        int _count = 0;
                        _BC_HDPhauThuat.OrderNumber = ++_count;
                        this.Add(_BC_HDPhauThuat);
                    }
                    else
                    {
                        _BC_HDPhauThuat.OrderNumber = 1;
                        this.Add(_BC_HDPhauThuat);

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
        public void UpdatedTo(BC_HDPhauThuat _BC_HDPhauThuat)
        {

           // _BC_HDPhauThuat.OrderNumber = this.Items[this.IndexOf(_BC_HDPhauThuat)].OrderNumber;
           ///this.Items[this.IndexOf(_BC_HDPhauThuat)] = _BC_HDPhauThuat;
        }
        public void RemoveTo(BC_HDPhauThuat _BC_HDPhauThuat)
        {
            this.Items.Remove(_BC_HDPhauThuat);

        }
        public BC_HDPhauThuat  AssignTo(BC_HDPhauThuat  _BC_HDPhauThuat)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_HDPhauThuat.OrderNumber = ++_count;
                this.Add(_BC_HDPhauThuat);
            }
            else
            {
                _BC_HDPhauThuat.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_HDPhauThuat);
            }
            //Add(_PhieuNhap_C);
            return _BC_HDPhauThuat;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_HDPhauThuat item in this)
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
            foreach (BC_HDPhauThuat obj in this)
                if ((obj.MaBC == MaBC) && (obj.Ma  == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_HDPhauThuat GetBC_HDPhauThuatById(string MaBC, string ma)
        {
            foreach (BC_HDPhauThuat item in this)
                if ((item.MaBC == MaBC) && (item.Ma  == ma))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_HDPhauThuat  item in this)
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
            BC_HDPhauThuat item = BC_HDPhauThuat.NewBC_HDPhauThuat();
            Add(item);
            return item;
        }

        

        private BC_HDPhauThuatList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_HDPhauThuat(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_HDPhauThuat.GetBC_HDPhauThuat(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_HDPhauThuat item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_HDPhauThuat item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_HDPhauThuatList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_HDPhauThuatList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
