using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMThuoc_KhoKhoaDTList : BusinessListBase<DMThuoc_KhoKhoaDTList, DMThuoc_KhoKhoaDT>
    {
        #region Factory Methods
        ////public static DMThuoc_KhoKhoaDTList GetAllDMThuoc_KhoKhoaDT(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMThuoc_KhoKhoaDTList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        //public static DMThuoc_KhoKhoaDTList FindDMThuoc_KhoKhoaDTByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMThuoc_KhoKhoaDTList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMThuoc_KhoKhoaDTList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMThuoc_KhoKhoaDTList>(new CriteriaOther(1, MaChungLoai));
        //}
        public DMThuoc_KhoKhoaDT NewTo()
        {
            DMThuoc_KhoKhoaDT obj = DMThuoc_KhoKhoaDT.NewDMThuoc_KhoKhoaDT();
            return obj;
        }
        public void   NewTo(DMThuoc_KhoKhoaDT _DMThuoc_KhoKhoaDT)
        {
           
            try
            {
                if (!Contains(_DMThuoc_KhoKhoaDT.MaThuoc, _DMThuoc_KhoKhoaDT.Makhoa, _DMThuoc_KhoKhoaDT.madt ,_DMThuoc_KhoKhoaDT.huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMThuoc_KhoKhoaDT.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMThuoc_KhoKhoaDT);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMThuoc_KhoKhoaDT.STT = ++_count;
                        this.Add(_DMThuoc_KhoKhoaDT);
                    }
                    else
                    {
                        _DMThuoc_KhoKhoaDT.STT = 1;
                        this.Add(_DMThuoc_KhoKhoaDT);

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
        public void UpdatedTo(DMThuoc_KhoKhoaDT _DMThuoc_KhoKhoaDT)
        {

            _DMThuoc_KhoKhoaDT.STT = this.Items[this.IndexOf(_DMThuoc_KhoKhoaDT)].STT;
            this.Items[this.IndexOf(_DMThuoc_KhoKhoaDT)] = _DMThuoc_KhoKhoaDT;
        }
        public void RemoveTo(DMThuoc_KhoKhoaDT _DMThuoc_KhoKhoaDT)
        {
            this.Items.Remove(_DMThuoc_KhoKhoaDT);

        }
        public DMThuoc_KhoKhoaDT  AssignTo(DMThuoc_KhoKhoaDT  _DMThuoc_KhoKhoaDT)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMThuoc_KhoKhoaDT.STT = ++_count;
                this.Add(_DMThuoc_KhoKhoaDT);
            }
            else
            {
                _DMThuoc_KhoKhoaDT.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMThuoc_KhoKhoaDT);
            }
            //Add(_PhieuNhap_C);
            return _DMThuoc_KhoKhoaDT;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMThuoc_KhoKhoaDT item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaThuoc, string makhoa,string madt,bool Huy)
        {
            foreach (DMThuoc_KhoKhoaDT obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.Makhoa == makhoa) && (obj.madt == madt) && (obj.huy == Huy))
                    return true;
            return false;
        }

        public DMThuoc_KhoKhoaDT GetDMThuoc_KhoKhoaDTById(string makho, decimal stt, string makhoa, string madt)
        {
            foreach (DMThuoc_KhoKhoaDT item in this)
                if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa) && (item.madt == madt))
                    return item;
            return null;
        }
        public void Remove(string makho, int stt, string makhoa, string madt)
        {
            foreach (DMThuoc_KhoKhoaDT  item in this)
            {
                if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa) && (item.madt == madt))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            DMThuoc_KhoKhoaDT item = DMThuoc_KhoKhoaDT.NewDMThuoc_KhoKhoaDT();
            Add(item);
            return item;
        }

        public static DMThuoc_KhoKhoaDTList GetAllDMThuoc_KhoKhoaDT(String makho, String makhoa, String madt)
        {
            return DataPortal.Fetch<DMThuoc_KhoKhoaDTList>(new Criteria(makho, makhoa,madt));
        }

        private DMThuoc_KhoKhoaDTList()
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
            private String _MaKho;
            private String _madt;
          
            private String _MaKhoa;
            private Boolean _qadmin = false ;
            public String MaKho
            {
                get
                {
                    return _MaKho;
                }
            }
            public String madt
            {
                get
                {
                    return _MaKho;
                }
            }
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String mMakho, String mMakhoa, String mmadt)
            {
                _MaKho  = mMakho  ;
                _MaKhoa = mMakhoa;
                _MaKho = mMakho;
            
                
            }
        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuoc_KhoKhoa(criteria.MaKho, criteria.MaKhoa,criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(DMThuoc_KhoKhoaDT.GetDMThuoc_KhoKhoaDT(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMThuoc_KhoKhoaDT item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMThuoc_KhoKhoaDT item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMThuoc_KhoKhoaDTList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMThuoc_KhoKhoaDTList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
