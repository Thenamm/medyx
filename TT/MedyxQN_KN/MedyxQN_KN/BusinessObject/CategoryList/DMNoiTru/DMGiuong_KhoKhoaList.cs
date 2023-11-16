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
    public class DMGiuong_KhoKhoaList : BusinessListBase<DMGiuong_KhoKhoaList, DMGiuong_KhoKhoa>
    {
        #region Factory Methods
        public static DMGiuong_KhoKhoaList NewList()
        {
            return DataPortal.Fetch<DMGiuong_KhoKhoaList>(new TemCriteria());
        }
       
        public DMGiuong_KhoKhoa NewTo() {
            DMGiuong_KhoKhoa obj = DMGiuong_KhoKhoa.NewDMGiuong_KhoKhoa();
            return obj;
        }
        public void NewTo(DMGiuong_KhoKhoa _DMGiuong_KhoKhoa)
        {
            try
            {
                if (!Contains(_DMGiuong_KhoKhoa.MaGiuong, _DMGiuong_KhoKhoa.Makhoa,_DMGiuong_KhoKhoa.huy ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMGiuong_KhoKhoa.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMGiuong_KhoKhoa);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMGiuong_KhoKhoa.STT = ++_count;
                        this.Add(_DMGiuong_KhoKhoa);
                    }
                    else
                    {
                        _DMGiuong_KhoKhoa.STT = 1;
                        this.Add(_DMGiuong_KhoKhoa);

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
        public void UpdatedTo(DMGiuong_KhoKhoa _DMGiuong_KhoKhoa)
        {

            _DMGiuong_KhoKhoa.STT = this.Items[this.IndexOf(_DMGiuong_KhoKhoa)].STT;
            this.Items[this.IndexOf(_DMGiuong_KhoKhoa)] = _DMGiuong_KhoKhoa;
        }
        public void RemoveTo(DMGiuong_KhoKhoa _DMGiuong_KhoKhoa)
        {
            this.Items.Remove(_DMGiuong_KhoKhoa);

        }
        public DMGiuong_KhoKhoa  AssignTo(DMGiuong_KhoKhoa  _DMGiuong_KhoKhoa)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMGiuong_KhoKhoa.STT = ++_count;
                this.Add(_DMGiuong_KhoKhoa);
            }
            else
            {
                _DMGiuong_KhoKhoa.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMGiuong_KhoKhoa);
            }
            //Add(_PhieuNhap_C);
            return _DMGiuong_KhoKhoa;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMGiuong_KhoKhoa item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaGiuong, string makhoa,bool Huy)
        {
            foreach (DMGiuong_KhoKhoa obj in this)
                if ((obj.MaGiuong == MaGiuong) && (obj.Makhoa == makhoa)&&(obj.huy ==Huy ) )
                    return true;
            return false;
        }

        public DMGiuong_KhoKhoa GetDMGiuong_KhoKhoaById(string makho, decimal stt, string makhoa)
        {
            foreach (DMGiuong_KhoKhoa item in this)
                if ( (item.STT == stt) && (item.Makhoa == makhoa))
                    return item;
            return null;
        }
        public void Remove(string makho, int stt,string makhoa)
        {
            foreach (DMGiuong_KhoKhoa  item in this)
            {
                if ( (item.STT == stt)&&(item .Makhoa==makhoa  ))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            DMGiuong_KhoKhoa item = DMGiuong_KhoKhoa.NewDMGiuong_KhoKhoa();
            Add(item);
            return item;
        }

        public static DMGiuong_KhoKhoaList GetAllDMGiuong_KhoKhoa(String makho, String makhoa)
        {
            return DataPortal.Fetch<DMGiuong_KhoKhoaList>(new Criteria(makho, makhoa));
        }

        private DMGiuong_KhoKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMGiuong_KhoKhoa( criteria.MaKhoa,criteria.qadmin      )))
            {
                while (dr.Read())
                {
                    this.Add(DMGiuong_KhoKhoa.GetDMGiuong_KhoKhoa(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMGiuong_KhoKhoa item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMGiuong_KhoKhoa item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMGiuong_KhoKhoaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMGiuong_KhoKhoaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
