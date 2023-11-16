using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMDichVu_HCList : BusinessListBase<DMDichVu_HCList, DMDichVu_HC>
    {
        #region Factory Methods
        public static DMDichVu_HCList GetAllDMDichVu_HC(String maDV)
        {
            return DataPortal.Fetch<DMDichVu_HCList>(new Criteria(maDV));
        }
        // tim theo dieu kien ten
        //public static DMDichVu_HCList FindDMDichVu_HCByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMDichVu_HCList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMDichVu_HCList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMDichVu_HCList>(new CriteriaOther(1, MaChungLoai));
        //}

        public DMDichVu_HC this[string MaHC]
        {
            get
            {
                foreach (DMDichVu_HC obj in this)
                    if (obj.MaHC.Equals(MaHC))
                        return obj;
                return null;
            }
        }

        public void NewTo(DMDichVu_HC _DMDichVu_HC)
        {
            try
            {
                if (!Contains(_DMDichVu_HC.MaDV))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMDichVu_HC.STT = this.Items[this.Count - 1].STT + 1;
                        //_DMDichVu_HC.STT = (byte)this.Items[this.Count - 1].STT  + 1;
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMDichVu_HC.STT = ++_count;
                        this.Add(_DMDichVu_HC);
                    }
                    else
                    {
                        _DMDichVu_HC.STT = 1;
                        this.Add(_DMDichVu_HC);

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
        public void UpdatedTo(DMDichVu_HC _DMDichVu_HC)
        {

            _DMDichVu_HC.STT = this.Items[this.IndexOf(_DMDichVu_HC)].STT;
            this.Items[this.IndexOf(_DMDichVu_HC)] = _DMDichVu_HC;
        }
        public void RemoveTo(DMDichVu_HC obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        //public DMDichVu_HC AssignTo(DMDichVu_HC _DMDichVu_HC)//add mot hang PhieuNhap_C
        //{
        //    if (!Containss(_DMDichVu_HC.MaHC))
        //    {
        //        //if (this.Items.Count > 0)
        //        //{
        //            //Byte _count = 0;
        //            //_count = (Byte)this.Items.Count;
        //            // _DMDichVu_HC.HanSDD = _PhieuNhap_C.HanSD;
        //            //_DMDichVu_HC.STT = ++_count;
        //            this.Add(_DMDichVu_HC);
        //        //}
        //        //else
        //        //{
        //            //_DMDichVu_HC.STT = 1;
        //            //_DMDichVu_HC.HanSDD = _DMDichVu_HC.HanSD;
        //           // this.Add(_DMDichVu_HC);
        //        //}

        //        return _DMDichVu_HC;
        //    }
        //    else
            
        //        //throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //        throw new InvalidOperationException("Khong trung ma vat tu");           
        //}

        //public void AssignTo(string  MaHC)//add mot hang PhieuNhap_C
        //{
        //    if (!Containss(MaHC))
        //    {
        //        //if (this.Items.Count > 0)
        //        //{
        //        //Byte _count = 0;
        //        //_count = (Byte)this.Items.Count;
        //        // _DMDichVu_HC.HanSDD = _PhieuNhap_C.HanSD;
        //        //_DMDichVu_HC.STT = ++_count;
        //        DMDichVu_HC obj = DMDichVu_HC.NewDMDichVu_HC(MaHC);
        //        this.Add(obj);
        //        //}
        //        //else
        //        //{
        //        //_DMDichVu_HC.STT = 1;
        //        //_DMDichVu_HC.HanSDD = _DMDichVu_HC.HanSD;
        //        // this.Add(_DMDichVu_HC);
        //        //}

        //        //return _DMDichVu_HC;
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //        //throw new InvalidOperationException("Khong trung ma vat tu");
        //    }
        //}
        //public DMDichVu_HC AssignTo(DMDichVu_HC _DMDichVu_HC)//add mot hang PhieuNhap_C
        //{
        //    if (this.Items.Count > 0)
        //    {
        //        Byte _count = 0;
        //        _count = (Byte)this.Items.Count;
        //        // _DMDichVu_HC.HanSDD = _PhieuNhap_C.HanSD;
        //        _DMDichVu_HC.STT = ++_count;
        //        this.Add(_DMDichVu_HC);
        //    }
        //    else
        //    {
        //        _DMDichVu_HC.STT = 1;
        //        //_DMDichVu_HC.HanSDD = _DMDichVu_HC.HanSD;
        //        this.Add(_DMDichVu_HC);
        //    }

        //    return _DMDichVu_HC;
        //}
        public DMDichVu_HC AssignTo(DMDichVu_HC _DMDichVu_HC)//add mot hang PhieuNhap_C
        {
            if (!Containss(_DMDichVu_HC.MaHC))
            {
                this.Add(_DMDichVu_HC);
                
            }
            return _DMDichVu_HC;
        }


        public bool Contains(string MaDV)
        {
            foreach (DMDichVu_HC obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public bool Containss(string MaHC)
        {
            foreach (DMDichVu_HC obj in this)
                if (obj.MaHC == MaHC)
                    return true;
            return false;
        }
        public DMDichVu_HC GetDMDichVu_HCById(string MaHC, Byte stt, string maDV)
        {
            foreach (DMDichVu_HC item in this)
                if ((item.MaDV == maDV) && (item.STT == stt) && (item.MaHC == MaHC))
                    return item;
            return null;
        }

        public void Remove(string madv, int stt)
        {
            foreach (DMDichVu_HC item in this)
            {
                if ((item.MaDV == madv) && (item.STT == stt ))
                {
                    Remove(item);
                    break;
                }
            }
        }

        protected override object AddNewCore()
        {
            DMDichVu_HC item = DMDichVu_HC.NewDMDichVu_HC();
            Add(item);
            return item;
        }

        private DMDichVu_HCList()
        {  /* Require use of factory methods */
            this.AllowNew = true;
        }

        #endregion

        #region Authorization Rules

        //public static bool CanAddObject()
        //{
        //    return true;
        //}

        //public static bool CanGetObject()
        //{
        //    return true;
        //}

        //public static bool CanDeleteObject()
        //{
        //    return true;
        //}

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion


        #region Data Access

        [Serializable()]
        private class Criteria
        {            
            private Boolean _qadmin = false ;

            private String _MaDV;
            public String MaDV
            {
                get
                {
                    return _MaDV;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String MaDV)
            {
                _MaDV = MaDV;
                
            }
        }

        // tim kiem theo ten
        //#region CriteriaOther
        //[Serializable()]
        //private class CriteriaOther
        //{
        //    //private int _id;
        //    //public int Id
        //    //{
        //    //    get
        //    //    {
        //    //        return _id;
        //    //    }
        //    //}
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

        //        _IdFind = mIdFind;
        //        if (mIdFind == 1)
        //            _DK = "MAChungLoai like '%" + mDK + "'";
        //        else if (mIdFind == 2)
        //            _DK = "ltrim(rtrim(TenChungLoai)) like N'" + mDK + "%'";


        //    }
        //}
        //#endregion

        ////private void DataPortal_Fetch(Criteria criteria)
        ////{
        ////    RaiseListChangedEvents = false;
        ////    using (
        ////        SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_HC(criteria.MaDV, criteria.qadmin)))
        ////    {
        ////        //IsReadOnly = false;
        ////        while (dr.Read())
        ////        {
        ////            DMDichVu_HC item = new DMDichVu_HC(
        //// dr.GetString("MaHC") ,
        //// dr.GetByte("STT") ,
        //// dr.GetString("MaDV") ,
        //// dr.GetDecimal("Soluong") ,
        //// dr.GetString("Ghichu"),
        //// dr.GetString("MaMay") ,
        //// dr.GetBoolean("Huy") ,
        //// dr.GetSmartDate("NgaySD", true) ,
        //// dr.GetString("NguoiSD"),
        //// dr.GetString("TENDV") ,
        //// dr.GetString("TENTM")
        ////// dr.GetString("TENNHOM") ,
        ////// dr.GetString("TENCHUNGLOAI") ,
        ////// dr.GetString("TENNSX") ,
        ////// dr.GetString("TENDVT") ,
        //////dr.GetString("TENKHOBAN") ,
        ////// dr.GetString("TENKHOPHAT") ,
        ////// dr.GetString("TENNGUOILAP") ,
        //////dr.GetString("TENNGUOISD") ,
        //////dr.GetString("TENNGUOIHUY")
        //// );
        ////            this.Add(item);

        ////        }
        ////        //IsReadOnly = true;
        ////    }
        ////    // Xem lai doan code duoi
        ////    //ArrayList arrList;
        ////    //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
        ////    //IsReadOnly = false;
        ////    //foreach (LocationListInfo obj in arrList)
        ////    //{
        ////    //    this.Add(obj);
        ////    //}
        ////    //IsReadOnly = true;

        ////    RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        ////}

        //private void DataPortal_Fetch(CriteriaOther criteria)
        //{
        //    RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_HC(criteria.DK, false)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMDichVu_HC item = new DMDichVu_HC(
        // i,
        // dr.GetString("MaChungLoai"),
        // dr.GetString("TenChungLoai"),
        // dr.GetByte("Loai"),
        // dr.GetString("MaMay"),
        // dr.GetBoolean("Huy"),
        // dr.GetSmartDate("NgaySD",false),
        // dr.GetString("NguoiSD"),
        // dr.GetString("hoten")
        // );
        //            this.Add(item);
        //            i += 1;

        //        }
        //        //IsReadOnly = true;
        //    }
           
        //    RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}

        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            //byte i = 1;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_HC(criteria.MaDV, criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(DMDichVu_HC.GetDMDichVu_HC(dr));
                    //i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMDichVu_HC item in DeletedList)
            {
                item.DeleteSelf() ;
            }

            DeletedList.Clear();

            foreach (DMDichVu_HC item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMDichVu_HCList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMDichVu_HCList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
