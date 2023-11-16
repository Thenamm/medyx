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
    public class DMDichVu_VTList : BusinessListBase<DMDichVu_VTList, DMDichVu_VT>
    {
        #region Factory Methods
        public static DMDichVu_VTList GetAllDMDichVu_VT(String maDV)
        {
            return DataPortal.Fetch<DMDichVu_VTList>(new Criteria(maDV));
        }
        // tim theo dieu kien ten
        //public static DMDichVu_VTList FindDMDichVu_VTByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMDichVu_VTList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMDichVu_VTList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMDichVu_VTList>(new CriteriaOther(1, MaChungLoai));
        //}

        public DMDichVu_VT this[string MaVT]
        {
            get
            {
                foreach (DMDichVu_VT obj in this)
                    if (obj.MaVT.Equals(MaVT))
                        return obj;
                return null;
            }
        }

        public void NewTo(DMDichVu_VT _DMDichVu_VT)
        {
            try
            {
                if (!Contains(_DMDichVu_VT.MaDV))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMDichVu_VT.STT = this.Items[this.Count - 1].STT + 1;
                        //_DMDichVu_VT.STT = (byte)this.Items[this.Count - 1].STT  + 1;
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMDichVu_VT.STT = ++_count;
                        this.Add(_DMDichVu_VT);
                    }
                    else
                    {
                        _DMDichVu_VT.STT = 1;
                        this.Add(_DMDichVu_VT);

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
        public void UpdatedTo(DMDichVu_VT _DMDichVu_VT)
        {

            _DMDichVu_VT.STT = this.Items[this.IndexOf(_DMDichVu_VT)].STT;
            this.Items[this.IndexOf(_DMDichVu_VT)] = _DMDichVu_VT;
        }
        public void RemoveTo(DMDichVu_VT obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        //public DMDichVu_VT AssignTo(DMDichVu_VT _DMDichVu_VT)//add mot hang PhieuNhap_C
        //{
        //    if (!Containss(_DMDichVu_VT.MaVT))
        //    {
        //        //if (this.Items.Count > 0)
        //        //{
        //            //Byte _count = 0;
        //            //_count = (Byte)this.Items.Count;
        //            // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
        //            //_DMDichVu_VT.STT = ++_count;
        //            this.Add(_DMDichVu_VT);
        //        //}
        //        //else
        //        //{
        //            //_DMDichVu_VT.STT = 1;
        //            //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
        //           // this.Add(_DMDichVu_VT);
        //        //}

        //        return _DMDichVu_VT;
        //    }
        //    else
            
        //        //throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //        throw new InvalidOperationException("Khong trung ma vat tu");           
        //}

        //public void AssignTo(string  maVT)//add mot hang PhieuNhap_C
        //{
        //    if (!Containss(maVT))
        //    {
        //        //if (this.Items.Count > 0)
        //        //{
        //        //Byte _count = 0;
        //        //_count = (Byte)this.Items.Count;
        //        // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
        //        //_DMDichVu_VT.STT = ++_count;
        //        DMDichVu_VT obj = DMDichVu_VT.NewDMDichVu_VT(maVT);
        //        this.Add(obj);
        //        //}
        //        //else
        //        //{
        //        //_DMDichVu_VT.STT = 1;
        //        //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
        //        // this.Add(_DMDichVu_VT);
        //        //}

        //        //return _DMDichVu_VT;
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //        //throw new InvalidOperationException("Khong trung ma vat tu");
        //    }
        //}
        //public DMDichVu_VT AssignTo(DMDichVu_VT _DMDichVu_VT)//add mot hang PhieuNhap_C
        //{
        //    if (this.Items.Count > 0)
        //    {
        //        Byte _count = 0;
        //        _count = (Byte)this.Items.Count;
        //        // _DMDichVu_VT.HanSDD = _PhieuNhap_C.HanSD;
        //        _DMDichVu_VT.STT = ++_count;
        //        this.Add(_DMDichVu_VT);
        //    }
        //    else
        //    {
        //        _DMDichVu_VT.STT = 1;
        //        //_DMDichVu_VT.HanSDD = _DMDichVu_VT.HanSD;
        //        this.Add(_DMDichVu_VT);
        //    }

        //    return _DMDichVu_VT;
        //}
        public DMDichVu_VT AssignTo(DMDichVu_VT _DMDichVu_VT)//add mot hang PhieuNhap_C
        {
            if (!Containss(_DMDichVu_VT.MaVT))
            {
                this.Add(_DMDichVu_VT);
                
            }
            return _DMDichVu_VT;
        }


        public bool Contains(string MaDV)
        {
            foreach (DMDichVu_VT obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public bool Containss(string MaVT)
        {
            foreach (DMDichVu_VT obj in this)
                if (obj.MaVT == MaVT)
                    return true;
            return false;
        }
        public DMDichVu_VT GetDMDichVu_VTById(string mavt, Byte stt, string maDV)
        {
            foreach (DMDichVu_VT item in this)
                if ((item.MaDV == maDV) && (item.STT == stt) && (item.MaVT == mavt))
                    return item;
            return null;
        }

        public void Remove(string madv, int stt)
        {
            foreach (DMDichVu_VT item in this)
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
            DMDichVu_VT item = DMDichVu_VT.NewDMDichVu_VT();
            Add(item);
            return item;
        }

        private DMDichVu_VTList()
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
        ////        SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_VT(criteria.MaDV, criteria.qadmin)))
        ////    {
        ////        //IsReadOnly = false;
        ////        while (dr.Read())
        ////        {
        ////            DMDichVu_VT item = new DMDichVu_VT(
        //// dr.GetString("MaVT") ,
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_VT(criteria.DK, false)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMDichVu_VT item = new DMDichVu_VT(
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
            byte i = 1;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_VT(criteria.MaDV, criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(DMDichVu_VT.GetDMDichVu_VT(i, dr));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMDichVu_VT item in DeletedList)
            {
                item.DeleteSelf() ;
            }

            DeletedList.Clear();

            foreach (DMDichVu_VT item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMDichVu_VTList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMDichVu_VTList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
