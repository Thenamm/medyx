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

    public class BenhAn_ThuocSD_DYList : BusinessListBase<BenhAn_ThuocSD_DYList, BenhAn_ThuocSD_DY>
    {

        #region Factory Methods
        public static BenhAn_ThuocSD_DYList NewList()
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_DYList>(new TemCriteria());
        }
        public static BenhAn_ThuocSD_DYList GetAllBenhAn_ThuocSD_DY(String MaBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_DYList>(new Criteria(MaBA,qadmin ));
        }
        public static BenhAn_ThuocSD_DYList GetAllBenhAn_ThuocSD_DYDT(String MaBA, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_DYList>(new OtherCriteria(MaBA, 0, "", 4,qadmin ));
        }
        public static BenhAn_ThuocSD_DYList GetAllBenhAn_ThuocSD_DYBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_DYList>(new OtherCriteria(MaBA, sttKhoa, "", 1,qadmin));
        }
        public static BenhAn_ThuocSD_DYList GetAllBenhAn_ThuocSD_DYByNgayYC(String MaBA, int sttKhoa, String NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_DYList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2,qadmin));
        }
        public static BenhAn_ThuocSD_DYList GetAllBenhAn_ThuocSD_DYByNgayYCDT(String MaBA, int sttKhoa, String NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSD_DYList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 3,qadmin));
        }
        public BenhAn_ThuocSD_DY NewTo()
        {
            BenhAn_ThuocSD_DY obj = BenhAn_ThuocSD_DY.NewBenhAn_ThuocSD_DY();
            return obj;
        }
        public void NewTo(BenhAn_ThuocSD_DY _BenhAn_ThuocSD_DY)
        {
           

                if (this.Items.Count > 0)
                {
                    //_BenhAn_ThuocSD_DY.STT = this.Items[this.Count - 1].STT + 1;
                    //this.Add(_BenhAn_ThuocSD_DY);
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _BenhAn_ThuocSD_DY.STT = ++_count;
                    Add(_BenhAn_ThuocSD_DY);
                }
                else
                {
                    _BenhAn_ThuocSD_DY.STT = 1;
                    Add(_BenhAn_ThuocSD_DY);

                }
            
        }


        public void UpdatedTo(BenhAn_ThuocSD_DY _BenhAn_ThuocSD_DY)
        {

            _BenhAn_ThuocSD_DY.STT = this.Items[this.IndexOf(_BenhAn_ThuocSD_DY)].STT;
            this.Items[this.IndexOf(_BenhAn_ThuocSD_DY)] = _BenhAn_ThuocSD_DY;
        }
        //public void RemoveTo(BenhAn_ThuocSD_DY _BenhAn_ThuocSD_DY)
        //{
        //    this.Items.Remove(_BenhAn_ThuocSD_DY);

        //}
        public BenhAn_ThuocSD_DY AssignTo(BenhAn_ThuocSD_DY _BenhAn_ThuocSD_DY)//add mot hang PhieuNhap_C
        {
           
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_ThuocSD_DY.STT = ++_count;
                    // _BenhAn_ThuocSD_DY.STTKhoa = this.Items[0].STTKhoa; 
                    Add(_BenhAn_ThuocSD_DY);
                }
                else
                {
                    _BenhAn_ThuocSD_DY.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    Add(_BenhAn_ThuocSD_DY);
                }
           
            //Add(_PhieuNhap_C);
            return _BenhAn_ThuocSD_DY;
        }
        public bool Contains(string MaThuoc, bool Huy)
        {
            //        foreach (BenhAn_ThuocSD_DY obj in this)
            //            if ((obj.Mathuoc == MaThuoc) && (obj.Huy == Huy) && ((obj.SLTra == "0") || (obj.SLTra == "")) && (obj.DATT != 0))
            //            {
            ////                if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )

            ////                return false ;
            ////else
            ////                return true;
            //            }
            return false;
        }
        public BenhAn_ThuocSD_DY GetBenhAn_ThuocSD_DYById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_ThuocSD_DY item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_ThuocSD_DY item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(BenhAn_ThuocSD_DY obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_ThuocSD_DY GetTo(decimal STT) //
        {
            foreach (BenhAn_ThuocSD_DY obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_ThuocSD_DY item = BenhAn_ThuocSD_DY.NewBenhAn_ThuocSD_DY();
            Add(item);
            return item;
        }


        private BenhAn_ThuocSD_DYList()
        {  /* Require use of factory methods */
            this.AllowNew = true;
            this.AllowRemove = true;
            this.AllowEdit = true;
            AllowNew = true;
            AllowRemove = true;
            AllowEdit = true;
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
            private String _MaBA;
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
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) <=0";
                    else if (loai == 3)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) <=0";
                    else if (loai == 4)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.maba = '" + MaBA + "'";
                    else
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";

                else

                    if (loai == 2)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + NgayDK + "')) <=0";
                    else if (loai == 4)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.maba = '" + MaBA + "'";
                    else if (loai == 3)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + NgayDK + "')) <=0";
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ThuocSD_DY(criteria.MaBA, "", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_ThuocSD_DY.GetBenhAn_ThuocSD_DY(dr, i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ThuocSD_DYBySTTKhoa(criteria.MaBA, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_ThuocSD_DY.GetBenhAn_ThuocSD_DY(dr, i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
      

        #endregion
    }
}
