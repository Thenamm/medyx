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
    public class DMPPSocheList : BusinessListBase<DMPPSocheList, DMPPSoche>
    {
        #region Factory Methods
        public static DMPPSocheList NewList()
        {
            return DataPortal.Fetch<DMPPSocheList>(new TemCriteria());
        }
        public static DMPPSocheList GetAllDMPPSoche(String mathuoc, string dK)
        {
			return DataPortal.Fetch<DMPPSocheList>(new Criteria(mathuoc, dK));
        }
        public static DMPPSocheList GetAllDMPPSoche(String mathuoc)
        {
			return DataPortal.Fetch<DMPPSocheList>(new Criteria(mathuoc, ""));
        }
        public DMPPSoche NewTo() {
            DMPPSoche obj = DMPPSoche.NewDMPPSoche();
            return obj ;
        }
        
        public void NewTo(DMPPSoche _DMPPSoche)
        {
            try
            {
                if (!Contains(_DMPPSoche.MaThuoc ,_DMPPSoche.MaDT,_DMPPSoche.Huy  ))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMPPSoche.STT = this.Items[this.Count - 1].STT + 1;
                        //this.Add(_DMPPSoche);
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMPPSoche.STT = ++_count;
                        this.Add(_DMPPSoche);
                    }
                    else
                    {
                        _DMPPSoche.STT = 1;
                        this.Add(_DMPPSoche);

                    }
                }
                else
                    throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
            }
            catch (Exception ex)
            {
               //MessageBox.Show(ex.Message)   ;
            }
        }
        public void UpdatedTo(DMPPSoche _DMPPSoche)
        {

            _DMPPSoche.STT = this.Items[this.IndexOf(_DMPPSoche)].STT;
            this.Items[this.IndexOf(_DMPPSoche)] = _DMPPSoche;
        }
        public DMPPSoche GetTo(decimal STT) //
        {
            foreach (DMPPSoche obj in this)
                if (obj.STT == STT)
                    return obj;
            return null;

        }
        //public void RemoveTo(DMPPSoche _DMPPSoche)
        //{
        //    this.Items.Remove(_DMPPSoche);

        //}
        public void RemoveTo(DMPPSoche obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }
        public DMPPSoche  AssignTo(DMPPSoche  _DMPPSoche)//add mot hang PhieuNhap_C
        {
            if (this.Items.Count > 0)
            {
                Byte _count = 0;
                _count = (Byte)this.Items.Count;
                // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
                _DMPPSoche.STT = ++_count;
                this.Add(_DMPPSoche);
            }
            else
            {
                _DMPPSoche.STT = 1;
                //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
                this.Add(_DMPPSoche);
            }
            //Add(_PhieuNhap_C);
            return _DMPPSoche;
        }
        public bool Contains(string MaThuoc, string MaDT,bool Huy)
        {
            foreach (DMPPSoche  obj in this)
                if ((obj.MaThuoc == MaThuoc) && (obj.MaDT == MaDT)&&(obj.Huy ==Huy ))
                    return true;
            return false;
        }
        public DMPPSoche  GetDMPPSocheById(string madt, decimal stt)
        {
            foreach (DMPPSoche  item in this)
                if ((item.MaDT   == madt ) && (item.STT == stt))
                    return item;
            return null;
        }
        public void Remove(string madt, int stt)
        {
            foreach (DMPPSoche  item in this)
            {
                if ((item.MaDT   == madt ) && (item.STT == stt))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            DMPPSoche item = DMPPSoche.NewDMPPSoche();
            Add(item);
            return item;
        }

        private DMPPSocheList()
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
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
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
            private String  _dK;
            public String DK
            {
                get
                {
                    return _dK;
                }
            }
            public Criteria(String MaDT, string dK)
            {
                _MaDT = MaDT ;
                _qadmin = HTC.ShareVariables.pub_bQadmin;
                _dK = dK;
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMPPSoche()))
        //    {
        //        int i = 1;

        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMPPSoche item  = new DMPPSoche(
        // i,
        // dr.GetString("MaDT") ,
        // dr.GetDecimal("STT") ,
        // dr.GetString("MaThuoc") ,
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMPPSoche(criteria.MaDT, criteria.DK,  criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(DMPPSoche .GetDMPPSoche(dr));
                  
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMPPSoche item in DeletedList)
            {
                item.DeleteSelf();
            }

            DeletedList.Clear();

            foreach (DMPPSoche item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMPPSocheList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMPPSocheList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
