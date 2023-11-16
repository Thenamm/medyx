using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////

namespace HTC.Business.NoiTru
{
    [Serializable()]

    public class BenhAn_KeNgoaiList : BusinessListBase<BenhAn_KeNgoaiList, BenhAn_KeNgoai>
    {
        #region Factory Methods
        public static BenhAn_KeNgoaiList NewList()
        {
            return DataPortal.Fetch<BenhAn_KeNgoaiList>(new TemCriteria());
        }
        public static BenhAn_KeNgoaiList GetAllBenhAn_KeNgoai(String MaBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_KeNgoaiList>(new Criteria(MaBA ,qadmin ));
        }


        public static BenhAn_KeNgoaiList GetAllBenhAn_KeNgoaiByNgayYC(String MaBA, int sttkhoa, string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_KeNgoaiList>(new OtherCriteria(MaBA,sttkhoa, NgayDK, 2,qadmin ));
        }
        public static BenhAn_KeNgoaiList GetAllBenhAn_KeNgoaiByNgayYCDT(String MaBA, int sttKhoa, string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_KeNgoaiList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 3,qadmin));
        }
        public BenhAn_KeNgoai NewTo() 
        {
            BenhAn_KeNgoai obj = BenhAn_KeNgoai.NewBenhAn_KeNgoai();
            return obj;
        }
        public void NewTo(BenhAn_KeNgoai _BenhAn_KeNgoai)
        {
            try
            {
                if (!Contains(_BenhAn_KeNgoai.MaKe, _BenhAn_KeNgoai.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_KeNgoai.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_KeNgoai);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_KeNgoai.STT = ++_count;
                        _BenhAn_KeNgoai.OrderNumber = _count;
                        this.Add(_BenhAn_KeNgoai);
                    }
                    else
                    {
                        _BenhAn_KeNgoai.STT = 1;
                        this.Add(_BenhAn_KeNgoai);

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
       
      
        public void UpdatedTo(BenhAn_KeNgoai _BenhAn_KeNgoai)
        {

            _BenhAn_KeNgoai.STT = this.Items[this.IndexOf(_BenhAn_KeNgoai)].STT;
            this.Items[this.IndexOf(_BenhAn_KeNgoai)] = _BenhAn_KeNgoai;
        }
        //public void RemoveTo(BenhAn_KeNgoai _BenhAn_KeNgoai)
        //{
        //    this.Items.Remove(_BenhAn_KeNgoai);

        //}
        public BenhAn_KeNgoai  AssignTo(BenhAn_KeNgoai  _BenhAn_KeNgoai)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_KeNgoai.MaKe, _BenhAn_KeNgoai.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_KeNgoai.STT = ++_count;
                    _BenhAn_KeNgoai.OrderNumber = _count;
                   // _BenhAn_KeNgoai.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_BenhAn_KeNgoai);
                }
                else
                {
                    _BenhAn_KeNgoai.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_KeNgoai);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_KeNgoai;
        }
        public bool Contains(string MaKe, bool Huy)
        {
    //        foreach (BenhAn_KeNgoai obj in this)
    //            if ((obj.MaKe == MaKe) && (obj.Huy == Huy)  )
    //            {
    ////                if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
         
    ////                return false ;
    ////else
    ////                return true;
                //}
            return false;
        }
        public BenhAn_KeNgoai  GetBenhAn_KeNgoaiById(string MaBA, int stt)
        {
            foreach (BenhAn_KeNgoai  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) )
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt)
        {
            foreach (BenhAn_KeNgoai  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) )
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(BenhAn_KeNgoai obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            //if (obj.IsNew == true)
            //    this.Items.Remove(obj);

            //else
                Remove(obj);

        }
        public BenhAn_KeNgoai GetTo(decimal STT) //
        {
            foreach (BenhAn_KeNgoai obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_KeNgoai  item = BenhAn_KeNgoai.NewBenhAn_KeNgoai();
            Add(item);
            return item;
        }

      
        private BenhAn_KeNgoaiList()
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
            private String  _MaBA;
            private Boolean _qadmin = false ;
            public String MaBA
            {
                get
                {
                    return _MaBA;
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
            public Criteria(String mMaBA,Boolean qadmin)
            {
                _MaBA = mMaBA;
                _qadmin = qadmin;
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
            private string _MaBA;
            public string MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
            public OtherCriteria(String MaBA, int sttkhoa, string NgayDK, byte loai, Boolean qadmin)
            {
                 if (DateTime.Now.ToString ("dd/MM/yyyy") == DateTime.Now.ToShortDateString () )
                    if (loai == 2)
                        _DK = " and a.maba = '" + MaBA + "' and a.sttkhoa ="+ sttkhoa.ToString ()+" and datediff(d,a.ngaydk ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) =0 ";
                    else if (loai == 3)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.sttkhoa =" + sttkhoa.ToString() + " and a.maba = '" + MaBA + "' and datediff(d,a.ngaydk ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) =0 ";
                    else if (loai == 4)
                        _DK = " and isnull(b.machungloai,'') ='00007'  and a.sttkhoa =" + sttkhoa.ToString() + " and a.maba = '" + MaBA + "'";
                    else
                        _DK =  " and a.maba = '" + MaBA + "' and a.sttkhoa ="+ sttkhoa.ToString ()+"";

                else

                    if (loai == 2)
                        _DK = " and a.maba = '" + MaBA + "' and datediff(d,a.ngaydk ,convert(datetime,'" + NgayDK + "')) =0 ";
                    else if (loai == 4)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.maba = '" + MaBA + "'";
                    else if (loai == 3)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + NgayDK + "')) <=0";
                    else
                        _DK = " and a.maba = '" + MaBA + "'";

                 _qadmin = qadmin;
                _MaBA = MaBA;
                
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_KeNgoai(criteria.MaBA,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_KeNgoai .GetBenhAn_KeNgoai(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_KeNgoai(criteria.MaBA,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_KeNgoai.GetBenhAn_KeNgoai(dr, i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_KeNgoai  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_KeNgoai  item in this)
            {
                if ((item.SLKeDon != "0" || item.SLMua != "0"))
                if (item.IsNew) 
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_KeNgoaiList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_KeNgoaiList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
