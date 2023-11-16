using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////
 
namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTTonKhoaList : BusinessListBase<VTTonKhoaList, VTTonKhoa>
    {
        #region Factory Methods
        public static VTTonKhoaList GetAllVTTonKhoa(DateTime thang, string makhoa, String dk)
        {
            return DataPortal.Fetch<VTTonKhoaList>(new Criteria(thang, makhoa,dk));
        }

        public static VTTonKhoaList GetAllVTTonKhoaH(DateTime thang, string makhoa, String dk)
        {
            return DataPortal.Fetch<VTTonKhoaList>(new OtherCriteria(thang.AddDays(0 - thang.Day + 1), thang.AddMonths(1).AddDays(0 - thang.Day), makhoa, dk));
        }
        public VTTonKhoa NewTo()
        {
            VTTonKhoa obj = VTTonKhoa.NewVTTonKhoa();
            return obj;
        }
        public void   NewTo(VTTonKhoa _VTTonKhoa)
        {
           
            try
            {
                if (!Contains(_VTTonKhoa.Makhoa, _VTTonKhoa.MaVT, Convert.ToDateTime  (_VTTonKhoa.Thang) ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_VTTonKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_VTTonKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _VTTonKhoa.OrderNumber = ++_count;
                        this.Add(_VTTonKhoa);
                    }
                    else
                    {
                        _VTTonKhoa.OrderNumber = 1;
                        this.Add(_VTTonKhoa);

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
        public void UpdatedTo(VTTonKhoa _VTTonKhoa)
        {

            _VTTonKhoa.OrderNumber = this.Items[this.IndexOf(_VTTonKhoa)].OrderNumber;
            this.Items[this.IndexOf(_VTTonKhoa)] = _VTTonKhoa;
        }
        public void RemoveTo(VTTonKhoa _VTTonKhoa)
        {
            this.Items.Remove(_VTTonKhoa);

        }
        public VTTonKhoa  AssignTo(VTTonKhoa  _VTTonKhoa)//add mot hang PhieuNhap_C
        {
             try
            {
                if (!Contains(_VTTonKhoa.Makhoa, _VTTonKhoa.MaVT, Convert.ToDateTime  (_VTTonKhoa.Thang) ))
                {
                    if (this.Items.Count > 0)
                    {
                        Byte _count = 0;
                        _count = (Byte)this.Items.Count;
                        _VTTonKhoa.OrderNumber = ++_count;
                        this.Add(_VTTonKhoa);
                    }
                    else
                    {
                        _VTTonKhoa.OrderNumber = 1;
                        this.Add(_VTTonKhoa);
                    }
                   
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
            return _VTTonKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (VTTonKhoa item in this)
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
            foreach (VTTonKhoa obj in this)
                if ((obj.MaVT == mathuoc) && (obj.Makhoa == makhoa) && (Convert.ToDateTime(obj.Thang) == thang))
                    return true;
            return false;
        }

        public VTTonKhoa GetVTTonKhoaById(DateTime  thang, string makhoa, string mathuoc)
        {
            foreach (VTTonKhoa item in this)
                if ((Convert.ToDateTime(item.Thang) == thang) && (item.MaVT == mathuoc) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makhoa, string mathuoc, DateTime thang)
        {
            foreach (VTTonKhoa  item in this)
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
            VTTonKhoa item = VTTonKhoa.NewVTTonKhoa();
            Add(item);
            return item;
        }

       

        private VTTonKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVTTonKhoa(criteria.Thang, criteria.MaKhoa,criteria.DK      )))
            
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(VTTonKhoa.GetVTTonKhoa(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVTTonKhoaH(criteria.TuThang, criteria.DenThang, criteria.MaKhoa, criteria.DK)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(VTTonKhoa.GetVTTonKhoa(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (VTTonKhoa item in DeletedList)
            {
                item.DeleteSelf(item);
            }

            DeletedList.Clear();

            foreach (VTTonKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override VTTonKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save VTTonKhoaList");
            foreach (VTTonKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            //VTTonKhoaList result;
            //result = base.Save();
           return this;
        }


        #endregion
    }
}
