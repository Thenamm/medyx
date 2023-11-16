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
    public class BC_HDChiDaoTuyenBList : BusinessListBase<BC_HDChiDaoTuyenBList, BC_HDChiDaoTuyenB>
    {
        #region Factory Methods
        public static BC_HDChiDaoTuyenBList GetAllBC_HDChiDaoTuyenB(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_HDChiDaoTuyenBList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_HDChiDaoTuyenBList FindBC_HDChiDaoTuyenBByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDChiDaoTuyenBList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_HDChiDaoTuyenBList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDChiDaoTuyenBList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_HDChiDaoTuyenB NewTo()
        {
            BC_HDChiDaoTuyenB obj = BC_HDChiDaoTuyenB.NewBC_HDChiDaoTuyenB();
            return obj;
        }
        public void   NewTo(BC_HDChiDaoTuyenB _BC_HDChiDaoTuyenB)
        {
           
            try
            {
                if (!Contains(_BC_HDChiDaoTuyenB.MaBC, _BC_HDChiDaoTuyenB.STT ,_BC_HDChiDaoTuyenB.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_HDChiDaoTuyenB.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_HDChiDaoTuyenB);
                        int _count = 0;
                        _BC_HDChiDaoTuyenB.STT = ++_count;
                        this.Add(_BC_HDChiDaoTuyenB);
                    }
                    else
                    {
                        _BC_HDChiDaoTuyenB.STT = 1;
                        this.Add(_BC_HDChiDaoTuyenB);

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
        public void UpdatedTo(BC_HDChiDaoTuyenB _BC_HDChiDaoTuyenB)
        {

            _BC_HDChiDaoTuyenB.STT = this.Items[this.IndexOf(_BC_HDChiDaoTuyenB)].STT;
            this.Items[this.IndexOf(_BC_HDChiDaoTuyenB)] = _BC_HDChiDaoTuyenB;
        }
        public void RemoveTo(BC_HDChiDaoTuyenB _BC_HDChiDaoTuyenB)
        {
            if (_BC_HDChiDaoTuyenB.IsNew ==true)
                this.Items.Remove(_BC_HDChiDaoTuyenB);
            else
                Remove(_BC_HDChiDaoTuyenB);

        }
        public BC_HDChiDaoTuyenB  AssignTo(BC_HDChiDaoTuyenB  _BC_HDChiDaoTuyenB)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count ;
                _BC_HDChiDaoTuyenB.OrderNumber  = ++_count;
                this.Add(_BC_HDChiDaoTuyenB);
            }
            else
            {
                _BC_HDChiDaoTuyenB.OrderNumber  = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_HDChiDaoTuyenB);
            }
            //Add(_PhieuNhap_C);
            return _BC_HDChiDaoTuyenB;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_HDChiDaoTuyenB item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaBC, int stt, bool Huy)
        {
            foreach (BC_HDChiDaoTuyenB obj in this)
                if ((obj.MaBC == MaBC) && (obj.STT == stt) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_HDChiDaoTuyenB GetBC_HDChiDaoTuyenBById(string MaBC, int sTT)
        {
            foreach (BC_HDChiDaoTuyenB item in this)
                if ((item.MaBC == MaBC) && (item.OrderNumber == sTT))
                    return item;
            return null;
        }
        public void Remove(string MaBC, int ma)
        {
            foreach (BC_HDChiDaoTuyenB  item in this)
            {
                if ((item.MaBC == MaBC)  && (item.STT  == ma))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            BC_HDChiDaoTuyenB item = BC_HDChiDaoTuyenB.NewBC_HDChiDaoTuyenB();
            Add(item);
            return item;
        }

        

        private BC_HDChiDaoTuyenBList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_HDChiDaoTuyenB(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_HDChiDaoTuyenB.GetBC_HDChiDaoTuyenB(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_HDChiDaoTuyenB item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_HDChiDaoTuyenB item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_HDChiDaoTuyenBList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_HDChiDaoTuyenBList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
