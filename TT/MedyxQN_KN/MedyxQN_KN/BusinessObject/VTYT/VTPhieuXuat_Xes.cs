using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTPhieuXuat_Xes : BusinessListBase<VTPhieuXuat_Xes,VTPhieuXuat_Xe>
    {
        #region Business Methods
        public VTPhieuXuat_Xe this[int i]
        {
            get
            {

                return this.Items[i];

            }
        }
        #endregion
        #region Factory Methods
        public static VTPhieuXuat_Xes GetAllVTPhieuXuat(Boolean qadmin ,String makho, Byte loaiphieu, Boolean daphat, DateTime tungay, DateTime denngay, String dieukienthem, Boolean daduyet)
        {
            return DataPortal.Fetch<VTPhieuXuat_Xes>(new Criteria(qadmin , makho, loaiphieu, daphat , tungay, denngay, dieukienthem,daduyet ));
        }
        //public static VTPhieuXuat_Xes FindVTPhieuXuatByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<VTPhieuXuat_Xes>()
        //}
        public void NewTo(VTPhieuXuat_Xe _VTPhieuXuat)
        {
            _VTPhieuXuat.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_VTPhieuXuat);
        }
        public void UpdatedTo(VTPhieuXuat_Xe _VTPhieuXuat)
        {
            _VTPhieuXuat.OrderNumber = this.Items[this.IndexOf(_VTPhieuXuat)].OrderNumber;
            this.Items[this.IndexOf(_VTPhieuXuat)] = _VTPhieuXuat;
        }
        public void RemoveTo(VTPhieuXuat_Xe _VTPhieuXuat)
        {
            this.Items.Remove(_VTPhieuXuat);

        }

        private VTPhieuXuat_Xes()
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

        #region CriteriaOther
        private class CriteriaOther
        {
            //
        }

        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVTPhieuXuat(criteria.qadmin, criteria.MaKho,
      criteria.LoaiPhieu, criteria.DaPhat, criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem,criteria.DaDuyet   )))
            {
                int i = 1;
                while (dr.Read())
                {
                VTPhieuXuat_Xe item=new VTPhieuXuat_Xe(
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
     dr.GetBoolean("DaDuyet"),
     dr.GetString ("DoiTuong")
                                  
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
