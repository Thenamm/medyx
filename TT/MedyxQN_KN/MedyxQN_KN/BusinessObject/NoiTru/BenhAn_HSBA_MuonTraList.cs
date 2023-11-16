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

    public class BenhAn_HSBA_MuonTraList : BusinessListBase<BenhAn_HSBA_MuonTraList, BenhAn_HSBA_MuonTra>
    {
        #region Factory Methods
        public static BenhAn_HSBA_MuonTraList GetAllBenhAn_HSBA_MuonTra(String MaBA, String DK, Boolean Qadmin)
        {
            return DataPortal.Fetch<BenhAn_HSBA_MuonTraList>(new Criteria(MaBA,"" ,Qadmin ));
        }
        public static BenhAn_HSBA_MuonTraList GetAllBenhAn_HSBA_MuonTra_ByPM(String MaPM, String DK, Boolean Tra, Boolean Qadmin)
        {
            return DataPortal.Fetch<BenhAn_HSBA_MuonTraList>(new CriteriaPM(MaPM, DK,Tra, Qadmin));
        }
        public BenhAn_HSBA_MuonTra NewTo() 
        {
            BenhAn_HSBA_MuonTra obj = BenhAn_HSBA_MuonTra.NewBenhAn_HSBA_MuonTra();
            return obj;
        }
        public void NewTo(BenhAn_HSBA_MuonTra _BenhAn_HSBA_MuonTra)
        {
            try
            {
                if (!Contains( _BenhAn_HSBA_MuonTra.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_HSBA_MuonTra.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_HSBA_MuonTra);
                        //byte _count = 0;
                        //_count = (byte)this.Items.Count;
                        //_BenhAn_HSBA_MuonTra.STT = ++_count;
                        this.Add(_BenhAn_HSBA_MuonTra);
                    }
                    else
                    {
                        //_BenhAn_HSBA_MuonTra.STT = 1;
                        this.Add(_BenhAn_HSBA_MuonTra);

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
       
      
        public void UpdatedTo(BenhAn_HSBA_MuonTra _BenhAn_HSBA_MuonTra)
        {

            //_BenhAn_HSBA_MuonTra.STT = this.Items[this.IndexOf(_BenhAn_HSBA_MuonTra)].STT;
            this.Items[this.IndexOf(_BenhAn_HSBA_MuonTra)] = _BenhAn_HSBA_MuonTra;
        }
        //public void RemoveTo(BenhAn_HSBA_MuonTra _BenhAn_HSBA_MuonTra)
        //{
        //    this.Items.Remove(_BenhAn_HSBA_MuonTra);

        //}
        public void RemoveTo(BenhAn_HSBA_MuonTra obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_HSBA_MuonTra  AssignTo(BenhAn_HSBA_MuonTra  _BenhAn_HSBA_MuonTra)//add mot hang PhieuNhap_C
        {
            if (!Contains( _BenhAn_HSBA_MuonTra.Huy))
            {
                if (this.Items.Count > 0)
                {
                    //Byte _count = 0;
                    //_count = (Byte)this.Items.Count;
                    //// _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    //_BenhAn_HSBA_MuonTra.STT = ++_count;
                    this.Add(_BenhAn_HSBA_MuonTra);
                }
                else
                {
                    //_BenhAn_HSBA_MuonTra.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_HSBA_MuonTra);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_HSBA_MuonTra;
        }
        public bool Contains(bool Huy)
        {
            //foreach (BenhAn_HSBA_MuonTra  obj in this)
            //    if ((obj.MaLDNghi == MaLDNghi) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
            //        //    return false;
            //        //else
            //        //    return true;
            //    }
            return false;
        }
        public BenhAn_HSBA_MuonTra  GetBenhAn_HSBA_MuonTraById(string MaBA, string MaMuon)
        {
            foreach (BenhAn_HSBA_MuonTra  item in this)
                if ((item.MaBA == MaBA) && (item.MaMuon == MaMuon))
                    return item;
            return null;
        }
        public void Remove(string MaBA, string MaMuon)
        {
            foreach (BenhAn_HSBA_MuonTra  item in this)
            {
                if ((item.MaBA == MaBA) && (item.MaMuon == MaMuon))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_HSBA_MuonTra GetTo(string MaMuon) //
        {
            foreach (BenhAn_HSBA_MuonTra obj in this)
                if (obj.MaMuon == MaMuon)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_HSBA_MuonTra  item = BenhAn_HSBA_MuonTra.NewBenhAn_HSBA_MuonTra();
            Add(item);
            return item;
        }

      
        private BenhAn_HSBA_MuonTraList()
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
        [Serializable()]
        private class CriteriaPM
        {
            private String _MaPM;
            private Boolean _qadmin = false;
            private Boolean _Tra = false;
            public String MaPM
            {
                get
                {
                    return _MaPM;
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
            public bool Tra
            {
                get
                {
                    return _Tra;
                }
            }
            public CriteriaPM(String mMaPM, String DK,Boolean Tra, Boolean QAdmin)
            {
                _MaPM = mMaPM;
                _DK = DK;
                _qadmin = QAdmin;
                _Tra = Tra;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_HSBA_MuonTra(criteria.MaBA, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_HSBA_MuonTra.GetBenhAn_HSBA_MuonTra(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaPM criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_HSBA_MuonTraByPM(criteria.MaPM,criteria.DK,criteria.Tra, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_HSBA_MuonTra.GetBenhAn_HSBA_MuonTra(dr, i));
                    i++;
                }
                dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_HSBA_MuonTra  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_HSBA_MuonTra  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        public override BenhAn_HSBA_MuonTraList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_HSBA_MuonTraList  result;
            result = base.Save();
            return result;
        }
        #endregion
    }
}
