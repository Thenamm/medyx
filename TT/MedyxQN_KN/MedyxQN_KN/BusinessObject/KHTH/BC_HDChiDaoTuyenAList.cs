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
    public class BC_HDChiDaoTuyenAList : BusinessListBase<BC_HDChiDaoTuyenAList, BC_HDChiDaoTuyenA>
    {
        #region Factory Methods
        public static BC_HDChiDaoTuyenAList GetAllBC_HDChiDaoTuyenA(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_HDChiDaoTuyenAList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_HDChiDaoTuyenAList FindBC_HDChiDaoTuyenAByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDChiDaoTuyenAList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_HDChiDaoTuyenAList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDChiDaoTuyenAList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_HDChiDaoTuyenA NewTo()
        {
            BC_HDChiDaoTuyenA obj = BC_HDChiDaoTuyenA.NewBC_HDChiDaoTuyenA();
            return obj;
        }
        public void   NewTo(BC_HDChiDaoTuyenA _BC_HDChiDaoTuyenA)
        {
           
            try
            {
                if (!Contains(_BC_HDChiDaoTuyenA.MaBC, _BC_HDChiDaoTuyenA.Ma,_BC_HDChiDaoTuyenA.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_HDChiDaoTuyenA.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_HDChiDaoTuyenA);
                        int _count = 0;
                        _BC_HDChiDaoTuyenA.OrderNumber = ++_count;
                        this.Add(_BC_HDChiDaoTuyenA);
                    }
                    else
                    {
                        _BC_HDChiDaoTuyenA.OrderNumber = 1;
                        this.Add(_BC_HDChiDaoTuyenA);

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
        public void UpdatedTo(BC_HDChiDaoTuyenA _BC_HDChiDaoTuyenA)
        {

            _BC_HDChiDaoTuyenA.OrderNumber = this.Items[this.IndexOf(_BC_HDChiDaoTuyenA)].OrderNumber;
            this.Items[this.IndexOf(_BC_HDChiDaoTuyenA)] = _BC_HDChiDaoTuyenA;
        }
        public void RemoveTo(BC_HDChiDaoTuyenA _BC_HDChiDaoTuyenA)
        {
            this.Items.Remove(_BC_HDChiDaoTuyenA);

        }
        public BC_HDChiDaoTuyenA  AssignTo(BC_HDChiDaoTuyenA  _BC_HDChiDaoTuyenA)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_HDChiDaoTuyenA.OrderNumber = ++_count;
                this.Add(_BC_HDChiDaoTuyenA);
            }
            else
            {
                _BC_HDChiDaoTuyenA.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_HDChiDaoTuyenA);
            }
            //Add(_PhieuNhap_C);
            return _BC_HDChiDaoTuyenA;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_HDChiDaoTuyenA item in this)
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
            foreach (BC_HDChiDaoTuyenA obj in this)
                if ((obj.MaBC == MaBC) && (obj.Ma == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_HDChiDaoTuyenA GetBC_HDChiDaoTuyenAById(string MaBC, string ma)
        {
            foreach (BC_HDChiDaoTuyenA item in this)
                if ((item.MaBC == MaBC) && (item.Ma == ma))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_HDChiDaoTuyenA  item in this)
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
            BC_HDChiDaoTuyenA item = BC_HDChiDaoTuyenA.NewBC_HDChiDaoTuyenA();
            Add(item);
            return item;
        }

        

        private BC_HDChiDaoTuyenAList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_HDChiDaoTuyenA(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_HDChiDaoTuyenA.GetBC_HDChiDaoTuyenA(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_HDChiDaoTuyenA item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_HDChiDaoTuyenA item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_HDChiDaoTuyenAList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_HDChiDaoTuyenAList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
