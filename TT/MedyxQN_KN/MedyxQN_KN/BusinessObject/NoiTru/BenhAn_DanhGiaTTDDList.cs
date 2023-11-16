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

    public class BenhAn_DanhGiaTTDDList : BusinessListBase<BenhAn_DanhGiaTTDDList, BenhAn_DanhGiaTTDD>
    {
        #region Factory Methods
        public static BenhAn_DanhGiaTTDDList GetAllBenhAn_DanhGiaTTDD(String MaBA, String DK, Boolean Qadmin)
        {
            return DataPortal.Fetch<BenhAn_DanhGiaTTDDList>(new Criteria(MaBA,"" ,Qadmin ));
        }
        public BenhAn_DanhGiaTTDD NewTo() 
        {
            BenhAn_DanhGiaTTDD obj = BenhAn_DanhGiaTTDD.NewBenhAn_DanhGiaTTDD();
            return obj;
        }
        public void NewTo(BenhAn_DanhGiaTTDD _BenhAn_DanhGiaTTDD)
        {
            try
            {
                if (!Contains( _BenhAn_DanhGiaTTDD.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_DanhGiaTTDD.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_DanhGiaTTDD);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _BenhAn_DanhGiaTTDD.STT = ++_count;
                        this.Add(_BenhAn_DanhGiaTTDD);
                    }
                    else
                    {
                        _BenhAn_DanhGiaTTDD.STT = 1;
                        this.Add(_BenhAn_DanhGiaTTDD);

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
       
      
        public void UpdatedTo(BenhAn_DanhGiaTTDD _BenhAn_DanhGiaTTDD)
        {

            _BenhAn_DanhGiaTTDD.STT = this.Items[this.IndexOf(_BenhAn_DanhGiaTTDD)].STT;
            this.Items[this.IndexOf(_BenhAn_DanhGiaTTDD)] = _BenhAn_DanhGiaTTDD;
        }
        //public void RemoveTo(BenhAn_DanhGiaTTDD _BenhAn_DanhGiaTTDD)
        //{
        //    this.Items.Remove(_BenhAn_DanhGiaTTDD);

        //}
        public void RemoveTo(BenhAn_DanhGiaTTDD obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_DanhGiaTTDD  AssignTo(BenhAn_DanhGiaTTDD  _BenhAn_DanhGiaTTDD)//add mot hang PhieuNhap_C
        {
            if (!Contains( _BenhAn_DanhGiaTTDD.Huy))
            {
                if (this.Items.Count > 0)
                {
                    //Byte _count = 0;
                    //_count = (Byte)this.Items.Count;
                    //// _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    //_BenhAn_DanhGiaTTDD.STT = ++_count;
                    this.Add(_BenhAn_DanhGiaTTDD);
                }
                else
                {
                    //_BenhAn_DanhGiaTTDD.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_DanhGiaTTDD);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_DanhGiaTTDD;
        }
        public bool Contains(bool Huy)
        {
            //foreach (BenhAn_DanhGiaTTDD  obj in this)
            //    if ((obj.MaLDNghi == MaLDNghi) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
            //        //    return false;
            //        //else
            //        //    return true;
            //    }
            return false;
        }
        public BenhAn_DanhGiaTTDD  GetBenhAn_DanhGiaTTDDById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_DanhGiaTTDD  item in this)
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_DanhGiaTTDD  item in this)
            {
                if ((item.MaBA == MaBA) && (item.STT == stt) && (item.STTKhoa == sttkhoa))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_DanhGiaTTDD GetTo(decimal STT) //
        {
            foreach (BenhAn_DanhGiaTTDD obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_DanhGiaTTDD  item = BenhAn_DanhGiaTTDD.NewBenhAn_DanhGiaTTDD();
            Add(item);
            return item;
        }
        private BenhAn_DanhGiaTTDDList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_DanhGiaTTDD(criteria.MaBA, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_DanhGiaTTDD.GetBenhAn_DanhGiaTTDD(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_DanhGiaTTDD  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_DanhGiaTTDD  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_DanhGiaTTDDList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_DanhGiaTTDDList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
