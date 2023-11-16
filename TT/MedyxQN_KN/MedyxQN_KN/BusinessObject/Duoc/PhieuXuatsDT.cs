using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuXuatsDT : BusinessListBase<PhieuXuatsDT,PhieuXuatDT>
    {
        #region Business Methods
        public PhieuXuatDT this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        #endregion
        #region Factory Methods
        public static PhieuXuatsDT GetAllPhieuXuat(Boolean qadmin ,String makho,String MaDT, Byte loaiphieu, Boolean daphat, DateTime tungay, DateTime denngay, String dieukienthem, Boolean daduyet)
        {
            return DataPortal.Fetch<PhieuXuatsDT>(new Criteria(qadmin , makho,MaDT , loaiphieu, daphat , tungay, denngay, dieukienthem,daduyet ));
        }
        public static PhieuXuatsDT GetAllPhieuXuatCB(Boolean qadmin, String makho, String MaDT, Boolean daphat,DateTime tungay, DateTime denngay, String dieukienthem, Boolean daduyet)
        {
            return DataPortal.Fetch<PhieuXuatsDT>(new CriteriaCHEBIEN(qadmin, makho, MaDT, daphat, tungay, denngay, dieukienthem, daduyet));
        }
        //public static PhieuXuatsDT FindPhieuXuatByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<PhieuXuatsDT>()
        //}
        public void NewTo(PhieuXuatDT _PhieuXuat)
        {
            _PhieuXuat.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_PhieuXuat);
        }
        public void UpdatedTo(PhieuXuatDT _PhieuXuat)
        {
            _PhieuXuat.OrderNumber = this.Items[this.IndexOf(_PhieuXuat)].OrderNumber;
            this.Items[this.IndexOf(_PhieuXuat)] = _PhieuXuat;
        }
        public void RemoveTo(PhieuXuatDT _PhieuXuat)
        {
            this.Items.Remove(_PhieuXuat);

        }

        private PhieuXuatsDT()
        {
            /* Require use of factory methods */
        }
        #endregion
        

        #region Data Access

        #region Criteria
        [Serializable()]
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _maKho;
            private String _MaDT;
            private Byte _loaiPhieu;
            private Boolean _daPhat;
            private DateTime _tuNgay;
            private DateTime _denNgay ;
            private String _dieuKienThem;
            private Boolean _daDuyet;
            public Boolean qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public String MaKho
            {
                get
                {
                    return _maKho;
                }
            }
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
            public Byte LoaiPhieu
            {
                get
                {
                    return _loaiPhieu;
                }
            }
            public Boolean DaPhat
            {
                get
                {
                    return _daPhat;
                }
            }
            public Boolean DaDuyet
            {
                get
                {
                    return _daDuyet;
                }
            }
            public DateTime TuNgay
            {
                get
                {
                    return _tuNgay;
                }
 
            }
            public DateTime DenNgay
            {
                get
                {
                    return _denNgay;
                }
            }
            public String DieuKienThem
            {
                get
                {
                    return _dieuKienThem;
                }
            }

            public Criteria(Boolean qadmin,String makho,String MaDT, Byte loaiphieu, Boolean daphat, DateTime tungay, DateTime denngay, String dieukienthem,Boolean daduyet )
            {
                _qadmin = qadmin;
                _maKho = makho;
                _MaDT = MaDT;
                _loaiPhieu = loaiphieu;
                _daPhat = daphat;
                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
                _daDuyet = daduyet;
            }
        }
        #endregion

        #region CriteriaOther
        private class CriteriaOther
        {
            //
        }
        private class CriteriaCHEBIEN
        {
             private Boolean _qadmin = false ;
            private String _maKho;
            private String _MaDT;          
            private Boolean _daPhat;
            private DateTime _tuNgay;
            private DateTime _denNgay;
            private String _dieuKienThem;
            private Boolean _daDuyet;
            public Boolean qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            public String MaKho
            {
                get
                {
                    return _maKho;
                }
            }
            public String MaDT
            {
                get
                {
                    return _MaDT;
                }
            }
           
            public Boolean DaPhat
            {
                get
                {
                    return _daPhat;
                }
            }
            public Boolean DaDuyet
            {
                get
                {
                    return _daDuyet;
                }
            }
            public DateTime TuNgay
            {
                get
                {
                    return _tuNgay;
                }

            }
            public DateTime DenNgay
            {
                get
                {
                    return _denNgay;
                }
            }
            public String DieuKienThem
            {
                get
                {
                    return _dieuKienThem;
                }
            }

            public CriteriaCHEBIEN(Boolean qadmin, String makho, String MaDT, Boolean daphat, DateTime tungay, DateTime denngay, String dieukienthem, Boolean daduyet)
            {
                _qadmin = qadmin;
                _maKho = makho;
                _MaDT = MaDT;               
                _daPhat = daphat;
                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
                _daDuyet = daduyet;
            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhieuXuat(criteria.qadmin, criteria.MaKho,criteria.MaDT ,
      criteria.LoaiPhieu, criteria.DaPhat, criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem,criteria.DaDuyet   )))
            {
                int i = 1;
                while (dr.Read())
                {
                PhieuXuatDT item=new PhieuXuatDT(
     i,
     dr.GetString("MaPX"),
     dr.GetString("NoiXuat"),
     dr.GetSmartDate("NgayXuat",false),
     dr.GetSmartDate("NgayXuatTT",false),
     dr.GetString("NoiNhap"),
     dr.GetByte("LoaiPhieu"),
     dr.GetString("SoCT"),
     dr.GetString("NVXuat"),
     dr.GetString("NVNhan"),
     dr.GetString("GhiChu"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"),
     dr.GetSmartDate("NgayLap",false),
     dr.GetString("NguoiLap"),
     dr.GetSmartDate("NgayHuy",false),
     dr.GetString("NguoiHuy"),
     dr.GetSmartDate("NgaySD1",false),
     dr.GetString("NguoiSD1"),
     dr.GetBoolean("DaPhat"),
     dr.GetBoolean("KhoaYC"),
     dr.GetString("MaMay"),
     dr.GetString("TenNoiXuat"),
     dr.GetString("TenNoiNhap"),
     dr.GetString("TenNVXuat"),    
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNguoiNhan"),
     dr.GetBoolean("DaDuyet")
     ,dr.GetString ("MaDT")
     , dr.GetString("TenDT")
    , dr.GetBoolean("Khongsua"),dr.GetDecimal("SLThang")
     ,dr.GetDecimal("SLDon"),dr.GetDecimal ("TongCP")
                    );
                this.Add(item);
                i +=1;
                }
            }
            RaiseListChangedEvents=true;
        }
        private void DataPortal_Fetch(CriteriaCHEBIEN criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhieuXuatCB(criteria.qadmin, criteria.MaKho, criteria.MaDT,
       criteria.DaPhat, criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.DaDuyet)))
            {
                int i = 1;
                while (dr.Read())
                {
                    PhieuXuatDT item = new PhieuXuatDT(
         i,
         dr.GetString("MaPX"),
         dr.GetString("NoiXuat"),
         dr.GetSmartDate("NgayXuat", false),
         dr.GetSmartDate("NgayXuatTT", false),
         dr.GetString("NoiNhap"),
         dr.GetByte("LoaiPhieu"),
         dr.GetString("SoCT"),
         dr.GetString("NVXuat"),
         dr.GetString("NVNhan"),
         dr.GetString("GhiChu"),
         dr.GetBoolean("Huy"),
         dr.GetSmartDate("NgaySD", false),
         dr.GetString("NguoiSD"),
         dr.GetSmartDate("NgayLap", false),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("NgayHuy", false),
         dr.GetString("NguoiHuy"),
         dr.GetSmartDate("NgaySD1", false),
         dr.GetString("NguoiSD1"),
         dr.GetBoolean("DaPhat"),
         dr.GetBoolean("KhoaYC"),
         dr.GetString("MaMay"),
         dr.GetString("TenNoiXuat"),
         dr.GetString("TenNoiNhap"),
         dr.GetString("TenNVXuat"),
         dr.GetString("TenNguoiLap"),
         dr.GetString("TenNguoiSD"),
         dr.GetString("TenNguoiHuy"),
         dr.GetString("TenNguoiNhan"),
         dr.GetBoolean("DaDuyet")
         , dr.GetString("MaDT")
         , dr.GetString("TenDT")
        , dr.GetBoolean("Khongsua"), dr.GetDecimal("SLThang")
         , dr.GetDecimal("SLDon"),
         dr.GetDecimal("tongCP") 
                        );
                    this.Add(item);
                    i += 1;
                }
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
#endregion
    }
}
