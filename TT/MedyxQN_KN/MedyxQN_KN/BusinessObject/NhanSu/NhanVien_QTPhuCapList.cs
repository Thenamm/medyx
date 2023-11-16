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

    public class NhanVien_QTPhuCapList : BusinessListBase<NhanVien_QTPhuCapList, NhanVien_QTPhuCap>
    {
        #region Factory Methods
        //public static NhanVien_QTPhuCapList GetAllNhanVien_QTPhuCap(String MaBA)
        //{
        //    return DataPortal.Fetch<NhanVien_QTPhuCapList>(new Criteria(MaBA,qadmin ));
        //}
        public static NhanVien_QTPhuCapList FindNhanVien_QTPhuCapByMaNV(String MaNV)
        {
            return DataPortal.Fetch<NhanVien_QTPhuCapList>(new OtherCriteria(MaNV,""));
        }
        //public static NhanVien_QTPhuCapList FindNhanVien_QTPhuCapByTenNV(String TenNV)
        //{
        //    return DataPortal.Fetch<NhanVien_QTPhuCapList>(new OtherCriteria(TenNV, 2));
        //}
        public NhanVien_QTPhuCap NewTo() 
        {
            NhanVien_QTPhuCap obj = NhanVien_QTPhuCap.NewNhanVien_QTPhuCap();
            return obj;
        }
        public void NewTo(NhanVien_QTPhuCap _NhanVien_QTPhuCap)
        {
            try
            {
                if (!Contains(_NhanVien_QTPhuCap.MaNV, _NhanVien_QTPhuCap.STT,  _NhanVien_QTPhuCap.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                       
                        int _count = 0;
                        _count = this.Items.Count;
                        _NhanVien_QTPhuCap.STT = ++_count;
                        this.Add(_NhanVien_QTPhuCap);
                    }
                    else
                    {
                        _NhanVien_QTPhuCap.STT = 1;
                        this.Add(_NhanVien_QTPhuCap);

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
       
      
        public void UpdatedTo(NhanVien_QTPhuCap _NhanVien_QTPhuCap)
        {

            _NhanVien_QTPhuCap.STT = this.Items[this.IndexOf(_NhanVien_QTPhuCap)].STT;
            this.Items[this.IndexOf(_NhanVien_QTPhuCap)] = _NhanVien_QTPhuCap;
        }
        //public void RemoveTo(NhanVien_QTPhuCap _NhanVien_QTPhuCap)
        //{
        //    this.Items.Remove(_NhanVien_QTPhuCap);

        //}
        public NhanVien_QTPhuCap  AssignTo(NhanVien_QTPhuCap  _NhanVien_QTPhuCap)
        {
            if (!Contains(_NhanVien_QTPhuCap.MaNV, _NhanVien_QTPhuCap.STT, _NhanVien_QTPhuCap.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _NhanVien_QTPhuCap.STT = ++_count;
                   // _NhanVien_QTPhuCap.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_NhanVien_QTPhuCap);
                }
                else
                {
                    _NhanVien_QTPhuCap.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_NhanVien_QTPhuCap);
                }
            }
            //Add(_PhieuNhap_C);
            return _NhanVien_QTPhuCap;
        }
        public bool Contains(string MaNV, int stt, bool Huy)
        {
            foreach (NhanVien_QTPhuCap  obj in this)
                if ((obj.STT == stt) && (obj.MaNV == MaNV) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public NhanVien_QTPhuCap  GetNhanVien_QTPhuCapById(string MaNV, int stt)
        {
            foreach (NhanVien_QTPhuCap  item in this)
                if ((item.MaNV == MaNV) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string MaNV, int stt)
        {
            foreach (NhanVien_QTPhuCap  item in this)
            {
                if ((item.MaNV == MaNV) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(NhanVien_QTPhuCap obj) 
        {

            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public NhanVien_QTPhuCap GetTo(decimal STT) 
        {
            foreach (NhanVien_QTPhuCap obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            NhanVien_QTPhuCap  item = NhanVien_QTPhuCap.NewNhanVien_QTPhuCap();
            Add(item);
            return item;
        }

      
        private NhanVien_QTPhuCapList()
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNhanVien_QTPhuCap(criteria.MaBA,"", criteria.qadmin)))
        //    {
        //        int i = 1;
        //        while (dr.Read())
        //        {
        //            this.Add(NhanVien_QTPhuCap .GetNhanVien_QTPhuCap(dr,i));
        //            i++;
        //        }
        //    }
        //    this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindNhanVien_QTPhuCap(criteria.MaNV,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(NhanVien_QTPhuCap.GetNhanVien_QTPhuCap(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (NhanVien_QTPhuCap  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (NhanVien_QTPhuCap  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override NhanVien_QTPhuCapList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            NhanVien_QTPhuCapList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
