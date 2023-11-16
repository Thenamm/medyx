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
    public class DMChePhamMau_KhoKhoaList : BusinessListBase<DMChePhamMau_KhoKhoaList, DMChePhamMau_KhoKhoa>
    {
        #region Factory Methods
        public static DMChePhamMau_KhoKhoaList NewList()
        {
            return DataPortal.Fetch<DMChePhamMau_KhoKhoaList>(new TemCriteria());
        }
        ////public static DMChePhamMau_KhoKhoaList GetAllDMChePhamMau_KhoKhoa(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMChePhamMau_KhoKhoaList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        //public static DMChePhamMau_KhoKhoaList FindDMChePhamMau_KhoKhoaByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMChePhamMau_KhoKhoaList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMChePhamMau_KhoKhoaList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMChePhamMau_KhoKhoaList>(new CriteriaOther(1, MaChungLoai));
        //}
        public DMChePhamMau_KhoKhoa NewTo() {
            DMChePhamMau_KhoKhoa obj = DMChePhamMau_KhoKhoa.NewDMChePhamMau_KhoKhoa();
            return obj;
        }
        public void NewTo(DMChePhamMau_KhoKhoa _DMChePhamMau_KhoKhoa)
        {
            try
            {
                if (!Contains(_DMChePhamMau_KhoKhoa.maCPMau, _DMChePhamMau_KhoKhoa.Makhoa,_DMChePhamMau_KhoKhoa.huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMChePhamMau_KhoKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMChePhamMau_KhoKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMChePhamMau_KhoKhoa.STT = ++_count;
                        this.Add(_DMChePhamMau_KhoKhoa);
                    }
                    else
                    {
                        _DMChePhamMau_KhoKhoa.STT = 1;
                        this.Add(_DMChePhamMau_KhoKhoa);

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
        public void UpdatedTo(DMChePhamMau_KhoKhoa _DMChePhamMau_KhoKhoa)
        {

            _DMChePhamMau_KhoKhoa.STT = this.Items[this.IndexOf(_DMChePhamMau_KhoKhoa)].STT;
            this.Items[this.IndexOf(_DMChePhamMau_KhoKhoa)] = _DMChePhamMau_KhoKhoa;
        }
        public void RemoveTo(DMChePhamMau_KhoKhoa _DMChePhamMau_KhoKhoa)
        {
            this.Items.Remove(_DMChePhamMau_KhoKhoa);

        }
        public DMChePhamMau_KhoKhoa  AssignTo(DMChePhamMau_KhoKhoa  _DMChePhamMau_KhoKhoa)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMChePhamMau_KhoKhoa.STT = ++_count;
                this.Add(_DMChePhamMau_KhoKhoa);
            }
            else
            {
                _DMChePhamMau_KhoKhoa.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMChePhamMau_KhoKhoa);
            }
            //Add(_PhieuNhap_C);
            return _DMChePhamMau_KhoKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMChePhamMau_KhoKhoa item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string maCPMau, string makhoa,bool Huy)
        {
            foreach (DMChePhamMau_KhoKhoa obj in this)
                if ((obj.maCPMau == maCPMau) && (obj.Makhoa == makhoa)&&(obj.huy ==Huy ) )
                    return true;
            return false;
        }

        public DMChePhamMau_KhoKhoa GetDMChePhamMau_KhoKhoaById(string makho, decimal stt, string makhoa)
        {
            foreach (DMChePhamMau_KhoKhoa item in this)
                if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makho, int stt,string makhoa)
        {
            foreach (DMChePhamMau_KhoKhoa  item in this)
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
            DMChePhamMau_KhoKhoa item = DMChePhamMau_KhoKhoa.NewDMChePhamMau_KhoKhoa();
            Add(item);
            return item;
        }

        public static DMChePhamMau_KhoKhoaList GetAllDMChePhamMau_KhoKhoa(String makho, String makhoa)
        {
            return DataPortal.Fetch<DMChePhamMau_KhoKhoaList>(new Criteria(makho, makhoa));
        }

        private DMChePhamMau_KhoKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMChePhamMau_KhoKhoa(criteria.MaKho, criteria.MaKhoa,criteria.qadmin      )))
            {
                while (dr.Read())
                {
                    this.Add(DMChePhamMau_KhoKhoa.GetDMChePhamMau_KhoKhoa(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMChePhamMau_KhoKhoa item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMChePhamMau_KhoKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMChePhamMau_KhoKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMChePhamMau_KhoKhoaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
