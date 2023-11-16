using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.CNK
{
    [Serializable()]
    public class NKPhieuXuats : BusinessListBase<NKPhieuXuats,NKPhieuXuat>
    {
        #region Business Methods
        public NKPhieuXuat this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        #endregion
        #region Factory Methods
        public static NKPhieuXuats GetAllNKPhieuXuat(Boolean qadmin ,String makho, Byte loaiphieu, Boolean daphat, DateTime tungay, DateTime denngay, String dieukienthem, Boolean daduyet)
        {
            return DataPortal.Fetch<NKPhieuXuats>(new Criteria(qadmin , makho, loaiphieu, daphat , tungay, denngay, dieukienthem,daduyet ));
        }
        //public static NKPhieuXuats FindNKPhieuXuatByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<NKPhieuXuats>()
        //}
        public void NewTo(NKPhieuXuat _NKPhieuXuat)
        {
            _NKPhieuXuat.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_NKPhieuXuat);
        }
        public void UpdatedTo(NKPhieuXuat _NKPhieuXuat)
        {
            _NKPhieuXuat.OrderNumber = this.Items[this.IndexOf(_NKPhieuXuat)].OrderNumber;
            this.Items[this.IndexOf(_NKPhieuXuat)] = _NKPhieuXuat;
        }
        public void RemoveTo(NKPhieuXuat _NKPhieuXuat)
        {
            this.Items.Remove(_NKPhieuXuat);

        }

        private NKPhieuXuats()
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

            public Criteria(Boolean qadmin,String makho, Byte loaiphieu, Boolean daphat, DateTime tungay, DateTime denngay, String dieukienthem,Boolean daduyet )
            {
                _qadmin = qadmin;
                _maKho = makho;
                _loaiPhieu = loaiphieu;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNKPhieuXuat(criteria.qadmin, criteria.MaKho,
      criteria.LoaiPhieu, criteria.DaPhat, criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem,criteria.DaDuyet   )))
            {
                int i = 1;
                while (dr.Read())
                {
                NKPhieuXuat item=new NKPhieuXuat(
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
