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
    public class DMNhanVien_TrucList : BusinessListBase<DMNhanVien_TrucList, DMNhanVien_Truc>
    {
        #region Factory Methods
        public static DMNhanVien_TrucList NewList()
        {
            return DataPortal.Fetch<DMNhanVien_TrucList>(new TemCriteria());
        }
       
        public DMNhanVien_Truc NewTo() {
            DMNhanVien_Truc obj = DMNhanVien_Truc.NewDMNhanVien_Truc();
            return obj;
        }
        public void NewTo(DMNhanVien_Truc _DMNhanVien_Truc)
        {
            try
            {
                if (!Contains(_DMNhanVien_Truc.MaNV, _DMNhanVien_Truc.Makhoa, _DMNhanVien_Truc.huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMNhanVien_Truc.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMNhanVien_Truc);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMNhanVien_Truc.STT = ++_count;
                        this.Add(_DMNhanVien_Truc);
                    }
                    else
                    {
                        _DMNhanVien_Truc.STT = 1;
                        this.Add(_DMNhanVien_Truc);

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
        public void UpdatedTo(DMNhanVien_Truc _DMNhanVien_Truc)
        {

            _DMNhanVien_Truc.STT = this.Items[this.IndexOf(_DMNhanVien_Truc)].STT;
            this.Items[this.IndexOf(_DMNhanVien_Truc)] = _DMNhanVien_Truc;
        }
        public void RemoveTo(DMNhanVien_Truc _DMNhanVien_Truc)
        {
            this.Items.Remove(_DMNhanVien_Truc);

        }
        public DMNhanVien_Truc  AssignTo(DMNhanVien_Truc  _DMNhanVien_Truc)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMNhanVien_Truc.STT = ++_count;
                this.Add(_DMNhanVien_Truc);
            }
            else
            {
                _DMNhanVien_Truc.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMNhanVien_Truc);
            }
            //Add(_PhieuNhap_C);
            return _DMNhanVien_Truc;
        }

        //public void Remove(int id)
        //{
        //    foreach (DMNhanVien_Truc item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string manv, string makhoa, bool Huy)
        {
            foreach (DMNhanVien_Truc obj in this)
                if ((obj.MaNV == manv) && (obj.Makhoa == makhoa) && (obj.huy == Huy))
                    return true;
            return false;
        }

        public DMNhanVien_Truc GetDMNhanVien_TrucById(decimal stt)
        {
            foreach (DMNhanVien_Truc item in this)
                if ( (item.STT == stt) )
                    return item;
            return null;
        }
        public void Remove(int stt)
        {
            foreach (DMNhanVien_Truc  item in this)
            {
                if ( (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            DMNhanVien_Truc item = DMNhanVien_Truc.NewDMNhanVien_Truc();
            Add(item);
            return item;
        }

        public static DMNhanVien_TrucList GetAllDMNhanVien_Truc(DateTime  tungay,DateTime  denngay,string makhoa, string manv,string dk,  Boolean qadmin)
        {
            return DataPortal.Fetch<DMNhanVien_TrucList>(new Criteria(tungay,denngay, makhoa, manv, qadmin));
        }

        private DMNhanVien_TrucList()
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
            private DateTime _tungaydk;
            private DateTime _denngaydk;
            private string _makhoa;
            private string _manv;
            private Boolean _qadmin = false ;

            public DateTime TuNgaydk
            {
                get
                {
                    return _tungaydk;
                }
            }
            public DateTime DenNgaydk
            {
                get
                {
                    return _denngaydk;
                }
            }
            public string makhoa
            {
                get
                {
                    return _makhoa;
                }
            }
            public string manv
            {
                get
                {
                    return _manv;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(DateTime mtungaydk, DateTime mdenngaydk,string mmakhoa, string mmanv ,Boolean qadmiM)
            {
                _tungaydk = mtungaydk;
                _denngaydk = mdenngaydk;
                _makhoa = mmakhoa;
                _manv = mmanv;
                _qadmin = qadmiM;
                
            }
        }

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhanVien_Truc(criteria.TuNgaydk, criteria.DenNgaydk, criteria.makhoa, criteria.manv,"",criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {

                    this.Add(DMNhanVien_Truc.GetDMNhanVien_Truc(i,dr));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMNhanVien_Truc item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMNhanVien_Truc item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMNhanVien_TrucList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMNhanVien_TrucList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
