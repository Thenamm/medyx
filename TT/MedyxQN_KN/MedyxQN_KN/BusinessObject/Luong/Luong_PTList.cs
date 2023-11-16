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
    public class Luong_PTList : BusinessListBase<Luong_PTList, Luong_PT>
    {
        #region Factory Methods
        //private static Luong_PTList _list;
        public static Luong_PTList GetAllLuong_PT(DateTime Thang,  String maKhoa, Byte maVaiTro,  String dk)
        {
            return DataPortal.Fetch<Luong_PTList>(new Criteria( Thang,   maKhoa,maVaiTro ,   dk));
        }
        public static bool CheckLuong_PT(DateTime Thang, String maKhoa,byte mavaitro, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_PT(Thang, maKhoa, mavaitro, dk,false )))
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
        //public static Luong_PTList FindLuong_PTByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_PTList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static Luong_PTList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<Luong_PTList>(new CriteriaOther(1, MaChungLoai));
        //}
        public Luong_PT NewTo()
        {
            Luong_PT obj = Luong_PT.NewLuong_PT();
            return obj;
        }
        public void   NewTo(Luong_PT _Luong_PT)
        {
           
            try
            {
                //if (!Contains(_Luong_PT.MaNV, System.Convert.ToDateTime(_Luong_PT.Thang), _Luong_PT.Huy))
                //{
                    if (this.Items.Count > 0)
                    {
                        //_Luong_PT.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_Luong_PT);
                        int _count = 0;
                        _Luong_PT.OrderNumber = ++_count;
                        this.Add(_Luong_PT);
                        
                    }
                    else
                    {
                        _Luong_PT.OrderNumber = 1;
                        this.Add(_Luong_PT);

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
        public void UpdatedTo(Luong_PT _Luong_PT)
        {

            _Luong_PT.OrderNumber = this.Items[this.IndexOf(_Luong_PT)].OrderNumber;
            this.Items[this.IndexOf(_Luong_PT)] = _Luong_PT;
        }
        public void RemoveTo(Luong_PT _Luong_PT)
        {
            this.Items.Remove(_Luong_PT);

        }
        public Luong_PT  AssignTo(Luong_PT  _Luong_PT)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _Luong_PT.OrderNumber = ++_count;
                this.Add(_Luong_PT);
            }
            else
            {
                _Luong_PT.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_Luong_PT);
            }
            //Add(_PhieuNhap_C);
            return _Luong_PT;
        }

        //public void Remove(int id)
        //{
        //    foreach (Luong_PT item in this)
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
            foreach (Luong_PT obj in this)
                if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public Luong_PT GetTo(string MaNV)
        {
            foreach (Luong_PT obj in this)
                if ((obj.MaNV == MaNV) )
                    return obj;
            return null;
        }
        //public Luong_PT GetLuong_PTById(string MaBC, string ma)
        //{
        //    foreach (Luong_PT item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        public void Remove(string MaNV)
        {
            foreach (Luong_PT  item in this)
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
            Luong_PT item = Luong_PT.NewLuong_PT();
            Add(item);
            return item;
        }

        public Luong_PTList DeleteCache()
        {
            return null;
        }

        private Luong_PTList()
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
            private byte _MaVaitro;

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
            public byte MaVaitro
            {
                get
                {
                    return _MaVaitro;
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
            public Criteria(DateTime Thang, String mMaKhoa,byte mMaVaitro, String mDK)
            {
                _MaKhoa  = mMaKhoa  ;
                _Thang = Thang;
                _DK = mDK ;
                _MaVaitro = mMaVaitro;
                
            }
        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindLuong_PT(criteria.Thang, criteria.MaKhoa,criteria.MaVaitro  , criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(Luong_PT.GetLuong_PT(dr,i));
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
            //foreach (Luong_PT item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (Luong_PT item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override Luong_PTList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            Luong_PTList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
