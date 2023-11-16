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
    public class BC_HDTaiChinhBHList : BusinessListBase<BC_HDTaiChinhBHList, BC_HDTaiChinhBH>
    {
        #region Factory Methods
        public static BC_HDTaiChinhBHList GetAllBC_HDTaiChinhBH(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_HDTaiChinhBHList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_HDTaiChinhBHList FindBC_HDTaiChinhBHByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDTaiChinhBHList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_HDTaiChinhBHList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDTaiChinhBHList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_HDTaiChinhBH NewTo()
        {
            BC_HDTaiChinhBH obj = BC_HDTaiChinhBH.NewBC_HDTaiChinhBH();
            return obj;
        }
        public void   NewTo(BC_HDTaiChinhBH _BC_HDTaiChinhBH)
        {
           
            try
            {
                if (!Contains(_BC_HDTaiChinhBH.MaBC, _BC_HDTaiChinhBH.MA,_BC_HDTaiChinhBH.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_HDTaiChinhBH.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_HDTaiChinhBH);
                        int _count = 0;
                        _BC_HDTaiChinhBH.OrderNumber = ++_count;
                        this.Add(_BC_HDTaiChinhBH);
                    }
                    else
                    {
                        _BC_HDTaiChinhBH.OrderNumber = 1;
                        this.Add(_BC_HDTaiChinhBH);

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
        public void UpdatedTo(BC_HDTaiChinhBH _BC_HDTaiChinhBH)
        {

            _BC_HDTaiChinhBH.OrderNumber = this.Items[this.IndexOf(_BC_HDTaiChinhBH)].OrderNumber;
            this.Items[this.IndexOf(_BC_HDTaiChinhBH)] = _BC_HDTaiChinhBH;
        }
        public void RemoveTo(BC_HDTaiChinhBH _BC_HDTaiChinhBH)
        {
            this.Items.Remove(_BC_HDTaiChinhBH);

        }
        public BC_HDTaiChinhBH  AssignTo(BC_HDTaiChinhBH  _BC_HDTaiChinhBH)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_HDTaiChinhBH.OrderNumber = ++_count;
                this.Add(_BC_HDTaiChinhBH);
            }
            else
            {
                _BC_HDTaiChinhBH.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_HDTaiChinhBH);
            }
            //Add(_PhieuNhap_C);
            return _BC_HDTaiChinhBH;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_HDTaiChinhBH item in this)
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
            foreach (BC_HDTaiChinhBH obj in this)
                if ((obj.MaBC == MaBC) && (obj.MA == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_HDTaiChinhBH GetBC_HDTaiChinhBHById(string MaBC, string ma)
        {
            foreach (BC_HDTaiChinhBH item in this)
                if ((item.MaBC == MaBC) && (item.MA == ma))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_HDTaiChinhBH  item in this)
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
            BC_HDTaiChinhBH item = BC_HDTaiChinhBH.NewBC_HDTaiChinhBH();
            Add(item);
            return item;
        }

        

        private BC_HDTaiChinhBHList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_HDTaiChinhBH(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_HDTaiChinhBH.GetBC_HDTaiChinhBH(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_HDTaiChinhBH item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_HDTaiChinhBH item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_HDTaiChinhBHList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_HDTaiChinhBHList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
