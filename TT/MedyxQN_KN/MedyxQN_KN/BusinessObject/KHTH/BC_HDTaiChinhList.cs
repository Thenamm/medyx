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
    public class BC_HDTaiChinhList : BusinessListBase<BC_HDTaiChinhList, BC_HDTaiChinh>
    {
        #region Factory Methods
        public static BC_HDTaiChinhList GetAllBC_HDTaiChinh(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_HDTaiChinhList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_HDTaiChinhList FindBC_HDTaiChinhByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDTaiChinhList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_HDTaiChinhList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDTaiChinhList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_HDTaiChinh NewTo()
        {
            BC_HDTaiChinh obj = BC_HDTaiChinh.NewBC_HDTaiChinh();
            return obj;
        }
        public void   NewTo(BC_HDTaiChinh _BC_HDTaiChinh)
        {
           
            try
            {
                if (!Contains(_BC_HDTaiChinh.MaBC, _BC_HDTaiChinh.MA,_BC_HDTaiChinh.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_HDTaiChinh.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_HDTaiChinh);
                        int _count = 0;
                        _BC_HDTaiChinh.OrderNumber = ++_count;
                        this.Add(_BC_HDTaiChinh);
                    }
                    else
                    {
                        _BC_HDTaiChinh.OrderNumber = 1;
                        this.Add(_BC_HDTaiChinh);

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
        public void UpdatedTo(BC_HDTaiChinh _BC_HDTaiChinh)
        {

            _BC_HDTaiChinh.OrderNumber = this.Items[this.IndexOf(_BC_HDTaiChinh)].OrderNumber;
            this.Items[this.IndexOf(_BC_HDTaiChinh)] = _BC_HDTaiChinh;
        }
        public void RemoveTo(BC_HDTaiChinh _BC_HDTaiChinh)
        {
            this.Items.Remove(_BC_HDTaiChinh);

        }
        public BC_HDTaiChinh  AssignTo(BC_HDTaiChinh  _BC_HDTaiChinh)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_HDTaiChinh.OrderNumber = ++_count;
                this.Add(_BC_HDTaiChinh);
            }
            else
            {
                _BC_HDTaiChinh.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_HDTaiChinh);
            }
            //Add(_PhieuNhap_C);
            return _BC_HDTaiChinh;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_HDTaiChinh item in this)
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
            foreach (BC_HDTaiChinh obj in this)
                if ((obj.MaBC == MaBC) && (obj.MA == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_HDTaiChinh GetBC_HDTaiChinhById(string MaBC, string ma)
        {
            foreach (BC_HDTaiChinh item in this)
                if ((item.MaBC == MaBC) && (item.MA == ma))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_HDTaiChinh  item in this)
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
            BC_HDTaiChinh item = BC_HDTaiChinh.NewBC_HDTaiChinh();
            Add(item);
            return item;
        }

        

        private BC_HDTaiChinhList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_HDTaiChinh(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_HDTaiChinh.GetBC_HDTaiChinh(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_HDTaiChinh item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_HDTaiChinh item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_HDTaiChinhList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_HDTaiChinhList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
