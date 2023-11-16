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

    public class NhanVien_QTTangLuongList : BusinessListBase<NhanVien_QTTangLuongList, NhanVien_QTTangLuong>
    {
        #region Factory Methods
        //public static NhanVien_QTTangLuongList GetAllNhanVien_QTTangLuong(String MaBA)
        //{
        //    return DataPortal.Fetch<NhanVien_QTTangLuongList>(new Criteria(MaBA,qadmin ));
        //}
        public static NhanVien_QTTangLuongList FindNhanVien_QTTangLuongByMaNV(String MaNV)
        {
            return DataPortal.Fetch<NhanVien_QTTangLuongList>(new OtherCriteria(MaNV,""));
        }
        //public static NhanVien_QTTangLuongList FindNhanVien_QTTangLuongByTenNV(String TenNV)
        //{
        //    return DataPortal.Fetch<NhanVien_QTTangLuongList>(new OtherCriteria(TenNV, 2));
        //}
        public NhanVien_QTTangLuong NewTo() 
        {
            NhanVien_QTTangLuong obj = NhanVien_QTTangLuong.NewNhanVien_QTTangLuong();
            return obj;
        }
        public void NewTo(NhanVien_QTTangLuong _NhanVien_QTTangLuong)
        {
            try
            {
                if (!Contains(_NhanVien_QTTangLuong.MaNV, _NhanVien_QTTangLuong.STT,  _NhanVien_QTTangLuong.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                       
                        int _count = 0;
                        _count = this.Items.Count;
                        _NhanVien_QTTangLuong.STT = ++_count;
                        this.Add(_NhanVien_QTTangLuong);
                    }
                    else
                    {
                        _NhanVien_QTTangLuong.STT = 1;
                        this.Add(_NhanVien_QTTangLuong);

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
       
      
        public void UpdatedTo(NhanVien_QTTangLuong _NhanVien_QTTangLuong)
        {

            _NhanVien_QTTangLuong.STT = this.Items[this.IndexOf(_NhanVien_QTTangLuong)].STT;
            this.Items[this.IndexOf(_NhanVien_QTTangLuong)] = _NhanVien_QTTangLuong;
        }
        //public void RemoveTo(NhanVien_QTTangLuong _NhanVien_QTTangLuong)
        //{
        //    this.Items.Remove(_NhanVien_QTTangLuong);

        //}
        public NhanVien_QTTangLuong  AssignTo(NhanVien_QTTangLuong  _NhanVien_QTTangLuong)
        {
            if (!Contains(_NhanVien_QTTangLuong.MaNV, _NhanVien_QTTangLuong.STT, _NhanVien_QTTangLuong.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _NhanVien_QTTangLuong.STT = ++_count;
                   // _NhanVien_QTTangLuong.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_NhanVien_QTTangLuong);
                }
                else
                {
                    _NhanVien_QTTangLuong.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_NhanVien_QTTangLuong);
                }
            }
            //Add(_PhieuNhap_C);
            return _NhanVien_QTTangLuong;
        }
        public bool Contains(string MaNV, int stt, bool Huy)
        {
            foreach (NhanVien_QTTangLuong  obj in this)
                if ((obj.STT == stt) && (obj.MaNV == MaNV) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public NhanVien_QTTangLuong  GetNhanVien_QTTangLuongById(string MaNV, int stt)
        {
            foreach (NhanVien_QTTangLuong  item in this)
                if ((item.MaNV == MaNV) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string MaNV, int stt)
        {
            foreach (NhanVien_QTTangLuong  item in this)
            {
                if ((item.MaNV == MaNV) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(NhanVien_QTTangLuong obj) 
        {

            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public NhanVien_QTTangLuong GetTo(decimal STT) 
        {
            foreach (NhanVien_QTTangLuong obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            NhanVien_QTTangLuong  item = NhanVien_QTTangLuong.NewNhanVien_QTTangLuong();
            Add(item);
            return item;
        }

      
        private NhanVien_QTTangLuongList()
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNhanVien_QTTangLuong(criteria.MaBA,"", criteria.qadmin)))
        //    {
        //        int i = 1;
        //        while (dr.Read())
        //        {
        //            this.Add(NhanVien_QTTangLuong .GetNhanVien_QTTangLuong(dr,i));
        //            i++;
        //        }
        //    }
        //    this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindNhanVien_QTTangLuong(criteria.MaNV,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(NhanVien_QTTangLuong.GetNhanVien_QTTangLuong(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (NhanVien_QTTangLuong  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (NhanVien_QTTangLuong  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override NhanVien_QTTangLuongList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            NhanVien_QTTangLuongList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
