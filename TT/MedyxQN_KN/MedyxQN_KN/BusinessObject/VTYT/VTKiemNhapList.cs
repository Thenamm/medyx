using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////
 
namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTKiemNhapList : BusinessListBase<VTKiemNhapList, VTKiemNhap>
    {
        #region Factory Methods
        public static VTKiemNhapList GetAllVTKiemNhap(String maPhieu, Byte loai )
        {
            return DataPortal.Fetch<VTKiemNhapList>(new Criteria(maPhieu,loai));
        }
        // tim theo dieu kien ten
        //public static VTKiemNhapList FindVTKiemNhapByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<VTKiemNhapList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static VTKiemNhapList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<VTKiemNhapList>(new CriteriaOther(1, MaChungLoai));
        //}

        public void NewTo(VTKiemNhap _VTKiemNhap)
        {
            try
            {
                if (!Contains(_VTKiemNhap.MaPhieu))
                {
                    if (this.Items.Count > 0)
                    {
                      
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _VTKiemNhap.STT = ++_count;
                        this.Add(_VTKiemNhap);
                    }
                    else
                    {
                        _VTKiemNhap.STT = 1;
                        this.Add(_VTKiemNhap);

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
        public void UpdatedTo(VTKiemNhap _VTKiemNhap)
        {

            _VTKiemNhap.STT = this.Items[this.IndexOf(_VTKiemNhap)].STT;
            this.Items[this.IndexOf(_VTKiemNhap)] = _VTKiemNhap;
        }
        public void RemoveTo(VTKiemNhap obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        //public VTKiemNhap AssignTo(VTKiemNhap _VTKiemNhap)//add mot hang PhieuNhap_C
        //{
        //    if (!Containss(_VTKiemNhap.MaPhieu ))
        //    {
        //        if (this.Items.Count > 0)
        //        {
        //            Byte _count = 0;
        //            _count = (Byte)this.Items.Count;
        //            _VTKiemNhap.STT = ++_count;
        //            this.Add(_VTKiemNhap);
        //        }
        //        else
        //        {
        //            _VTKiemNhap.STT = 1;
        //            this.Add(_VTKiemNhap);
        //        }
        //        //Add(_PhieuNhap_C);
        //        return _VTKiemNhap;
        //    }
            
        //     else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        
        //}
        public VTKiemNhap AssignTo(VTKiemNhap _VTKiemNhap)//add mot hang PhieuNhap_C
        {
            if (!Containss(_VTKiemNhap.MaNV))
            {
               // _VTKiemNhap.tenChucDanh = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_VTKiemNhap.MaCD).TenCD;
              //  _VTKiemNhap.MaMay = ,_maMay ,;
              // _VTKiemNhap.NgaySD =  new SmartDate(DateTime.Today) ;
              ////_VTKiemNhap.NgaySD = Convert.ToString("dd/MM/yyyy",DateTime.Today )    ;   
              //  _VTKiemNhap.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
              //  _VTKiemNhap.TenNguoiSD = HTC.Business.CategoryList.DMNhanVien.GetDMNhanVien(_VTKiemNhap.NguoiSD).TenNguoiSD;      
                this.Add(_VTKiemNhap);

            }
            return _VTKiemNhap;
        }


        public bool Containss(string MaNV)
        {
            foreach (VTKiemNhap obj in this)
                if (obj.MaNV == MaNV)
                    return true;
            return false;
        }

        public bool Contains(string MaDV)
        {
            foreach (VTKiemNhap obj in this)
                if (obj.MaPhieu == MaDV)
                    return true;
            return false;
        }
        //public bool Containss(string MaVT)
        //{
        //    foreach (VTKiemNhap obj in this)
        //        if (obj.MaPhieu == MaVT)
        //            return true;
        //    return false;
        //}
        //public VTKiemNhap GetVTKiemNhapById(string maNV, Byte stt, string maP)
        //{
        //    foreach (VTKiemNhap item in this)
        //        if ((item.MaPhieu == maP) && (item.STT == stt) && (item.MaNV == maNV))
        //            return item;
        //    return null;
        //}
        public VTKiemNhap GetVTKiemNhapById(Byte stt, string maP)
        {
            foreach (VTKiemNhap item in this)
                if ((item.MaPhieu == maP) && (item.STT == stt) )
                    return item;
            return null;
        }
        //public void Remove(string madv, int stt)
        //{
        //    foreach (VTKiemNhap item in this)
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
            VTKiemNhap item = VTKiemNhap.NewVTKiemNhap();
            Add(item);
            return item;
        }

        private VTKiemNhapList()
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
        ////        SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVTKiemNhap(criteria.MaDV, criteria.qadmin)))
        ////    {
        ////        //IsReadOnly = false;
        ////        while (dr.Read())
        ////        {
        ////            VTKiemNhap item = new VTKiemNhap(
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindVTKiemNhap(criteria.DK, false)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            VTKiemNhap item = new VTKiemNhap(
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVTKiemNhap(criteria.MaPhieu,  criteria.qadmin, criteria.Loai  )))
            {
                while (dr.Read())
                {
                    this.Add(VTKiemNhap.GetVTKiemNhap(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (VTKiemNhap item in DeletedList)
            {
                item.DeleteSelf() ;
            }

            DeletedList.Clear();

            foreach (VTKiemNhap item in this)
            {
                if (item.IsNew == true )
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override VTKiemNhapList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            VTKiemNhapList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
