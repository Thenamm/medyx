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
    public class DMVPP_KhoKhoaList : BusinessListBase<DMVPP_KhoKhoaList, DMVPP_KhoKhoa>
    {
        #region Factory Methods
        ////public static DMVPP_KhoKhoaList GetAllDMVPP_KhoKhoa(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMVPP_KhoKhoaList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        //public static DMVPP_KhoKhoaList FindDMVPP_KhoKhoaByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMVPP_KhoKhoaList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMVPP_KhoKhoaList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMVPP_KhoKhoaList>(new CriteriaOther(1, MaChungLoai));
        //}
        public DMVPP_KhoKhoa NewTo() {
            DMVPP_KhoKhoa obj = DMVPP_KhoKhoa.NewDMVPP_KhoKhoa();
            return obj;
        }
        public void NewTo(DMVPP_KhoKhoa _DMVPP_KhoKhoa)
        {
            try
            {
                if (!Contains(_DMVPP_KhoKhoa.MaVT, _DMVPP_KhoKhoa.Makhoa,_DMVPP_KhoKhoa.huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMVPP_KhoKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMVPP_KhoKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMVPP_KhoKhoa.STT = ++_count;
                        this.Add(_DMVPP_KhoKhoa);
                    }
                    else
                    {
                        _DMVPP_KhoKhoa.STT = 1;
                        this.Add(_DMVPP_KhoKhoa);

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
        public void UpdatedTo(DMVPP_KhoKhoa _DMVPP_KhoKhoa)
        {

            _DMVPP_KhoKhoa.STT = this.Items[this.IndexOf(_DMVPP_KhoKhoa)].STT;
            this.Items[this.IndexOf(_DMVPP_KhoKhoa)] = _DMVPP_KhoKhoa;
        }
        public void RemoveTo(DMVPP_KhoKhoa _DMVPP_KhoKhoa)
        {
            this.Items.Remove(_DMVPP_KhoKhoa);

        }
        public DMVPP_KhoKhoa  AssignTo(DMVPP_KhoKhoa  _DMVPP_KhoKhoa)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMVPP_KhoKhoa.STT = ++_count;
                this.Add(_DMVPP_KhoKhoa);
            }
            else
            {
                _DMVPP_KhoKhoa.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMVPP_KhoKhoa);
            }
            //Add(_PhieuNhap_C);
            return _DMVPP_KhoKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMVPP_KhoKhoa item in this)
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
            foreach (DMVPP_KhoKhoa obj in this)
                if ((obj.MaVT == MaVT) && (obj.Makhoa == makhoa)&&(obj.huy == Huy ) )
                    return true;
            return false;
        }

        public DMVPP_KhoKhoa GetDMVPP_KhoKhoaById(string makho, decimal stt, string makhoa)
        {
            foreach (DMVPP_KhoKhoa item in this)
                if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makho, decimal stt, string makhoa)
        {
            foreach (DMVPP_KhoKhoa  item in this)
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
            DMVPP_KhoKhoa item = DMVPP_KhoKhoa.NewDMVPP_KhoKhoa();
            Add(item);
            return item;
        }

        public static DMVPP_KhoKhoaList GetAllDMVPP_KhoKhoa(String makho, String makhoa)
        {
            return DataPortal.Fetch<DMVPP_KhoKhoaList>(new Criteria(makho, makhoa));
        }

        private DMVPP_KhoKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVPP_KhoKhoa(criteria.MaKho, criteria.MaKhoa,criteria.qadmin      )))
            {
                while (dr.Read())
                {
                    this.Add(DMVPP_KhoKhoa.GetDMVPP_KhoKhoa(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMVPP_KhoKhoa item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMVPP_KhoKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMVPP_KhoKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMVPP_KhoKhoaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
