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
    public class DMTBVTYT_KhoKhoaList : BusinessListBase<DMTBVTYT_KhoKhoaList, DMTBVTYT_KhoKhoa>
    {
        #region Factory Methods
        ////public static DMTBVTYT_KhoKhoaList GetAllDMTBVTYT_KhoKhoa(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMTBVTYT_KhoKhoaList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        //public static DMTBVTYT_KhoKhoaList FindDMTBVTYT_KhoKhoaByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMTBVTYT_KhoKhoaList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMTBVTYT_KhoKhoaList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMTBVTYT_KhoKhoaList>(new CriteriaOther(1, MaChungLoai));
        //}
        public static DMTBVTYT_KhoKhoaList NewList()
        {
            return DataPortal.Fetch<DMTBVTYT_KhoKhoaList>(new TemCriteria());
        }
        public DMTBVTYT_KhoKhoa NewTo() {
            DMTBVTYT_KhoKhoa obj = DMTBVTYT_KhoKhoa.NewDMTBVTYT_KhoKhoa();
            return obj;
        }
        public void NewTo(DMTBVTYT_KhoKhoa _DMTBVTYT_KhoKhoa)
        {
            try
            {
                if (!Contains(_DMTBVTYT_KhoKhoa.MaVT, _DMTBVTYT_KhoKhoa.Makhoa,_DMTBVTYT_KhoKhoa.huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMTBVTYT_KhoKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMTBVTYT_KhoKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMTBVTYT_KhoKhoa.STT = ++_count;
                        this.Add(_DMTBVTYT_KhoKhoa);
                    }
                    else
                    {
                        _DMTBVTYT_KhoKhoa.STT = 1;
                        this.Add(_DMTBVTYT_KhoKhoa);

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
        public void UpdatedTo(DMTBVTYT_KhoKhoa _DMTBVTYT_KhoKhoa)
        {

            _DMTBVTYT_KhoKhoa.STT = this.Items[this.IndexOf(_DMTBVTYT_KhoKhoa)].STT;
            this.Items[this.IndexOf(_DMTBVTYT_KhoKhoa)] = _DMTBVTYT_KhoKhoa;
        }
        public void RemoveTo(DMTBVTYT_KhoKhoa _DMTBVTYT_KhoKhoa)
        {
            this.Items.Remove(_DMTBVTYT_KhoKhoa);

        }
        public DMTBVTYT_KhoKhoa  AssignTo(DMTBVTYT_KhoKhoa  _DMTBVTYT_KhoKhoa)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMTBVTYT_KhoKhoa.STT = ++_count;
                this.Add(_DMTBVTYT_KhoKhoa);
            }
            else
            {
                _DMTBVTYT_KhoKhoa.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMTBVTYT_KhoKhoa);
            }
            //Add(_PhieuNhap_C);
            return _DMTBVTYT_KhoKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMTBVTYT_KhoKhoa item in this)
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
            foreach (DMTBVTYT_KhoKhoa obj in this)
                if ((obj.MaVT == MaVT) && (obj.Makhoa == makhoa)&&(obj.huy == Huy ) )
                    return true;
            return false;
        }

        public DMTBVTYT_KhoKhoa GetDMTBVTYT_KhoKhoaById(string makho, decimal stt, string makhoa)
        {
            foreach (DMTBVTYT_KhoKhoa item in this)
                if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makho, decimal stt, string makhoa)
        {
            foreach (DMTBVTYT_KhoKhoa  item in this)
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
            DMTBVTYT_KhoKhoa item = DMTBVTYT_KhoKhoa.NewDMTBVTYT_KhoKhoa();
            Add(item);
            return item;
        }

        public static DMTBVTYT_KhoKhoaList GetAllDMTBVTYT_KhoKhoa(String makho, String makhoa)
        {
            return DataPortal.Fetch<DMTBVTYT_KhoKhoaList>(new Criteria(makho, makhoa));
        }

        private DMTBVTYT_KhoKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTBVTYT_KhoKhoa(criteria.MaKho, criteria.MaKhoa,criteria.qadmin      )))
            {
                while (dr.Read())
                {
                    this.Add(DMTBVTYT_KhoKhoa.GetDMTBVTYT_KhoKhoa(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMTBVTYT_KhoKhoa item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMTBVTYT_KhoKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMTBVTYT_KhoKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMTBVTYT_KhoKhoaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
