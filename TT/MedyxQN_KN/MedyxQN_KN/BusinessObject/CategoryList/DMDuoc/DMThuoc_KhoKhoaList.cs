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
    public class DMThuoc_KhoKhoaList : BusinessListBase<DMThuoc_KhoKhoaList, DMThuoc_KhoKhoa>
    {
        #region Factory Methods
        ////public static DMThuoc_KhoKhoaList GetAllDMThuoc_KhoKhoa(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMThuoc_KhoKhoaList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        //public static DMThuoc_KhoKhoaList FindDMThuoc_KhoKhoaByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMThuoc_KhoKhoaList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMThuoc_KhoKhoaList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMThuoc_KhoKhoaList>(new CriteriaOther(1, MaChungLoai));
        //}
        public static DMThuoc_KhoKhoaList NewList()
        {
            return DataPortal.Fetch<DMThuoc_KhoKhoaList>(new TemCriteria());
        }
        public DMThuoc_KhoKhoa NewTo()
        {
            DMThuoc_KhoKhoa obj = DMThuoc_KhoKhoa.NewDMThuoc_KhoKhoa();
            return obj;
        }
        public void   NewTo(DMThuoc_KhoKhoa _DMThuoc_KhoKhoa)
        {
           
            try
            {
                if (!Contains(_DMThuoc_KhoKhoa.MaThuoc, _DMThuoc_KhoKhoa.Makhoa,_DMThuoc_KhoKhoa.huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMThuoc_KhoKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMThuoc_KhoKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMThuoc_KhoKhoa.STT = ++_count;
                        this.Add(_DMThuoc_KhoKhoa);
                    }
                    else
                    {
                        _DMThuoc_KhoKhoa.STT = 1;
                        this.Add(_DMThuoc_KhoKhoa);

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
        public void UpdatedTo(DMThuoc_KhoKhoa _DMThuoc_KhoKhoa)
        {

            _DMThuoc_KhoKhoa.STT = this.Items[this.IndexOf(_DMThuoc_KhoKhoa)].STT;
            this.Items[this.IndexOf(_DMThuoc_KhoKhoa)] = _DMThuoc_KhoKhoa;
        }
        public void RemoveTo(DMThuoc_KhoKhoa _DMThuoc_KhoKhoa)
        {
            this.Items.Remove(_DMThuoc_KhoKhoa);

        }
        public DMThuoc_KhoKhoa  AssignTo(DMThuoc_KhoKhoa  _DMThuoc_KhoKhoa)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMThuoc_KhoKhoa.STT = ++_count;
                this.Add(_DMThuoc_KhoKhoa);
            }
            else
            {
                _DMThuoc_KhoKhoa.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMThuoc_KhoKhoa);
            }
            //Add(_PhieuNhap_C);
            return _DMThuoc_KhoKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMThuoc_KhoKhoa item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaThuoc, string makhoa,bool Huy)
        {
            foreach (DMThuoc_KhoKhoa obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.Makhoa == makhoa)&&(obj.huy ==Huy  ) )
                    return true;
            return false;
        }

        public DMThuoc_KhoKhoa GetDMThuoc_KhoKhoaById(string makho, decimal stt, string makhoa)
        {
            foreach (DMThuoc_KhoKhoa item in this)
                if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makho, int stt,string makhoa)
        {
            foreach (DMThuoc_KhoKhoa  item in this)
            {
                if ((item.Makho == makho  ) && (item.STT == stt)&&(item .Makhoa==makhoa  ))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            DMThuoc_KhoKhoa item = DMThuoc_KhoKhoa.NewDMThuoc_KhoKhoa();
            Add(item);
            return item;
        }

        public static DMThuoc_KhoKhoaList GetAllDMThuoc_KhoKhoa(String makho, String makhoa)
        {
            return DataPortal.Fetch<DMThuoc_KhoKhoaList>(new Criteria(makho, makhoa));
        }

        private DMThuoc_KhoKhoaList()
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
            private String _MaKho;
            private String _MaKhoa;
            private Boolean _qadmin = false ;
            public String MaKho
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
            public Criteria(String mMakho, String mMakhoa)
            {
                _MaKho  = mMakho  ;
                _MaKhoa = mMakhoa;
                
            }
        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuoc_KhoKhoa(criteria.MaKho, criteria.MaKhoa,criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(DMThuoc_KhoKhoa.GetDMThuoc_KhoKhoa(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMThuoc_KhoKhoa item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMThuoc_KhoKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMThuoc_KhoKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMThuoc_KhoKhoaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
