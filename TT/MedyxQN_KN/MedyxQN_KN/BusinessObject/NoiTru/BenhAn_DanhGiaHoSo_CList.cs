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

    public class BenhAn_DanhGiaHoSo_CList : BusinessListBase<BenhAn_DanhGiaHoSo_CList, BenhAn_DanhGiaHoSo_C>
    {
        #region Factory Methods
        public static BenhAn_DanhGiaHoSo_CList GetAllBenhAn_DanhGiaHoSo_C(String MaBA, String DK, Boolean Qadmin)
        {
            return DataPortal.Fetch<BenhAn_DanhGiaHoSo_CList>(new Criteria(MaBA,DK ,Qadmin ));
        }
        public static BenhAn_DanhGiaHoSo_CList GetAllBenhAn_DanhGiaHoSo_CByMaDGHS(String MaBA, String MaDGHS, Boolean qadmin)
        {
            return DataPortal.Fetch<BenhAn_DanhGiaHoSo_CList>(new OtherCriteria(MaBA,MaDGHS,qadmin ));
        }
        //public static BenhAn_DanhGiaHoSo_CList GetAllBenhAn_DanhGiaHoSo_CByNgayYC(String MaBA, int sttKhoa,string NgayDK, Boolean qadmin)
        //{
        //    return DataPortal.Fetch<BenhAn_DanhGiaHoSo_CList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2, qadmin));
        //}
        public BenhAn_DanhGiaHoSo_C NewTo() 
        {
            BenhAn_DanhGiaHoSo_C obj = BenhAn_DanhGiaHoSo_C.NewBenhAn_DanhGiaHoSo_C();
            return obj;
        }
        public void NewTo(BenhAn_DanhGiaHoSo_C _BenhAn_DanhGiaHoSo_C)
        {
            try
            {
                if (!Contains(_BenhAn_DanhGiaHoSo_C.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_DanhGiaHoSo_C.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_DanhGiaHoSo_C);
                        //byte _count = 0;
                        //_count = (byte)this.Items.Count;
                        //_BenhAn_DanhGiaHoSo_C.STT = ++_count;
                        this.Add(_BenhAn_DanhGiaHoSo_C);
                    }
                    else
                    {
                        //_BenhAn_DanhGiaHoSo_C.STT = 1;
                        this.Add(_BenhAn_DanhGiaHoSo_C);

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
       
      
        public void UpdatedTo(BenhAn_DanhGiaHoSo_C _BenhAn_DanhGiaHoSo_C)
        {

            _BenhAn_DanhGiaHoSo_C.MaDGHS = this.Items[this.IndexOf(_BenhAn_DanhGiaHoSo_C)].MaDGHS;
            this.Items[this.IndexOf(_BenhAn_DanhGiaHoSo_C)] = _BenhAn_DanhGiaHoSo_C;
        }
        //public void RemoveTo(BenhAn_DanhGiaHoSo_C _BenhAn_DanhGiaHoSo_C)
        //{
        //    this.Items.Remove(_BenhAn_DanhGiaHoSo_C);

        //}
        public void RemoveTo(BenhAn_DanhGiaHoSo_C obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_DanhGiaHoSo_C  AssignTo(BenhAn_DanhGiaHoSo_C  _BenhAn_DanhGiaHoSo_C)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_DanhGiaHoSo_C.Huy))
            {
                if (this.Items.Count > 0)
                {
                    //Byte _count = 0;
                    //_count = (Byte)this.Items.Count;
                    //// _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    //_BenhAn_DanhGiaHoSo_C.STT = ++_count;
                    this.Add(_BenhAn_DanhGiaHoSo_C);
                }
                else
                {
                    //_BenhAn_DanhGiaHoSo_C.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_DanhGiaHoSo_C);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_DanhGiaHoSo_C;
        }
        public bool Contains(bool Huy)
        {
            //foreach (BenhAn_DanhGiaHoSo_C  obj in this)
            //    if ((obj.MaLDNghi == MaLDNghi) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
            //        //    return false;
            //        //else
            //        //    return true;
            //    }
            return false;
        }
        public BenhAn_DanhGiaHoSo_C  GetBenhAn_DanhGiaHoSo_CById(string MaBA, string MaDGHS)
        {
            foreach (BenhAn_DanhGiaHoSo_C  item in this)
                if ((item.MaBA == MaBA) && (item.MaDGHS == MaDGHS))
                    return item;
            return null;
        }
        public void Remove(string MaBA,string MaDGHS)
        {
            foreach (BenhAn_DanhGiaHoSo_C  item in this)
            {
                if ((item.MaBA == MaBA) && (item.MaDGHS == MaDGHS))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_DanhGiaHoSo_C GetTo(string MaDGHS) //
        {
            foreach (BenhAn_DanhGiaHoSo_C obj in this)
                if (obj.MaDGHS == MaDGHS)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_DanhGiaHoSo_C  item = BenhAn_DanhGiaHoSo_C.NewBenhAn_DanhGiaHoSo_C();
            Add(item);
            return item;
        }

      
        private BenhAn_DanhGiaHoSo_CList()
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
            public Criteria(String mMaBA, String DK, Boolean QAdmin)
            {
                _MaBA = mMaBA;
                _DK = DK;
                _qadmin = QAdmin;
                
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
            private String _MaDGHS;
            public String MaDGHS
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
            public OtherCriteria(String MaBA, String MaDGHS, Boolean qadmin)
            {
                _DK = " and a.MaDGHS = " + MaDGHS + " and a.maba = '" + MaBA + "'";
                _MaBA = MaBA;
                _MaDGHS = MaDGHS;
                _qadmin = qadmin;
            }
        }
     
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_DanhGiaHoSo_C(criteria.MaBA, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_DanhGiaHoSo_C.GetBenhAn_DanhGiaHoSo_C(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_DanhGiaHoSo_CByMaDGHS(criteria.MaBA, criteria.MaDGHS, criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_DanhGiaHoSo_C.GetBenhAn_DanhGiaHoSo_C(dr, i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_DanhGiaHoSo_C  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_DanhGiaHoSo_C  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_DanhGiaHoSo_CList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_DanhGiaHoSo_CList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
