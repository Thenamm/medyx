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
    public class BC_HDDieuTriList : BusinessListBase<BC_HDDieuTriList, BC_HDDieuTri>
    {
        #region Factory Methods
        public static BC_HDDieuTriList GetAllBC_HDDieuTri(String maBC, String dk)
        {
            return DataPortal.Fetch<BC_HDDieuTriList>(new Criteria(maBC, dk));
        }
        
        // tim theo dieu kien ten
        //public static BC_HDDieuTriList FindBC_HDDieuTriByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDDieuTriList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static BC_HDDieuTriList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<BC_HDDieuTriList>(new CriteriaOther(1, MaChungLoai));
        //}
        public BC_HDDieuTri NewTo()
        {
            BC_HDDieuTri obj = BC_HDDieuTri.NewBC_HDDieuTri();
            return obj;
        }
        public void   NewTo(BC_HDDieuTri _BC_HDDieuTri)
        {
           
            try
            {
                if (!Contains(_BC_HDDieuTri.MaBC, _BC_HDDieuTri.MaKhoa,_BC_HDDieuTri.Huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BC_HDDieuTri.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BC_HDDieuTri);
                        int _count = 0;
                        _BC_HDDieuTri.OrderNumber = ++_count;
                        this.Add(_BC_HDDieuTri);
                    }
                    else
                    {
                        _BC_HDDieuTri.OrderNumber = 1;
                        this.Add(_BC_HDDieuTri);

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
        public void UpdatedTo(BC_HDDieuTri _BC_HDDieuTri)
        {

            _BC_HDDieuTri.OrderNumber = this.Items[this.IndexOf(_BC_HDDieuTri)].OrderNumber;
            this.Items[this.IndexOf(_BC_HDDieuTri)] = _BC_HDDieuTri;
        }
        public void RemoveTo(BC_HDDieuTri _BC_HDDieuTri)
        {
            this.Items.Remove(_BC_HDDieuTri);

        }
        public BC_HDDieuTri  AssignTo(BC_HDDieuTri  _BC_HDDieuTri)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _BC_HDDieuTri.OrderNumber = ++_count;
                this.Add(_BC_HDDieuTri);
            }
            else
            {
                _BC_HDDieuTri.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_BC_HDDieuTri);
            }
            //Add(_PhieuNhap_C);
            return _BC_HDDieuTri;
        }

        //public void Remove(int id)
        //{
        //    foreach (BC_HDDieuTri item in this)
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
            foreach (BC_HDDieuTri obj in this)
                if ((obj.MaBC == MaBC) && (obj.MaKhoa == ma) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public BC_HDDieuTri GetBC_HDDieuTriById(string MaBC, string maKhoa)
        {
            foreach (BC_HDDieuTri item in this)
                if ((item.MaBC == MaBC) && (item.MaKhoa == maKhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBC, string ma)
        {
            foreach (BC_HDDieuTri  item in this)
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
            BC_HDDieuTri item = BC_HDDieuTri.NewBC_HDDieuTri();
            Add(item);
            return item;
        }

        

        private BC_HDDieuTriList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_HDDieuTri(criteria.MaBC, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(BC_HDDieuTri.GetBC_HDDieuTri(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BC_HDDieuTri item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BC_HDDieuTri item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BC_HDDieuTriList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            BC_HDDieuTriList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
