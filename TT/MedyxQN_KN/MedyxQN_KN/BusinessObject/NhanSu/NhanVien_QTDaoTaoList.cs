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

    public class NhanVien_QTDaoTaoList : BusinessListBase<NhanVien_QTDaoTaoList, NhanVien_QTDaoTao>
    {
        #region Factory Methods
        //public static NhanVien_QTDaoTaoList GetAllNhanVien_QTDaoTao(String MaBA)
        //{
        //    return DataPortal.Fetch<NhanVien_QTDaoTaoList>(new Criteria(MaBA,qadmin ));
        //}
        public static NhanVien_QTDaoTaoList FindNhanVien_QTDaoTaoByMaNV(String MaNV)
        {
            return DataPortal.Fetch<NhanVien_QTDaoTaoList>(new OtherCriteria(MaNV,""));
        }
        //public static NhanVien_QTDaoTaoList FindNhanVien_QTDaoTaoByTenNV(String TenNV)
        //{
        //    return DataPortal.Fetch<NhanVien_QTDaoTaoList>(new OtherCriteria(TenNV, 2));
        //}
        public NhanVien_QTDaoTao NewTo() 
        {
            NhanVien_QTDaoTao obj = NhanVien_QTDaoTao.NewNhanVien_QTDaoTao();
            return obj;
        }
        public void NewTo(NhanVien_QTDaoTao _NhanVien_QTDaoTao)
        {
            try
            {
                if (!Contains(_NhanVien_QTDaoTao.MaNV, _NhanVien_QTDaoTao.STT,  _NhanVien_QTDaoTao.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                       
                        int _count = 0;
                        _count = this.Items.Count;
                        _NhanVien_QTDaoTao.STT = ++_count;
                        this.Add(_NhanVien_QTDaoTao);
                    }
                    else
                    {
                        _NhanVien_QTDaoTao.STT = 1;
                        this.Add(_NhanVien_QTDaoTao);

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
       
      
        public void UpdatedTo(NhanVien_QTDaoTao _NhanVien_QTDaoTao)
        {

            _NhanVien_QTDaoTao.STT = this.Items[this.IndexOf(_NhanVien_QTDaoTao)].STT;
            this.Items[this.IndexOf(_NhanVien_QTDaoTao)] = _NhanVien_QTDaoTao;
        }
        //public void RemoveTo(NhanVien_QTDaoTao _NhanVien_QTDaoTao)
        //{
        //    this.Items.Remove(_NhanVien_QTDaoTao);

        //}
        public NhanVien_QTDaoTao  AssignTo(NhanVien_QTDaoTao  _NhanVien_QTDaoTao)
        {
            if (!Contains(_NhanVien_QTDaoTao.MaNV, _NhanVien_QTDaoTao.STT, _NhanVien_QTDaoTao.Huy))
            {
                if (this.Items.Count > 0)
                {
                    Byte _count = 0;
                    _count = (Byte)this.Items.Count;
                    // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                    _NhanVien_QTDaoTao.STT = ++_count;
                   // _NhanVien_QTDaoTao.STTKhoa = this.Items[0].STTKhoa; 
                    this.Add(_NhanVien_QTDaoTao);
                }
                else
                {
                    _NhanVien_QTDaoTao.STT = 1;
                    //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                    this.Add(_NhanVien_QTDaoTao);
                }
            }
            //Add(_PhieuNhap_C);
            return _NhanVien_QTDaoTao;
        }
        public bool Contains(string MaNV, int stt, bool Huy)
        {
            foreach (NhanVien_QTDaoTao  obj in this)
                if ((obj.STT == stt) && (obj.MaNV == MaNV) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public NhanVien_QTDaoTao  GetNhanVien_QTDaoTaoById(string MaNV, int stt)
        {
            foreach (NhanVien_QTDaoTao  item in this)
                if ((item.MaNV == MaNV) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string MaNV, int stt)
        {
            foreach (NhanVien_QTDaoTao  item in this)
            {
                if ((item.MaNV == MaNV) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }
        public void RemoveTo(NhanVien_QTDaoTao obj) 
        {

            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public NhanVien_QTDaoTao GetTo(decimal STT) 
        {
            foreach (NhanVien_QTDaoTao obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        protected override object AddNewCore()
        {
            NhanVien_QTDaoTao  item = NhanVien_QTDaoTao.NewNhanVien_QTDaoTao();
            Add(item);
            return item;
        }

      
        private NhanVien_QTDaoTaoList()
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNhanVien_QTDaoTao(criteria.MaBA,"", criteria.qadmin)))
        //    {
        //        int i = 1;
        //        while (dr.Read())
        //        {
        //            this.Add(NhanVien_QTDaoTao .GetNhanVien_QTDaoTao(dr,i));
        //            i++;
        //        }
        //    }
        //    this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindNhanVien_QTDaoTao(criteria.MaNV,criteria.DK , criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(NhanVien_QTDaoTao.GetNhanVien_QTDaoTao(dr, i));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (NhanVien_QTDaoTao  item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (NhanVien_QTDaoTao  item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override NhanVien_QTDaoTaoList  Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            NhanVien_QTDaoTaoList  result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
