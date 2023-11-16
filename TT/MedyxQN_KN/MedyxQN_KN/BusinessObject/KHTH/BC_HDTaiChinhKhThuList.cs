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
    public class BC_HDTaiChinhKhThuList : BusinessListBase<BC_HDTaiChinhKhThuList, BC_HDTaiChinhKhThu>
    {
        #region Factory Methods
        public static BC_HDTaiChinhKhThuList GetAllBC_HDTaiChinhKhThu(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_HDTaiChinhKhThuList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_HDTaiChinhKhThuList FindBC_HDTaiChinhKhThuByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDTaiChinhKhThuList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_HDTaiChinhKhThuList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDTaiChinhKhThuList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_HDTaiChinhKhThu NewTo()
        {
            BC_HDTaiChinhKhThu obj = BC_HDTaiChinhKhThu.NewBC_HDTaiChinhKhThu();
            return obj;
        }
        public void   NewTo(BC_HDTaiChinhKhThu _BC_HDTaiChinhKhThu)
        {
           
            try
            {
                if (!Contains(_BC_HDTaiChinhKhThu.MaBC, _BC_HDTaiChinhKhThu.Ma,_BC_HDTaiChinhKhThu.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_HDTaiChinhKhThu.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_HDTaiChinhKhThu);
                        int _count = 0;
                        _BC_HDTaiChinhKhThu.OrderNumber = ++_count;
                        this.Add(_BC_HDTaiChinhKhThu);
                    }
                    else
                    {
                        _BC_HDTaiChinhKhThu.OrderNumber = 1;
                        this.Add(_BC_HDTaiChinhKhThu);

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
        public void UpdatedTo(BC_HDTaiChinhKhThu _BC_HDTaiChinhKhThu)
        {

            _BC_HDTaiChinhKhThu.OrderNumber = this.Items[this.IndexOf(_BC_HDTaiChinhKhThu)].OrderNumber;
            this.Items[this.IndexOf(_BC_HDTaiChinhKhThu)] = _BC_HDTaiChinhKhThu;
        }
        public void RemoveTo(BC_HDTaiChinhKhThu _BC_HDTaiChinhKhThu)
        {
            this.Items.Remove(_BC_HDTaiChinhKhThu);

        }
        public BC_HDTaiChinhKhThu  AssignTo(BC_HDTaiChinhKhThu  _BC_HDTaiChinhKhThu)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_HDTaiChinhKhThu.OrderNumber = ++_count;
                this.Add(_BC_HDTaiChinhKhThu);
            }
            else
            {
                _BC_HDTaiChinhKhThu.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_HDTaiChinhKhThu);
            }
            //Add(_PhieuNhap_C);
            return _BC_HDTaiChinhKhThu;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_HDTaiChinhKhThu item in this)
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
            foreach (BC_HDTaiChinhKhThu obj in this)
                if ((obj.MaBC == MaBC) && (obj.Ma == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_HDTaiChinhKhThu GetBC_HDTaiChinhKhThuById(string MaBC, string ma)
        {
            foreach (BC_HDTaiChinhKhThu item in this)
                if ((item.MaBC == MaBC) && (item.Ma == ma))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_HDTaiChinhKhThu  item in this)
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
            BC_HDTaiChinhKhThu item = BC_HDTaiChinhKhThu.NewBC_HDTaiChinhKhThu();
            Add(item);
            return item;
        }

        

        private BC_HDTaiChinhKhThuList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_HDTaiChinhKhThu(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_HDTaiChinhKhThu.GetBC_HDTaiChinhKhThu(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_HDTaiChinhKhThu item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_HDTaiChinhKhThu item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_HDTaiChinhKhThuList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_HDTaiChinhKhThuList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
