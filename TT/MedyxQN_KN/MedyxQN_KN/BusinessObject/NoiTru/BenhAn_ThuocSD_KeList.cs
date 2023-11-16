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

    public class BenhAn_ThuocSD_KeList : BusinessListBase<BenhAn_ThuocSD_KeList, BenhAn_ThuocSD_Ke>
    {
        #region Factory Methods
        public static BenhAn_ThuocSD_KeList NewList()
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_KeList>(new TemCriteria());
        }
        public static BenhAn_ThuocSD_KeList GetAllBenhAn_ThuocSD_Ke(String MaBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_KeList>(new Criteria(MaBA,qadmin ));
        }
        public static BenhAn_ThuocSD_KeList GetAllBenhAn_ThuocSD_KeDT(String MaBA, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_KeList>(new OtherCriteria(MaBA,"", 4,qadmin ));
        }

        public static BenhAn_ThuocSD_KeList GetAllBenhAn_ThuocSD_KeByNgayYC(String MaBA, string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_KeList>(new OtherCriteria(MaBA, NgayDK, 2,qadmin));
        }
        public static BenhAn_ThuocSD_KeList GetAllBenhAn_ThuocSD_KeByNgayYCDT(String MaBA, string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_KeList>(new OtherCriteria(MaBA,  NgayDK, 3,qadmin));
        }
        public BenhAn_ThuocSD_Ke NewTo() 
        {
            BenhAn_ThuocSD_Ke obj = BenhAn_ThuocSD_Ke.NewBenhAn_ThuocSD_Ke();
            return obj;
        }
        public void NewTo(BenhAn_ThuocSD_Ke _BenhAn_ThuocSD_Ke)
        {
            try
            {
                if (!Contains(_BenhAn_ThuocSD_Ke.Mathuoc, _BenhAn_ThuocSD_Ke.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_ThuocSD_Ke.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_ThuocSD_Ke);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_ThuocSD_Ke.STT = ++_count;
                        _BenhAn_ThuocSD_Ke.OrderNumber = _count;
                        this.Add(_BenhAn_ThuocSD_Ke);
                    }
                    else
                    {
                        _BenhAn_ThuocSD_Ke.STT = 1;
                        this.Add(_BenhAn_ThuocSD_Ke);

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
       
      
        public void UpdatedTo(BenhAn_ThuocSD_Ke _BenhAn_ThuocSD_Ke)
        {

            _BenhAn_ThuocSD_Ke.STT = this.Items[this.IndexOf(_BenhAn_ThuocSD_Ke)].STT;
            this.Items[this.IndexOf(_BenhAn_ThuocSD_Ke)] = _BenhAn_ThuocSD_Ke;
        }
        //public void RemoveTo(BenhAn_ThuocSD_Ke _BenhAn_ThuocSD_Ke)
        //{
        //    this.Items.Remove(_BenhAn_ThuocSD_Ke);

        //}
        public BenhAn_ThuocSD_Ke  AssignTo(BenhAn_ThuocSD_Ke  _BenhAn_ThuocSD_Ke)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_ThuocSD_Ke.Mathuoc, _BenhAn_ThuocSD_Ke.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_ThuocSD_Ke.STT = ++_count;
                    _BenhAn_ThuocSD_Ke.OrderNumber = _count;
                   // _BenhAn_ThuocSD_Ke.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_BenhAn_ThuocSD_Ke);
                }
                else
                {
                    _BenhAn_ThuocSD_Ke.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_ThuocSD_Ke);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_ThuocSD_Ke;
        }
        public bool Contains(string MaThuoc, bool Huy)
        {
    //        foreach (BenhAn_ThuocSD_Ke obj in this)
    //            if ((obj.Mathuoc == MaThuoc) && (obj.Huy == Huy)  )
    //            {
    ////                if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
         
    ////                return false ;
    ////else
    ////                return true;
                //}
            return false;
        }
        public BenhAn_ThuocSD_Ke  GetBenhAn_ThuocSD_KeById(string MaBA, int stt)
        {
            foreach (BenhAn_ThuocSD_Ke  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) )
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt)
        {
            foreach (BenhAn_ThuocSD_Ke  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) )
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(BenhAn_ThuocSD_Ke obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            //if (obj.IsNew == true)
            //    this.Items.Remove(obj);

            //else
                Remove(obj);

        }
        public BenhAn_ThuocSD_Ke GetTo(decimal STT) //
        {
            foreach (BenhAn_ThuocSD_Ke obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_ThuocSD_Ke  item = BenhAn_ThuocSD_Ke.NewBenhAn_ThuocSD_Ke();
            Add(item);
            return item;
        }

      
        private BenhAn_ThuocSD_KeList()
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
                _qadmin =qadmin ;
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
            public OtherCriteria(String MaBA,  string NgayDK, byte loai,Boolean qadmin)
            {
                 if (DateTime.Now.ToString ("dd/MM/yyyy") == DateTime.Now.ToShortDateString () )
                    if (loai == 2)
                        _DK = " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) <=0";
                    else if (loai == 3)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) <=0";
                    else if (loai == 4)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.maba = '" + MaBA + "'";
                    else
                        _DK =  " and a.maba = '" + MaBA + "'";

                else

                    if (loai == 2)
                        _DK = " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + NgayDK + "')) <=0";
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ThuocSD_Ke(criteria.MaBA,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_ThuocSD_Ke .GetBenhAn_ThuocSD_Ke(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ThuocSD_Ke(criteria.MaBA,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_ThuocSD_Ke.GetBenhAn_ThuocSD_Ke(dr, i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_ThuocSD_Ke  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_ThuocSD_Ke  item in this)
            {
                if ((item.SLKeDon != "0" || item.SLMua != "0"))
                if (item.IsNew) 
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_ThuocSD_KeList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_ThuocSD_KeList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
