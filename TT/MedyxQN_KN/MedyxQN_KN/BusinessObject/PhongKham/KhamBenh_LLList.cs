using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenh_LLList : BusinessListBase<KhamBenh_LLList, KhamBenh_LL>
    {

        #region Factory Methods
       public KhamBenh_LL NewTo()
        {
            KhamBenh_LL obj = KhamBenh_LL.NewKhamBenh_LL();
            return obj;
        }

        public void NewTo(KhamBenh_LL _KhamBenh_LL)
        {

            try
            {
                if (!Contains(_KhamBenh_LL.MaSoKham, _KhamBenh_LL.STT, _KhamBenh_LL.STTTH, _KhamBenh_LL.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_KhamBenh_LL.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_KhamBenh_LL);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _KhamBenh_LL.STTTH = ++_count;
                        this.Add(_KhamBenh_LL);
                    }
                    else
                    {
                        _KhamBenh_LL.STTTH = 1;
                        this.Add(_KhamBenh_LL);

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
        public void UpdatedTo(KhamBenh_LL _KhamBenh_LL)
        {

            _KhamBenh_LL.STTTH = this.Items[this.IndexOf(_KhamBenh_LL)].STTTH;
             this.Items[this.IndexOf(_KhamBenh_LL)] = _KhamBenh_LL;
            int i;
            _KhamBenh_LL.SoLuongT = 0;
            for (i = 0; i <= this.Count-1; i++)
            {
                if (_KhamBenh_LL.MaDV == this[i].MaDV)
                    _KhamBenh_LL.SoLuongT = _KhamBenh_LL.SoLuongT + Decimal.Parse(this[i].SoLuong);
            }
          
        }
        public void RemoveTo(KhamBenh_LL _KhamBenh_LL)
        {
            this.Items.Remove(_KhamBenh_LL);

        }
        public KhamBenh_LL AssignTo(KhamBenh_LL _KhamBenh_LL)//add mot hang PhieuNhap_C
        {
            int i;
            _KhamBenh_LL.SoLuongT = 0;
            for (i = 0; i <= this.Count-1; i++)
            {
                if (_KhamBenh_LL.MaDV ==this[i].MaDV)
                    _KhamBenh_LL.SoLuongT = _KhamBenh_LL.SoLuongT + Decimal.Parse(this[i].SoLuong);
            }
            _KhamBenh_LL.SoLuongT = _KhamBenh_LL.SoLuongT + Decimal.Parse(_KhamBenh_LL.SoLuong);
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _KhamBenh_LL.STTTH = ++_count;
                    this.Add(_KhamBenh_LL);
                }
                else
                {
                    _KhamBenh_LL.STTTH = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_KhamBenh_LL);
                }
            //Add(_PhieuNhap_C);
            return _KhamBenh_LL;
        }

        //public void Remove(int id)
        //{
        //    foreach (KhamBenh_LL item in this)
        //    {
        //        if (item.IdCountry == id)
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}

        public bool Contains(string MaSoKham, int stt,int sttth, bool Huy)
        {
            foreach (KhamBenh_LL obj in this)
                if ((obj.MaSoKham == MaSoKham) && (obj.STT == stt) && (obj.STTTH == sttth) && (obj.Huy == Huy))
                    return true;
            return false;
        }

        public KhamBenh_LL GetKhamBenh_LLById(string MaSoKham, int stt, int sttth, string DK)
        {
            foreach (KhamBenh_LL item in this)
                if ((item.MaSoKham == MaSoKham) && (item.STT == stt) && (item.STTTH == sttth))
                    return item;
            return null;
        }
        public void Remove(string MaSoKham, int stt, int sttth)
        {
          
            foreach (KhamBenh_LL item in this)
            {
                if ((item.MaSoKham == MaSoKham) && (item.STT == stt) && (item.STTTH == sttth))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            KhamBenh_LL item = KhamBenh_LL.NewKhamBenh_LL();
            Add(item);
            return item;
        }

        public static KhamBenh_LLList GetAllKhamBenh_LL(String MaSoKham, String DK)
        {
            return DataPortal.Fetch<KhamBenh_LLList>(new Criteria(MaSoKham, DK));
        }

        private KhamBenh_LLList()
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
            private String _MaSoKham;
            private String _DK;
             private Boolean _qadmin = false ;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
                }
            }
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String mMaSoKham, String mDK)
            {
                _MaSoKham = mMaSoKham;
                _DK = mDK;

            }
        }



        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_LL(criteria.MaSoKham, criteria.DK, criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(KhamBenh_LL.GetKhamBenh_LL(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (KhamBenh_LL item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (KhamBenh_LL item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override KhamBenh_LLList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            KhamBenh_LLList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
