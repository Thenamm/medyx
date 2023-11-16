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
    public class BC_HDKhamBenhYHList : BusinessListBase<BC_HDKhamBenhYHList, BC_HDKhamBenhYH>
    {
        #region Factory Methods
        public static BC_HDKhamBenhYHList GetAllBC_HDKhamBenhYH(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_HDKhamBenhYHList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_HDKhamBenhYHList FindBC_HDKhamBenhYHByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDKhamBenhYHList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_HDKhamBenhYHList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDKhamBenhYHList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_HDKhamBenhYH NewTo()
        {
            BC_HDKhamBenhYH obj = BC_HDKhamBenhYH.NewBC_HDKhamBenhYH();
            return obj;
        }
        public void   NewTo(BC_HDKhamBenhYH _BC_HDKhamBenhYH)
        {
           
            try
            {
                if (!Contains(_BC_HDKhamBenhYH.MaBC, _BC_HDKhamBenhYH.MaKhoa,_BC_HDKhamBenhYH.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_HDKhamBenhYH.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_HDKhamBenhYH);
                        int _count = 0;
                        _BC_HDKhamBenhYH.OrderNumber = ++_count;
                        this.Add(_BC_HDKhamBenhYH);
                    }
                    else
                    {
                        _BC_HDKhamBenhYH.OrderNumber = 1;
                        this.Add(_BC_HDKhamBenhYH);

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
        public void UpdatedTo(BC_HDKhamBenhYH _BC_HDKhamBenhYH)
        {

            _BC_HDKhamBenhYH.OrderNumber = this.Items[this.IndexOf(_BC_HDKhamBenhYH)].OrderNumber;
            this.Items[this.IndexOf(_BC_HDKhamBenhYH)] = _BC_HDKhamBenhYH;
        }
        public void RemoveTo(BC_HDKhamBenhYH _BC_HDKhamBenhYH)
        {
            this.Items.Remove(_BC_HDKhamBenhYH);

        }
        public BC_HDKhamBenhYH  AssignTo(BC_HDKhamBenhYH  _BC_HDKhamBenhYH)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_HDKhamBenhYH.OrderNumber = ++_count;
                this.Add(_BC_HDKhamBenhYH);
            }
            else
            {
                _BC_HDKhamBenhYH.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_HDKhamBenhYH);
            }
            //Add(_PhieuNhap_C);
            return _BC_HDKhamBenhYH;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_HDKhamBenhYH item in this)
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
            foreach (BC_HDKhamBenhYH obj in this)
                if ((obj.MaBC == MaBC) && (obj.MaKhoa == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_HDKhamBenhYH GetBC_HDKhamBenhYHById(string MaBC, string ma)
        {
            foreach (BC_HDKhamBenhYH item in this)
                if ((item.MaBC == MaBC) && (item.MaKhoa == ma))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_HDKhamBenhYH  item in this)
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
            BC_HDKhamBenhYH item = BC_HDKhamBenhYH.NewBC_HDKhamBenhYH();
            Add(item);
            return item;
        }

        

        private BC_HDKhamBenhYHList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_HDKhamBenhYH(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_HDKhamBenhYH.GetBC_HDKhamBenhYH(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_HDKhamBenhYH item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_HDKhamBenhYH item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_HDKhamBenhYHList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_HDKhamBenhYHList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
