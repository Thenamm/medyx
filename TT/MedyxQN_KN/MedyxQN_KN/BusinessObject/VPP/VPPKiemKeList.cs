using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.VPP
{
    [Serializable()]
    public class VPPKiemKeList : BusinessListBase<VPPKiemKeList,VPPKiemKe>
    {
        #region Factory Methods
        public static VPPKiemKeList GetAllVPPKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem,bool qadmin )
        {
            return DataPortal.Fetch<VPPKiemKeList>(new Criteria(makho, tungay, denngay, dieukienthem,qadmin));
        }
        //public static VPPKiemKeList FindVPPKiemKeByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<VPPKiemKeList>()
        //}
        public void NewTo(VPPKiemKe _VPPKiemKe)
        {
            if (this.Count == 0)
                _VPPKiemKe.OrderNumber = 1;
            else
            _VPPKiemKe.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            _VPPKiemKe.TenKho = HTC.Business.CategoryList.DMKho.GetDMKho(_VPPKiemKe.Makho).TenKho;
            this.Add(_VPPKiemKe);
        }
        //public VPPKiemKe AssignTo(VPPKiemKe _VPPKiemKe)//add mot hang PhieuNhap_C
        //{

        //    if (this.Items.Count > 0)
        //    {
        //        byte _count = 0;
        //        _count = (byte)this.Items.Count;
        //        _VPPKiemKe.OrderNumber = ++_count;
        //        //_NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        this.Add(_VPPKiemKe);
        //    }
        //    else
        //    {
        //       // _NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        _VPPKiemKe.OrderNumber = 1;
        //        this.Add(_VPPKiemKe);
        //    }


        //    return _VPPKiemKe;
        //}
        public void UpdatedTo(VPPKiemKe _VPPKiemKe)
        {
            _VPPKiemKe.OrderNumber = this.Items[this.IndexOf(_VPPKiemKe)].OrderNumber;
            this.Items[this.IndexOf(_VPPKiemKe)] = _VPPKiemKe;
        }
        public void RemoveTo(VPPKiemKe  _DMVPPKiemKe)
        {
            this.Items.Remove(_DMVPPKiemKe);

        }

        private VPPKiemKeList()
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

            public Criteria(String makho, DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin)
            {
                _qadmin = qadmin;
                _maKho = makho;
                
                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
            }
        }
        #endregion

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllVPPKiemKe(criteria.MaKho,
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                { 
                VPPKiemKe item=new VPPKiemKe(
     i,
     dr.GetString("MaKK") ,
			                                dr.GetSmartDate("NgayKK", true),
			                                dr.GetString("Makho") ,
			                                dr.GetString("NguoiKK") ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("Ngaylap", true) ,
			                                dr.GetString("GhiChu") ,
			                                dr.GetBoolean("Xuly") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetSmartDate("Ngayhuy", true) ,
			                                dr.GetString("Nguoihuy") ,
			                                dr.GetBoolean("Huy") ,
     dr.GetString("TenKho"),
     dr.GetString("TenNVKK"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy")
                                  
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
