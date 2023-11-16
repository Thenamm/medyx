using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.CNK
{
    [Serializable()]
    public class NKKiemKeList : BusinessListBase<NKKiemKeList,NKKiemKe>
    {
        #region Factory Methods
        public static NKKiemKeList GetAllNKKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem,bool qadmin )
        {
            return DataPortal.Fetch<NKKiemKeList>(new Criteria(makho, tungay, denngay, dieukienthem,qadmin));
        }
        //public static NKKiemKeList FindNKKiemKeByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<NKKiemKeList>()
        //}
        public void NewTo(NKKiemKe _NKKiemKe)
        {
            if (this.Count == 0)
                _NKKiemKe.OrderNumber = 1;
            else
            _NKKiemKe.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            _NKKiemKe.TenKho = HTC.Business.CategoryList.DMKho.GetDMKho(_NKKiemKe.Makho).TenKho;
            this.Add(_NKKiemKe);
        }
        //public NKKiemKe AssignTo(NKKiemKe _NKKiemKe)//add mot hang PhieuNhap_C
        //{

        //    if (this.Items.Count > 0)
        //    {
        //        byte _count = 0;
        //        _count = (byte)this.Items.Count;
        //        _NKKiemKe.OrderNumber = ++_count;
        //        //_NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        this.Add(_NKKiemKe);
        //    }
        //    else
        //    {
        //       // _NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        _NKKiemKe.OrderNumber = 1;
        //        this.Add(_NKKiemKe);
        //    }


        //    return _NKKiemKe;
        //}
        public void UpdatedTo(NKKiemKe _NKKiemKe)
        {
            _NKKiemKe.OrderNumber = this.Items[this.IndexOf(_NKKiemKe)].OrderNumber;
            this.Items[this.IndexOf(_NKKiemKe)] = _NKKiemKe;
        }
        public void RemoveTo(NKKiemKe  _DMNKKiemKe)
        {
            this.Items.Remove(_DMNKKiemKe);

        }

        private NKKiemKeList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllNKKiemKe(criteria.MaKho,
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                { 
                NKKiemKe item=new NKKiemKe(
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
     dr.GetString("TenNguoiHuy"),
     dr.GetString("Makhoa"),
     dr.GetString("tenkhoa") 
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
