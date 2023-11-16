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
    public class Luong_M2List : BusinessListBase<Luong_M2List, Luong_M2>
    {
        #region Factory Methods
        //private static Luong_M2List _list;
        public static Luong_M2List GetAllLuong_M2(DateTime Thang,  String maKhoa, String dk)
        {
            return DataPortal.Fetch<Luong_M2List>(new Criteria( Thang,   maKhoa,  dk));
        }
        public static bool CheckLuong_M2(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_M2(Thang, maKhoa, dk,false )))
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
        //public static Luong_M2List FindLuong_M2ByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_M2List>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static Luong_M2List FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_M2List>(new CriteriaOther(1, MaChungLoai));
        //}
        public Luong_M2 NewTo()
        {
            Luong_M2 obj = Luong_M2.NewLuong_M2();
            return obj;
        }
        public void   NewTo(Luong_M2 _Luong_M2)
        {
           
            try
            {
                //if (!Contains(_Luong_M2.MaNV, System.Convert.ToDateTime(_Luong_M2.Thang), _Luong_M2.Huy))
                //{
                    if (this.Items.Count > 0)
                    {
                        //_Luong_M2.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_Luong_M2);
                        int _count = 0;
                        _Luong_M2.OrderNumber = ++_count;
                        this.Add(_Luong_M2);
                        
                    }
                    else
                    {
                        _Luong_M2.OrderNumber = 1;
                        this.Add(_Luong_M2);

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
        public void UpdatedTo(Luong_M2 _Luong_M2)
        {

            _Luong_M2.OrderNumber = this.Items[this.IndexOf(_Luong_M2)].OrderNumber;
            this.Items[this.IndexOf(_Luong_M2)] = _Luong_M2;
        }
        public void RemoveTo(Luong_M2 _Luong_M2)
        {
            this.Items.Remove(_Luong_M2);

        }
        public Luong_M2  AssignTo(Luong_M2  _Luong_M2)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _Luong_M2.OrderNumber = ++_count;
                this.Add(_Luong_M2);
            }
            else
            {
                _Luong_M2.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_Luong_M2);
            }
            //Add(_PhieuNhap_C);
            return _Luong_M2;
        }

        //public void Remove(int id)
        //{
        //    foreach (Luong_M2 item in this)
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
            foreach (Luong_M2 obj in this)
                if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        //public Luong_M2 GetLuong_M2ById(string MaBC, string ma)
        //{
        //    foreach (Luong_M2 item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        public void Remove(string MaNV)
        {
            foreach (Luong_M2  item in this)
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
            Luong_M2 item = Luong_M2.NewLuong_M2();
            Add(item);
            return item;
        }

        public Luong_M2List DeleteCache()
        {
            return null;
        }

        private Luong_M2List()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_M2(criteria.Thang, criteria.MaKhoa, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(Luong_M2.GetLuong_M2(dr,i));
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
            //foreach (Luong_M2 item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (Luong_M2 item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override Luong_M2List Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            Luong_M2List result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
