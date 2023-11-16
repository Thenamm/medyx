using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.HoaDon
{
    [Serializable()]
    public class HDKiemNhapList : BusinessListBase<HDKiemNhapList, HDKiemNhap>
    {
        #region Factory Methods
        public static HDKiemNhapList GetAllHDKiemNhap(String maPhieu, Byte loai )
        {
            return DataPortal.Fetch<HDKiemNhapList>(new Criteria(maPhieu,loai));
        }
        // tim theo dieu kien ten
        //public static HDKiemNhapList FindHDKiemNhapByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<HDKiemNhapList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static HDKiemNhapList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<HDKiemNhapList>(new CriteriaOther(1, MaChungLoai));
        //}

        public void NewTo(HDKiemNhap _HDKiemNhap)
        {
            try
            {
                if (!Contains(_HDKiemNhap.MaPhieu))
                {
                    if (this.Items.Count > 0)
                    {
                      
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _HDKiemNhap.STT = ++_count;
                        this.Add(_HDKiemNhap);
                    }
                    else
                    {
                        _HDKiemNhap.STT = 1;
                        this.Add(_HDKiemNhap);

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
        public void UpdatedTo(HDKiemNhap _HDKiemNhap)
        {

            _HDKiemNhap.STT = this.Items[this.IndexOf(_HDKiemNhap)].STT;
            this.Items[this.IndexOf(_HDKiemNhap)] = _HDKiemNhap;
        }
        public void RemoveTo(HDKiemNhap obj) //xoa 1 HDPhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        //public HDKiemNhap AssignTo(HDKiemNhap _HDKiemNhap)//add mot hang HDPhieuNhap_C
        //{
        //    if (!Containss(_HDKiemNhap.MaPhieu ))
        //    {
        //        if (this.Items.Count > 0)
        //        {
        //            Byte _count = 0;
        //            _count = (Byte)this.Items.Count;
        //            _HDKiemNhap.STT = ++_count;
        //            this.Add(_HDKiemNhap);
        //        }
        //        else
        //        {
        //            _HDKiemNhap.STT = 1;
        //            this.Add(_HDKiemNhap);
        //        }
        //        //Add(_HDPhieuNhap_C);
        //        return _HDKiemNhap;
        //    }
            
        //     else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        
        //}
        public HDKiemNhap AssignTo(HDKiemNhap _HDKiemNhap)//add mot hang HDPhieuNhap_C
        {
            if (!Containss(_HDKiemNhap.MaNV))
            {
                _HDKiemNhap.tenChucDanh = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_HDKiemNhap.MaCD).TenCD;
              //  _HDKiemNhap.MaMay = ,_maMay ,;
              // _HDKiemNhap.NgaySD =  new SmartDate(DateTime.Today) ;
              ////_HDKiemNhap.NgaySD = Convert.ToString("dd/MM/yyyy",DateTime.Today )    ;   
              //  _HDKiemNhap.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
               // _HDKiemNhap.TenNguoiSD = HTC.Business.CategoryList.DMNhanVien.GetDMNhanVien(_HDKiemNhap.NguoiSD).TenNguoiSD;      
                this.Add(_HDKiemNhap);

            }
            return _HDKiemNhap;
        }


        public bool Containss(string MaNV)
        {
            foreach (HDKiemNhap obj in this)
                if (obj.MaNV == MaNV)
                    return true;
            return false;
        }

        public bool Contains(string MaDV)
        {
            foreach (HDKiemNhap obj in this)
                if (obj.MaPhieu == MaDV)
                    return true;
            return false;
        }
        //public bool Containss(string MaVT)
        //{
        //    foreach (HDKiemNhap obj in this)
        //        if (obj.MaPhieu == MaVT)
        //            return true;
        //    return false;
        //}
        //public HDKiemNhap GetHDKiemNhapById(string maNV, Byte stt, string maP)
        //{
        //    foreach (HDKiemNhap item in this)
        //        if ((item.MaPhieu == maP) && (item.STT == stt) && (item.MaNV == maNV))
        //            return item;
        //    return null;
        //}
        public HDKiemNhap GetHDKiemNhapById(Byte stt, string maP)
        {
            foreach (HDKiemNhap item in this)
                if ((item.MaPhieu == maP) && (item.STT == stt) )
                    return item;
            return null;
        }
        //public void Remove(string madv, int stt)
        //{
        //    foreach (HDKiemNhap item in this)
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
            HDKiemNhap item = HDKiemNhap.NewHDKiemNhap();
            Add(item);
            return item;
        }

        private HDKiemNhapList()
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
        ////        SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHDKiemNhap(criteria.MaDV, criteria.qadmin)))
        ////    {
        ////        //IsReadOnly = false;
        ////        while (dr.Read())
        ////        {
        ////            HDKiemNhap item = new HDKiemNhap(
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
        //// dr.GetString("KyHieu")
        ////// dr.GetString("TENNHOM") ,
        ////// dr.GetString("TENCHUNGLOAI") ,
        ////// dr.GetString("TENNSX") ,
        ////// dr.GetString("DenSo") ,
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindHDKiemNhap(criteria.DK, false)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            HDKiemNhap item = new HDKiemNhap(
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHDKiemNhap(criteria.MaPhieu,  criteria.qadmin, criteria.Loai  )))
            {
                while (dr.Read())
                {
                    this.Add(HDKiemNhap.GetHDKiemNhap(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (HDKiemNhap item in DeletedList)
            {
                item.DeleteSelf() ;
            }

            DeletedList.Clear();

            foreach (HDKiemNhap item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override HDKiemNhapList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            HDKiemNhapList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
