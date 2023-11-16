using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//

namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCTonKhoa_BNList : BusinessListBase<HCTonKhoa_BNList, HCTonKhoa_BN>
    {
        #region Factory Methods
        public static HCTonKhoa_BNList NewList()
        {
            return DataPortal.Fetch<HCTonKhoa_BNList>(new TemCriteria());
        }
        public static HCTonKhoa_BNList GetAllHCTonKhoa_BN(DateTime ngayyclinh, string makhoa)
        {
            return DataPortal.Fetch<HCTonKhoa_BNList>(new Criteria(ngayyclinh, makhoa,""));
        }
        public static HCTonKhoa_BNList GetAllHCTonKhoa_BN( string makhoa)
        {
            return DataPortal.Fetch<HCTonKhoa_BNList>(new Criteria(DateTime.Parse ("01/01/1900"), makhoa, ""));
        }
        public static HCTonKhoa_BNList GetAllHCTonKhoa_BN(DateTime ngayyclinh, string makhoa, DateTime ngayphat)
        {
            return DataPortal.Fetch<HCTonKhoa_BNList>(new Criteria(ngayyclinh, makhoa, " and datediff(n,a.ngayphat , '" + ngayphat.ToShortDateString() + "') =0"));
        }
        
       
        public HCTonKhoa_BN NewTo()
        {
            HCTonKhoa_BN obj = HCTonKhoa_BN.NewHCTonKhoa_BN();
            return obj;
        }
        public void   NewTo(HCTonKhoa_BN _HCTonKhoa_BN)
        {
           
            try
            {
                if (!Contains(_HCTonKhoa_BN.Makhoa, _HCTonKhoa_BN.MaHC, Convert.ToDateTime  (_HCTonKhoa_BN.ngayyclinh) ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_HCTonKhoa_BN.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_HCTonKhoa_BN);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _HCTonKhoa_BN.OrderNumber = ++_count;
                        this.Add(_HCTonKhoa_BN);
                    }
                    else
                    {
                        _HCTonKhoa_BN.OrderNumber = 1;
                        this.Add(_HCTonKhoa_BN);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }
        public void UpdatedTo(HCTonKhoa_BN _HCTonKhoa_BN)
        {

            _HCTonKhoa_BN.OrderNumber = this.Items[this.IndexOf(_HCTonKhoa_BN)].OrderNumber;
            this.Items[this.IndexOf(_HCTonKhoa_BN)] = _HCTonKhoa_BN;
        }
        public void RemoveTo(HCTonKhoa_BN _HCTonKhoa_BN)
        {
            this.Items.Remove(_HCTonKhoa_BN);

        }
        public HCTonKhoa_BN  AssignTo(HCTonKhoa_BN  _HCTonKhoa_BN)//add mot hang PhieuNhap_C
        {
             try
            {
                if (!Contains(_HCTonKhoa_BN.Makhoa, _HCTonKhoa_BN.MaHC, _HCTonKhoa_BN.mapx))
                {
                    if (this.Items.Count > 0)
                    {
                        Byte _count = 0;
                        _count = (Byte)this.Items.Count;
                        _HCTonKhoa_BN.OrderNumber = ++_count;
                        this.Add(_HCTonKhoa_BN);
                    }
                    else
                    {
                        _HCTonKhoa_BN.OrderNumber = 1;
                        this.Add(_HCTonKhoa_BN);
                    }
                   
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
            return _HCTonKhoa_BN;
        }

        //public void Remove(int id)
        //{
        //    foreach (HCTonKhoa_BN item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string makhoa, string maHC, DateTime ngayyclinh)
        {
            foreach (HCTonKhoa_BN obj in this)
                if ((obj.MaHC == maHC) && (obj.Makhoa == makhoa) && (Convert.ToDateTime(obj.ngayyclinh) == ngayyclinh))
                    return true;
            return false;
        }
        public bool Contains(string makhoa, string maHC, string mapx)
        {
            foreach (HCTonKhoa_BN obj in this)
                if ((obj.MaHC == maHC) && (obj.Makhoa == makhoa) && (obj.mapx ==mapx ))
                    return true;
            return false;
        }
        public bool Contains(string makhoa, string maHC)
        {
            foreach (HCTonKhoa_BN obj in this)
                if ((obj.MaHC == maHC) && (obj.Makhoa == makhoa) )
                    return true;
            return false;
        }
        public HCTonKhoa_BN Containss(string makhoa, string mathuoc)
        {
            foreach (HCTonKhoa_BN obj in this)
                if ((obj.MaHC == mathuoc) && (obj.Makhoa == makhoa))
                    return obj;
            return null;
        }
        public HCTonKhoa_BN GetHCTonKhoa_BNById(DateTime  ngayyclinh, string makhoa, string maHC)
        {
            foreach (HCTonKhoa_BN item in this)
                if ((Convert.ToDateTime(item.ngayyclinh) == ngayyclinh) && (item.MaHC == maHC) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public HCTonKhoa_BN GetHCTonKhoa_BNById( string makhoa, string maHC)
        {
            foreach (HCTonKhoa_BN item in this)
                if ( (item.MaHC == maHC) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makhoa, string maHC, DateTime ngayyclinh)
        {
            foreach (HCTonKhoa_BN  item in this)
            {
                if ((item.MaHC == maHC) && (Convert.ToDateTime(item.ngayyclinh) == ngayyclinh ) && (item.Makhoa == makhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            HCTonKhoa_BN item = HCTonKhoa_BN.NewHCTonKhoa_BN();
            Add(item);
            return item;
        }

        public HCTonKhoa_BN GetTo(decimal STT) //
        {
            foreach (HCTonKhoa_BN obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;

        }

        private HCTonKhoa_BNList()
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
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class Criteria
        {
            private DateTime _ngayyclinh;
            private String _DK;
            private String _MaKhoa;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            public DateTime  ngayyclinh
            {
                get
                {
                    return _ngayyclinh;
                }
            }
            public Criteria(DateTime mngayyclinh, String mMakhoa, String dk)
            {
                if  (mngayyclinh > DateTime.Parse ("01/01/1900")) 
                {
                    _DK = _DK + " and datediff(d,a.ngayyclinh,'"+ mngayyclinh.ToShortDateString() +"') = 0"; 
                }
                else
                    _DK = _DK + " and a.ngayyclinh is null"; 
                _DK  = dk  ;
                _MaKhoa = mMakhoa;
                
            }
        }

        private class OtherCriteria
        {
            private DateTime _Tungayyclinh;
            private DateTime _Denngayyclinh;
            private String _DK;
            private String _MaKhoa;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            public DateTime Tungayyclinh
            {
                get
                {
                    return _Tungayyclinh;
                }
            }
            public DateTime Denngayyclinh
            {
                get
                {
                    return _Denngayyclinh;
                }
            }
            public OtherCriteria(DateTime mTungayyclinh, DateTime mDenngayyclinh, String mMakhoa, String dk)
            {
                _Tungayyclinh = mTungayyclinh;
                _Denngayyclinh = mDenngayyclinh;
                _DK = dk ;
                _MaKhoa = mMakhoa;

            }
        }
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHCTonKhoa_BN(criteria.MaKhoa,criteria.DK      )))
            
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(HCTonKhoa_BN.GetHCTonKhoa_BN(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            //foreach (HCTonKhoa_BN item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (HCTonKhoa_BN item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override HCTonKhoa_BNList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save HCTonKhoa_BNList");
            foreach (HCTonKhoa_BN item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            //HCTonKhoa_BNList result;
            //result = base.Save();
           return this;
        }


        #endregion
    }
}
