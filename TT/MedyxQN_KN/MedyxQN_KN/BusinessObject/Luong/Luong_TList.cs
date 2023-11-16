using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////

namespace HTC.Business.Luong
{
    [Serializable()]
    public class Luong_TList : BusinessListBase<Luong_TList, Luong_T>
    {
        #region Factory Methods
        //private static Luong_TList _list;
        public static Luong_TList GetAllLuong_T(DateTime Thang,  String maKhoa, String dk)
        {
            return DataPortal.Fetch<Luong_TList>(new Criteria( Thang,   maKhoa,  dk));
        }
        public static bool CheckLuong_T(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_T(Thang, maKhoa, dk,false )))
            {
                if (dr.Read())
                {
                    if (!dr.GetSmartDate("Thang", true).IsEmpty)
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }
        // tim theo dieu kien ten
        //public static Luong_TList FindLuong_TByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_TList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static Luong_TList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_TList>(new CriteriaOther(1, MaChungLoai));
        //}
        public Luong_T NewTo()
        {
            Luong_T obj = Luong_T.NewLuong_T();
            return obj;
        }
        public void   NewTo(Luong_T _Luong_T)
        {
           
            try
            {
                //if (!Contains(_Luong_T.MaNV, System.Convert.ToDateTime(_Luong_T.Thang), _Luong_T.Huy))
                //{
                    if (this.Items.Count > 0)
                    {
                        //_Luong_T.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_Luong_T);
                        int _count = 0;
                        _Luong_T.OrderNumber = ++_count;
                        this.Add(_Luong_T);
                        
                    }
                    else
                    {
                        _Luong_T.OrderNumber = 1;
                        this.Add(_Luong_T);

                    }
                //}
                //else
                //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
        public void UpdatedTo(Luong_T _Luong_T)
        {

            _Luong_T.OrderNumber = this.Items[this.IndexOf(_Luong_T)].OrderNumber;
            this.Items[this.IndexOf(_Luong_T)] = _Luong_T;
        }
        public void RemoveTo(Luong_T _Luong_T)
        {
            this.Items.Remove(_Luong_T);

        }
        public Luong_T  AssignTo(Luong_T  _Luong_T)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _Luong_T.OrderNumber = ++_count;
                this.Add(_Luong_T);
            }
            else
            {
                _Luong_T.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_Luong_T);
            }
            //Add(_PhieuNhap_C);
            return _Luong_T;
        }

        //public void Remove(int id)
        //{
        //    foreach (Luong_T item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaNV, DateTime thang,  bool Huy)
        {
            foreach (Luong_T obj in this)
                if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        //public Luong_T GetLuong_TById(string MaBC, string ma)
        //{
        //    foreach (Luong_T item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        public void Remove(string MaNV)
        {
            foreach (Luong_T  item in this)
            {
                if (item.MaNV == MaNV) 
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            Luong_T item = Luong_T.NewLuong_T();
            Add(item);
            return item;
        }

        public Luong_TList DeleteCache()
        {
            return null;
        }

        private Luong_TList()
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
            private String _MaKhoa;
            private String _DK;
            private Boolean _qadmin = false ;
            private DateTime _Thang;

            public DateTime  Thang
            {
                get
                {
                    return _Thang;
                }
            }
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
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
            public Criteria(DateTime Thang, String mMaKhoa, String mDK)
            {
                _MaKhoa  = mMaKhoa  ;
                _Thang = Thang;
                _DK = mDK ;
                
            }
        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_T(criteria.Thang, criteria.MaKhoa, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(Luong_T.GetLuong_T(dr,i));
                    i++;
                }
                //_list = this;
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            //DeletedList.Clear();
            //foreach (Luong_T item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (Luong_T item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override Luong_TList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            Luong_TList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
