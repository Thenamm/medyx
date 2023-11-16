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
    public class HCTonKhoaList : BusinessListBase<HCTonKhoaList, HCTonKhoa>
    {
        #region Factory Methods
        public static HCTonKhoaList GetAllHCTonKhoa(DateTime thang, string makhoa, String dk)
        {
            return DataPortal.Fetch<HCTonKhoaList>(new Criteria(thang, makhoa,dk));
        }

        public static HCTonKhoaList GetAllHCTonKhoaH(DateTime thang, string makhoa, String dk)
        {
            return DataPortal.Fetch<HCTonKhoaList>(new OtherCriteria(thang.AddDays(0 - thang.Day + 1), thang.AddMonths(1).AddDays(0 - thang.Day), makhoa, dk));
        }

        public HCTonKhoa NewTo()
        {
            HCTonKhoa obj = HCTonKhoa.NewHCTonKhoa();
            return obj;
        }
        public void   NewTo(HCTonKhoa _HCTonKhoa)
        {
           
            try
            {
                if (!Contains(_HCTonKhoa.Makhoa, _HCTonKhoa.MaHC, Convert.ToDateTime  (_HCTonKhoa.Thang) ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_HCTonKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_HCTonKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _HCTonKhoa.OrderNumber = ++_count;
                        this.Add(_HCTonKhoa);
                    }
                    else
                    {
                        _HCTonKhoa.OrderNumber = 1;
                        this.Add(_HCTonKhoa);

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
        public void UpdatedTo(HCTonKhoa _HCTonKhoa)
        {

            _HCTonKhoa.OrderNumber = this.Items[this.IndexOf(_HCTonKhoa)].OrderNumber;
            this.Items[this.IndexOf(_HCTonKhoa)] = _HCTonKhoa;
        }
        public void RemoveTo(HCTonKhoa _HCTonKhoa)
        {
            this.Items.Remove(_HCTonKhoa);

        }
        public HCTonKhoa  AssignTo(HCTonKhoa  _HCTonKhoa)//add mot hang PhieuNhap_C
        {
             try
            {
                if (!Contains(_HCTonKhoa.Makhoa, _HCTonKhoa.MaHC, Convert.ToDateTime  (_HCTonKhoa.Thang) ))
                {
                    if (this.Items.Count > 0)
                    {
                        Byte _count = 0;
                        _count = (Byte)this.Items.Count;
                        _HCTonKhoa.OrderNumber = ++_count;
                        this.Add(_HCTonKhoa);
                    }
                    else
                    {
                        _HCTonKhoa.OrderNumber = 1;
                        this.Add(_HCTonKhoa);
                    }
                   
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
            return _HCTonKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (HCTonKhoa item in this)
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
            foreach (HCTonKhoa obj in this)
                if ((obj.MaHC == mathuoc) && (obj.Makhoa == makhoa) && (Convert.ToDateTime(obj.Thang) == thang))
                    return true;
            return false;
        }

        public HCTonKhoa GetHCTonKhoaById(DateTime  thang, string makhoa, string mathuoc)
        {
            foreach (HCTonKhoa item in this)
                if ((Convert.ToDateTime(item.Thang) == thang) && (item.MaHC == mathuoc) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makhoa, string mathuoc, DateTime thang)
        {
            foreach (HCTonKhoa  item in this)
            {
                if ((item.MaHC == mathuoc) && (Convert.ToDateTime(item.Thang) == thang ) && (item.Makhoa == makhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            HCTonKhoa item = HCTonKhoa.NewHCTonKhoa();
            Add(item);
            return item;
        }

       

        private HCTonKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHCTonKhoa(criteria.Thang, criteria.MaKhoa,criteria.DK      )))
            
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(HCTonKhoa.GetHCTonKhoa(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHCTonKhoaH(criteria.TuThang, criteria.DenThang, criteria.MaKhoa, criteria.DK)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(HCTonKhoa.GetHCTonKhoa(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (HCTonKhoa item in DeletedList)
            {
                item.DeleteSelf(item);
            }

            DeletedList.Clear();

            foreach (HCTonKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override HCTonKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save HCTonKhoaList");
            foreach (HCTonKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            //HCTonKhoaList result;
            //result = base.Save();
           return this;
        }


        #endregion
    }
}
