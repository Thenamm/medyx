using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//

namespace HTC.Business.Luong
{
    [Serializable()]
    public class Luong_NgheList : BusinessListBase<Luong_NgheList, Luong_Nghe>
    {
        #region Factory Methods
        //private static Luong_NgheList _list;
        public static Luong_NgheList GetAllLuong_Nghe(DateTime Thang, String maKhoa, String dk)
        {
            return DataPortal.Fetch<Luong_NgheList>(new Criteria(Thang, maKhoa, dk));
        }
        public static bool CheckLuong_Nghe(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_Nghe(Thang, maKhoa, dk,false )))
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
        //public static Luong_NgheList FindLuong_NgheByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_NgheList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static Luong_NgheList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_NgheList>(new CriteriaOther(1, MaChungLoai));
        //}
        public Luong_Nghe NewTo()
        {
            Luong_Nghe obj = Luong_Nghe.NewLuong_Nghe();
            return obj;
        }
        public void NewTo(Luong_Nghe _Luong_Nghe)
        {

            try
            {
                //if (!Contains(_Luong_Nghe.MaNV, System.Convert.ToDateTime(_Luong_Nghe.Thang), _Luong_Nghe.Huy))
                //{
                if (this.Items.Count > 0)
                {
                    //_Luong_Nghe.STT = this.Items[this.Count - 1].STT + 1;
                    //this.Add(_Luong_Nghe);
                    int _count = 0;
                    _Luong_Nghe.OrderNumber = ++_count;
                    this.Add(_Luong_Nghe);

                }
                else
                {
                    _Luong_Nghe.OrderNumber = 1;
                    this.Add(_Luong_Nghe);

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
        public void UpdatedTo(Luong_Nghe _Luong_Nghe)
        {

            _Luong_Nghe.OrderNumber = this.Items[this.IndexOf(_Luong_Nghe)].OrderNumber;
            this.Items[this.IndexOf(_Luong_Nghe)] = _Luong_Nghe;
        }
        public void RemoveTo(Luong_Nghe _Luong_Nghe)
        {
            this.Items.Remove(_Luong_Nghe);

        }
        public Luong_Nghe AssignTo(Luong_Nghe _Luong_Nghe)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _Luong_Nghe.OrderNumber = ++_count;
                this.Add(_Luong_Nghe);
            }
            else
            {
                _Luong_Nghe.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_Luong_Nghe);
            }
            //Add(_PhieuNhap_C);
            return _Luong_Nghe;
        }

        //public void Remove(int id)
        //{
        //    foreach (Luong_Nghe item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaNV, DateTime thang, bool Huy)
        {
            foreach (Luong_Nghe obj in this)
                if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang) == thang) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        //public Luong_Nghe GetLuong_NgheById(string MaBC, string ma)
        //{
        //    foreach (Luong_Nghe item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        public void Remove(string MaNV)
        {
            foreach (Luong_Nghe item in this)
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
            Luong_Nghe item = Luong_Nghe.NewLuong_Nghe();
            Add(item);
            return item;
        }

        public Luong_NgheList DeleteCache()
        {
            return null;
        }

        private Luong_NgheList()
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

            public DateTime Thang
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
                _MaKhoa = mMaKhoa;
                _Thang = Thang;
                _DK = mDK;

            }
        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_Nghe(criteria.Thang, criteria.MaKhoa, criteria.DK,false )))
            {
                while (dr.Read())
                {

                    this.Add(Luong_Nghe.GetLuong_Nghe(dr, i));
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
            //foreach (Luong_Nghe item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (Luong_Nghe item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override Luong_NgheList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            Luong_NgheList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
