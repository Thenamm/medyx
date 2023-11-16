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
    public class DMThuoc_KhoKhoaGList : BusinessListBase<DMThuoc_KhoKhoaGList, DMThuoc_KhoKhoaG>
    {
        #region Factory Methods
        ////public static DMThuoc_KhoKhoaGList GetAllDMThuoc_KhoKhoaG(String makho, String makhoa)
        ////{
        ////    return DataPortal.Fetch<DMThuoc_KhoKhoaGList>(new Criteria(makho, makhoa ));
        ////}
        // tim theo dieu kien ten
        //public static DMThuoc_KhoKhoaGList FindDMThuoc_KhoKhoaGByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMThuoc_KhoKhoaGList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMThuoc_KhoKhoaGList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMThuoc_KhoKhoaGList>(new CriteriaOther(1, MaChungLoai));
        //}
        public DMThuoc_KhoKhoaG NewTo()
        {
            DMThuoc_KhoKhoaG obj = DMThuoc_KhoKhoaG.NewDMThuoc_KhoKhoaG();
            return obj;
        }
        public void   NewTo(DMThuoc_KhoKhoaG _DMThuoc_KhoKhoaG)
        {
           
            try
            {
                if (!Contains(_DMThuoc_KhoKhoaG.MaThuoc, _DMThuoc_KhoKhoaG.Makhoa,_DMThuoc_KhoKhoaG.huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMThuoc_KhoKhoaG.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMThuoc_KhoKhoaG);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMThuoc_KhoKhoaG.STT = ++_count;
                        this.Add(_DMThuoc_KhoKhoaG);
                    }
                    else
                    {
                        _DMThuoc_KhoKhoaG.STT = 1;
                        this.Add(_DMThuoc_KhoKhoaG);

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
        public void UpdatedTo(DMThuoc_KhoKhoaG _DMThuoc_KhoKhoaG)
        {

            _DMThuoc_KhoKhoaG.STT = this.Items[this.IndexOf(_DMThuoc_KhoKhoaG)].STT;
            this.Items[this.IndexOf(_DMThuoc_KhoKhoaG)] = _DMThuoc_KhoKhoaG;
        }
        public void RemoveTo(DMThuoc_KhoKhoaG _DMThuoc_KhoKhoaG)
        {
            this.Items.Remove(_DMThuoc_KhoKhoaG);

        }
        public DMThuoc_KhoKhoaG  AssignTo(DMThuoc_KhoKhoaG  _DMThuoc_KhoKhoaG)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMThuoc_KhoKhoaG.STT = ++_count;
                this.Add(_DMThuoc_KhoKhoaG);
            }
            else
            {
                _DMThuoc_KhoKhoaG.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMThuoc_KhoKhoaG);
            }
            //Add(_PhieuNhap_C);
            return _DMThuoc_KhoKhoaG;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMThuoc_KhoKhoaG item in this)
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
            foreach (DMThuoc_KhoKhoaG obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.Makhoa == makhoa)&&(obj.huy ==Huy  ) )
                    return true;
            return false;
        }

        public DMThuoc_KhoKhoaG GetDMThuoc_KhoKhoaGById(string makho, decimal stt, string makhoa)
        {
            foreach (DMThuoc_KhoKhoaG item in this)
                if ((item.Makho == makho) && (item.STT == stt) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makho, int stt,string makhoa)
        {
            foreach (DMThuoc_KhoKhoaG  item in this)
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
            DMThuoc_KhoKhoaG item = DMThuoc_KhoKhoaG.NewDMThuoc_KhoKhoaG();
            Add(item);
            return item;
        }

        public static DMThuoc_KhoKhoaGList GetAllDMThuoc_KhoKhoaG(String makho, String makhoa)
        {
            return DataPortal.Fetch<DMThuoc_KhoKhoaGList>(new Criteria(makho, makhoa));
        }

        private DMThuoc_KhoKhoaGList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMThuoc_KhoKhoaG(criteria.MaKho, criteria.MaKhoa,criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(DMThuoc_KhoKhoaG.GetDMThuoc_KhoKhoaG(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMThuoc_KhoKhoaG item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMThuoc_KhoKhoaG item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMThuoc_KhoKhoaGList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMThuoc_KhoKhoaGList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
