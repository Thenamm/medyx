using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class KhamBenhList : BusinessListBase<KhamBenhList, KhamBenh>
    {
        #region Factory Methods
        public static KhamBenhList GetAllKhamBenhByMaBN(string maBN, DateTime ngayYC, Byte loai, string dk)
        {
            return DataPortal.Fetch<KhamBenhList>(new Criteria(maBN, ngayYC, loai, dk));
        }
        // tim theo dieu kien ten
        //public static KhamBenhList FindKhamBenhByTen(string TenChungLoai)
        //{
        //    return DataPortal.Fetch<KhamBenhList>(new CriteriaOther(2, TenChungLoai));
        //}
        //public static KhamBenhList FindDMDichVuByMa(string MaChungLoai)
        //{
        //    return DataPortal.Fetch<KhamBenhList>(new CriteriaOther(1, MaChungLoai));
        //}
        public void NewTo(KhamBenh _KhamBenh)
        {
            if (this.Count == 0)
                _KhamBenh.OrderNumber = 1;
            else
            _KhamBenh.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_KhamBenh);
        }
        public void UpdatedTo(KhamBenh _KhamBenh)
        {

            _KhamBenh.OrderNumber = this.Items[this.IndexOf(_KhamBenh)].OrderNumber;
            this.Items[this.IndexOf(_KhamBenh)] = _KhamBenh;
        }
        public void RemoveTo(KhamBenh _KhamBenh)
        {
            this.Items.Remove(_KhamBenh);

        }

        private KhamBenhList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _maBN;
            public String maBN
            {
                get
                {
                    return _maBN;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            private DateTime _ngayYC;
            public DateTime ngayYC
            {
                get
                {
                    return _ngayYC;
                }
            }
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }
            public Criteria(string maBN, DateTime ngayYC, Byte loai, string dk)
            {
                _ngayYC = ngayYC;
                _Loai = loai ;
                _maBN = maBN;
                _DK = dk;
                
                
            }
        }

        // tim kiem theo ten
        //#region CriteriaOther
        //[Serializable()]
        //private class CriteriaOther
        //{
        //    private int _id;
        //    public int Id
        //    {
        //        get
        //        {
        //            return _id;
        //        }
        //    }
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
        //    public Criteria(Boolean mqadmin)
        //    {

        //        _qadmin = mqadmin;
        //    }
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

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllKhamBenhByMaBN(criteria.maBN, criteria.ngayYC, criteria.Loai, criteria.DK, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    KhamBenh item = new KhamBenh(
         i,
         dr.GetString("MaSoKham"),
			 dr.GetString("MaBN") ,
			 dr.GetString("MaDT") ,
			 dr.GetString("Sothe") ,
			 dr.GetSmartDate("GiatriDN", true) ,
			 dr.GetString("MaBV") ,
			 dr.GetString("MaTinh") ,
			 dr.GetSmartDate("NgayKT", true) ,
			 dr.GetString("Gio") ,
			 dr.GetSmartDate("Ngayduyet", true) ,
			 dr.GetString("Nguoiduyet") ,
			 dr.GetSmartDate("NgayQT", true) ,
			 dr.GetSmartDate("NgayQTTT", true) ,
			 dr.GetString("NguoiQT") ,
			 dr.GetString("MaBenhNoiGT") ,
			 dr.GetString("MaNoiGT") ,
			 dr.GetString("CDNoiGT") ,
			 dr.GetString("Ghichu") ,
			 dr.GetByte("LoaiKham") ,
			 dr.GetBoolean("Cungtra") ,
			 dr.GetDecimal("CK") ,
			 dr.GetSmartDate("NgayLap", true) ,
			 dr.GetString("NguoiLap") ,
			 dr.GetSmartDate("NgaySD", true) ,
			 dr.GetString("NguoiSD") ,
			 dr.GetString("MaMay") ,
			 dr.GetBoolean("Huy") ,
         dr.GetString("NguoiHuy"),
			 dr.GetSmartDate("NgayHuy", true) ,
			 dr.GetSmartDate("NgaySD1", true) ,
			 dr.GetString("NguoiSD1") ,
			 dr.GetString("DienThoai") ,
			 dr.GetString("DiaChi") ,
         dr.GetDecimal("TongTien") ,
         dr.GetDecimal("TongTienBH") ,
         dr.GetDecimal("TongBHTra"),
          dr.GetString("mabhxh") ,
          dr.GetDecimal("BHTra"),
          dr.GetDecimal("sotienBHTra"),
           dr.GetString("tenbv"),
            dr.GetSmartDate("ngaydk", true),
            dr.GetSmartDate("giatritn", true) ,
             dr.GetString("MaBVgt") ,
             dr.GetString("mabhxhgt") ,
              dr.GetString("tenbvgt"),
                dr.GetBoolean("duyetbh") ,
                 dr.GetDecimal("kyquybh"),
            dr.GetSmartDate("ngaygt", true)
         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        //private void DataPortal_Fetch(CriteriaOther criteria)
        //{
        //    RaiseListChangedEvents = false;
        //    using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindKhamBenh(criteria.DK, criteria.qadmin)))
        //    {
        //        int i = 1;
        //        //IsReadOnly = false;
        //        while (dr.Read())
        //        {
        //            KhamBenh item = new KhamBenh(
        // i,
        // dr.GetString("MaSoKham"),
        // dr.GetString("MaBN"),
        // dr.GetString("MaDT"),
        // dr.GetString("Sothe"),
        // dr.GetSmartDate("GiatriDN", true),
        // dr.GetString("MaBV"),
        // dr.GetString("MaTinh"),
        // dr.GetSmartDate("NgayKT", true),
        // dr.GetString("Gio"),
        // dr.GetSmartDate("Ngayduyet", true),
        // dr.GetString("Nguoiduyet"),
        // dr.GetSmartDate("NgayQT", true),
        // dr.GetSmartDate("NgayQTTT", true),
        // dr.GetString("NguoiQT"),
        // dr.GetString("MaBenhNoiGT"),
        // dr.GetString("MaNoiGT"),
        // dr.GetString("CDNoiGT"),
        // dr.GetString("Ghichu"),
        // dr.GetByte("LoaiKham"),
        // dr.GetBoolean("Cungtra"),
        // dr.GetDecimal("CK"),
        // dr.GetSmartDate("NgayLap", true),
        // dr.GetString("NguoiLap"),
        // dr.GetSmartDate("NgaySD", true),
        // dr.GetString("NguoiSD"),
        // dr.GetString("MaMay"),
        // dr.GetBoolean("Huy"),
        // dr.GetByte("NguoiHuy"),
        // dr.GetSmartDate("NgayHuy", true),
        // dr.GetSmartDate("NgaySD1", true),
        // dr.GetString("NguoiSD1"),
        // dr.GetString("DienThoai"),
        // dr.GetString("DiaChi"),
        // dr.GetDecimal("TongTien"),
        // dr.GetDecimal("TongTienBH"),
        // dr.GetDecimal("TongBHTra") 
        // );
        //            this.Add(item);
        //            i += 1;

        //        }
        //        //IsReadOnly = true;
        //    }
           
        //    RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        //}

        #endregion
    }
}
