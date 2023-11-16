using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////
 
namespace HTC.Business.VPP
{
    [Serializable()]
    public class VPPTonKhoaList : BusinessListBase<VPPTonKhoaList, VPPTonKhoa>
    {
        #region Factory Methods
        public static VPPTonKhoaList GetAllVPPTonKhoa(DateTime thang, string makhoa, String dk)
        {
            return DataPortal.Fetch<VPPTonKhoaList>(new Criteria(thang, makhoa,dk));
        }

        public static VPPTonKhoaList GetAllVPPTonKhoaH(DateTime thang, string makhoa, String dk)
        {
            return DataPortal.Fetch<VPPTonKhoaList>(new OtherCriteria(thang.AddDays(0 - thang.Day + 1), thang.AddMonths(1).AddDays(0 - thang.Day), makhoa, dk));
        }
        public VPPTonKhoa NewTo()
        {
            VPPTonKhoa obj = VPPTonKhoa.NewVPPTonKhoa();
            return obj;
        }
        public void   NewTo(VPPTonKhoa _VPPTonKhoa)
        {
           
            try
            {
                if (!Contains(_VPPTonKhoa.Makhoa, _VPPTonKhoa.MaVT, Convert.ToDateTime  (_VPPTonKhoa.Thang) ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_VPPTonKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_VPPTonKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _VPPTonKhoa.OrderNumber = ++_count;
                        this.Add(_VPPTonKhoa);
                    }
                    else
                    {
                        _VPPTonKhoa.OrderNumber = 1;
                        this.Add(_VPPTonKhoa);

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
        public void UpdatedTo(VPPTonKhoa _VPPTonKhoa)
        {

            _VPPTonKhoa.OrderNumber = this.Items[this.IndexOf(_VPPTonKhoa)].OrderNumber;
            this.Items[this.IndexOf(_VPPTonKhoa)] = _VPPTonKhoa;
        }
        public void RemoveTo(VPPTonKhoa _VPPTonKhoa)
        {
            this.Items.Remove(_VPPTonKhoa);

        }
        public VPPTonKhoa  AssignTo(VPPTonKhoa  _VPPTonKhoa)//add mot hang PhieuNhap_C
        {
             try
            {
                if (!Contains(_VPPTonKhoa.Makhoa, _VPPTonKhoa.MaVT, Convert.ToDateTime  (_VPPTonKhoa.Thang) ))
                {
                    if (this.Items.Count > 0)
                    {
                        Byte _count = 0;
                        _count = (Byte)this.Items.Count;
                        _VPPTonKhoa.OrderNumber = ++_count;
                        this.Add(_VPPTonKhoa);
                    }
                    else
                    {
                        _VPPTonKhoa.OrderNumber = 1;
                        this.Add(_VPPTonKhoa);
                    }
                   
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
            return _VPPTonKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (VPPTonKhoa item in this)
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
            foreach (VPPTonKhoa obj in this)
                if ((obj.MaVT == mathuoc) && (obj.Makhoa == makhoa) && (Convert.ToDateTime(obj.Thang) == thang))
                    return true;
            return false;
        }

        public VPPTonKhoa GetVPPTonKhoaById(DateTime  thang, string makhoa, string mathuoc)
        {
            foreach (VPPTonKhoa item in this)
                if ((Convert.ToDateTime(item.Thang) == thang) && (item.MaVT == mathuoc) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makhoa, string mathuoc, DateTime thang)
        {
            foreach (VPPTonKhoa  item in this)
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
            VPPTonKhoa item = VPPTonKhoa.NewVPPTonKhoa();
            Add(item);
            return item;
        }

       

        private VPPTonKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVPPTonKhoa(criteria.Thang, criteria.MaKhoa,criteria.DK      )))
            
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(VPPTonKhoa.GetVPPTonKhoa(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVPPTonKhoaH(criteria.TuThang, criteria.DenThang, criteria.MaKhoa, criteria.DK)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(VPPTonKhoa.GetVPPTonKhoa(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            //foreach (VPPTonKhoa item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (VPPTonKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override VPPTonKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save VPPTonKhoaList");
            foreach (VPPTonKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            //VPPTonKhoaList result;
            //result = base.Save();
           return this;
        }


        #endregion
    }
}
