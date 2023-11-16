using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public class MauKiemNhapList : BusinessListBase<MauKiemNhapList, MauKiemNhap>
    {
        #region Factory Methods
        public static MauKiemNhapList GetAllMauKiemNhap(String maPhieu, Byte loai )
        {
            return DataPortal.Fetch<MauKiemNhapList>(new Criteria(maPhieu,loai));
        }
        // tim theo dieu kien ten
        //public static MauKiemNhapList FindMauKiemNhapByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<MauKiemNhapList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static MauKiemNhapList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<MauKiemNhapList>(new CriteriaOther(1, MaChungLoai));
        //}

        public void NewTo(MauKiemNhap _MauKiemNhap)
        {
            try
            {
                if (!Contains(_MauKiemNhap.MaPhieu))
                {
                    if (this.Items.Count > 0)
                    {
                      
                        byte _count = 0;
                        _count = (byte)this.Items.Count;
                        _MauKiemNhap.STT = ++_count;
                        this.Add(_MauKiemNhap);
                    }
                    else
                    {
                        _MauKiemNhap.STT = 1;
                        this.Add(_MauKiemNhap);

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
        public void UpdatedTo(MauKiemNhap _MauKiemNhap)
        {

            _MauKiemNhap.STT = this.Items[this.IndexOf(_MauKiemNhap)].STT;
            this.Items[this.IndexOf(_MauKiemNhap)] = _MauKiemNhap;
        }
        public void RemoveTo(MauKiemNhap obj) //xoa 1 PhieuNhap_C
        {

            //Remove(obj); 
            if (obj.IsNew == true)
                this.Items.Remove(obj);

            else
                Remove(obj);

        }

        //public MauKiemNhap AssignTo(MauKiemNhap _MauKiemNhap)//add mot hang PhieuNhap_C
        //{
        //    if (!Containss(_MauKiemNhap.MaPhieu ))
        //    {
        //        if (this.Items.Count > 0)
        //        {
        //            Byte _count = 0;
        //            _count = (Byte)this.Items.Count;
        //            _MauKiemNhap.STT = ++_count;
        //            this.Add(_MauKiemNhap);
        //        }
        //        else
        //        {
        //            _MauKiemNhap.STT = 1;
        //            this.Add(_MauKiemNhap);
        //        }
        //        //Add(_PhieuNhap_C);
        //        return _MauKiemNhap;
        //    }
            
        //     else
        //        throw new InvalidOperationException(HTC.ShareVariables.VAR_ITEMEXIST);
        
        //}
        public MauKiemNhap AssignTo(MauKiemNhap _MauKiemNhap)//add mot hang PhieuNhap_C
        {
            if (!Containss(_MauKiemNhap.MaNV))
            {
                //_MauKiemNhap.tenChucDanh = HTC.Business.CategoryList.DMChucDanh.GetDMChucDanh(_MauKiemNhap.MaCD).TenCD;
               // _MauKiemNhap.MaMay = ,_maMay ,;
               //_MauKiemNhap.NgaySD =  new SmartDate(DateTime.Today) ;
              //_MauKiemNhap.NgaySD = Convert.ToString("dd/MM/yyyy",DateTime.Today )    ;   
                //_MauKiemNhap.NguoiSD = HTC.ShareVariables.pub_sNguoiSD;
                //_MauKiemNhap.TenNguoiSD = HTC.Business.CategoryList.DMNhanVien.GetDMNhanVien(_MauKiemNhap.NguoiSD).TenNguoiSD;      
                this.Add(_MauKiemNhap);

            }
            return _MauKiemNhap;
        }


        public bool Containss(string MaNV)
        {
            foreach (MauKiemNhap obj in this)
                if (obj.MaNV == MaNV)
                    return true;
            return false;
        }

        public bool Contains(string MaDV)
        {
            foreach (MauKiemNhap obj in this)
                if (obj.MaPhieu == MaDV)
                    return true;
            return false;
        }
        //public bool Containss(string MaVT)
        //{
        //    foreach (MauKiemNhap obj in this)
        //        if (obj.MaPhieu == MaVT)
        //            return true;
        //    return false;
        //}
        //public MauKiemNhap GetMauKiemNhapById(string maNV, Byte stt, string maP)
        //{
        //    foreach (MauKiemNhap item in this)
        //        if ((item.MaPhieu == maP) && (item.STT == stt) && (item.MaNV == maNV))
        //            return item;
        //    return null;
        //}
        public MauKiemNhap GetMauKiemNhapById(Byte stt, string maP)
        {
            foreach (MauKiemNhap item in this)
                if ((item.MaPhieu == maP) && (item.STT == stt) )
                    return item;
            return null;
        }
        //public void Remove(string madv, int stt)
        //{
        //    foreach (MauKiemNhap item in this)
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
            MauKiemNhap item = MauKiemNhap.NewMauKiemNhap();
            Add(item);
            return item;
        }

        private MauKiemNhapList()
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
        ////        SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllMauKiemNhap(criteria.MaDV, criteria.qadmin)))
        ////    {
        ////        //IsReadOnly = false;
        ////        while (dr.Read())
        ////        {
        ////            MauKiemNhap item = new MauKiemNhap(
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
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindMauKiemNhap(criteria.DK, false)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            MauKiemNhap item = new MauKiemNhap(
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllMauKiemNhap(criteria.MaPhieu,  criteria.qadmin, criteria.Loai  )))
            {
                while (dr.Read())
                {
                    this.Add(MauKiemNhap.GetMauKiemNhap(dr));
                }
            }
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        protected override void DataPortal_Update()
        {
            this.RaiseListChangedEvents = false;
            foreach (MauKiemNhap item in DeletedList)
            {
                item.DeleteSelf() ;
            }

            DeletedList.Clear();

            foreach (MauKiemNhap item in this)
            {
                if (item.IsNew)
                    item.Insert();
                else
                    item.Update();
            }

            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        public override MauKiemNhapList Save()
        {
            // see if save is allowed
            if (!CanEditObject())
                throw new System.Security.SecurityException(
                  "User not authorized to save DonviTCs");

            MauKiemNhapList result;
            result = base.Save();
            return result;
        }


        #endregion
    }
}
