using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.Duoc
{
    [Serializable()]
    public class TonKhoa_BNList : BusinessListBase<TonKhoa_BNList, TonKhoa_BN>
    {
        #region Factory Methods
        public static TonKhoa_BNList NewList()
        {
            return DataPortal.Fetch<TonKhoa_BNList>(new TemCriteria());
        }

        public static TonKhoa_BNList GetAllTonKhoa_BN(DateTime ngayyclinh, string makhoa)
        {
            return DataPortal.Fetch<TonKhoa_BNList>(new Criteria(ngayyclinh, makhoa,""));
        }
        public static TonKhoa_BNList GetAllTonKhoa_BN( string makhoa)
        {
            return DataPortal.Fetch<TonKhoa_BNList>(new Criteria(DateTime.Parse ("01/01/1900"), makhoa, ""));
        }
        public static TonKhoa_BNList GetAllTonKhoa_BN(DateTime ngayyclinh, string makhoa, DateTime ngayphat)
        {
            return DataPortal.Fetch<TonKhoa_BNList>(new Criteria(ngayyclinh, makhoa, " and datediff(n,a.ngayphat , '" + ngayphat.ToShortDateString() + "') =0"));
        }
        
       
        public TonKhoa_BN NewTo()
        {
            TonKhoa_BN obj = TonKhoa_BN.NewTonKhoa_BN();
            return obj;
        }
        public void   NewTo(TonKhoa_BN _TonKhoa_BN)
        {
           
            try
            {
                if (Contains(_TonKhoa_BN.Makhoa, _TonKhoa_BN.Mathuoc, Convert.ToDateTime  (_TonKhoa_BN.ngayyclinh) ) != null)
                {
                    if (this.Items.Count > 0)
                    {
                        //_TonKhoa_BN.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_TonKhoa_BN);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _TonKhoa_BN.OrderNumber = ++_count;
                        this.Add(_TonKhoa_BN);
                    }
                    else
                    {
                        _TonKhoa_BN.OrderNumber = 1;
                        this.Add(_TonKhoa_BN);

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
        public void UpdatedTo(TonKhoa_BN _TonKhoa_BN)
        {

            _TonKhoa_BN.OrderNumber = this.Items[this.IndexOf(_TonKhoa_BN)].OrderNumber;
            this.Items[this.IndexOf(_TonKhoa_BN)] = _TonKhoa_BN;
        }
        public void RemoveTo(TonKhoa_BN _TonKhoa_BN)
        {
            this.Items.Remove(_TonKhoa_BN);

        }
        public TonKhoa_BN  AssignTo(TonKhoa_BN  _TonKhoa_BN)//add mot hang PhieuNhap_C
        {
             try
            {
                if (!Contains(_TonKhoa_BN.Makhoa, _TonKhoa_BN.Mathuoc,_TonKhoa_BN.mapx   ))
                {
                    if (this.Items.Count > 0)
                    {
                        Byte _count = 0;
                        _count = (Byte)this.Items.Count;
                        _TonKhoa_BN.OrderNumber = ++_count;
                        this.Add(_TonKhoa_BN);
                    }
                    else
                    {
                        _TonKhoa_BN.OrderNumber = 1;
                        this.Add(_TonKhoa_BN);
                    }
                   
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
            return _TonKhoa_BN;
        }

        //public void Remove(int id)
        //{
        //    foreach (TonKhoa_BN item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public TonKhoa_BN Contains(string makhoa, string mathuoc, DateTime ngayyclinh)
        {
            foreach (TonKhoa_BN obj in this)
                if ((obj.Mathuoc == mathuoc) && (obj.Makhoa == makhoa) && (Convert.ToDateTime(obj.ngayyclinh) == ngayyclinh))
                    return obj;
            return null;
        }
        public Boolean Containss(string makhoa, string mathuoc, DateTime ngayyclinh)
        {
            foreach (TonKhoa_BN obj in this)
                if ((obj.Mathuoc == mathuoc) && (obj.Makhoa == makhoa) && (Convert.ToDateTime(obj.ngayyclinh) == ngayyclinh))
                    return true;
            return false;
        }
        public Boolean Contains(string makhoa, string mathuoc, string mapx)
        {
            foreach (TonKhoa_BN obj in this)
                if ((obj.Mathuoc == mathuoc) && (obj.Makhoa == makhoa) && (obj.mapx  == mapx ))
                    return true;
            return false;
        }
        public TonKhoa_BN Contains(string makhoa, string mathuoc)
        {
            foreach (TonKhoa_BN obj in this)
                if ((obj.Mathuoc == mathuoc) && (obj.Makhoa == makhoa) )
                    return obj;
            return null;
        }
        public Boolean Containss(string makhoa, string mathuoc)
        {
            foreach (TonKhoa_BN obj in this)
                if ((obj.Mathuoc == mathuoc) && (obj.Makhoa == makhoa))
                    return true;
            return false;
        }

        public TonKhoa_BN GetTonKhoa_BNById(DateTime  ngayyclinh, string makhoa, string mathuoc)
        {
            foreach (TonKhoa_BN item in this)
                if ((Convert.ToDateTime(item.ngayyclinh) == ngayyclinh) && (item.Mathuoc == mathuoc) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public TonKhoa_BN GetTonKhoa_BNById( string makhoa, string mathuoc)
        {
            foreach (TonKhoa_BN item in this)
                if ( (item.Mathuoc == mathuoc) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makhoa, string mathuoc, DateTime ngayyclinh)
        {
            foreach (TonKhoa_BN  item in this)
            {
                if ((item.Mathuoc == mathuoc) && (Convert.ToDateTime(item.ngayyclinh) == ngayyclinh ) && (item.Makhoa == makhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            TonKhoa_BN item = TonKhoa_BN.NewTonKhoa_BN();
            Add(item);
            return item;
        }

        public TonKhoa_BN GetTo(decimal STT) //
        {
            foreach (TonKhoa_BN obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;

        }

        private TonKhoa_BNList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllTonKhoa_BN(criteria.MaKhoa,criteria.DK      )))
            
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(TonKhoa_BN.GetTonKhoa_BN(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            //foreach (TonKhoa_BN item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (TonKhoa_BN item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override TonKhoa_BNList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save TonKhoa_BNList");
            foreach (TonKhoa_BN item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            //TonKhoa_BNList result;
            //result = base.Save();
           return this;
        }


        #endregion
    }
}
