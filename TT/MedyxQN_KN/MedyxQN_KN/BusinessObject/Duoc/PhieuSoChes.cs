using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuSoChes : BusinessListBase<PhieuSoChes,PhieuSoChe>
    {
        #region Business Methods
        public PhieuSoChe this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        #endregion
        #region Factory Methods
        public static PhieuSoChes GetAllPhieuSoChe(Boolean qadmin ,String makho,String MaDT, Byte loaiphieu, Boolean daphat, DateTime tungay, DateTime denngay, String dieukienthem, Boolean daduyet)
        {
            return DataPortal.Fetch<PhieuSoChes>(new Criteria(qadmin , makho,MaDT , loaiphieu, daphat , tungay, denngay, dieukienthem,daduyet ));
        }
        //public static PhieuSoChes FindPhieuSoCheByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<PhieuSoChes>()
        //}
        public void NewTo(PhieuSoChe _PhieuSoChe)
        {
            _PhieuSoChe.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_PhieuSoChe);
        }
        public void UpdatedTo(PhieuSoChe _PhieuSoChe)
        {
            _PhieuSoChe.OrderNumber = this.Items[this.IndexOf(_PhieuSoChe)].OrderNumber;
            this.Items[this.IndexOf(_PhieuSoChe)] = _PhieuSoChe;
        }
        public void RemoveTo(PhieuSoChe _PhieuSoChe)
        {
            this.Items.Remove(_PhieuSoChe);

        }

        private PhieuSoChes()
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
           
            private DateTime _tuNgay;
            private DateTime _denNgay ;
            private String _dieuKienThem;
            private Byte _loaiPhieu;
            private Boolean _daPhat;
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

        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhieuSoche(criteria.qadmin, criteria.MaKho,criteria.MaDT ,
      criteria.LoaiPhieu, criteria.DaPhat, criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem,criteria.DaDuyet)))
            {
                int i = 1;
                while (dr.Read())
                {
                PhieuSoChe item=new PhieuSoChe(
     i,
     dr.GetString("MaSC"),
     dr.GetString("NoiXuat"),
     dr.GetSmartDate("NgayXuat",false),
     dr.GetSmartDate("NgayNhap",false),
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
    , dr.GetBoolean("Khongsua")
    ,  dr.GetString("MaPHC"),
                            dr.GetString("MaPPL"),
                            dr.GetString("MaPBB"),
                            dr.GetDecimal("TIENPX"),
                            dr.GetDecimal("TIENHC"),
                            dr.GetDecimal("TienPL"),
                            dr.GetDecimal("TienBB"),
                            dr.GetDecimal("TONGTIEN"),
                    dr.GetDecimal ("TienCong"),
                    dr.GetDecimal ("DienNuoc"),
                    dr.GetDecimal ("TienKhac"),
                                  dr.GetDecimal ("Khoanthem")
                                  
                    );
                this.Add(item);
                i +=1;
                }
            }
            RaiseListChangedEvents=true;
        }
        #endregion
    }
}
