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
    public class Luong_DocHaiList : BusinessListBase<Luong_DocHaiList, Luong_DocHai>
    {
        #region Factory Methods
        //private static Luong_DocHaiList _list;
        public static Luong_DocHaiList GetAllLuong_DocHai(DateTime Thang,  String maKhoa, String dk)
        {
            return DataPortal.Fetch<Luong_DocHaiList>(new Criteria( Thang,   maKhoa,  dk));
        }
        public static bool CheckLuong_DocHai(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_DocHai(Thang, maKhoa, dk)))
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
        //public static Luong_DocHaiList FindLuong_DocHaiByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_DocHaiList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static Luong_DocHaiList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_DocHaiList>(new CriteriaOther(1, MaChungLoai));
        //}
        public Luong_DocHai NewTo()
        {
            Luong_DocHai obj = Luong_DocHai.NewLuong_DocHai();
            return obj;
        }
        public void   NewTo(Luong_DocHai _Luong_DocHai)
        {
           
            try
            {
                //if (!Contains(_Luong_DocHai.MaNV, System.Convert.ToDateTime(_Luong_DocHai.Thang), _Luong_DocHai.Huy))
                //{
                    if (this.Items.Count > 0)
                    {
                        //_Luong_DocHai.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_Luong_DocHai);
                        int _count = 0;
                        _Luong_DocHai.OrderNumber = ++_count;
                        this.Add(_Luong_DocHai);
                        
                    }
                    else
                    {
                        _Luong_DocHai.OrderNumber = 1;
                        this.Add(_Luong_DocHai);

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
        public void UpdatedTo(Luong_DocHai _Luong_DocHai)
        {

            _Luong_DocHai.OrderNumber = this.Items[this.IndexOf(_Luong_DocHai)].OrderNumber;
            this.Items[this.IndexOf(_Luong_DocHai)] = _Luong_DocHai;
        }
        public void RemoveTo(Luong_DocHai _Luong_DocHai)
        {
            this.Items.Remove(_Luong_DocHai);

        }
        public Luong_DocHai  AssignTo(Luong_DocHai  _Luong_DocHai)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _Luong_DocHai.OrderNumber = ++_count;
                this.Add(_Luong_DocHai);
            }
            else
            {
                _Luong_DocHai.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_Luong_DocHai);
            }
            //Add(_PhieuNhap_C);
            return _Luong_DocHai;
        }

        //public void Remove(int id)
        //{
        //    foreach (Luong_DocHai item in this)
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
            foreach (Luong_DocHai obj in this)
                if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public Luong_DocHai GetTo(string MaNV)
        {
            foreach (Luong_DocHai obj in this)
                if ((obj.MaNV == MaNV))
                    return obj;
            return null;
        }
        //public Luong_DocHai GetLuong_DocHaiById(string MaBC, string ma)
        //{
        //    foreach (Luong_DocHai item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        public void Remove(string MaNV)
        {
            foreach (Luong_DocHai  item in this)
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
            Luong_DocHai item = Luong_DocHai.NewLuong_DocHai();
            Add(item);
            return item;
        }

        public Luong_DocHaiList DeleteCache()
        {
            return null;
        }

        private Luong_DocHaiList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_DocHai(criteria.Thang, criteria.MaKhoa, criteria.DK)))
            {
                while (dr.Read())
                {
                    
                    this.Add(Luong_DocHai.GetLuong_DocHai(dr,i));
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
            //foreach (Luong_DocHai item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (Luong_DocHai item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override Luong_DocHaiList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            Luong_DocHaiList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
