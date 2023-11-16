using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//
 //using System.Windows.Forms;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMVPP_GiaList : BusinessListBase<DMVPP_GiaList, DMVPP_Gia>
    {

        #region Factory Methods
        public static DMVPP_GiaList GetAllDMVPP_Gia(String madt , String DK)
        {
            return DataPortal.Fetch<DMVPP_GiaList>(new Criteria(madt, DK ));
        }
        public DMVPP_Gia NewTo()
        {
            DMVPP_Gia obj = DMVPP_Gia.NewDMVPP_Gia();
            return obj;
        }

        public void NewTo(DMVPP_Gia _DMVPP_Gia)
        {
            try
            {
                if (!Contains(_DMVPP_Gia.MaVT, _DMVPP_Gia.MaDT, _DMVPP_Gia.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMVPP_Gia.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMVPP_Gia);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMVPP_Gia.STT = ++_count;
                        this.Add(_DMVPP_Gia);
                    }
                    else
                    {
                        _DMVPP_Gia.STT = 1;
                        this.Add(_DMVPP_Gia);

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
        public void UpdatedTo(DMVPP_Gia _DMVPP_Gia)
        {

            _DMVPP_Gia.STT = this.Items[this.IndexOf(_DMVPP_Gia)].STT;
            this.Items[this.IndexOf(_DMVPP_Gia)] = _DMVPP_Gia;
        }
        public void RemoveTo(DMVPP_Gia _DMVPP_Gia)
        {
            this.Items.Remove(_DMVPP_Gia);

        }
        public DMVPP_Gia AssignTo(DMVPP_Gia _DMVPP_Gia)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMVPP_Gia.STT = ++_count;
                this.Add(_DMVPP_Gia);
            }
            else
            {
                _DMVPP_Gia.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMVPP_Gia);
            }
            //Add(_PhieuNhap_C);
            return _DMVPP_Gia;
        }
        public bool Contains(string MaVT, string MaDT, bool Huy)
        {
            foreach (DMVPP_Gia obj in this)
                if ((obj.MaVT == MaVT) && (obj.MaDT == MaDT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public DMVPP_Gia GetDMVPP_GiaById(string madt, decimal stt)
        {
            foreach (DMVPP_Gia item in this)
                if ((item.MaDT == madt) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMVPP_Gia item in this)
            {
                if ((item.MaDT == madt) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            DMVPP_Gia item = DMVPP_Gia.NewDMVPP_Gia();
            Add(item);
            return item;
        }

        private DMVPP_GiaList()
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

            private String _MaDT;
             private Boolean _qadmin = false ;
            private String _DK;
            public Boolean qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            public String dK
            {
                get
                {
                    return _DK;
                }
            }

            public Criteria(String MaDT, String DK)
            {
                _MaDT = MaDT;
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _DK = DK;
            }
        }

        //#region CriteriaOther

        //[Serializable()]
        //private class CriteriaOther
        //{

        //    private Byte _IdFind;
        //    public Byte IdFind
        //    {
        //        get
        //        {
        //            return _IdFind;
        //        }
        //    }
        //    private string _DK;
        //    public string DK
        //    {
        //        get
        //        {
        //            return _DK;
        //        }
        //    }
        //     private Boolean _qadmin = false ;
        //    public bool qadmin
        //    {
        //        get
        //        {
        //            return _qadmin;
        //        }
        //    }
        //    //public Criteria(Boolean mqadmin)
        //    //{

        //    //    _qadmin = mqadmin;
        //    //}
        //    public CriteriaOther(Byte mIdFind, String mDK)
        //    {

        //        //_IdFind = mIdFind;
        //        //if (mIdFind == 1)
        //        //    _DK = "MaDT like '%" + mDK + "'";
        //        //else if (mIdFind == 2)
        //        //    _DK = "ltrim(rtrim(TenDTsudung)) like N'" + mDK + "%'";


        //    }
        //}
        //#endregion

        //private void DataPortal_Fetch(Criteria criteria)
        //{
        //    RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVPP_Gia()))
        //    {
        //        int i = 1;

        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMVPP_Gia item  = new DMVPP_Gia(
        // i,
        // dr.GetString("MaDT") ,
        // dr.GetDecimal("STT") ,
        // dr.GetString("MaVT") ,
        // dr.GetDecimal("DonGiaBH") ,
        // dr.GetDecimal("DonGiaThuT") ,
        // dr.GetDecimal("DonGiaPhauT") ,
        // dr.GetDecimal("DonGiaCLS") ,
        // dr.GetDecimal("GiaChenhLech"),
        // dr.GetBoolean("ADChenhLech") ,
        // dr.GetBoolean("DTBH"),
        // dr.GetBoolean("ADPhongMo") ,
        // dr.GetDecimal("DonGia1") ,
        // dr.GetDecimal("GiachenhLech1") ,
        // dr.GetSmartDate("Ngay1", true) ,
        // dr.GetString("Ghichu") ,
        // dr.GetString("MaMay") ,
        // dr.GetBoolean("Huy") ,
        // dr.GetSmartDate("NgayLap", false) ,
        // dr.GetString("NguoiLap") ,
        // dr.GetSmartDate("NgayHuy", false) ,
        // dr.GetString("NguoiHuy") ,
        // dr.GetSmartDate("NgaySD1", false) ,
        // dr.GetString("NguoiSD1") ,
        // dr.GetSmartDate("NgaySD",false) ,
        // dr.GetString("NguoiSD") 

        // );
        //            this.Add(item);
        //            i += 1;

        //        }
        //        //IsReadOnly = true;
        //    }
        // Xem lai doan code duoi
        //ArrayList arrList;
        //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
        //IsReadOnly = false;
        //foreach (LocationListInfo obj in arrList)
        //{
        //    this.Add(obj);
        //}
        //IsReadOnly = true;

        //    RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMVPP_Gia(criteria.MaDT, criteria.qadmin, criteria.dK  )))
            {
                while (dr.Read())
                {
                    this.Add(DMVPP_Gia.GetDMVPP_Gia(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMVPP_Gia item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMVPP_Gia item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMVPP_GiaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMVPP_GiaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
