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

    public class KhamBenh_DongTienList : BusinessListBase<KhamBenh_DongTienList, KhamBenh_DongTien>
    {
        #region Factory Methods
        public static KhamBenh_DongTienList NewList()
        {
            return DataPortal.Fetch<KhamBenh_DongTienList>(new TemCriteria());
        }
        public static KhamBenh_DongTienList GetAllKhamBenh_DongTien(String MaSoKham)
        {
            return DataPortal.Fetch<KhamBenh_DongTienList>(new Criteria(MaSoKham,1));
        }
    
        public static KhamBenh_DongTienList GetAllKhamBenh_DongTienChi(String MaSoKham)
        {
            return DataPortal.Fetch<KhamBenh_DongTienList>(new Criteria(MaSoKham, 2));
        }

        public static KhamBenh_DongTienList GetAllKhamBenh_DongTienThu(String MaSoKham)
        {
            return DataPortal.Fetch<KhamBenh_DongTienList>(new Criteria(MaSoKham,3));
        }
       
       
        public KhamBenh_DongTien NewTo() 
        {
            KhamBenh_DongTien obj = KhamBenh_DongTien.NewKhamBenh_DongTien();
            return obj;
        }
        public void NewTo(KhamBenh_DongTien _KhamBenh_DongTien)
        {
            try
            {
                if (!Contains(_KhamBenh_DongTien.STT, _KhamBenh_DongTien.MaSoKham,  _KhamBenh_DongTien.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_KhamBenh_DongTien.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_KhamBenh_DongTien);
                       
                        _KhamBenh_DongTien.STT = this.Items[this.Items.Count - 1].STT + 1;
                        this.Add(_KhamBenh_DongTien);
                    }
                    else
                    {
                        _KhamBenh_DongTien.STT = 1;
                        this.Add(_KhamBenh_DongTien);

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
       
      
        public void UpdatedTo(KhamBenh_DongTien _KhamBenh_DongTien)
        {

            _KhamBenh_DongTien.STT = this.Items[this.IndexOf(_KhamBenh_DongTien)].STT;
            this.Items[this.IndexOf(_KhamBenh_DongTien)] = _KhamBenh_DongTien;
        }
        //public void RemoveTo(KhamBenh_DongTien _KhamBenh_DongTien)
        //{
        //    this.Items.Remove(_KhamBenh_DongTien);

        //}
        public KhamBenh_DongTien  AssignTo(KhamBenh_DongTien  _KhamBenh_DongTien)//add mot hang PhieuNhap_C
        {
            if (!Contains(_KhamBenh_DongTien.STT, _KhamBenh_DongTien.MaSoKham,  _KhamBenh_DongTien.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _KhamBenh_DongTien.STT = ++_count;
                 
                    this.Add(_KhamBenh_DongTien);
                }
                else
                {
                    _KhamBenh_DongTien.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_KhamBenh_DongTien);
                }
            }
            //Add(_PhieuNhap_C);
            return _KhamBenh_DongTien;
        }
        public bool Contains(int stt,string MaSoKham, bool Huy)
        {
            foreach (KhamBenh_DongTien  obj in this)
                if ((obj.STT == stt) && (obj.MaSoKham == MaSoKham)  && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public KhamBenh_DongTien  GetKhamBenh_DongTienById(string MaSoKham, int stt)
        {
            foreach (KhamBenh_DongTien  item in this)
                if ((item.MaSoKham == MaSoKham) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string MaSoKham, int stt)
        {
            foreach (KhamBenh_DongTien  item in this)
            {
                if ((item.MaSoKham == MaSoKham) && (item.STT == stt) )
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(KhamBenh_DongTien obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public KhamBenh_DongTien GetTo(decimal STT) //
        {
            foreach (KhamBenh_DongTien obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            KhamBenh_DongTien  item = KhamBenh_DongTien.NewKhamBenh_DongTien();
            Add(item);
            return item;
        }

      
        private KhamBenh_DongTienList()
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
            private String  _MaSoKham;
            private Boolean _qadmin = false ;
            public String MaSoKham
            {
                get
                {
                    return _MaSoKham;
                }
            }
            private string _DK;
            public string DK
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
            public Criteria(String mMaSoKham,byte mloai)
            {
                _MaSoKham = mMaSoKham;
                _DK = "";
                if (mloai == 2)
                    _DK = " and isnull(k.loai,0) = 1  ";
                else if (mloai == 3)
                    _DK = " and isnull(k.loai,0) = 0 ";
                
            }
        }
   
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_DongTien(criteria.MaSoKham,criteria.DK  , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(KhamBenh_DongTien .GetKhamBenh_DongTien(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
     
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (KhamBenh_DongTien  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (KhamBenh_DongTien  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override KhamBenh_DongTienList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            KhamBenh_DongTienList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
