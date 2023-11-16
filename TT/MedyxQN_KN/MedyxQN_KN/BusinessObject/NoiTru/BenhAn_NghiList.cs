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

    public class BenhAn_NghiList : BusinessListBase<BenhAn_NghiList, BenhAn_Nghi>
    {
        #region Factory Methods
        public static BenhAn_NghiList GetAllBenhAn_Nghi(String MaBA, String DK, Boolean Qadmin, byte loaikq = 0)
        {
            return DataPortal.Fetch<BenhAn_NghiList>(new Criteria(MaBA,DK ,Qadmin,loaikq  ));
        }
        public static BenhAn_NghiList GetAllBenhAn_Nghi(String MaBA, String DK, Boolean Qadmin)
        {
            return DataPortal.Fetch<BenhAn_NghiList>(new Criteria(MaBA, DK, Qadmin, 0));
        }
        public static BenhAn_NghiList GetAllBenhAn_NghiBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_NghiList>(new OtherCriteria(MaBA,sttKhoa,"",1,qadmin ));
        }
        public static BenhAn_NghiList GetAllBenhAn_NghiByNgayYC(String MaBA, int sttKhoa,string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_NghiList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2, qadmin));
        }
        public BenhAn_Nghi NewTo() 
        {
            BenhAn_Nghi obj = BenhAn_Nghi.NewBenhAn_Nghi();
            return obj;
        }
        public void NewTo(BenhAn_Nghi _BenhAn_Nghi)
        {
            try
            {
                if (!Contains(_BenhAn_Nghi.MaLDNghi  , _BenhAn_Nghi.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_Nghi.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_Nghi);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_Nghi.STT = ++_count;
                        this.Add(_BenhAn_Nghi);
                    }
                    else
                    {
                        _BenhAn_Nghi.STT = 1;
                        this.Add(_BenhAn_Nghi);

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
       
      
        public void UpdatedTo(BenhAn_Nghi _BenhAn_Nghi)
        {

            _BenhAn_Nghi.STT = this.Items[this.IndexOf(_BenhAn_Nghi)].STT;
            this.Items[this.IndexOf(_BenhAn_Nghi)] = _BenhAn_Nghi;
        }
        //public void RemoveTo(BenhAn_Nghi _BenhAn_Nghi)
        //{
        //    this.Items.Remove(_BenhAn_Nghi);

        //}
        public void RemoveTo(BenhAn_Nghi obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_Nghi  AssignTo(BenhAn_Nghi  _BenhAn_Nghi)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_Nghi.MaLDNghi  ,  _BenhAn_Nghi.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_Nghi.STT = ++_count;
                    this.Add(_BenhAn_Nghi);
                }
                else
                {
                    _BenhAn_Nghi.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_Nghi);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_Nghi;
        }
        public bool Contains(string MaLDNghi, bool Huy)
        {
            //foreach (BenhAn_Nghi  obj in this)
            //    if ((obj.MaLDNghi == MaLDNghi) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
            //        //    return false;
            //        //else
            //        //    return true;
            //    }
            return false;
        }
        public BenhAn_Nghi  GetBenhAn_NghiById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_Nghi  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_Nghi  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_Nghi GetTo(decimal STT) //
        {
            foreach (BenhAn_Nghi obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_Nghi  item = BenhAn_Nghi.NewBenhAn_Nghi();
            Add(item);
            return item;
        }

      
        private BenhAn_NghiList()
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
            private byte _loaikq;
            public byte loaikq
            {
                get
                {
                    return _loaikq;
                }
            }
            public Criteria(String mMaBA, String DK, Boolean QAdmin, byte loaikq = 0)
            {
                _MaBA = mMaBA;
                _DK = DK;
                _qadmin = QAdmin;
                _loaikq = loaikq;
            }
        }
        private class OtherCriteria
        {
            private int _STTKhoa;
             private Boolean _qadmin = false ;
            private String _MaBA;
            public String MaBA
            {
                get
                {
                    return _MaBA;
                }
            }
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
            public OtherCriteria(String MaBA, int sttKhoa, string NgayDK, byte loai, Boolean qadmin)
            {
                 if (DateTime.Now.ToString ("dd/MM/yyyy") == DateTime.Now.ToShortDateString () )
                    if (loai == 2)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) <=0";
                    else
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";

                else

                    if (loai == 2)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + NgayDK + "')) <=0";
                    else
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";
                _MaBA = MaBA;
                _qadmin = qadmin;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Nghi(criteria.MaBA,"", criteria.qadmin,criteria .loaikq )))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_Nghi.GetBenhAn_Nghi(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_NghiBySTTKhoa(criteria.MaBA, criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_Nghi.GetBenhAn_Nghi(dr, i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_Nghi  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_Nghi  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_NghiList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_NghiList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
