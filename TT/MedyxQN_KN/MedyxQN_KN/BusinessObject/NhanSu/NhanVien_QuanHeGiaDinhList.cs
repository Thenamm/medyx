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

    public class NhanVien_QuanHeGiaDinhList : BusinessListBase<NhanVien_QuanHeGiaDinhList, NhanVien_QuanHeGiaDinh>
    {
        #region Factory Methods
        //public static NhanVien_QuanHeGiaDinhList GetAllNhanVien_QuanHeGiaDinh(String MaBA)
        //{
        //    return DataPortal.Fetch<NhanVien_QuanHeGiaDinhList>(new Criteria(MaBA,qadmin ));
        //}
        public static NhanVien_QuanHeGiaDinhList FindNhanVien_QuanHeGiaDinhByMaNV(String MaNV)
        {
            return DataPortal.Fetch<NhanVien_QuanHeGiaDinhList>(new OtherCriteria(MaNV,""));
        }
        //public static NhanVien_QuanHeGiaDinhList FindNhanVien_QuanHeGiaDinhByTenNV(String TenNV)
        //{
        //    return DataPortal.Fetch<NhanVien_QuanHeGiaDinhList>(new OtherCriteria(TenNV, 2));
        //}
        public NhanVien_QuanHeGiaDinh NewTo() 
        {
            NhanVien_QuanHeGiaDinh obj = NhanVien_QuanHeGiaDinh.NewNhanVien_QuanHeGiaDinh();
            return obj;
        }
        public void NewTo(NhanVien_QuanHeGiaDinh _NhanVien_QuanHeGiaDinh)
        {
            try
            {
                if (!Contains(_NhanVien_QuanHeGiaDinh.MaNV, _NhanVien_QuanHeGiaDinh.STT,  _NhanVien_QuanHeGiaDinh.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                       
                        int _count = 0;
                        _count = this.Items.Count;
                        _NhanVien_QuanHeGiaDinh.STT = ++_count;
                        this.Add(_NhanVien_QuanHeGiaDinh);
                    }
                    else
                    {
                        _NhanVien_QuanHeGiaDinh.STT = 1;
                        this.Add(_NhanVien_QuanHeGiaDinh);

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
       
      
        public void UpdatedTo(NhanVien_QuanHeGiaDinh _NhanVien_QuanHeGiaDinh)
        {

            _NhanVien_QuanHeGiaDinh.STT = this.Items[this.IndexOf(_NhanVien_QuanHeGiaDinh)].STT;
            this.Items[this.IndexOf(_NhanVien_QuanHeGiaDinh)] = _NhanVien_QuanHeGiaDinh;
        }
        //public void RemoveTo(NhanVien_QuanHeGiaDinh _NhanVien_QuanHeGiaDinh)
        //{
        //    this.Items.Remove(_NhanVien_QuanHeGiaDinh);

        //}
        public NhanVien_QuanHeGiaDinh  AssignTo(NhanVien_QuanHeGiaDinh  _NhanVien_QuanHeGiaDinh)
        {
            if (!Contains(_NhanVien_QuanHeGiaDinh.MaNV, _NhanVien_QuanHeGiaDinh.STT, _NhanVien_QuanHeGiaDinh.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _NhanVien_QuanHeGiaDinh.STT = ++_count;
                   // _NhanVien_QuanHeGiaDinh.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_NhanVien_QuanHeGiaDinh);
                }
                else
                {
                    _NhanVien_QuanHeGiaDinh.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_NhanVien_QuanHeGiaDinh);
                }
            }
            //Add(_PhieuNhap_C);
            return _NhanVien_QuanHeGiaDinh;
        }
        public bool Contains(string MaNV, int stt, bool Huy)
        {
            foreach (NhanVien_QuanHeGiaDinh  obj in this)
                if ((obj.STT == stt) && (obj.MaNV == MaNV) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public NhanVien_QuanHeGiaDinh  GetNhanVien_QuanHeGiaDinhById(string MaNV, int stt)
        {
            foreach (NhanVien_QuanHeGiaDinh  item in this)
                if ((item.MaNV == MaNV) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string MaNV, int stt)
        {
            foreach (NhanVien_QuanHeGiaDinh  item in this)
            {
                if ((item.MaNV == MaNV) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(NhanVien_QuanHeGiaDinh obj) 
        {

            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public NhanVien_QuanHeGiaDinh GetTo(decimal STT) 
        {
            foreach (NhanVien_QuanHeGiaDinh obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            NhanVien_QuanHeGiaDinh  item = NhanVien_QuanHeGiaDinh.NewNhanVien_QuanHeGiaDinh();
            Add(item);
            return item;
        }

      
        private NhanVien_QuanHeGiaDinhList()
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNhanVien_QuanHeGiaDinh(criteria.MaBA,"", criteria.qadmin)))
        //    {
        //        int i = 1;
        //        while (dr.Read())
        //        {
        //            this.Add(NhanVien_QuanHeGiaDinh .GetNhanVien_QuanHeGiaDinh(dr,i));
        //            i++;
        //        }
        //    }
        //    this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindNhanVien_QuanHeGiaDinh(criteria.MaNV,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(NhanVien_QuanHeGiaDinh.GetNhanVien_QuanHeGiaDinh(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (NhanVien_QuanHeGiaDinh  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (NhanVien_QuanHeGiaDinh  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override NhanVien_QuanHeGiaDinhList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            NhanVien_QuanHeGiaDinhList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
