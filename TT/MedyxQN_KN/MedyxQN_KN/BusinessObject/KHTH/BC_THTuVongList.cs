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
    public class BC_THTuVongList : BusinessListBase<BC_THTuVongList, BC_THTuVong>
    {
        #region Factory Methods
        public static BC_THTuVongList GetAllBC_THTuVong(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_THTuVongList>(new Criteria(maBC, dk));
        }
        public static BC_THTuVongList GetAllBC_THTuVong(DateTime  tungay, DateTime  denngay, String dk)
        {
            return DataPortal.Fetch<BC_THTuVongList>(new CriteriaOther(tungay,denngay, dk));
        }
        // tim theo dieu kien ten
        //public static BC_THTuVongList FindBC_THTuVongByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_THTuVongList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_THTuVongList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_THTuVongList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_THTuVong NewTo()
        {
            BC_THTuVong obj = BC_THTuVong.NewBC_THTuVong();
            return obj;
        }
        public void   NewTo(BC_THTuVong _BC_THTuVong)
        {
           
            try
            {
                if (!Contains(_BC_THTuVong.MaBC, _BC_THTuVong.MaBenh,_BC_THTuVong.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_THTuVong.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_THTuVong);
                        int _count = 0;
                        _BC_THTuVong.OrderNumber = ++_count;
                        this.Add(_BC_THTuVong);
                    }
                    else
                    {
                        _BC_THTuVong.OrderNumber = 1;
                        this.Add(_BC_THTuVong);

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
        public void UpdatedTo(BC_THTuVong _BC_THTuVong)
        {

            _BC_THTuVong.OrderNumber = this.Items[this.IndexOf(_BC_THTuVong)].OrderNumber;
            this.Items[this.IndexOf(_BC_THTuVong)] = _BC_THTuVong;
        }
        public void RemoveTo(BC_THTuVong _BC_THTuVong)
        {
            this.Items.Remove(_BC_THTuVong);

        }
        public BC_THTuVong  AssignTo(BC_THTuVong  _BC_THTuVong)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_THTuVong.OrderNumber = ++_count;
                this.Add(_BC_THTuVong);
            }
            else
            {
                _BC_THTuVong.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_THTuVong);
            }
            //Add(_PhieuNhap_C);
            return _BC_THTuVong;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_THTuVong item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string maBC,string maBenh,  bool Huy)
        {
            foreach (BC_THTuVong obj in this)
                if ((obj.MaBC == maBC) && (obj.MaBenh == maBenh) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_THTuVong GetBC_THTuVongById(string maBC, string maBenh)
        {
            foreach (BC_THTuVong item in this)
                if ((item.MaBC == maBC) && (item.MaBenh == maBenh))
                    return item;
            return null;
        }
        public void Remove(string maBC, string maBenh)
        {
            foreach (BC_THTuVong  item in this)
            {
                if ((item.MaBC == maBC) && (item.MaBenh == maBenh))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            BC_THTuVong item = BC_THTuVong.NewBC_THTuVong();
            Add(item);
            return item;
        }

        

        private BC_THTuVongList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_THTuVong(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_THTuVong.GetBC_THTuVong(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class CriteriaOther
        {
            private DateTime  _tungay;
            private DateTime _denngay;
            private String _DK;
             private Boolean _qadmin = false ;
            public DateTime tungay
            {
                get
                {
                    return _tungay;
                }
            }
            public DateTime denngay
            {
                get
                {
                    return _denngay;
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
            public CriteriaOther(DateTime mtungay, DateTime mdenngay, String mDK)
            {
                _tungay = mtungay;
                _denngay = mdenngay;
                _DK = mDK;
                _qadmin = qadmin;

            }
        }




        private void DataPortal_Fetch(CriteriaOther CriteriaOther)
        {
            int i = 1;
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_THTuVong(CriteriaOther.tungay, CriteriaOther.denngay,CriteriaOther.DK)))
          
            {
                while (dr.Read())
                {

                    this.Add(BC_THTuVong.GetBC_THTuVong(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_THTuVong item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_THTuVong item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_THTuVongList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_THTuVongList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
