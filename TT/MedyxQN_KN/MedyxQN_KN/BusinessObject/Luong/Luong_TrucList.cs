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
    public class Luong_TrucList : BusinessListBase<Luong_TrucList, Luong_Truc>
    {
        #region Factory Methods
        //private static Luong_TrucList _list;
        public static Luong_TrucList GetAllLuong_Truc(DateTime Thang,  String maKhoa, String dk)
        {
            return DataPortal.Fetch<Luong_TrucList>(new Criteria( Thang,   maKhoa,  dk));
        }
        public static bool CheckLuong_Truc(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_Truc(Thang, maKhoa, dk,false )))
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
        //public static Luong_TrucList FindLuong_TrucByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_TrucList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static Luong_TrucList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_TrucList>(new CriteriaOther(1, MaChungLoai));
        //}
        public Luong_Truc NewTo()
        {
            Luong_Truc obj = Luong_Truc.NewLuong_Truc();
            return obj;
        }
        public void   NewTo(Luong_Truc _Luong_Truc)
        {
           
            try
            {
                //if (!Contains(_Luong_Truc.MaNV, System.Convert.ToDateTime(_Luong_Truc.Thang), _Luong_Truc.Huy))
                //{
                    if (this.Items.Count > 0)
                    {
                        //_Luong_Truc.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_Luong_Truc);
                        int _count = 0;
                        _Luong_Truc.OrderNumber = ++_count;
                        this.Add(_Luong_Truc);
                        
                    }
                    else
                    {
                        _Luong_Truc.OrderNumber = 1;
                        this.Add(_Luong_Truc);

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
        public void UpdatedTo(Luong_Truc _Luong_Truc)
        {

            _Luong_Truc.OrderNumber = this.Items[this.IndexOf(_Luong_Truc)].OrderNumber;
            this.Items[this.IndexOf(_Luong_Truc)] = _Luong_Truc;
        }
        public void RemoveTo(Luong_Truc _Luong_Truc)
        {
            this.Items.Remove(_Luong_Truc);

        }
        public Luong_Truc  AssignTo(Luong_Truc  _Luong_Truc)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _Luong_Truc.OrderNumber = ++_count;
                this.Add(_Luong_Truc);
            }
            else
            {
                _Luong_Truc.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_Luong_Truc);
            }
            //Add(_PhieuNhap_C);
            return _Luong_Truc;
        }

        //public void Remove(int id)
        //{
        //    foreach (Luong_Truc item in this)
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
            foreach (Luong_Truc obj in this)
                if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        //public Luong_Truc GetLuong_TrucById(string MaBC, string ma)
        //{
        //    foreach (Luong_Truc item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        public void Remove(string MaNV)
        {
            foreach (Luong_Truc  item in this)
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
            Luong_Truc item = Luong_Truc.NewLuong_Truc();
            Add(item);
            return item;
        }

        public Luong_TrucList DeleteCache()
        {
            return null;
        }

        private Luong_TrucList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_Truc(criteria.Thang, criteria.MaKhoa, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(Luong_Truc.GetLuong_Truc(dr,i));
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
            //foreach (Luong_Truc item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (Luong_Truc item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override Luong_TrucList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            Luong_TrucList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
