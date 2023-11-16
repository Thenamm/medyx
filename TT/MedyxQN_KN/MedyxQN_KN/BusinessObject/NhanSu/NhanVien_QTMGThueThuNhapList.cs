


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

    public class NhanVien_QTMGThueThuNhapList : BusinessListBase<NhanVien_QTMGThueThuNhapList, NhanVien_QTMGThueThuNhap>
    {
        #region Factory Methods
        //public static NhanVien_QTMGThueThuNhapList GetAllNhanVien_QTMGThueThuNhap(String MaBA)
        //{
        //    return DataPortal.Fetch<NhanVien_QTMGThueThuNhapList>(new Criteria(MaBA,qadmin ));
        //}
        public static NhanVien_QTMGThueThuNhapList FindNhanVien_QTMGThueThuNhapByMaNV(String MaNV)
        {
            return DataPortal.Fetch<NhanVien_QTMGThueThuNhapList>(new OtherCriteria(MaNV, ""));
        }
        //public static NhanVien_QTMGThueThuNhapList FindNhanVien_QTMGThueThuNhapByTenNV(String TenNV)
        //{
        //    return DataPortal.Fetch<NhanVien_QTMGThueThuNhapList>(new OtherCriteria(TenNV, 2));
        //}
        public NhanVien_QTMGThueThuNhap NewTo()
        {
            NhanVien_QTMGThueThuNhap obj = NhanVien_QTMGThueThuNhap.NewNhanVien_QTMGThueThuNhap();
            return obj;
        }
        public void NewTo(NhanVien_QTMGThueThuNhap _NhanVien_QTMGThueThuNhap)
        {
            try
            {
                if (!Contains(_NhanVien_QTMGThueThuNhap.MaNV, _NhanVien_QTMGThueThuNhap.STT, _NhanVien_QTMGThueThuNhap.Huy))
                {
                    if (this.Items.Count > 0)
                    {

                        int _count = 0;
                        _count = this.Items.Count;
                        _NhanVien_QTMGThueThuNhap.STT = ++_count;
                        this.Add(_NhanVien_QTMGThueThuNhap);
                    }
                    else
                    {
                        _NhanVien_QTMGThueThuNhap.STT = 1;
                        this.Add(_NhanVien_QTMGThueThuNhap);

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


        public void UpdatedTo(NhanVien_QTMGThueThuNhap _NhanVien_QTMGThueThuNhap)
        {

            _NhanVien_QTMGThueThuNhap.STT = this.Items[this.IndexOf(_NhanVien_QTMGThueThuNhap)].STT;
            this.Items[this.IndexOf(_NhanVien_QTMGThueThuNhap)] = _NhanVien_QTMGThueThuNhap;
        }
        //public void RemoveTo(NhanVien_QTMGThueThuNhap _NhanVien_QTMGThueThuNhap)
        //{
        //    this.Items.Remove(_NhanVien_QTMGThueThuNhap);

        //}
        public NhanVien_QTMGThueThuNhap AssignTo(NhanVien_QTMGThueThuNhap _NhanVien_QTMGThueThuNhap)
        {
            if (!Contains(_NhanVien_QTMGThueThuNhap.MaNV, _NhanVien_QTMGThueThuNhap.STT, _NhanVien_QTMGThueThuNhap.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _NhanVien_QTMGThueThuNhap.STT = ++_count;
                    // _NhanVien_QTMGThueThuNhap.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_NhanVien_QTMGThueThuNhap);
                }
                else
                {
                    _NhanVien_QTMGThueThuNhap.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_NhanVien_QTMGThueThuNhap);
                }
            }
            //Add(_PhieuNhap_C);
            return _NhanVien_QTMGThueThuNhap;
        }
        public bool Contains(string MaNV, int stt, bool Huy)
        {
            foreach (NhanVien_QTMGThueThuNhap obj in this)
                if ((obj.STT == stt) && (obj.MaNV == MaNV) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public NhanVien_QTMGThueThuNhap GetNhanVien_QTMGThueThuNhapById(string MaNV, int stt)
        {
            foreach (NhanVien_QTMGThueThuNhap item in this)
                if ((item.MaNV == MaNV) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string MaNV, int stt)
        {
            foreach (NhanVien_QTMGThueThuNhap item in this)
            {
                if ((item.MaNV == MaNV) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(NhanVien_QTMGThueThuNhap obj)
        {

            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public NhanVien_QTMGThueThuNhap GetTo(decimal STT)
        {
            foreach (NhanVien_QTMGThueThuNhap obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            NhanVien_QTMGThueThuNhap item = NhanVien_QTMGThueThuNhap.NewNhanVien_QTMGThueThuNhap();
            Add(item);
            return item;
        }


        private NhanVien_QTMGThueThuNhapList()
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNhanVien_QTMGThueThuNhap(criteria.MaBA,"", criteria.qadmin)))
        //    {
        //        int i = 1;
        //        while (dr.Read())
        //        {
        //            this.Add(NhanVien_QTMGThueThuNhap .GetNhanVien_QTMGThueThuNhap(dr,i));
        //            i++;
        //        }
        //    }
        //    this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindNhanVien_QTMGThueThuNhap(criteria.MaNV, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(NhanVien_QTMGThueThuNhap.GetNhanVien_QTMGThueThuNhap(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (NhanVien_QTMGThueThuNhap item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (NhanVien_QTMGThueThuNhap item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override NhanVien_QTMGThueThuNhapList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            NhanVien_QTMGThueThuNhapList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}

//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace HTC.BusinessObject.NhanSu
//{
//    class NhanVien_QTMGThueThuNhapList
//    {
//    }
//}
