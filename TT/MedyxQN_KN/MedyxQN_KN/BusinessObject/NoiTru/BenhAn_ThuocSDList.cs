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

    public class BenhAn_ThuocSDList : BusinessListBase<BenhAn_ThuocSDList, BenhAn_ThuocSD>
    {
        
        #region Factory Methods
        public static BenhAn_ThuocSDList NewList()
        {
            return DataPortal.Fetch<BenhAn_ThuocSDList>(new TemCriteria());
        }
        public static BenhAn_ThuocSDList GetAllBenhAn_ThuocSD(String MaBA,Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSDList>(new Criteria(MaBA,qadmin));
        }
        public static BenhAn_ThuocSDList GetAllBenhAn_ThuocSDDT(String MaBA, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSDList>(new OtherCriteria(MaBA, 0, "", 4, qadmin));
        }
        public static BenhAn_ThuocSDList GetAllBenhAn_ThuocSD(String MaBA,string dk)
        {
            return DataPortal.Fetch<BenhAn_ThuocSDList>(new OtherCriteria(MaBA, 0, dk, 5, false));
        }
        public static BenhAn_ThuocSDList GetAllBenhAn_ThuocSDBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSDList>(new OtherCriteria(MaBA, sttKhoa, "", 1, qadmin));
        }
        public static BenhAn_ThuocSDList GetAllBenhAn_ThuocSDByNgayYC(String MaBA, int sttKhoa,string NgayDK,  Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSDList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2, qadmin));
        }
        public static BenhAn_ThuocSDList GetAllBenhAn_ThuocSDByNgayYCDT(String MaBA, int sttKhoa,string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSDList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 3, qadmin));
        }
        public static BenhAn_ThuocSDList GetAllBenhAn_ThuocSDByMaPT(String MaBA, int sttKhoa, string mapt, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSDList>(new OtherCriteria(MaBA, sttKhoa, mapt, 6, qadmin));
        }
        public static BenhAn_ThuocSDList GetAllBenhAn_ThuocSDByMaDVTT(String MaBA, int sttKhoa, string mapt, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_ThuocSDList>(new OtherCriteria(MaBA, sttKhoa, mapt, 7, qadmin));
        }
        public BenhAn_ThuocSD NewTo() 
        {
            BenhAn_ThuocSD obj = BenhAn_ThuocSD.NewBenhAn_ThuocSD();
            return obj;
        }
        public void NewTo(BenhAn_ThuocSD _BenhAn_ThuocSD)
        {
            try
            {
                if (!Contains(_BenhAn_ThuocSD.Mathuoc, _BenhAn_ThuocSD.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_ThuocSD.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_ThuocSD);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_ThuocSD.STT = ++_count;
                        Add(_BenhAn_ThuocSD);
                    }
                    else
                    {
                        _BenhAn_ThuocSD.STT = 1;
                        Add(_BenhAn_ThuocSD);

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
       
      
        public void UpdatedTo(BenhAn_ThuocSD _BenhAn_ThuocSD)
        {

            _BenhAn_ThuocSD.STT = this.Items[this.IndexOf(_BenhAn_ThuocSD)].STT;
            this.Items[this.IndexOf(_BenhAn_ThuocSD)] = _BenhAn_ThuocSD;
        }
        //public void RemoveTo(BenhAn_ThuocSD _BenhAn_ThuocSD)
        //{
        //    this.Items.Remove(_BenhAn_ThuocSD);

        //}
        public BenhAn_ThuocSD  AssignTo(BenhAn_ThuocSD  _BenhAn_ThuocSD)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_ThuocSD.Mathuoc, _BenhAn_ThuocSD.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_ThuocSD.STT = ++_count;
                   // _BenhAn_ThuocSD.STTKhoa = this.Items[0].STTKhoa; 
                    Add(_BenhAn_ThuocSD);
                }
                else
                {
                    _BenhAn_ThuocSD.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    Add(_BenhAn_ThuocSD);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_ThuocSD;
        }
        public bool Contains(string MaThuoc, bool Huy)
        {
    //        foreach (BenhAn_ThuocSD obj in this)
    //            if ((obj.Mathuoc == MaThuoc) && (obj.Huy == Huy) && ((obj.SLTra == "0") || (obj.SLTra == "")) && (obj.DATT != 0))
    //            {
    ////                if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
         
    ////                return false ;
    ////else
    ////                return true;
    //            }
            return false;
        }
        public BenhAn_ThuocSD  GetBenhAn_ThuocSDById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_ThuocSD  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_ThuocSD  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(BenhAn_ThuocSD obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_ThuocSD GetTo(decimal STT) //
        {
            foreach (BenhAn_ThuocSD obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_ThuocSD  item = BenhAn_ThuocSD.NewBenhAn_ThuocSD();
            Add(item);
            return item;
        }

      
        private BenhAn_ThuocSDList()
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
            public OtherCriteria(String MaBA, int sttKhoa,  string NgayDK, byte loai,Boolean qadmin)
            {
                if (loai == 6)
                {
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and a.mapttt ='" + NgayDK + "'";
                }
                else  if (loai == 7)
                {
                    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and a.madvtt ='" + NgayDK + "'";
                }
                else if (DateTime.Now.ToString("dd/MM/yyyy") == DateTime.Now.ToShortDateString())
                    if (loai == 2)
                       // _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) <=0";
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) =0 ";
                    else if (loai == 3)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + DateTime.Parse(NgayDK).ToString("MM/dd/yyyy") + "')) =0 ";
                    else if (loai == 4)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.maba = '" + MaBA + "'";
                    else if (loai == 5)
                        _DK = NgayDK ;
                    else
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";

                else

                    if (loai == 2)
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) =0 ";
                    else if (loai == 4)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.maba = '" + MaBA + "'";
                    else if (loai == 3)
                        _DK = " and isnull(b.machungloai,'') ='00007' and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) =0 ";
                    else if (loai == 5)
                        _DK = NgayDK;
                    else
                        _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";

                if ((loai == 2 || loai ==3) && HTC.ShareVariables.pub_spC == "HU")
                    _DK = _DK + " and isnull(a.mapttt,'') = ''"; 

                _STTKhoa = sttKhoa;
                _MaBA = MaBA;
                _qadmin =qadmin ;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ThuocSD(criteria.MaBA,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_ThuocSD .GetBenhAn_ThuocSD(dr,i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_ThuocSDBySTTKhoa(criteria.MaBA,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_ThuocSD.GetBenhAn_ThuocSD(dr, i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_ThuocSD  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_ThuocSD  item in this)
            {
                if ((item.SLKeDon != "0" || item.SLMua != "0"))
                if (item.IsNew) 
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_ThuocSDList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_ThuocSDList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
