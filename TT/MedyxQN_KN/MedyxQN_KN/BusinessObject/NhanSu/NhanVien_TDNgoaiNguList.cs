



using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////

namespace HTC.Business.NhanSu
{
    [Serializable()]

    public class NhanVien_TDNgoaiNguList : BusinessListBase<NhanVien_TDNgoaiNguList, NhanVien_TDNgoaiNgu>
    {
        #region Factory Methods
        //public static NhanVien_QTCongTacList GetAllNhanVien_QTCongTac(String MaBA)
        //{
        //    return DataPortal.Fetch<NhanVien_QTCongTacList>(new Criteria(MaBA,qadmin ));
        //}
        public static NhanVien_TDNgoaiNguList FindNhanVien_TDNgoaiNguByMaNV(String MaNV)
        {
            return DataPortal.Fetch<NhanVien_TDNgoaiNguList>(new OtherCriteria(MaNV, ""));
        }
        //public static NhanVien_QTCongTacList FindNhanVien_QTCongTacByTenNV(String TenNV)
        //{
        //    return DataPortal.Fetch<NhanVien_QTCongTacList>(new OtherCriteria(TenNV, 2));
        //}
        public NhanVien_TDNgoaiNgu NewTo()
        {
            NhanVien_TDNgoaiNgu obj = NhanVien_TDNgoaiNgu.NewNhanVien_TDNgoaiNgu();
            return obj;
        }
        public void NewTo(NhanVien_TDNgoaiNgu _NhanVien_TDNgoaiNgu)
        {
            try
            {
                //if (!Contains(_NhanVien_TDNgoaiNgu.MaNV, _NhanVien_TDNgoaiNgu.STT, _NhanVien_TDNgoaiNgu.Huy))
                //{
                    if (this.Items.Count > 0)
                    {

                        int _count = 0;
                        _count = this.Items.Count;
                        _NhanVien_TDNgoaiNgu.OrderNumber = ++_count;
                        this.Add(_NhanVien_TDNgoaiNgu);
                    }
                    else
                    {
                        _NhanVien_TDNgoaiNgu.OrderNumber = 1;
                        this.Add(_NhanVien_TDNgoaiNgu);

                    }
                //}
                //else
                //    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException(HTC.ShareVariables.VAR_DATA+ex.Message);
            }
        }


        public void UpdatedTo(NhanVien_TDNgoaiNgu _NhanVien_TDNgoaiNgu)
        {

            _NhanVien_TDNgoaiNgu.OrderNumber = this.Items[this.IndexOf(_NhanVien_TDNgoaiNgu)].OrderNumber;
            this.Items[this.IndexOf(_NhanVien_TDNgoaiNgu)] = _NhanVien_TDNgoaiNgu;
        }
        //public void RemoveTo(NhanVien_QTCongTac _NhanVien_QTCongTac)
        //{
        //    this.Items.Remove(_NhanVien_QTCongTac);

        //}
        public NhanVien_TDNgoaiNgu AssignTo(NhanVien_TDNgoaiNgu _NhanVien_TDNgoaiNgu)
        {
            //if (!Contains(_NhanVien_TDNgoaiNgu.MaNV, _NhanVien_TDNgoaiNgu.STT, _NhanVien_TDNgoaiNgu.Huy))
            //{
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _NhanVien_TDNgoaiNgu.OrderNumber = ++_count;
                    //_NhanVien_QTCongTac.MaNV = maNV; 
                    // _NhanVien_QTCongTac.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_NhanVien_TDNgoaiNgu);
                }
                else
                {
                    _NhanVien_TDNgoaiNgu.OrderNumber = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_NhanVien_TDNgoaiNgu);
                }
            //}
    
            return _NhanVien_TDNgoaiNgu;
        }
        public bool Contains(string MaNV, int stt, bool Huy)
        {
            foreach (NhanVien_TDNgoaiNgu obj in this)
                if ((obj.STT == stt) && (obj.MaNV == MaNV) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public NhanVien_TDNgoaiNgu GetNhanVien_TDNgoaiNguById(string MaNV, int stt)
        {
            foreach (NhanVien_TDNgoaiNgu item in this)
                if ((item.MaNV == MaNV) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string MaNV, int stt)
        {
            foreach (NhanVien_TDNgoaiNgu item in this)
            {
                if ((item.MaNV == MaNV) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(NhanVien_TDNgoaiNgu obj)
        {

            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public NhanVien_TDNgoaiNgu GetTo(decimal STT)
        {
            foreach (NhanVien_TDNgoaiNgu obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            NhanVien_TDNgoaiNgu item = NhanVien_TDNgoaiNgu.NewNhanVien_TDNgoaiNgu();
            Add(item);
            return item;
        }


        private NhanVien_TDNgoaiNguList()
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
            public Criteria(String mMaBA)
            {
                _MaBA = mMaBA;

            }
        }
        private class OtherCriteria
        {
             private Boolean _qadmin = false ;

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
            private string _MaNV;
            public string MaNV
            {
                get
                {
                    return _MaNV;
                }
            }
            public OtherCriteria(String MaNV, string dk)
            {
                //if (loai == 2)
                //    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "' and datediff(d,a.tungay ,convert(datetime,'" + NgayDK + "')) >=0 and datediff(d,a.denngay ,convert(datetime,'" + NgayDK + "')) <=0";
                //else
                //    _DK = " and a.STTKhoa = " + sttKhoa + " and a.maba = '" + MaBA + "'";

                //_STTKhoa = sttKhoa;
                //_MaBA = MaBA;
                _MaNV = MaNV;
                _DK = dk;

            }
        }

        //private void DataPortal_Fetch(Criteria criteria)
        //{
        //    this.RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNhanVien_QTCongTac(criteria.MaBA,"", criteria.qadmin)))
        //    {
        //        int i = 1;
        //        while (dr.Read())
        //        {
        //            this.Add(NhanVien_QTCongTac .GetNhanVien_QTCongTac(dr,i));
        //            i++;
        //        }
        //    }
        //    this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindNhanVien_TDNgoaiNgu(criteria.MaNV, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(NhanVien_TDNgoaiNgu.GetNhanVien_TDNgoaiNgu(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            //foreach (NhanVien_TDNgoaiNgu item in DeletedList)
            //{
            //    item.DeleteSelf();
            //}

            //DeletedList.Clear();

            foreach (NhanVien_TDNgoaiNgu item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override NhanVien_TDNgoaiNguList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            NhanVien_TDNgoaiNguList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
