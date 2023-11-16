﻿using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//

namespace HTC.Business.KHTH
{
    [Serializable()]
    public class BC_DuocBVList : BusinessListBase<BC_DuocBVList, BC_DuocBV>
    {
        #region Factory Methods
        public static BC_DuocBVList GetAllBC_DuocBV(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_DuocBVList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_DuocBVList FindBC_DuocBVByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_DuocBVList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_DuocBVList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_DuocBVList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_DuocBV NewTo()
        {
            BC_DuocBV obj = BC_DuocBV.NewBC_DuocBV();
            return obj;
        }
        public void   NewTo(BC_DuocBV _BC_DuocBV)
        {
           
            try
            {
                if (!Contains(_BC_DuocBV.MaBC, _BC_DuocBV.Ma,_BC_DuocBV.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_DuocBV.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_DuocBV);
                        int _count = 0;
                        _BC_DuocBV.OrderNumber = ++_count;
                        this.Add(_BC_DuocBV);
                    }
                    else
                    {
                        _BC_DuocBV.OrderNumber = 1;
                        this.Add(_BC_DuocBV);

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
        public void UpdatedTo(BC_DuocBV _BC_DuocBV)
        {

            _BC_DuocBV.OrderNumber = this.Items[this.IndexOf(_BC_DuocBV)].OrderNumber;
            this.Items[this.IndexOf(_BC_DuocBV)] = _BC_DuocBV;
        }
        public void RemoveTo(BC_DuocBV _BC_DuocBV)
        {
            this.Items.Remove(_BC_DuocBV);

        }
        public BC_DuocBV  AssignTo(BC_DuocBV  _BC_DuocBV)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_DuocBV.OrderNumber = ++_count;
                this.Add(_BC_DuocBV);
            }
            else
            {
                _BC_DuocBV.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_DuocBV);
            }
            //Add(_PhieuNhap_C);
            return _BC_DuocBV;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_DuocBV item in this)
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
            foreach (BC_DuocBV obj in this)
                if ((obj.MaBC == MaBC) && (obj.Ma == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_DuocBV GetBC_DuocBVById(string MaBC, string ma)
        {
            foreach (BC_DuocBV item in this)
                if ((item.MaBC == MaBC) && (item.Ma == ma))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_DuocBV  item in this)
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
            BC_DuocBV item = BC_DuocBV.NewBC_DuocBV();
            Add(item);
            return item;
        }

        

        private BC_DuocBVList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_DuocBV(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_DuocBV.GetBC_DuocBV(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_DuocBV item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_DuocBV item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_DuocBVList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_DuocBVList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
