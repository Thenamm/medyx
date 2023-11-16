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
    public class DMHoaChat_KhoKhoaList : BusinessListBase<DMHoaChat_KhoKhoaList, DMHoaChat_KhoKhoa>
    {
        #region Factory Methods
        ////public static DMHoaChat_KhoKhoaList GetAllDMHoaChat_KhoKhoa(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMHoaChat_KhoKhoaList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        //public static DMHoaChat_KhoKhoaList FindDMHoaChat_KhoKhoaByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMHoaChat_KhoKhoaList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMHoaChat_KhoKhoaList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMHoaChat_KhoKhoaList>(new CriteriaOther(1, MaChungLoai));
        //}
        public static DMHoaChat_KhoKhoaList NewList()
        {
            return DataPortal.Fetch<DMHoaChat_KhoKhoaList>(new TemCriteria());
        }
        public DMHoaChat_KhoKhoa NewTo() {
            DMHoaChat_KhoKhoa obj = DMHoaChat_KhoKhoa.NewDMHoaChat_KhoKhoa();
            return obj;
        }
        public void NewTo(DMHoaChat_KhoKhoa _DMHoaChat_KhoKhoa)
        {
            try
            {
                if (!Contains(_DMHoaChat_KhoKhoa.MaHC, _DMHoaChat_KhoKhoa.Makhoa,_DMHoaChat_KhoKhoa.huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMHoaChat_KhoKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMHoaChat_KhoKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMHoaChat_KhoKhoa.STT = ++_count;
                        this.Add(_DMHoaChat_KhoKhoa);
                    }
                    else
                    {
                        _DMHoaChat_KhoKhoa.STT = 1;
                        this.Add(_DMHoaChat_KhoKhoa);

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
        public void UpdatedTo(DMHoaChat_KhoKhoa _DMHoaChat_KhoKhoa)
        {

            _DMHoaChat_KhoKhoa.STT = this.Items[this.IndexOf(_DMHoaChat_KhoKhoa)].STT;
            this.Items[this.IndexOf(_DMHoaChat_KhoKhoa)] = _DMHoaChat_KhoKhoa;
        }
        public void RemoveTo(DMHoaChat_KhoKhoa _DMHoaChat_KhoKhoa)
        {
            this.Items.Remove(_DMHoaChat_KhoKhoa);

        }
        public DMHoaChat_KhoKhoa  AssignTo(DMHoaChat_KhoKhoa  _DMHoaChat_KhoKhoa)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMHoaChat_KhoKhoa.STT = ++_count;
                this.Add(_DMHoaChat_KhoKhoa);
            }
            else
            {
                _DMHoaChat_KhoKhoa.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMHoaChat_KhoKhoa);
            }
            //Add(_PhieuNhap_C);
            return _DMHoaChat_KhoKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMHoaChat_KhoKhoa item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaHC, string makhoa,bool Huy)
        {
            foreach (DMHoaChat_KhoKhoa obj in this)
                if ((obj.MaHC == MaHC) && (obj.Makhoa == makhoa)&&(obj.huy ==Huy ) )
                    return true;
            return false;
        }

        public DMHoaChat_KhoKhoa GetDMHoaChat_KhoKhoaById(string makho, decimal stt, string makhoa)
        {
            foreach (DMHoaChat_KhoKhoa item in this)
                if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makho, int stt,string makhoa)
        {
            foreach (DMHoaChat_KhoKhoa  item in this)
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
            DMHoaChat_KhoKhoa item = DMHoaChat_KhoKhoa.NewDMHoaChat_KhoKhoa();
            Add(item);
            return item;
        }

        public static DMHoaChat_KhoKhoaList GetAllDMHoaChat_KhoKhoa(String makho, String makhoa)
        {
            return DataPortal.Fetch<DMHoaChat_KhoKhoaList>(new Criteria(makho, makhoa));
        }

        private DMHoaChat_KhoKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMHoaChat_KhoKhoa(criteria.MaKho, criteria.MaKhoa,criteria.qadmin      )))
            {
                while (dr.Read())
                {
                    this.Add(DMHoaChat_KhoKhoa.GetDMHoaChat_KhoKhoa(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMHoaChat_KhoKhoa item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMHoaChat_KhoKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMHoaChat_KhoKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMHoaChat_KhoKhoaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
