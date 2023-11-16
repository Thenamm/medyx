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
    public class DMVTYT_KhoKhoaGList : BusinessListBase<DMVTYT_KhoKhoaGList, DMVTYT_KhoKhoaG>
    {
        #region Factory Methods
        ////public static DMVTYT_KhoKhoaGList GetAllDMVTYT_KhoKhoaG(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMVTYT_KhoKhoaGList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        //public static DMVTYT_KhoKhoaGList FindDMVTYT_KhoKhoaGByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMVTYT_KhoKhoaGList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMVTYT_KhoKhoaGList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMVTYT_KhoKhoaGList>(new CriteriaOther(1, MaChungLoai));
        //}
        public DMVTYT_KhoKhoaG NewTo() {
            DMVTYT_KhoKhoaG obj = DMVTYT_KhoKhoaG.NewDMVTYT_KhoKhoaG();
            return obj;
        }
        public void NewTo(DMVTYT_KhoKhoaG _DMVTYT_KhoKhoaG)
        {
            try
            {
                if (!Contains(_DMVTYT_KhoKhoaG.MaVT, _DMVTYT_KhoKhoaG.Makhoa,_DMVTYT_KhoKhoaG.huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMVTYT_KhoKhoaG.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMVTYT_KhoKhoaG);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMVTYT_KhoKhoaG.STT = ++_count;
                        this.Add(_DMVTYT_KhoKhoaG);
                    }
                    else
                    {
                        _DMVTYT_KhoKhoaG.STT = 1;
                        this.Add(_DMVTYT_KhoKhoaG);

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
        public void UpdatedTo(DMVTYT_KhoKhoaG _DMVTYT_KhoKhoaG)
        {

            _DMVTYT_KhoKhoaG.STT = this.Items[this.IndexOf(_DMVTYT_KhoKhoaG)].STT;
            this.Items[this.IndexOf(_DMVTYT_KhoKhoaG)] = _DMVTYT_KhoKhoaG;
        }
        public void RemoveTo(DMVTYT_KhoKhoaG _DMVTYT_KhoKhoaG)
        {
            this.Items.Remove(_DMVTYT_KhoKhoaG);

        }
        public DMVTYT_KhoKhoaG  AssignTo(DMVTYT_KhoKhoaG  _DMVTYT_KhoKhoaG)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMVTYT_KhoKhoaG.STT = ++_count;
                this.Add(_DMVTYT_KhoKhoaG);
            }
            else
            {
                _DMVTYT_KhoKhoaG.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMVTYT_KhoKhoaG);
            }
            //Add(_PhieuNhap_C);
            return _DMVTYT_KhoKhoaG;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMVTYT_KhoKhoaG item in this)
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
            foreach (DMVTYT_KhoKhoaG obj in this)
                if ((obj.MaVT == MaVT) && (obj.Makhoa == makhoa)&&(obj.huy == Huy ) )
                    return true;
            return false;
        }

        public DMVTYT_KhoKhoaG GetDMVTYT_KhoKhoaGById(string makho, decimal stt, string makhoa)
        {
            foreach (DMVTYT_KhoKhoaG item in this)
                if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makho, decimal stt, string makhoa)
        {
            foreach (DMVTYT_KhoKhoaG  item in this)
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
            DMVTYT_KhoKhoaG item = DMVTYT_KhoKhoaG.NewDMVTYT_KhoKhoaG();
            Add(item);
            return item;
        }

        public static DMVTYT_KhoKhoaGList GetAllDMVTYT_KhoKhoaG(String makho, String makhoa)
        {
            return DataPortal.Fetch<DMVTYT_KhoKhoaGList>(new Criteria(makho, makhoa));
        }

        private DMVTYT_KhoKhoaGList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVTYT_KhoKhoaG(criteria.MaKho, criteria.MaKhoa,criteria.qadmin      )))
            {
                while (dr.Read())
                {
                    this.Add(DMVTYT_KhoKhoaG.GetDMVTYT_KhoKhoaG(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMVTYT_KhoKhoaG item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMVTYT_KhoKhoaG item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMVTYT_KhoKhoaGList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMVTYT_KhoKhoaGList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
