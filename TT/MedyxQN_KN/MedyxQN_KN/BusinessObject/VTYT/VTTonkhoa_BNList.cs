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
    public class VTTonKhoa_BNList : BusinessListBase<VTTonKhoa_BNList, VTTonKhoa_BN>
    {
        #region Factory Methods
        public static VTTonKhoa_BNList NewList()
        {
            return DataPortal.Fetch<VTTonKhoa_BNList>(new TemCriteria());
        }
        public static VTTonKhoa_BNList GetAllVTTonKhoa_BN(DateTime ngayyclinh, string makhoa)
        {
            return DataPortal.Fetch<VTTonKhoa_BNList>(new Criteria(ngayyclinh, makhoa,""));
        }
        public static VTTonKhoa_BNList GetAllVTTonKhoa_BN( string makhoa)
        {
            return DataPortal.Fetch<VTTonKhoa_BNList>(new Criteria(DateTime.Parse ("01/01/1900"), makhoa, ""));
        }
        public static VTTonKhoa_BNList GetAllVTTonKhoa_BN(DateTime ngayyclinh, string makhoa, DateTime ngayphat)
        {
            return DataPortal.Fetch<VTTonKhoa_BNList>(new Criteria(ngayyclinh, makhoa, " and datediff(n,a.ngayphat , '" + ngayphat.ToShortDateString() + "') =0"));
        }
        
       
        public VTTonKhoa_BN NewTo()
        {
            VTTonKhoa_BN obj = VTTonKhoa_BN.NewVTTonKhoa_BN();
            return obj;
        }
        public void   NewTo(VTTonKhoa_BN _VTTonKhoa_BN)
        {
           
            try
            {
                if (!Contains(_VTTonKhoa_BN.Makhoa, _VTTonKhoa_BN.MaVT, Convert.ToDateTime  (_VTTonKhoa_BN.ngayyclinh) ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_VTTonKhoa_BN.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_VTTonKhoa_BN);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _VTTonKhoa_BN.OrderNumber = ++_count;
                        this.Add(_VTTonKhoa_BN);
                    }
                    else
                    {
                        _VTTonKhoa_BN.OrderNumber = 1;
                        this.Add(_VTTonKhoa_BN);

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
        public void UpdatedTo(VTTonKhoa_BN _VTTonKhoa_BN)
        {

            _VTTonKhoa_BN.OrderNumber = this.Items[this.IndexOf(_VTTonKhoa_BN)].OrderNumber;
            this.Items[this.IndexOf(_VTTonKhoa_BN)] = _VTTonKhoa_BN;
        }
        public void RemoveTo(VTTonKhoa_BN _VTTonKhoa_BN)
        {
            this.Items.Remove(_VTTonKhoa_BN);

        }
        public VTTonKhoa_BN  AssignTo(VTTonKhoa_BN  _VTTonKhoa_BN)//add mot hang PhieuNhap_C
        {
             try
            {
                if (!Contains(_VTTonKhoa_BN.Makhoa, _VTTonKhoa_BN.MaVT, _VTTonKhoa_BN.mapx))
                {
                    if (this.Items.Count > 0)
                    {
                        Byte _count = 0;
                        _count = (Byte)this.Items.Count;
                        _VTTonKhoa_BN.OrderNumber = ++_count;
                        this.Add(_VTTonKhoa_BN);
                    }
                    else
                    {
                        _VTTonKhoa_BN.OrderNumber = 1;
                        this.Add(_VTTonKhoa_BN);
                    }
                   
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
            return _VTTonKhoa_BN;
        }

        //public void Remove(int id)
        //{
        //    foreach (VTTonKhoa_BN item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string makhoa, string MaVT, DateTime ngayyclinh)
        {
            foreach (VTTonKhoa_BN obj in this)
                if ((obj.MaVT == MaVT) && (obj.Makhoa == makhoa) && (Convert.ToDateTime(obj.ngayyclinh) == ngayyclinh))
                    return true;
            return false;
        }
        public bool Contains(string makhoa, string maVT, string mapx)
        {
            foreach (VTTonKhoa_BN obj in this)
                if ((obj.MaVT == maVT) && (obj.Makhoa == makhoa) && (obj.mapx == mapx))
                    return true;
            return false;
        }
        public bool Contains(string makhoa, string MaVT)
        {
            foreach (VTTonKhoa_BN obj in this)
                if ((obj.MaVT == MaVT) && (obj.Makhoa == makhoa) )
                    return true;
            return false;
        }
        public VTTonKhoa_BN Containss(string makhoa, string mathuoc)
        {
            foreach (VTTonKhoa_BN obj in this)
                if ((obj.MaVT == mathuoc) && (obj.Makhoa == makhoa))
                    return obj;
            return null;
        }

        public VTTonKhoa_BN GetVTTonKhoa_BNById(DateTime  ngayyclinh, string makhoa, string MaVT)
        {
            foreach (VTTonKhoa_BN item in this)
                if ((Convert.ToDateTime(item.ngayyclinh) == ngayyclinh) && (item.MaVT == MaVT) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public VTTonKhoa_BN GetVTTonKhoa_BNById( string makhoa, string MaVT)
        {
            foreach (VTTonKhoa_BN item in this)
                if ( (item.MaVT == MaVT) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makhoa, string MaVT, DateTime ngayyclinh)
        {
            foreach (VTTonKhoa_BN  item in this)
            {
                if ((item.MaVT == MaVT) && (Convert.ToDateTime(item.ngayyclinh) == ngayyclinh ) && (item.Makhoa == makhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            VTTonKhoa_BN item = VTTonKhoa_BN.NewVTTonKhoa_BN();
            Add(item);
            return item;
        }

        public VTTonKhoa_BN GetTo(decimal STT) //
        {
            foreach (VTTonKhoa_BN obj in this)
                if (obj.OrderNumber == STT)
                    return obj;
            return null;

        }

        private VTTonKhoa_BNList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVTTonKhoa_BN(criteria.MaKhoa,criteria.DK      )))
            
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(VTTonKhoa_BN.GetVTTonKhoa_BN(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            //foreach (VTTonKhoa_BN item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (VTTonKhoa_BN item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override VTTonKhoa_BNList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save VTTonKhoa_BNList");
            foreach (VTTonKhoa_BN item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }
            //VTTonKhoa_BNList result;
            //result = base.Save();
           return this;
        }


        #endregion
    }
}
