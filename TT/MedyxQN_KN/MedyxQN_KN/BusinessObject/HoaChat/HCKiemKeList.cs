using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCKiemKeList : BusinessListBase<HCKiemKeList,HCKiemKe>
    {
        #region Factory Methods
        public static HCKiemKeList GetAllHCKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem,bool qadmin )
        {
            return DataPortal.Fetch<HCKiemKeList>(new Criteria(makho, tungay, denngay, dieukienthem,qadmin));
        }
        //public static HCKiemKeList FindHCKiemKeByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<HCKiemKeList>()
        //}
        public void NewTo(HCKiemKe _HCKiemKe)
        {
            _HCKiemKe.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            _HCKiemKe.TenKho = HTC.Business.CategoryList.DMKho.GetDMKho(_HCKiemKe.Makho).TenKho;
            this.Add(_HCKiemKe);
        }
        //public HCKiemKe AssignTo(HCKiemKe _HCKiemKe)//add mot hang PhieuNhap_C
        //{

        //    if (this.Items.Count > 0)
        //    {
        //        byte _count = 0;
        //        _count = (byte)this.Items.Count;
        //        _HCKiemKe.OrderNumber = ++_count;
        //        //_NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        this.Add(_HCKiemKe);
        //    }
        //    else
        //    {
        //       // _NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        _HCKiemKe.OrderNumber = 1;
        //        this.Add(_HCKiemKe);
        //    }


        //    return _HCKiemKe;
        //}
        public void UpdatedTo(HCKiemKe _HCKiemKe)
        {
            _HCKiemKe.OrderNumber = this.Items[this.IndexOf(_HCKiemKe)].OrderNumber;
            this.Items[this.IndexOf(_HCKiemKe)] = _HCKiemKe;
        }
        public void RemoveTo(HCKiemKe  _DMHCKiemKe)
        {
            this.Items.Remove(_DMHCKiemKe);

        }

        private HCKiemKeList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHCKiemKe(criteria.MaKho,
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                { 
                HCKiemKe item=new HCKiemKe(
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
