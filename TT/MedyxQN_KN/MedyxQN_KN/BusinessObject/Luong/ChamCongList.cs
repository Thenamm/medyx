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
    public class ChamCongList : BusinessListBase<ChamCongList, ChamCong>
    {
        #region Factory Methods
        //private static ChamCongList _list;
        public static ChamCongList GetAllChamCong(DateTime Thang,  String maKhoa, String dk)
        {
            return DataPortal.Fetch<ChamCongList>(new Criteria( Thang,   maKhoa,  dk));
        }
        public static bool CheckChamcong(DateTime Thang, String maKhoa, String dk)
        {
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllChamCong(Thang, maKhoa, dk,false )))
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
        public void TinhCongTruc(int stt)
        {
            foreach (ChamCong item in this)
            {

                if (item.STT == stt)
                {
                    //if ((item.Phep != 0) || (item.Om != 0) || (item.ThaiSan != 0) || (item.NghiBu !=0)|| (item.NghiKhongLuong !=0)|| (item.NganHan  !=0)|| (item.DaiHan !=0)|| (item.NuocNgoai !=0)|| (item.HocBongNuocNgoai !=0));
                    //item.CongThuc = item
                    break;
                }
            }
        }
        // tim theo dieu kien ten
        //public static ChamCongList FindChamCongByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<ChamCongList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static ChamCongList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<ChamCongList>(new CriteriaOther(1, MaChungLoai));
        //}
        public ChamCong NewTo()
        {
            ChamCong obj = ChamCong.NewChamCong();
            return obj;
        }
        public void   NewTo(ChamCong _ChamCong)
        {
           
            try
            {
                //if (!Contains(_ChamCong.MaNV, System.Convert.ToDateTime(_ChamCong.Thang), _ChamCong.Huy))
                //{
                    if (this.Items.Count > 0)
                    {
                        //_ChamCong.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_ChamCong);
                        int _count = 0;
                        _ChamCong.OrderNumber = ++_count;
                        this.Add(_ChamCong);
                        
                    }
                    else
                    {
                        _ChamCong.OrderNumber = 1;
                        this.Add(_ChamCong);

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
        public void UpdatedTo(ChamCong _ChamCong)
        {

            _ChamCong.OrderNumber = this.Items[this.IndexOf(_ChamCong)].OrderNumber;
            this.Items[this.IndexOf(_ChamCong)] = _ChamCong;
        }
        public void RemoveTo(ChamCong _ChamCong)
        {
            this.Items.Remove(_ChamCong);

        }
        public ChamCong  AssignTo(ChamCong  _ChamCong)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                int _count = 0;
                _count = this.Items.Count;
                _ChamCong.OrderNumber = ++_count;
                this.Add(_ChamCong);
            }
            else
            {
                _ChamCong.OrderNumber = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_ChamCong);
            }
            //Add(_PhieuNhap_C);
            return _ChamCong;
        }

        //public void Remove(int id)
        //{
        //    foreach (ChamCong item in this)
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
            foreach (ChamCong obj in this)
                if ((obj.MaNV == MaNV) && (System.Convert.ToDateTime(obj.Thang)  == thang) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        //public ChamCong GetChamCongById(string MaBC, string ma)
        //{
        //    foreach (ChamCong item in this)
        //        if ((item.MaBC == MaBC) && (item.Ma == ma))
        //            return item;
        //    return null;
        //}
        public void Remove(string MaNV)
        {
            foreach (ChamCong  item in this)
            {
                if (item.MaNV == MaNV) 
                {
                    Remove(item);
                    break;
                }
            }
        }
        public ChamCong GetTo(decimal STT)
        {
            foreach (ChamCong obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            ChamCong item = ChamCong.NewChamCong();
            Add(item);
            return item;
        }

        public ChamCongList DeleteCache()
        {
            return null;
        }

        private ChamCongList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllChamCong(criteria.Thang, criteria.MaKhoa, criteria.DK,false )))
            {
                while (dr.Read())
                {
                    
                    this.Add(ChamCong.GetChamCong(dr,i));
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
            //foreach (ChamCong item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (ChamCong item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override ChamCongList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized saving");

            ChamCongList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
