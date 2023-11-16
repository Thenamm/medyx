using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//using System.Windows.Forms;
 
namespace HTC.Business.CNK
{
    [Serializable()]
    public class NKTonKhoaList : BusinessListBase<NKTonKhoaList, NKTonKhoa>
    {
        #region Factory Methods
        public static NKTonKhoaList GetAllNKTonKhoa(DateTime thang, string makhoa, String dk)
        {
            return DataPortal.Fetch<NKTonKhoaList>(new Criteria(thang, makhoa,dk));
        }

        public static NKTonKhoaList GetAllNKTonKhoaH(DateTime thang, string makhoa, String dk)
        {
            return DataPortal.Fetch<NKTonKhoaList>(new OtherCriteria(thang.AddDays(0 - thang.Day + 1), thang.AddMonths(1).AddDays(0 - thang.Day), makhoa, dk));
        }
        public NKTonKhoa NewTo()
        {
            NKTonKhoa obj = NKTonKhoa.NewNKTonKhoa();
            return obj;
        }
        public void   NewTo(NKTonKhoa _NKTonKhoa)
        {
           
            try
            {
                if (!Contains(_NKTonKhoa.Makhoa, _NKTonKhoa.MaVT, Convert.ToDateTime  (_NKTonKhoa.Thang) ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_NKTonKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_NKTonKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _NKTonKhoa.OrderNumber = ++_count;
                        this.Add(_NKTonKhoa);
                    }
                    else
                    {
                        _NKTonKhoa.OrderNumber = 1;
                        this.Add(_NKTonKhoa);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public void UpdatedTo(NKTonKhoa _NKTonKhoa)
        {

            _NKTonKhoa.OrderNumber = this.Items[this.IndexOf(_NKTonKhoa)].OrderNumber;
            this.Items[this.IndexOf(_NKTonKhoa)] = _NKTonKhoa;
        }
        public void RemoveTo(NKTonKhoa _NKTonKhoa)
        {
            this.Items.Remove(_NKTonKhoa);

        }
        public NKTonKhoa  AssignTo(NKTonKhoa  _NKTonKhoa)//add mot hang PhieuNhap_C
        {
             try
            {
                if (!Contains(_NKTonKhoa.Makhoa, _NKTonKhoa.MaVT, Convert.ToDateTime  (_NKTonKhoa.Thang) ))
                {
                    if (this.Items.Count > 0)
                    {
                        Byte _count = 0;
                        _count = (Byte)this.Items.Count;
                        _NKTonKhoa.OrderNumber = ++_count;
                        this.Add(_NKTonKhoa);
                    }
                    else
                    {
                        _NKTonKhoa.OrderNumber = 1;
                        this.Add(_NKTonKhoa);
                    }
                   
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            return _NKTonKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (NKTonKhoa item in this)
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
            foreach (NKTonKhoa obj in this)
                if ((obj.MaVT == mathuoc) && (obj.Makhoa == makhoa) && (Convert.ToDateTime(obj.Thang) == thang))
                    return true;
            return false;
        }

        public NKTonKhoa GetNKTonKhoaById(DateTime  thang, string makhoa, string mathuoc)
        {
            foreach (NKTonKhoa item in this)
                if ((Convert.ToDateTime(item.Thang) == thang) && (item.MaVT == mathuoc) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makhoa, string mathuoc, DateTime thang)
        {
            foreach (NKTonKhoa  item in this)
            {
                if ((item.MaVT == mathuoc) && (Convert.ToDateTime(item.Thang) == thang ) && (item.Makhoa == makhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            NKTonKhoa item = NKTonKhoa.NewNKTonKhoa();
            Add(item);
            return item;
        }

       

        private NKTonKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNKTonKhoa(criteria.Thang, criteria.MaKhoa,criteria.DK      )))
            
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(NKTonKhoa.GetNKTonKhoa(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNKTonKhoaH(criteria.TuThang, criteria.DenThang, criteria.MaKhoa, criteria.DK)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(NKTonKhoa.GetNKTonKhoa(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            //foreach (NKTonKhoa item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (NKTonKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override NKTonKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save NKTonKhoaList");
            foreach (NKTonKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            //NKTonKhoaList result;
            //result = base.Save();
           return this;
        }


        #endregion
    }
}
