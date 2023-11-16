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
    public class BC_THCanBoList : BusinessListBase<BC_THCanBoList, BC_THCanBo>
    {
        #region Factory Methods
        public static BC_THCanBoList GetAllBC_THCanBo(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_THCanBoList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_THCanBoList FindBC_THCanBoByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_THCanBoList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_THCanBoList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_THCanBoList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_THCanBo NewTo()
        {
            BC_THCanBo obj = BC_THCanBo.NewBC_THCanBo();
            return obj;
        }
        public void   NewTo(BC_THCanBo _BC_THCanBo)
        {
           
            try
            {
                if (!Contains(_BC_THCanBo.MaBC, _BC_THCanBo.MaKhoa,_BC_THCanBo.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_THCanBo.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_THCanBo);
                        int _count = 0;
                        _BC_THCanBo.OrderNumber = ++_count;
                        this.Add(_BC_THCanBo);
                    }
                    else
                    {
                        _BC_THCanBo.OrderNumber = 1;
                        this.Add(_BC_THCanBo);

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
        public void UpdatedTo(BC_THCanBo _BC_THCanBo)
        {

            _BC_THCanBo.OrderNumber = this.Items[this.IndexOf(_BC_THCanBo)].OrderNumber;
            this.Items[this.IndexOf(_BC_THCanBo)] = _BC_THCanBo;
        }
        public void RemoveTo(BC_THCanBo _BC_THCanBo)
        {
            this.Items.Remove(_BC_THCanBo);

        }
        public BC_THCanBo  AssignTo(BC_THCanBo  _BC_THCanBo)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_THCanBo.OrderNumber = ++_count;
                this.Add(_BC_THCanBo);
            }
            else
            {
                _BC_THCanBo.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_THCanBo);
            }
            //Add(_PhieuNhap_C);
            return _BC_THCanBo;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_THCanBo item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string maBC,string maKhoa,  bool Huy)
        {
            foreach (BC_THCanBo obj in this)
                if ((obj.MaBC == maBC)&& (obj.MaKhoa  == maKhoa ) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_THCanBo GetBC_THCanBoById(string maBC,string maKhoa)
        {
            foreach (BC_THCanBo item in this)
                if ((item.MaBC == maBC)&& (item.MaKhoa  == maKhoa ))
                    return item;
            return null;
        }
        public void Remove(string maBC, string maKhoa)
        {
            foreach (BC_THCanBo  item in this)
            {
                if ((item.MaBC == maBC) && (item.MaKhoa == maKhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            BC_THCanBo item = BC_THCanBo.NewBC_THCanBo();
            Add(item);
            return item;
        }

        

        private BC_THCanBoList()
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
                _MaBC = mMaBC;
                _DK = mDK;
                _qadmin = qadmin;

            }
        }


        

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_THCanBo(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_THCanBo.GetBC_THCanBo(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_THCanBo item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_THCanBo item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_THCanBoList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_THCanBoList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
