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
    public class TonKhoaList : BusinessListBase<TonKhoaList, TonKhoa>
    {
        #region Factory Methods
        public static TonKhoaList GetAllTonKhoa(DateTime thang, string makhoa, String dk)
        {
            return DataPortal.Fetch<TonKhoaList>(new Criteria(thang, makhoa,dk));
        }


        public static TonKhoaList GetAllTonKhoaH(DateTime thang, string makhoa, String dk)
        {
            return DataPortal.Fetch<TonKhoaList>(new OtherCriteria(thang.AddDays(0-thang.Day+1)  , thang.AddMonths(1).AddDays(0-thang.Day) , makhoa, dk));
        }


        public TonKhoa NewTo()
        {
            TonKhoa obj = TonKhoa.NewTonKhoa();
            return obj;
        }
        public void   NewTo(TonKhoa _TonKhoa)
        {
           
            try
            {
                if (!Contains(_TonKhoa.Makhoa, _TonKhoa.Mathuoc, Convert.ToDateTime  (_TonKhoa.Thang) ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_TonKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_TonKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _TonKhoa.OrderNumber = ++_count;
                        this.Add(_TonKhoa);
                    }
                    else
                    {
                        _TonKhoa.OrderNumber = 1;
                        this.Add(_TonKhoa);

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
        public void UpdatedTo(TonKhoa _TonKhoa)
        {

            _TonKhoa.OrderNumber = this.Items[this.IndexOf(_TonKhoa)].OrderNumber;
            this.Items[this.IndexOf(_TonKhoa)] = _TonKhoa;
        }
        public void RemoveTo(TonKhoa _TonKhoa)
        {
            this.Items.Remove(_TonKhoa);

        }
        public TonKhoa  AssignTo(TonKhoa  _TonKhoa)//add mot hang PhieuNhap_C
        {
             try
            {
                if (!Contains(_TonKhoa.Makhoa, _TonKhoa.Mathuoc, Convert.ToDateTime  (_TonKhoa.Thang) ))
                {
                    if (this.Items.Count > 0)
                    {
                        Byte _count = 0;
                        _count = (Byte)this.Items.Count;
                        _TonKhoa.OrderNumber = ++_count;
                        this.Add(_TonKhoa);
                    }
                    else
                    {
                        _TonKhoa.OrderNumber = 1;
                        this.Add(_TonKhoa);
                    }
                   
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
            return _TonKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (TonKhoa item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string makhoa, string mathuoc, DateTime thang)
        {
            foreach (TonKhoa obj in this)
                if ((obj.Mathuoc == mathuoc) && (obj.Makhoa == makhoa) && (Convert.ToDateTime(obj.Thang) == thang))
                    return true;
            return false;
        }

        public TonKhoa GetTonKhoaById(DateTime  thang, string makhoa, string mathuoc)
        {
            foreach (TonKhoa item in this)
                if ((Convert.ToDateTime(item.Thang) == thang) && (item.Mathuoc == mathuoc) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makhoa, string mathuoc, DateTime thang)
        {
            foreach (TonKhoa  item in this)
            {
                if ((item.Mathuoc == mathuoc) && (Convert.ToDateTime(item.Thang) == thang ) && (item.Makhoa == makhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            TonKhoa item = TonKhoa.NewTonKhoa();
            Add(item);
            return item;
        }

       

        private TonKhoaList()
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
            private DateTime _Thang;
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
            public DateTime  Thang
            {
                get
                {
                    return _Thang;
                }
            }
            public Criteria(DateTime mThang, String mMakhoa, String dk)
            {
                _Thang = mThang ;
                _DK  = dk  ;
                _MaKhoa = mMakhoa;
                
            }
        }

        private class OtherCriteria
        {
            private DateTime _TuThang;
            private DateTime _DenThang;
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
            public DateTime TuThang
            {
                get
                {
                    return _TuThang;
                }
            }
            public DateTime DenThang
            {
                get
                {
                    return _DenThang;
                }
            }
            public OtherCriteria(DateTime mTuThang, DateTime mDenThang, String mMakhoa, String dk)
            {
                _TuThang = mTuThang;
                _DenThang = mDenThang;
                _DK = dk ;
                _MaKhoa = mMakhoa;

            }
        }
        

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllTonKhoa(criteria.Thang, criteria.MaKhoa,criteria.DK      )))
            
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(TonKhoa.GetTonKhoa(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetsTonKhoaH (criteria.TuThang ,criteria.DenThang ,  criteria.MaKhoa, criteria.DK)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(TonKhoa.GetTonKhoa(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (TonKhoa item in DeletedList)
            {
                item.DeleteSelf(item);
            }

            DeletedList.Clear();

            foreach (TonKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override TonKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save TonKhoaList");
            foreach (TonKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            //TonKhoaList result;
            //result = base.Save();
           return this;
        }


        #endregion
    }
}
