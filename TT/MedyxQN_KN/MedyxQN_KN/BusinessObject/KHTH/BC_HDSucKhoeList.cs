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
    public class BC_HDSucKhoeList : BusinessListBase<BC_HDSucKhoeList, BC_HDSucKhoe>
    {
        #region Factory Methods
        public static BC_HDSucKhoeList GetAllBC_HDSucKhoe(String maBC, string dk)
        {
            return DataPortal.Fetch<BC_HDSucKhoeList>(new Criteria(maBC,""));
        }
       
        // tim theo dieu kien ten
        //public static BC_HDSucKhoeList FindBC_HDSucKhoeByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDSucKhoeList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_HDSucKhoeList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDSucKhoeList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_HDSucKhoe NewTo()
        {
            BC_HDSucKhoe obj = BC_HDSucKhoe.NewBC_HDSucKhoe();
            return obj;
        }
        public void   NewTo(BC_HDSucKhoe _BC_HDSucKhoe)
        {
           
            try
            {
                if (!Contains(_BC_HDSucKhoe.MaBC, _BC_HDSucKhoe.MA,_BC_HDSucKhoe.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_HDSucKhoe.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_HDSucKhoe);
                        int _count = 0;
                        _BC_HDSucKhoe.OrderNumber = ++_count;
                        this.Add(_BC_HDSucKhoe);
                    }
                    else
                    {
                        _BC_HDSucKhoe.OrderNumber = 1;
                        this.Add(_BC_HDSucKhoe);

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
        public void UpdatedTo(BC_HDSucKhoe _BC_HDSucKhoe)
        {

            _BC_HDSucKhoe.OrderNumber = this.Items[this.IndexOf(_BC_HDSucKhoe)].OrderNumber;
            this.Items[this.IndexOf(_BC_HDSucKhoe)] = _BC_HDSucKhoe;
        }
        public void RemoveTo(BC_HDSucKhoe _BC_HDSucKhoe)
        {
            this.Items.Remove(_BC_HDSucKhoe);

        }
        public BC_HDSucKhoe  AssignTo(BC_HDSucKhoe  _BC_HDSucKhoe)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_HDSucKhoe.OrderNumber = ++_count;
                this.Add(_BC_HDSucKhoe);
            }
            else
            {
                _BC_HDSucKhoe.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_HDSucKhoe);
            }
            //Add(_PhieuNhap_C);
            return _BC_HDSucKhoe;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_HDSucKhoe item in this)
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
            foreach (BC_HDSucKhoe obj in this)
                if ((obj.MaBC == MaBC) && (obj.MA == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_HDSucKhoe GetBC_HDSucKhoeById(string MaBC, string ma)
        {
            foreach (BC_HDSucKhoe item in this)
                if ((item.MaBC == MaBC) && (item.MA == ma))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_HDSucKhoe  item in this)
            {
                if ((item.MaBC == MaBC)  && (item.MA == ma))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            BC_HDSucKhoe item = BC_HDSucKhoe.NewBC_HDSucKhoe();
            Add(item);
            return item;
        }

        

        private BC_HDSucKhoeList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_HDSucKhoe(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_HDSucKhoe.GetBC_HDSucKhoe(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_HDSucKhoe item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_HDSucKhoe item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_HDSucKhoeList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_HDSucKhoeList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
