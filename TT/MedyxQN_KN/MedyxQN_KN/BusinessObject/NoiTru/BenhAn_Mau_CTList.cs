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

    public class BenhAn_Mau_CTList : BusinessListBase<BenhAn_Mau_CTList, BenhAn_Mau_CT>
    {
        #region Factory Methods
        public static BenhAn_Mau_CTList NewList()
        {
            return DataPortal.Fetch<BenhAn_Mau_CTList>(new TemCriteria());
        }
        public static BenhAn_Mau_CTList GetAllBenhAn_Mau_CT(String MaBA, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_Mau_CTList>(new Criteria(MaBA,qadmin ));
        }
        public static BenhAn_Mau_CTList GetAllBenhAn_Mau_CTBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_Mau_CTList>(new OtherCriteria(MaBA,sttKhoa,"",1,qadmin ));
        }
        public static BenhAn_Mau_CTList GetAllBenhAn_Mau_CTByNgayYC(String MaBA, int sttKhoa,string NgayDK, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_Mau_CTList>(new OtherCriteria(MaBA, sttKhoa, NgayDK,2,qadmin ));
        }
        public BenhAn_Mau_CT NewTo() 
        {
            BenhAn_Mau_CT obj = BenhAn_Mau_CT.NewBenhAn_Mau_CT();
            return obj;
        }
        public void NewTo(BenhAn_Mau_CT _BenhAn_Mau_CT)
        {
            try
            {
                if (!Contains(_BenhAn_Mau_CT.MaCPMau , _BenhAn_Mau_CT.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_Mau_CT.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_Mau_CT);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_Mau_CT.STT = ++_count;
                        this.Add(_BenhAn_Mau_CT);
                    }
                    else
                    {
                        _BenhAn_Mau_CT.STT = 1;
                        this.Add(_BenhAn_Mau_CT);

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
       
      
        public void UpdatedTo(BenhAn_Mau_CT _BenhAn_Mau_CT)
        {

            _BenhAn_Mau_CT.STT = this.Items[this.IndexOf(_BenhAn_Mau_CT)].STT;
            this.Items[this.IndexOf(_BenhAn_Mau_CT)] = _BenhAn_Mau_CT;
        }
        //public void RemoveTo(BenhAn_Mau_CT _BenhAn_Mau_CT)
        //{
        //    this.Items.Remove(_BenhAn_Mau_CT);

        //}
        public void RemoveTo(BenhAn_Mau_CT obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_Mau_CT  AssignTo(BenhAn_Mau_CT  _BenhAn_Mau_CT)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_Mau_CT.MaCPMau ,  _BenhAn_Mau_CT.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _BenhAn_Mau_CT.STT = ++_count;
                    this.Add(_BenhAn_Mau_CT);
                }
                else
                {
                    _BenhAn_Mau_CT.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_Mau_CT);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_Mau_CT;
        }
        public bool Contains(string MaMau, bool Huy)
        {
            //foreach (BenhAn_Mau_CT  obj in this)
            //    if ((obj.MaCPMau == MaMau) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
            //        //    return false;
            //        //else
            //        //    return true;
            //    }
            return false;
        }
        public BenhAn_Mau_CT  GetBenhAn_Mau_CTById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_Mau_CT  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_Mau_CT  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_Mau_CT GetTo(decimal STT) //
        {
            foreach (BenhAn_Mau_CT obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_Mau_CT  item = BenhAn_Mau_CT.NewBenhAn_Mau_CT();
            Add(item);
            return item;
        }

      
        private BenhAn_Mau_CTList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Mau_CT(criteria.MaBA,"", criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_Mau_CT.GetBenhAn_Mau_CT(dr,i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_Mau_CTBySTTKhoa(criteria.MaBA, criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_Mau_CT.GetBenhAn_Mau_CT(dr, i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_Mau_CT  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_Mau_CT  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_Mau_CTList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_Mau_CTList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
