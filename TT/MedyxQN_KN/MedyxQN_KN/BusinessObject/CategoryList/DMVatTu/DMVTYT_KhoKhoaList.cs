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
    public class DMVTYT_KhoKhoaList : BusinessListBase<DMVTYT_KhoKhoaList, DMVTYT_KhoKhoa>
    {
        #region Factory Methods
        ////public static DMVTYT_KhoKhoaList GetAllDMVTYT_KhoKhoa(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMVTYT_KhoKhoaList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        //public static DMVTYT_KhoKhoaList FindDMVTYT_KhoKhoaByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMVTYT_KhoKhoaList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMVTYT_KhoKhoaList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMVTYT_KhoKhoaList>(new CriteriaOther(1, MaChungLoai));
        //}
        public static DMVTYT_KhoKhoaList NewList()
        {
            return DataPortal.Fetch<DMVTYT_KhoKhoaList>(new TemCriteria());
        }
        public DMVTYT_KhoKhoa NewTo() {
            DMVTYT_KhoKhoa obj = DMVTYT_KhoKhoa.NewDMVTYT_KhoKhoa();
            return obj;
        }
        public void NewTo(DMVTYT_KhoKhoa _DMVTYT_KhoKhoa)
        {
            try
            {
                if (!Contains(_DMVTYT_KhoKhoa.MaVT, _DMVTYT_KhoKhoa.Makhoa,_DMVTYT_KhoKhoa.huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMVTYT_KhoKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMVTYT_KhoKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMVTYT_KhoKhoa.STT = ++_count;
                        this.Add(_DMVTYT_KhoKhoa);
                    }
                    else
                    {
                        _DMVTYT_KhoKhoa.STT = 1;
                        this.Add(_DMVTYT_KhoKhoa);

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
        public void UpdatedTo(DMVTYT_KhoKhoa _DMVTYT_KhoKhoa)
        {

            _DMVTYT_KhoKhoa.STT = this.Items[this.IndexOf(_DMVTYT_KhoKhoa)].STT;
            this.Items[this.IndexOf(_DMVTYT_KhoKhoa)] = _DMVTYT_KhoKhoa;
        }
        public void RemoveTo(DMVTYT_KhoKhoa _DMVTYT_KhoKhoa)
        {
            this.Items.Remove(_DMVTYT_KhoKhoa);

        }
        public DMVTYT_KhoKhoa  AssignTo(DMVTYT_KhoKhoa  _DMVTYT_KhoKhoa)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMVTYT_KhoKhoa.STT = ++_count;
                this.Add(_DMVTYT_KhoKhoa);
            }
            else
            {
                _DMVTYT_KhoKhoa.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMVTYT_KhoKhoa);
            }
            //Add(_PhieuNhap_C);
            return _DMVTYT_KhoKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMVTYT_KhoKhoa item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaVT, string makhoa,bool Huy)
        {
            foreach (DMVTYT_KhoKhoa obj in this)
                if ((obj.MaVT == MaVT) && (obj.Makhoa == makhoa)&&(obj.huy == Huy ) )
                    return true;
            return false;
        }

        public DMVTYT_KhoKhoa GetDMVTYT_KhoKhoaById(string makho, decimal stt, string makhoa)
        {
            foreach (DMVTYT_KhoKhoa item in this)
                if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makho, decimal stt, string makhoa)
        {
            foreach (DMVTYT_KhoKhoa  item in this)
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
            DMVTYT_KhoKhoa item = DMVTYT_KhoKhoa.NewDMVTYT_KhoKhoa();
            Add(item);
            return item;
        }

        public static DMVTYT_KhoKhoaList GetAllDMVTYT_KhoKhoa(String makho, String makhoa)
        {
            return DataPortal.Fetch<DMVTYT_KhoKhoaList>(new Criteria(makho, makhoa));
        }

        private DMVTYT_KhoKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVTYT_KhoKhoa(criteria.MaKho, criteria.MaKhoa,criteria.qadmin      )))
            {
                while (dr.Read())
                {
                    this.Add(DMVTYT_KhoKhoa.GetDMVTYT_KhoKhoa(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMVTYT_KhoKhoa item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMVTYT_KhoKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMVTYT_KhoKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMVTYT_KhoKhoaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
