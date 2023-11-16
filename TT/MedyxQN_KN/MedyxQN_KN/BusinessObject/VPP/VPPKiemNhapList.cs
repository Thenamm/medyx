using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////
 
namespace HTC.Business.VPP
{
    [Serializable()]
    public class VPPKiemNhapList : BusinessListBase<VPPKiemNhapList, VPPKiemNhap>
    {
        #region Factory Methods
        public static VPPKiemNhapList GetAllVPPKiemNhap(String maPhieu, Byte loai )
        {
            return DataPortal.Fetch<VPPKiemNhapList>(new Criteria(maPhieu,loai));
        }
        // tim theo dieu kien ten
        //public static VPPKiemNhapList FindVPPKiemNhapByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<VPPKiemNhapList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static VPPKiemNhapList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<VPPKiemNhapList>(new CriteriaOther(1, MaChungLoai));
        //}

        public void NewTo(VPPKiemNhap _VPPKiemNhap)
        {
            try
            {
                if (!Contains(_VPPKiemNhap.MaPhieu))
                {
                    if (this.Items.Count > 0)
                    {
                      
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _VPPKiemNhap.STT = ++_count;
                        this.Add(_VPPKiemNhap);
                    }
                    else
                    {
                        _VPPKiemNhap.STT = 1;
                        this.Add(_VPPKiemNhap);

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
        public void UpdatedTo(VPPKiemNhap _VPPKiemNhap)
        {

            _VPPKiemNhap.STT = this.Items[this.IndexOf(_VPPKiemNhap)].STT;
            this.Items[this.IndexOf(_VPPKiemNhap)] = _VPPKiemNhap;
        }
        public void RemoveTo(VPPKiemNhap obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        //public VPPKiemNhap AssignTo(VPPKiemNhap _VPPKiemNhap)//add mot hang PhieuNhap_C
        //{
        //    if (!Containss(_VPPKiemNhap.MaPhieu ))
        //    {
        //        if (this.Items.Count > 0)
        //        {
        //            Byte _count = 0;
        //            _count = (Byte)this.Items.Count;
        //            _VPPKiemNhap.STT = ++_count;
        //            this.Add(_VPPKiemNhap);
        //        }
        //        else
        //        {
        //            _VPPKiemNhap.STT = 1;
        //            this.Add(_VPPKiemNhap);
        //        }
        //        //Add(_PhieuNhap_C);
        //        return _VPPKiemNhap;
        //    }
            
        //     else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        
        //}
        public VPPKiemNhap AssignTo(VPPKiemNhap _VPPKiemNhap)//add mot hang PhieuNhap_C
        {
            if (!Containss(_VPPKiemNhap.MaNV))
            {
               // _VPPKiemNhap.tenChucDanh = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_VPPKiemNhap.MaCD).TenCD;
              //  _VPPKiemNhap.MaMay = ,_maMay ,;
              // _VPPKiemNhap.NgaySD =  new SmartDate(DateTime.Today) ;
              ////_VPPKiemNhap.NgaySD = Convert.ToString("dd/MM/yyyy",DateTime.Today )    ;   
              //  _VPPKiemNhap.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
              //  _VPPKiemNhap.TenNguoiSD = HTC.Business.CategoryList.DMNhanVien.GetDMNhanVien(_VPPKiemNhap.NguoiSD).TenNguoiSD;      
                this.Add(_VPPKiemNhap);

            }
            return _VPPKiemNhap;
        }


        public bool Containss(string MaNV)
        {
            foreach (VPPKiemNhap obj in this)
                if (obj.MaNV == MaNV)
                    return true;
            return false;
        }

        public bool Contains(string MaDV)
        {
            foreach (VPPKiemNhap obj in this)
                if (obj.MaPhieu == MaDV)
                    return true;
            return false;
        }
        //public bool Containss(string MaVPP)
        //{
        //    foreach (VPPKiemNhap obj in this)
        //        if (obj.MaPhieu == MaVPP)
        //            return true;
        //    return false;
        //}
        //public VPPKiemNhap GetVPPKiemNhapById(string maNV, Byte stt, string maP)
        //{
        //    foreach (VPPKiemNhap item in this)
        //        if ((item.MaPhieu == maP) && (item.STT == stt) && (item.MaNV == maNV))
        //            return item;
        //    return null;
        //}
        public VPPKiemNhap GetVPPKiemNhapById(Byte stt, string maP)
        {
            foreach (VPPKiemNhap item in this)
                if ((item.MaPhieu == maP) && (item.STT == stt) )
                    return item;
            return null;
        }
        //public void Remove(string madv, int stt)
        //{
        //    foreach (VPPKiemNhap item in this)
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
            VPPKiemNhap item = VPPKiemNhap.NewVPPKiemNhap();
            Add(item);
            return item;
        }

        private VPPKiemNhapList()
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
        ////        SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVPPKiemNhap(criteria.MaDV, criteria.qadmin)))
        ////    {
        ////        //IsReadOnly = false;
        ////        while (dr.Read())
        ////        {
        ////            VPPKiemNhap item = new VPPKiemNhap(
        //// dr.GetString("MaVPP") ,
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
        ////// dr.GetString("TENDVPP") ,
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindVPPKiemNhap(criteria.DK, false)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            VPPKiemNhap item = new VPPKiemNhap(
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVPPKiemNhap(criteria.MaPhieu,  criteria.qadmin, criteria.Loai  )))
            {
                while (dr.Read())
                {
                    this.Add(VPPKiemNhap.GetVPPKiemNhap(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (VPPKiemNhap item in DeletedList)
            {
                item.DeleteSelf() ;
            }

            DeletedList.Clear();

            foreach (VPPKiemNhap item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override VPPKiemNhapList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            VPPKiemNhapList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
