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
    public class DMDichVu_ThuocList : BusinessListBase<DMDichVu_ThuocList, DMDichVu_Thuoc>
    {
        #region Factory Methods
        public static DMDichVu_ThuocList GetAllDMDichVu_Thuoc(String maDV)
        {
            return DataPortal.Fetch<DMDichVu_ThuocList>(new Criteria(maDV));
        }
        // tim theo dieu kien ten
        //public static DMDichVu_ThuocList FindDMDichVu_ThuocByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<DMDichVu_ThuocList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static DMDichVu_ThuocList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<DMDichVu_ThuocList>(new CriteriaOther(1, MaChungLoai));
        //}

        public DMDichVu_Thuoc this[string MaThuoc]
        {
            get
            {
                foreach (DMDichVu_Thuoc obj in this)
                    if (obj.MaThuoc.Equals(MaThuoc))
                        return obj;
                return null;
            }
        }

        public void NewTo(DMDichVu_Thuoc _DMDichVu_Thuoc)
        {
            try
            {
                if (!Contains(_DMDichVu_Thuoc.MaDV))
                {
                    if (this.Items.Count > 0)
                    {
                        //_DMDichVu_Thuoc.STT = this.Items[this.Count - 1].STT + 1;
                        //_DMDichVu_Thuoc.STT = (byte)this.Items[this.Count - 1].STT  + 1;
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _DMDichVu_Thuoc.STT = ++_count;
                        this.Add(_DMDichVu_Thuoc);
                    }
                    else
                    {
                        _DMDichVu_Thuoc.STT = 1;
                        this.Add(_DMDichVu_Thuoc);

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
        public void UpdatedTo(DMDichVu_Thuoc _DMDichVu_Thuoc)
        {

            _DMDichVu_Thuoc.STT = this.Items[this.IndexOf(_DMDichVu_Thuoc)].STT;
            this.Items[this.IndexOf(_DMDichVu_Thuoc)] = _DMDichVu_Thuoc;
        }
        public void RemoveTo(DMDichVu_Thuoc obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        //public DMDichVu_Thuoc AssignTo(DMDichVu_Thuoc _DMDichVu_Thuoc)//add mot hang PhieuNhap_C
        //{
        //    if (!Containss(_DMDichVu_Thuoc.MaThuoc))
        //    {
        //        //if (this.Items.Count > 0)
        //        //{
        //            //Byte _count = 0;
        //            //_count = (Byte)this.Items.Count;
        //            // _DMDichVu_Thuoc.HanSDD = _PhieuNhap_C.HanSD;
        //            //_DMDichVu_Thuoc.STT = ++_count;
        //            this.Add(_DMDichVu_Thuoc);
        //        //}
        //        //else
        //        //{
        //            //_DMDichVu_Thuoc.STT = 1;
        //            //_DMDichVu_Thuoc.HanSDD = _DMDichVu_Thuoc.HanSD;
        //           // this.Add(_DMDichVu_Thuoc);
        //        //}

        //        return _DMDichVu_Thuoc;
        //    }
        //    else
            
        //        //throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //        throw new InvalidOperationException("Khong trung ma vat tu");           
        //}

        //public void AssignTo(string  MaThuoc)//add mot hang PhieuNhap_C
        //{
        //    if (!Containss(MaThuoc))
        //    {
        //        //if (this.Items.Count > 0)
        //        //{
        //        //Byte _count = 0;
        //        //_count = (Byte)this.Items.Count;
        //        // _DMDichVu_Thuoc.HanSDD = _PhieuNhap_C.HanSD;
        //        //_DMDichVu_Thuoc.STT = ++_count;
        //        DMDichVu_Thuoc obj = DMDichVu_Thuoc.NewDMDichVu_Thuoc(MaThuoc);
        //        this.Add(obj);
        //        //}
        //        //else
        //        //{
        //        //_DMDichVu_Thuoc.STT = 1;
        //        //_DMDichVu_Thuoc.HanSDD = _DMDichVu_Thuoc.HanSD;
        //        // this.Add(_DMDichVu_Thuoc);
        //        //}

        //        //return _DMDichVu_Thuoc;
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        //        //throw new InvalidOperationException("Khong trung ma vat tu");
        //    }
        //}
        //public DMDichVu_Thuoc AssignTo(DMDichVu_Thuoc _DMDichVu_Thuoc)//add mot hang PhieuNhap_C
        //{
        //    if (this.Items.Count > 0)
        //    {
        //        Byte _count = 0;
        //        _count = (Byte)this.Items.Count;
        //        // _DMDichVu_Thuoc.HanSDD = _PhieuNhap_C.HanSD;
        //        _DMDichVu_Thuoc.STT = ++_count;
        //        this.Add(_DMDichVu_Thuoc);
        //    }
        //    else
        //    {
        //        _DMDichVu_Thuoc.STT = 1;
        //        //_DMDichVu_Thuoc.HanSDD = _DMDichVu_Thuoc.HanSD;
        //        this.Add(_DMDichVu_Thuoc);
        //    }

        //    return _DMDichVu_Thuoc;
        //}
        public DMDichVu_Thuoc AssignTo(DMDichVu_Thuoc _DMDichVu_Thuoc)//add mot hang PhieuNhap_C
        {
            if (!Containss(_DMDichVu_Thuoc.MaThuoc))
            {
                this.Add(_DMDichVu_Thuoc);
                
            }
            return _DMDichVu_Thuoc;
        }


        public bool Contains(string MaDV)
        {
            foreach (DMDichVu_Thuoc obj in this)
                if (obj.MaDV == MaDV)
                    return true;
            return false;
        }
        public bool Containss(string MaThuoc)
        {
            foreach (DMDichVu_Thuoc obj in this)
                if (obj.MaThuoc == MaThuoc)
                    return true;
            return false;
        }
        public DMDichVu_Thuoc GetDMDichVu_ThuocById(string MaThuoc, Byte stt, string maDV)
        {
            foreach (DMDichVu_Thuoc item in this)
                if ((item.MaDV == maDV) && (item.STT == stt) && (item.MaThuoc == MaThuoc))
                    return item;
            return null;
        }

        public void Remove(string madv, int stt)
        {
            foreach (DMDichVu_Thuoc item in this)
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
            DMDichVu_Thuoc item = DMDichVu_Thuoc.NewDMDichVu_Thuoc();
            Add(item);
            return item;
        }

        private DMDichVu_ThuocList()
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
        ////        SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_Thuoc(criteria.MaDV, criteria.qadmin)))
        ////    {
        ////        //IsReadOnly = false;
        ////        while (dr.Read())
        ////        {
        ////            DMDichVu_Thuoc item = new DMDichVu_Thuoc(
        //// dr.GetString("MaThuoc") ,
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindDMDichVu_Thuoc(criteria.DK, false)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            DMDichVu_Thuoc item = new DMDichVu_Thuoc(
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMDichVu_Thuoc(criteria.MaDV, criteria.qadmin)))
            {
                while (dr.Read())
                {
                    this.Add(DMDichVu_Thuoc.GetDMDichVu_Thuoc(i, dr));
                    i++;
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (DMDichVu_Thuoc item in DeletedList)
            {
                item.DeleteSelf() ;
            }

            DeletedList.Clear();

            foreach (DMDichVu_Thuoc item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override DMDichVu_ThuocList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            DMDichVu_ThuocList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
