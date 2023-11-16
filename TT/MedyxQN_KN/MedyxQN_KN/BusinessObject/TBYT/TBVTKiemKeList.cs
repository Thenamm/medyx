using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.TBYT
{
    [Serializable()]
    public class TBVTKiemKeList : BusinessListBase<TBVTKiemKeList,TBVTKiemKe>
    {
        #region Factory Methods
        public static TBVTKiemKeList GetAllTBVTKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem,bool qadmin )
        {
            return DataPortal.Fetch<TBVTKiemKeList>(new Criteria(makho, tungay, denngay, dieukienthem,qadmin));
        }
        //public static TBVTKiemKeList FindTBVTKiemKeByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<TBVTKiemKeList>()
        //}
        public void NewTo(TBVTKiemKe _TBVTKiemKe)
        {
            if (this.Count == 0)
                _TBVTKiemKe.OrderNumber = 1;
            else
            _TBVTKiemKe.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            _TBVTKiemKe.TenKho = HTC.Business.CategoryList.DMKho.GetDMKho(_TBVTKiemKe.Makho).TenKho;
            this.Add(_TBVTKiemKe);
        }
        //public TBVTKiemKe AssignTo(TBVTKiemKe _TBVTKiemKe)//add mot hang PhieuNhap_C
        //{

        //    if (this.Items.Count > 0)
        //    {
        //        byte _count = 0;
        //        _count = (byte)this.Items.Count;
        //        _TBVTKiemKe.OrderNumber = ++_count;
        //        //_NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        this.Add(_TBVTKiemKe);
        //    }
        //    else
        //    {
        //       // _NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        _TBVTKiemKe.OrderNumber = 1;
        //        this.Add(_TBVTKiemKe);
        //    }


        //    return _TBVTKiemKe;
        //}
        public void UpdatedTo(TBVTKiemKe _TBVTKiemKe)
        {
            _TBVTKiemKe.OrderNumber = this.Items[this.IndexOf(_TBVTKiemKe)].OrderNumber;
            this.Items[this.IndexOf(_TBVTKiemKe)] = _TBVTKiemKe;
        }
        public void RemoveTo(TBVTKiemKe  _DMTBVTKiemKe)
        {
            this.Items.Remove(_DMTBVTKiemKe);

        }

        private TBVTKiemKeList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllTBVTKiemKe(criteria.MaKho,
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                { 
                TBVTKiemKe item=new TBVTKiemKe(
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
