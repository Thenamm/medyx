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

    public class KhamBenh_KeNgoaiList : BusinessListBase<KhamBenh_KeNgoaiList, KhamBenh_KeNgoai>
    {
        #region Factory Methods
        public static KhamBenh_KeNgoaiList NewList()
        {
            return DataPortal.Fetch<KhamBenh_KeNgoaiList>(new TemCriteria());
        }
        public static KhamBenh_KeNgoaiList GetAllKhamBenh_KeNgoai(String MaSoKham)
        {
            return DataPortal.Fetch<KhamBenh_KeNgoaiList>(new Criteria(MaSoKham));
        }
        public static KhamBenh_KeNgoaiList GetAllKhamBenh_KeNgoaiDT(String MaSoKham)
        {
            return DataPortal.Fetch<KhamBenh_KeNgoaiList>(new OtherCriteria(MaSoKham,"", 4));
        }
       
        public static KhamBenh_KeNgoaiList GetAllKhamBenh_KeNgoaiByNgayYC(String MaSoKham,  string NgayDK)
        {
            return DataPortal.Fetch<KhamBenh_KeNgoaiList>(new OtherCriteria(MaSoKham, NgayDK, 2));
        }
        public static KhamBenh_KeNgoaiList GetAllKhamBenh_KeNgoaiByNgayYCDT(String MaSoKham,  string NgayDK)
        {
            return DataPortal.Fetch<KhamBenh_KeNgoaiList>(new OtherCriteria(MaSoKham,  NgayDK, 3));
        }
        public KhamBenh_KeNgoai NewTo() 
        {
            KhamBenh_KeNgoai obj = KhamBenh_KeNgoai.NewKhamBenh_KeNgoai();
            return obj;
        }
        public void NewTo(KhamBenh_KeNgoai _KhamBenh_KeNgoai)
        {
            try
            {
                if (!Contains(_KhamBenh_KeNgoai.MaKe, _KhamBenh_KeNgoai.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_KhamBenh_KeNgoai.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_KhamBenh_KeNgoai);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _KhamBenh_KeNgoai.STT = ++_count;
                        _KhamBenh_KeNgoai.OrderNumber = _count;
                        this.Add(_KhamBenh_KeNgoai);
                    }
                    else
                    {
                        _KhamBenh_KeNgoai.STT = 1;
                        this.Add(_KhamBenh_KeNgoai);

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
       
      
        public void UpdatedTo(KhamBenh_KeNgoai _KhamBenh_KeNgoai)
        {

            _KhamBenh_KeNgoai.STT = this.Items[this.IndexOf(_KhamBenh_KeNgoai)].STT;
            this.Items[this.IndexOf(_KhamBenh_KeNgoai)] = _KhamBenh_KeNgoai;
        }
        //public void RemoveTo(KhamBenh_KeNgoai _KhamBenh_KeNgoai)
        //{
        //    this.Items.Remove(_KhamBenh_KeNgoai);

        //}
        public KhamBenh_KeNgoai  AssignTo(KhamBenh_KeNgoai  _KhamBenh_KeNgoai)//add mot hang PhieuNhap_C
        {
            if (!Contains(_KhamBenh_KeNgoai.MaKe, _KhamBenh_KeNgoai.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _KhamBenh_KeNgoai.STT = ++_count;
                    _KhamBenh_KeNgoai.OrderNumber = _count;
                   // _KhamBenh_KeNgoai.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_KhamBenh_KeNgoai);
                }
                else
                {
                    _KhamBenh_KeNgoai.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_KhamBenh_KeNgoai);
                }
            }
            //Add(_PhieuNhap_C);
            return _KhamBenh_KeNgoai;
        }
        public bool Contains(string MaKe, bool Huy)
        {
    //        foreach (KhamBenh_KeNgoai obj in this)
    //            if ((obj.MaKe == MaKe) && (obj.Huy == Huy)  )
    //            {
    ////                if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
         
    ////                return false ;
    ////else
    ////                return true;
                //}
            return false;
        }
        public KhamBenh_KeNgoai  GetKhamBenh_KeNgoaiById(string MaSoKham, int stt)
        {
            foreach (KhamBenh_KeNgoai  item in this)
                if ((item.MaSoKham == MaSoKham) && (item.STT == stt) )
                    return item;
            return null;
        }
        public void Remove(string MaSoKham, int stt)
        {
            foreach (KhamBenh_KeNgoai  item in this)
            {
                if ((item.MaSoKham == MaSoKham) && (item.STT == stt) )
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(KhamBenh_KeNgoai obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            //if (obj.IsNew == true)
            //    this.Items.Remove(obj);

            //else
                Remove(obj);

        }
        public KhamBenh_KeNgoai GetTo(decimal STT) //
        {
            foreach (KhamBenh_KeNgoai obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            KhamBenh_KeNgoai  item = KhamBenh_KeNgoai.NewKhamBenh_KeNgoai();
            Add(item);
            return item;
        }

      
        private KhamBenh_KeNgoaiList()
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
            public Criteria(String mMaSoKham)
            {
                _MaSoKham = mMaSoKham;
                
            }
        }
        private class OtherCriteria
        {
           
             private Boolean _qadmin = false ;
          
            public bool qadmin
            {
                get
                {
                    return _qadmin;
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
            private string _MaSoKham;
            public string MaSoKham
            {
                get
                {
                    return _MaSoKham;
                }
            }
            public OtherCriteria(String MaSoKham,  string NgayDK, byte loai)
            {
                    
                        _DK =  " and a.MaSoKham = '" + MaSoKham + "'";

             
             
                _MaSoKham = MaSoKham;
                
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_KeNgoai(criteria.MaSoKham,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(KhamBenh_KeNgoai .GetKhamBenh_KeNgoai(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenh_KeNgoai(criteria.MaSoKham,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(KhamBenh_KeNgoai.GetKhamBenh_KeNgoai(dr, i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (KhamBenh_KeNgoai  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (KhamBenh_KeNgoai  item in this)
            {
                if ((item.SLKeDon != "0" || item.SLMua != "0"))
                if (item.IsNew) 
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override KhamBenh_KeNgoaiList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            KhamBenh_KeNgoaiList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
