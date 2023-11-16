using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.VPP
{
    [Serializable()]
    public class VPPNhapTras : BusinessListBase<VPPNhapTras,VPPNhapTra>
    {
        #region Factory Methods
        public static VPPNhapTras GetAllVPPNhapTra(bool qadmin ,String makho, Byte loaiphieu, Byte daphat, DateTime tungay, DateTime denngay, String dieukienthem)
        {
            return DataPortal.Fetch<VPPNhapTras>(new Criteria(qadmin , makho, loaiphieu, daphat , tungay, denngay, dieukienthem));
        }
        //public static VPPNhapTras FindVPPNhapTraByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<VPPNhapTras>()
        //}
        public void NewTo(VPPNhapTra _VPPNhapTra)
        {
            _VPPNhapTra.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_VPPNhapTra);
        }
        public VPPNhapTra AssignTo(VPPNhapTra _VPPNhapTra)//add mot hang PhieuNhap_C
        {
            
                if (this.Items.Count > 0)
                {
                    byte _count = 0;
                    _count = (byte)this.Items.Count;
                    _VPPNhapTra.OrderNumber = ++_count;
                    _VPPNhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_VPPNhapTra.Noinhap).TenKho;
                    _VPPNhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_VPPNhapTra.NoiXuat).TenKho;
                    this.Add(_VPPNhapTra);
                }
                else
                {
                    _VPPNhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_VPPNhapTra.Noinhap).TenKho;
                    _VPPNhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_VPPNhapTra.NoiXuat).TenKho;
                    this.Add(_VPPNhapTra);
                }
           
            
            return _VPPNhapTra;
        }
        public void UpdatedTo(VPPNhapTra _VPPNhapTra)
        {
            _VPPNhapTra.OrderNumber = this.Items[this.IndexOf(_VPPNhapTra)].OrderNumber;
            //_VPPNhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_VPPNhapTra.Noinhap).TenKho;
            //_VPPNhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_VPPNhapTra.NoiXuat).TenKho;
            this.Items[this.IndexOf(_VPPNhapTra)] = _VPPNhapTra;
        }
        public void RemoveTo(VPPNhapTra _DMVPPNhapTra)
        {
            this.Items.Remove(_DMVPPNhapTra);

        }
        //public void RemoveTo(VPPNhapTra obj) //xoa 1 PhieuNhap_C
        //{

        //    Remove(obj);


        //}
        //public void RemoveTo(String MaPNT)
        //{
        //    foreach (VPPNhapTra obj in this)
        //    {
        //        if (obj.MaPNT.Equals(MaPNT))
        //        {
        //            Remove(obj);
        //            break;
        //        }
        //    }
        //}
        private VPPNhapTras()
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
            private Byte _daPhat;
            private DateTime _tuNgay;
            private DateTime _denNgay ;
            private String _dieuKienThem;

            public bool qadmin
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
            public Byte DaPhat
            {
                get
                {
                    return _daPhat;
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

            public Criteria(bool qadmin,String makho, Byte loaiphieu, Byte daphat, DateTime tungay, DateTime denngay, String dieukienthem)
            {
                _qadmin = qadmin;
                _maKho = makho;
                _loaiPhieu = loaiphieu;
                _daPhat = daphat;
                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVPPNhapTra(criteria.qadmin, criteria.MaKho,
      criteria.LoaiPhieu, criteria.DaPhat, criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem)))
            {
                int i = 1;
                while (dr.Read())
                { 
                VPPNhapTra item=new VPPNhapTra(
     i,
     dr.GetString("MaPNT"),
     dr.GetString("NoiXuat"),
     //dr.GetSmartDate("Ngayxuat", false),
     //dr.GetSmartDate("NgayXuatTT", false),
     dr.GetSmartDate("ngayNhap",false),
     dr.GetSmartDate("ngayNhapTT",false),
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
     dr.GetByte("DaPhat"),
     dr.GetBoolean("bnTra"),
     dr.GetString("MaMay"),
     dr.GetString("TenNoiXuat"),
     dr.GetString("TenNoiNhap"),
     dr.GetString("TenNVXuat"),    
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy"),
     dr.GetString("TenNguoiNhan"),
     dr.GetBoolean("daduyet")
                                  
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
