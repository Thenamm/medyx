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

    public class BenhAn_GiuongList : BusinessListBase<BenhAn_GiuongList, BenhAn_Giuong>
    {
      //  //public HTC.Common.MessageBox mb; 
        #region Factory Methods
        public static BenhAn_GiuongList NewList()
        {
            return DataPortal.Fetch<BenhAn_GiuongList>(new TemCriteria());
        }
        public static BenhAn_GiuongList GetAllBenhAn_Giuong(String MaBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_GiuongList>(new Criteria(MaBA,qadmin ));
        }
        public static BenhAn_GiuongList GetAllBenhAn_GiuongBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_GiuongList>(new OtherCriteria(MaBA, sttKhoa, "", 1,qadmin));
        }
        public static BenhAn_GiuongList GetAllBenhAn_GiuongByNgayYC(String MaBA, int sttKhoa,string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_GiuongList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2,qadmin));
        }
        public BenhAn_Giuong NewTo() 
        {
            BenhAn_Giuong obj = BenhAn_Giuong.NewBenhAn_Giuong();
            return obj;
        }
        public void NewTo(BenhAn_Giuong _BenhAn_Giuong)
        {
            try
            {
                if (!Contains(_BenhAn_Giuong.MaGiuong, _BenhAn_Giuong.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_Giuong.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_Giuong);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_Giuong.STT = ++_count;
                        this.Add(_BenhAn_Giuong);
                    }
                    else
                    {
                        _BenhAn_Giuong.STT = 1;
                        this.Add(_BenhAn_Giuong);

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
       
      
        public void UpdatedTo(BenhAn_Giuong _BenhAn_Giuong)
        {

            _BenhAn_Giuong.STT = this.Items[this.IndexOf(_BenhAn_Giuong)].STT;
            this.Items[this.IndexOf(_BenhAn_Giuong)] = _BenhAn_Giuong;
        }
        //public void RemoveTo(BenhAn_Giuong _BenhAn_Giuong)
        //{
        //    this.Items.Remove(_BenhAn_Giuong);

        //}
        public BenhAn_Giuong  AssignTo(BenhAn_Giuong  _BenhAn_Giuong)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_Giuong.MaGiuong, _BenhAn_Giuong.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_Giuong.STT = ++_count;
                   // _BenhAn_Giuong.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_BenhAn_Giuong);
                }
                else
                {
                    _BenhAn_Giuong.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_Giuong);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_Giuong;
        }
        public bool Contains(string MaGiuong, bool Huy)
        {
            //foreach (BenhAn_Giuong obj in this)
            //    if ((obj.MaGiuong == MaGiuong) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi ! Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            //        //         return false ;
            //    }
            return false;
        }
        public BenhAn_Giuong  GetBenhAn_GiuongById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_Giuong  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_Giuong  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(BenhAn_Giuong obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_Giuong GetTo(decimal STT) //
        {
            foreach (BenhAn_Giuong obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_Giuong  item = BenhAn_Giuong.NewBenhAn_Giuong();
            Add(item);
            return item;
        }

      
        private BenhAn_GiuongList()
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
            private int _STTKhoa;
             private Boolean _qadmin = false ;
            public int STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
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
            public OtherCriteria(String MaBA, int sttKhoa, string NgayDK, byte loai, Boolean qadmin)
            {
                if (DateTime.Now.ToString("dd/MM/yyyy") == DateTime.Now.ToShortDateString())
                    if (loai == 2)
                      //  _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and ((datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.ngaydk ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) <=0) or datediff(d,a.ngaylap ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) =0 OR datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) =0) ";
                      _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) =0 ";
                   else
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";

                else

                    if (loai == 2)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) =0 ";
                    else
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";
         
                _STTKhoa = sttKhoa;
                _MaBA = MaBA;
                _qadmin = qadmin;
            }
        }
  
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Giuong(criteria.MaBA,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_Giuong .GetBenhAn_Giuong(dr,i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_GiuongBySTTKhoa(criteria.MaBA, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_Giuong.GetBenhAn_Giuong(dr, i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_Giuong  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_Giuong  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else if ((item.IsNew == false) && (item.IsDirty == true))
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_GiuongList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to saving");

            BenhAn_GiuongList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
