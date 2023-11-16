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
    public class BC_HDKhamBenhList : BusinessListBase<BC_HDKhamBenhList, BC_HDKhamBenh>
    {
        #region Factory Methods
        public static BC_HDKhamBenhList GetAllBC_HDKhamBenh(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_HDKhamBenhList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_HDKhamBenhList FindBC_HDKhamBenhByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDKhamBenhList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_HDKhamBenhList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDKhamBenhList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_HDKhamBenh NewTo()
        {
            BC_HDKhamBenh obj = BC_HDKhamBenh.NewBC_HDKhamBenh();
            return obj;
        }
        public void   NewTo(BC_HDKhamBenh _BC_HDKhamBenh)
        {
           
            try
            {
                if (!Contains(_BC_HDKhamBenh.MaBC, _BC_HDKhamBenh.MaKhoa,_BC_HDKhamBenh.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_HDKhamBenh.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_HDKhamBenh);
                        int _count = 0;
                        _BC_HDKhamBenh.OrderNumber = ++_count;
                        this.Add(_BC_HDKhamBenh);
                    }
                    else
                    {
                        _BC_HDKhamBenh.OrderNumber = 1;
                        this.Add(_BC_HDKhamBenh);

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
        public void UpdatedTo(BC_HDKhamBenh _BC_HDKhamBenh)
        {

            _BC_HDKhamBenh.OrderNumber = this.Items[this.IndexOf(_BC_HDKhamBenh)].OrderNumber;
            this.Items[this.IndexOf(_BC_HDKhamBenh)] = _BC_HDKhamBenh;
        }
        public void RemoveTo(BC_HDKhamBenh _BC_HDKhamBenh)
        {
            this.Items.Remove(_BC_HDKhamBenh);

        }
        public BC_HDKhamBenh  AssignTo(BC_HDKhamBenh  _BC_HDKhamBenh)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_HDKhamBenh.OrderNumber = ++_count;
                this.Add(_BC_HDKhamBenh);
            }
            else
            {
                _BC_HDKhamBenh.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_HDKhamBenh);
            }
            //Add(_PhieuNhap_C);
            return _BC_HDKhamBenh;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_HDKhamBenh item in this)
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
            foreach (BC_HDKhamBenh obj in this)
                if ((obj.MaBC == MaBC) && (obj.MaKhoa == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_HDKhamBenh GetBC_HDKhamBenhById(string MaBC, string ma)
        {
            foreach (BC_HDKhamBenh item in this)
                if ((item.MaBC == MaBC) && (item.MaKhoa == ma))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_HDKhamBenh  item in this)
            {
                if ((item.MaBC == MaBC)  && (item.MaKhoa == ma))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            BC_HDKhamBenh item = BC_HDKhamBenh.NewBC_HDKhamBenh();
            Add(item);
            return item;
        }

        

        private BC_HDKhamBenhList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_HDKhamBenh(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_HDKhamBenh.GetBC_HDKhamBenh(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_HDKhamBenh item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_HDKhamBenh item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_HDKhamBenhList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_HDKhamBenhList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
