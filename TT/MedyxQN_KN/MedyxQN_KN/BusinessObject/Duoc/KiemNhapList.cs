using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.Duoc
{
    [Serializable()]
    public class KiemNhapList : BusinessListBase<KiemNhapList, KiemNhap>
    {
        #region Factory Methods
        public static KiemNhapList GetAllKiemNhap(String maPhieu, Byte loai )
        {
            return DataPortal.Fetch<KiemNhapList>(new Criteria(maPhieu,loai));
        }
        // tim theo dieu kien ten
        //public static KiemNhapList FindKiemNhapByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<KiemNhapList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static KiemNhapList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<KiemNhapList>(new CriteriaOther(1, MaChungLoai));
        //}

        public void NewTo(KiemNhap _KiemNhap)
        {
            try
            {
                if (!Contains(_KiemNhap.MaPhieu))
                {
                    if (this.Items.Count > 0)
                    {
                      
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _KiemNhap.STT = ++_count;
                        this.Add(_KiemNhap);
                    }
                    else
                    {
                        _KiemNhap.STT = 1;
                        this.Add(_KiemNhap);

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
        public void UpdatedTo(KiemNhap _KiemNhap)
        {

            _KiemNhap.STT = this.Items[this.IndexOf(_KiemNhap)].STT;
            this.Items[this.IndexOf(_KiemNhap)] = _KiemNhap;
        }
        public void RemoveTo(KiemNhap obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        //public KiemNhap AssignTo(KiemNhap _KiemNhap)//add mot hang PhieuNhap_C
        //{
        //    if (!Containss(_KiemNhap.MaPhieu ))
        //    {
        //        if (this.Items.Count > 0)
        //        {
        //            Byte _count = 0;
        //            _count = (Byte)this.Items.Count;
        //            _KiemNhap.STT = ++_count;
        //            this.Add(_KiemNhap);
        //        }
        //        else
        //        {
        //            _KiemNhap.STT = 1;
        //            this.Add(_KiemNhap);
        //        }
        //        //Add(_PhieuNhap_C);
        //        return _KiemNhap;
        //    }
            
        //     else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        
        //}
        public KiemNhap AssignTo(KiemNhap _KiemNhap)//add mot hang PhieuNhap_C
        {
            if (!Containss(_KiemNhap.MaNV))
            {
                _KiemNhap.tenChucDanh = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_KiemNhap.MaCD).TenCD;
              //  _KiemNhap.MaMay = ,_maMay ,;
              // _KiemNhap.NgaySD =  new SmartDate(DateTime.Today) ;
              ////_KiemNhap.NgaySD = Convert.ToString("dd/MM/yyyy",DateTime.Today )    ;   
              //  _KiemNhap.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
               // _KiemNhap.TenNguoiSD = HTC.Business.CategoryList.DMNhanVien.GetDMNhanVien(_KiemNhap.NguoiSD).TenNguoiSD;      
                this.Add(_KiemNhap);

            }
            return _KiemNhap;
        }


        public bool Containss(string MaNV)
        {
            foreach (KiemNhap obj in this)
                if (obj.MaNV == MaNV)
                    return true;
            return false;
        }

        public bool Contains(string MaDV)
        {
            foreach (KiemNhap obj in this)
                if (obj.MaPhieu == MaDV)
                    return true;
            return false;
        }
        //public bool Containss(string MaVT)
        //{
        //    foreach (KiemNhap obj in this)
        //        if (obj.MaPhieu == MaVT)
        //            return true;
        //    return false;
        //}
        //public KiemNhap GetKiemNhapById(string maNV, Byte stt, string maP)
        //{
        //    foreach (KiemNhap item in this)
        //        if ((item.MaPhieu == maP) && (item.STT == stt) && (item.MaNV == maNV))
        //            return item;
        //    return null;
        //}
        public KiemNhap GetKiemNhapById(Byte stt, string maP)
        {
            foreach (KiemNhap item in this)
                if ((item.MaPhieu == maP) && (item.STT == stt) )
                    return item;
            return null;
        }
        //public void Remove(string madv, int stt)
        //{
        //    foreach (KiemNhap item in this)
        //    {
        //        if ((item.MaPhieu == madv) && (item.STT == stt ))
        //        {
        //            Remove(item);
        //            break;
        //        }
        //    }
        //}
        

        protected override object AddNewCore()
        {
            KiemNhap item = KiemNhap.NewKiemNhap();
            Add(item);
            return item;
        }

        private KiemNhapList()
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
            private Boolean _qadmin = false ;

            private String _MaPhieu;
            public String MaPhieu
            {
                get
                {
                    return _MaPhieu;
                }
            }
            private Byte  _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public Criteria(String MaPhieu, Byte Loai)
            {
                _MaPhieu = MaPhieu;
                _Loai = Loai;
                
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
        ////        SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKiemNhap(criteria.MaDV, criteria.qadmin)))
        ////    {
        ////        //IsReadOnly = false;
        ////        while (dr.Read())
        ////        {
        ////            KiemNhap item = new KiemNhap(
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindKiemNhap(criteria.DK, false)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            KiemNhap item = new KiemNhap(
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKiemNhap(criteria.MaPhieu,  criteria.qadmin, criteria.Loai  )))
            {
                while (dr.Read())
                {
                    this.Add(KiemNhap.GetKiemNhap(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (KiemNhap item in DeletedList)
            {
                item.DeleteSelf() ;
            }

            DeletedList.Clear();

            foreach (KiemNhap item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override KiemNhapList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            KiemNhapList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
