using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

//using System.Windows.Forms;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMCNK_GiaList : BusinessListBase<DMCNK_GiaList, DMCNK_Gia>
    {

        #region Factory Methods
        public static DMCNK_GiaList GetAllDMCNK_Gia(String madt)
        {
            return DataPortal.Fetch<DMCNK_GiaList>(new Criteria(madt));
        }
        public DMCNK_Gia NewTo()
        {
            DMCNK_Gia obj = DMCNK_Gia.NewDMCNK_Gia();
            return obj;
        }

        public void NewTo(DMCNK_Gia _DMCNK_Gia)
        {
            try
            {
                if (!Contains(_DMCNK_Gia.MaVT, _DMCNK_Gia.MaDT, _DMCNK_Gia.Huy))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMCNK_Gia.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMCNK_Gia);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMCNK_Gia.STT = ++_count;
                        this.Add(_DMCNK_Gia);
                    }
                    else
                    {
                        _DMCNK_Gia.STT = 1;
                        this.Add(_DMCNK_Gia);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
        public void UpdatedTo(DMCNK_Gia _DMCNK_Gia)
        {

            _DMCNK_Gia.STT = this.Items[this.IndexOf(_DMCNK_Gia)].STT;
            this.Items[this.IndexOf(_DMCNK_Gia)] = _DMCNK_Gia;
        }
        public void RemoveTo(DMCNK_Gia _DMCNK_Gia)
        {
            this.Items.Remove(_DMCNK_Gia);

        }
        public DMCNK_Gia AssignTo(DMCNK_Gia _DMCNK_Gia)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMCNK_Gia.STT = ++_count;
                this.Add(_DMCNK_Gia);
            }
            else
            {
                _DMCNK_Gia.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMCNK_Gia);
            }
            //Add(_PhieuNhap_C);
            return _DMCNK_Gia;
        }
        public bool Contains(string MaVT, string MaDT, bool Huy)
        {
            foreach (DMCNK_Gia obj in this)
                if ((obj.MaVT == MaVT) && (obj.MaDT == MaDT) && (obj.Huy == Huy))
                    return true;
            return false;
        }
        public DMCNK_Gia GetDMCNK_GiaById(string madt, decimal stt)
        {
            foreach (DMCNK_Gia item in this)
                if ((item.MaDT == madt) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMCNK_Gia item in this)
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
            DMCNK_Gia item = DMCNK_Gia.NewDMCNK_Gia();
            Add(item);
            return item;
        }

        private DMCNK_GiaList()
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

            public Criteria(String MaDT)
            {
                _MaDT = MaDT;

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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMCNK_Gia()))
        //    {
        //        int i = 1;

        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMCNK_Gia item  = new DMCNK_Gia(
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMCNK_Gia(criteria.MaDT, criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(DMCNK_Gia.GetDMCNK_Gia(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMCNK_Gia item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMCNK_Gia item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMCNK_GiaList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMCNK_GiaList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
