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

    public class BenhAn_DanhGiaTTDD_BenhLQList : BusinessListBase<BenhAn_DanhGiaTTDD_BenhLQList, BenhAn_DanhGiaTTDD_BenhLQ>
    {
        #region Factory Methods
        public static BenhAn_DanhGiaTTDD_BenhLQList GetAllBenhAn_DanhGiaTTDD_BenhLQ(String MaBA, Boolean Qadmin, Int32 LanDanhGia)
        {
            return DataPortal.Fetch<BenhAn_DanhGiaTTDD_BenhLQList>(new Criteria(MaBA, "", Qadmin, LanDanhGia));
        }
        public BenhAn_DanhGiaTTDD_BenhLQ NewTo() 
        {
            BenhAn_DanhGiaTTDD_BenhLQ obj = BenhAn_DanhGiaTTDD_BenhLQ.NewBenhAn_DanhGiaTTDD_BenhLQ();
            return obj;
        }
        public void NewTo(BenhAn_DanhGiaTTDD_BenhLQ _BenhAn_DanhGiaTTDD_BenhLQ)
        {
            try
            {
                if (!Contains( _BenhAn_DanhGiaTTDD_BenhLQ.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_DanhGiaTTDD_BenhLQ.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_DanhGiaTTDD_BenhLQ);
                        //byte _count = 0;
                        //_count = (byte)this.Items.Count;
                        //_BenhAn_DanhGiaTTDD_BenhLQ.STT = ++_count;
                        this.Add(_BenhAn_DanhGiaTTDD_BenhLQ);
                    }
                    else
                    {
                        //_BenhAn_DanhGiaTTDD_BenhLQ.STT = 1;
                        this.Add(_BenhAn_DanhGiaTTDD_BenhLQ);

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
       
      
        public void UpdatedTo(BenhAn_DanhGiaTTDD_BenhLQ _BenhAn_DanhGiaTTDD_BenhLQ)
        {

            //_BenhAn_DanhGiaTTDD_BenhLQ.STT = this.Items[this.IndexOf(_BenhAn_DanhGiaTTDD_BenhLQ)].STT;
            this.Items[this.IndexOf(_BenhAn_DanhGiaTTDD_BenhLQ)] = _BenhAn_DanhGiaTTDD_BenhLQ;
        }
        //public void RemoveTo(BenhAn_DanhGiaTTDD_BenhLQ _BenhAn_DanhGiaTTDD_BenhLQ)
        //{
        //    this.Items.Remove(_BenhAn_DanhGiaTTDD_BenhLQ);

        //}
        public void RemoveTo(BenhAn_DanhGiaTTDD_BenhLQ obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_DanhGiaTTDD_BenhLQ  AssignTo(BenhAn_DanhGiaTTDD_BenhLQ  _BenhAn_DanhGiaTTDD_BenhLQ)//add mot hang PhieuNhap_C
        {
            if (!Contains( _BenhAn_DanhGiaTTDD_BenhLQ.Huy))
            {
                if (this.Items.Count > 0)
                {
                    //Byte _count = 0;
                    //_count = (Byte)this.Items.Count;
                    //// _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    //_BenhAn_DanhGiaTTDD_BenhLQ.STT = ++_count;
                    this.Add(_BenhAn_DanhGiaTTDD_BenhLQ);
                }
                else
                {
                    //_BenhAn_DanhGiaTTDD_BenhLQ.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_DanhGiaTTDD_BenhLQ);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_DanhGiaTTDD_BenhLQ;
        }
        public bool Contains(bool Huy)
        {
            //foreach (BenhAn_DanhGiaTTDD_BenhLQ  obj in this)
            //    if ((obj.MaLDNghi == MaLDNghi) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
            //        //    return false;
            //        //else
            //        //    return true;
            //    }
            return false;
        }
        public BenhAn_DanhGiaTTDD_BenhLQ  GetBenhAn_DanhGiaTTDD_BenhLQById(string MaBA, string MaBenhID, int LanDanhGia)
        {
            foreach (BenhAn_DanhGiaTTDD_BenhLQ  item in this)
                if ((item.MaBA == MaBA) && (item.MaBenhID == MaBenhID) && (item.LanDanhGia == LanDanhGia))
                    return item;
            return null;
        }
        public void Remove(string MaBA, string MaBenhID, int LanDanhGia)
        {
            foreach (BenhAn_DanhGiaTTDD_BenhLQ  item in this)
            {
                if ((item.MaBA == MaBA) && (item.MaBenhID == MaBenhID) && (item.LanDanhGia == LanDanhGia))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_DanhGiaTTDD_BenhLQ GetTo(String MaBenhID) //
        {
            foreach (BenhAn_DanhGiaTTDD_BenhLQ obj in this)
                if (obj.MaBenhID == MaBenhID)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_DanhGiaTTDD_BenhLQ  item = BenhAn_DanhGiaTTDD_BenhLQ.NewBenhAn_DanhGiaTTDD_BenhLQ();
            Add(item);
            return item;
        }

      
        private BenhAn_DanhGiaTTDD_BenhLQList()
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
            private String _MaBA;
            private Boolean _qadmin = false;
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
            private int _LanDanhGia;
            public int LanDanhGia
            {
                get
                {
                    return _LanDanhGia;
                }
            }
            public Criteria(String mMaBA, String DK, Boolean QAdmin, Int32 LanDanhGia)
            {
                _MaBA = mMaBA;
                _DK = DK;
                _qadmin = QAdmin;
                _LanDanhGia = LanDanhGia;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_DanhGiaTTDD_BenhLQ(criteria.MaBA, criteria.qadmin, criteria.LanDanhGia)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_DanhGiaTTDD_BenhLQ.GetBenhAn_DanhGiaTTDD_BenhLQ(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_DanhGiaTTDD_BenhLQ  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_DanhGiaTTDD_BenhLQ  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_DanhGiaTTDD_BenhLQList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_DanhGiaTTDD_BenhLQList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
