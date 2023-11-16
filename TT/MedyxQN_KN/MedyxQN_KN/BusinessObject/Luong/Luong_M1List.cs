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
    public class Luong_M1List : BusinessListBase<Luong_M1List, Luong_M1>
    {
        #region Factory Methods
        //private static Luong_M1List _list;
        public static Luong_M1List GetAllLuong_M1(DateTime Thang,  String maKhoa, String dk)
        {
            return DataPortal.Fetch<Luong_M1List>(new Criteria( Thang,   maKhoa,  dk));
        }
        public static bool CheckLuong_M1(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_M1(Thang, maKhoa, dk,false )))
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
        //public static Luong_M1List FindLuong_M1ByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_M1List>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static Luong_M1List FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_M1List>(new CriteriaOther(1, MaChungLoai));
        //}
        public Luong_M1 NewTo()
        {
            Luong_M1 obj = Luong_M1.NewLuong_M1();
            return obj;
        }
        public void   NewTo(Luong_M1 _Luong_M1)
        {
           
            try
            {
                //if (!Contains(_Luong_M1.MaNV, System.Convert.ToDateTime(_Luong_M1.Thang), _Luong_M1.Huy))
                //{
                    if (this.Items.Count > 0)
                    {
                        //_Luong_M1.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_Luong_M1);
                        int _count = 0;
                        _Luong_M1.OrderNumber = ++_count;
                        this.Add(_Luong_M1);
                        
                    }
                    else
                    {
                        _Luong_M1.OrderNumber = 1;
                        this.Add(_Luong_M1);

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
        public void UpdatedTo(Luong_M1 _Luong_M1)
        {

            _Luong_M1.OrderNumber = this.Items[this.IndexOf(_Luong_M1)].OrderNumber;
            this.Items[this.IndexOf(_Luong_M1)] = _Luong_M1;
        }
        public void RemoveTo(Luong_M1 _Luong_M1)
        {
            this.Items.Remove(_Luong_M1);

        }
        public Luong_M1  AssignTo(Luong_M1  _Luong_M1)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _Luong_M1.OrderNumber = ++_count;
                this.Add(_Luong_M1);
            }
            else
            {
                _Luong_M1.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_Luong_M1);
            }
            //Add(_PhieuNhap_C);
            return _Luong_M1;
        }

        //public void Remove(int id)
        //{
        //    foreach (Luong_M1 item in this)
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
            foreach (Luong_M1 obj in this)
                if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public Luong_M1 GetTo(string MaNV)
        {
            foreach (Luong_M1 obj in this)
                if ((obj.MaNV == MaNV))
                    return obj;
            return null;
        }
        public void Remove(string MaNV)
        {
            foreach (Luong_M1  item in this)
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
            Luong_M1 item = Luong_M1.NewLuong_M1();
            Add(item);
            return item;
        }

        public Luong_M1List DeleteCache()
        {
            return null;
        }

        private Luong_M1List()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_M1(criteria.Thang, criteria.MaKhoa, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(Luong_M1.GetLuong_M1(dr,i));
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
            //foreach (Luong_M1 item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (Luong_M1 item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override Luong_M1List Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            Luong_M1List result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
