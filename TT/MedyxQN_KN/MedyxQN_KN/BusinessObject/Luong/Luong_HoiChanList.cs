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
    public class Luong_HoiChanList : BusinessListBase<Luong_HoiChanList, Luong_HoiChan>
    {
        #region Factory Methods
        //private static Luong_HoiChanList _list;
        public static Luong_HoiChanList GetAllLuong_HoiChan(DateTime Thang,  String maKhoa, String dk)
        {
            return DataPortal.Fetch<Luong_HoiChanList>(new Criteria( Thang,   maKhoa,  dk));
        }
        public static bool CheckLuong_HoiChan(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_HoiChan(Thang, maKhoa, dk,false )))
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
        //public static Luong_HoiChanList FindLuong_HoiChanByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_HoiChanList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static Luong_HoiChanList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_HoiChanList>(new CriteriaOther(1, MaChungLoai));
        //}
        public Luong_HoiChan NewTo()
        {
            Luong_HoiChan obj = Luong_HoiChan.NewLuong_HoiChan();
            return obj;
        }
        public void   NewTo(Luong_HoiChan _Luong_HoiChan)
        {
           
            try
            {
                //if (!Contains(_Luong_HoiChan.MaNV, System.Convert.ToDateTime(_Luong_HoiChan.Thang), _Luong_HoiChan.Huy))
                //{
                    if (this.Items.Count > 0)
                    {
                        //_Luong_HoiChan.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_Luong_HoiChan);
                        int _count = 0;
                        _Luong_HoiChan.OrderNumber = ++_count;
                        this.Add(_Luong_HoiChan);
                        
                    }
                    else
                    {
                        _Luong_HoiChan.OrderNumber = 1;
                        this.Add(_Luong_HoiChan);

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
        public void UpdatedTo(Luong_HoiChan _Luong_HoiChan)
        {

            _Luong_HoiChan.OrderNumber = this.Items[this.IndexOf(_Luong_HoiChan)].OrderNumber;
            this.Items[this.IndexOf(_Luong_HoiChan)] = _Luong_HoiChan;
        }
        public void RemoveTo(Luong_HoiChan _Luong_HoiChan)
        {
            this.Items.Remove(_Luong_HoiChan);

        }
        public Luong_HoiChan  AssignTo(Luong_HoiChan  _Luong_HoiChan)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _Luong_HoiChan.OrderNumber = ++_count;
                this.Add(_Luong_HoiChan);
            }
            else
            {
                _Luong_HoiChan.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_Luong_HoiChan);
            }
            //Add(_PhieuNhap_C);
            return _Luong_HoiChan;
        }

        //public void Remove(int id)
        //{
        //    foreach (Luong_HoiChan item in this)
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
            foreach (Luong_HoiChan obj in this)
                if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public Luong_HoiChan GetTo(string MaNV)
        {
            foreach (Luong_HoiChan obj in this)
                if ((obj.MaNV == MaNV))
                    return obj;
            return null;
        }
        //public Luong_HoiChan GetLuong_HoiChanById(string MaBC, string ma)
        //{
        //    foreach (Luong_HoiChan item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        public void Remove(string MaNV)
        {
            foreach (Luong_HoiChan  item in this)
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
            Luong_HoiChan item = Luong_HoiChan.NewLuong_HoiChan();
            Add(item);
            return item;
        }

        public Luong_HoiChanList DeleteCache()
        {
            return null;
        }

        private Luong_HoiChanList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_HoiChan(criteria.Thang, criteria.MaKhoa, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(Luong_HoiChan.GetLuong_HoiChan(dr,i));
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
            //foreach (Luong_HoiChan item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (Luong_HoiChan item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override Luong_HoiChanList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            Luong_HoiChanList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
