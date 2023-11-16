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

    public class BenhAn_DanhGiaHoSoList : BusinessListBase<BenhAn_DanhGiaHoSoList, BenhAn_DanhGiaHoSo>
    {
        #region Factory Methods
        public static BenhAn_DanhGiaHoSoList GetAllBenhAn_DanhGiaHoSo(String MaBA, String DK, Boolean Qadmin)
        {
            return DataPortal.Fetch<BenhAn_DanhGiaHoSoList>(new Criteria(MaBA,DK ,Qadmin ));
        }
        //public static BenhAn_DanhGiaHoSoList GetAllBenhAn_DanhGiaHoSoBySTTKhoa(String MaBA, int sttKhoa, Boolean qadmin)
        //{
        //    return DataPortal.Fetch<BenhAn_DanhGiaHoSoList>(new OtherCriteria(MaBA,sttKhoa,"",1,qadmin ));
        //}
        //public static BenhAn_DanhGiaHoSoList GetAllBenhAn_DanhGiaHoSoByNgayYC(String MaBA, int sttKhoa,string NgayDK, Boolean qadmin)
        //{
        //    return DataPortal.Fetch<BenhAn_DanhGiaHoSoList>(new OtherCriteria(MaBA, sttKhoa, NgayDK, 2, qadmin));
        //}
        public BenhAn_DanhGiaHoSo NewTo() 
        {
            BenhAn_DanhGiaHoSo obj = BenhAn_DanhGiaHoSo.NewBenhAn_DanhGiaHoSo();
            return obj;
        }
        public void NewTo(BenhAn_DanhGiaHoSo _BenhAn_DanhGiaHoSo)
        {
            try
            {
                if (!Contains(_BenhAn_DanhGiaHoSo.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_BenhAn_DanhGiaHoSo.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_BenhAn_DanhGiaHoSo);
                        //byte _count = 0;
                        //_count = (byte)this.Items.Count;
                        //_BenhAn_DanhGiaHoSo.STT = ++_count;
                        this.Add(_BenhAn_DanhGiaHoSo);
                    }
                    else
                    {
                        //_BenhAn_DanhGiaHoSo.STT = 1;
                        this.Add(_BenhAn_DanhGiaHoSo);

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
       
      
        public void UpdatedTo(BenhAn_DanhGiaHoSo _BenhAn_DanhGiaHoSo)
        {

            _BenhAn_DanhGiaHoSo.MaBA = this.Items[this.IndexOf(_BenhAn_DanhGiaHoSo)].MaBA;
            this.Items[this.IndexOf(_BenhAn_DanhGiaHoSo)] = _BenhAn_DanhGiaHoSo;
        }
        //public void RemoveTo(BenhAn_DanhGiaHoSo _BenhAn_DanhGiaHoSo)
        //{
        //    this.Items.Remove(_BenhAn_DanhGiaHoSo);

        //}
        public void RemoveTo(BenhAn_DanhGiaHoSo obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public BenhAn_DanhGiaHoSo  AssignTo(BenhAn_DanhGiaHoSo  _BenhAn_DanhGiaHoSo)//add mot hang PhieuNhap_C
        {
            if (!Contains(_BenhAn_DanhGiaHoSo.Huy))
            {
                if (this.Items.Count > 0)
                {
                    //Byte _count = 0;
                    //_count = (Byte)this.Items.Count;
                    //// _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    //_BenhAn_DanhGiaHoSo.STT = ++_count;
                    this.Add(_BenhAn_DanhGiaHoSo);
                }
                else
                {
                    //_BenhAn_DanhGiaHoSo.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_BenhAn_DanhGiaHoSo);
                }
            }
            //Add(_PhieuNhap_C);
            return _BenhAn_DanhGiaHoSo;
        }
        public bool Contains(bool Huy)
        {
            //foreach (BenhAn_DanhGiaHoSo  obj in this)
            //    if ((obj.MaLDNghi == MaLDNghi) && (obj.Huy == Huy))
            //    {
            //        //if (MessageBox.Show("Dịch vụ này đã được chọn rồi!Bạn chọn tiếp ?", "Thongbao", MessageBoxButtons.OKCancel) == DialogResult.OK )
            //        //    return false;
            //        //else
            //        //    return true;
            //    }
            return false;
        }
        public BenhAn_DanhGiaHoSo  GetBenhAn_DanhGiaHoSoById(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_DanhGiaHoSo  item in this)
                if (item.MaBA == MaBA)
                    return item;
            return null;
        }
        public void Remove(string MaBA, int stt, int sttkhoa)
        {
            foreach (BenhAn_DanhGiaHoSo  item in this)
            {
                if (item.MaBA == MaBA)
                {
                    Remove(item);
                    break;
                }
            }
        }
        public BenhAn_DanhGiaHoSo GetTo(string MaBA) //
        {
            foreach (BenhAn_DanhGiaHoSo obj in this)
                if (obj.MaBA == MaBA)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            BenhAn_DanhGiaHoSo  item = BenhAn_DanhGiaHoSo.NewBenhAn_DanhGiaHoSo();
            Add(item);
            return item;
        }

      
        private BenhAn_DanhGiaHoSoList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_DanhGiaHoSo(criteria.MaBA, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(BenhAn_DanhGiaHoSo.GetBenhAn_DanhGiaHoSo(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        //private void DataPortal_Fetch(OtherCriteria criteria)
        //{
        //    this.RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_DanhGiaHoSoBySTTKhoa(criteria.MaBA, criteria.DK , criteria.qadmin)))
        //    {
        //        int i = 1;
        //        while (dr.Read())
        //        {
        //            this.Add(BenhAn_DanhGiaHoSo.GetBenhAn_DanhGiaHoSo(dr, i));
        //            i++;
        //        } dr.Close(); dr.Dispose();
        //    }
        //    this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (BenhAn_DanhGiaHoSo  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (BenhAn_DanhGiaHoSo  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override BenhAn_DanhGiaHoSoList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            BenhAn_DanhGiaHoSoList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
