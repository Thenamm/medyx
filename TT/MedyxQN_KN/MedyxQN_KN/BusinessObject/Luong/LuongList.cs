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
    public class LuongList : BusinessListBase<LuongList, Luong>
    {
        #region Factory Methods
        //private static LuongList _list;
        public static LuongList GetAllLuong(DateTime Thang,  String maKhoa, String dk)
        {
            return DataPortal.Fetch<LuongList>(new Criteria( Thang,   maKhoa,  dk));
        }
        public static bool CheckLuong(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong(Thang, maKhoa, dk,false )))
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
        //public static LuongList FindLuongByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<LuongList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static LuongList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<LuongList>(new CriteriaOther(1, MaChungLoai));
        //}
        public Luong NewTo()
        {
            Luong obj = Luong.NewLuong();
            return obj;
        }
        public void   NewTo(Luong _Luong)
        {
           
            try
            {
                //if (!Contains(_Luong.MaNV, System.Convert.ToDateTime(_Luong.Thang), _Luong.Huy))
                //{
                    if (this.Items.Count > 0)
                    {
                        //_Luong.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_Luong);
                        int _count = 0;
                        _Luong.OrderNumber = ++_count;
                        this.Add(_Luong);
                        
                    }
                    else
                    {
                        _Luong.OrderNumber = 1;
                        this.Add(_Luong);

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
        public void UpdatedTo(Luong _Luong)
        {

            _Luong.OrderNumber = this.Items[this.IndexOf(_Luong)].OrderNumber;
            this.Items[this.IndexOf(_Luong)] = _Luong;
        }
        public void RemoveTo(Luong _Luong)
        {
            this.Items.Remove(_Luong);

        }
        public Luong  AssignTo(Luong  _Luong)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _Luong.OrderNumber = ++_count;
                this.Add(_Luong);
            }
            else
            {
                _Luong.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_Luong);
            }
            //Add(_PhieuNhap_C);
            return _Luong;
        }

        //public void Remove(int id)
        //{
        //    foreach (Luong item in this)
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
            foreach (Luong obj in this)
                if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        //public Luong GetLuongById(string MaBC, string ma)
        //{
        //    foreach (Luong item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        public void Remove(string MaNV)
        {
            foreach (Luong  item in this)
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
            Luong item = Luong.NewLuong();
            Add(item);
            return item;
        }

        public LuongList DeleteCache()
        {
            return null;
        }

        private LuongList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong(criteria.Thang, criteria.MaKhoa, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(Luong.GetLuong(dr,i));
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
            //foreach (Luong item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (Luong item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override LuongList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            LuongList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
