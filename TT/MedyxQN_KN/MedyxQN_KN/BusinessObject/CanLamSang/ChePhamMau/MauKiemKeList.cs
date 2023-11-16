using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public class MauKiemKeList : BusinessListBase<MauKiemKeList,MauKiemKe>
    {
        #region Factory Methods
        public static MauKiemKeList GetAllMauKiemKe(String makho, DateTime tungay, DateTime denngay, String dieukienthem,bool qadmin )
        {
            return DataPortal.Fetch<MauKiemKeList>(new Criteria(makho, tungay, denngay, dieukienthem,qadmin));
        }
        //public static MauKiemKeList FindMauKiemKeByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<MauKiemKeList>()
        //}
        public void NewTo(MauKiemKe _MauKiemKe)
        {
            _MauKiemKe.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            _MauKiemKe.TenKho = HTC.Business.CategoryList.DMKho.GetDMKho(_MauKiemKe.Makho).TenKho;
            this.Add(_MauKiemKe);
        }
        //public MauKiemKe AssignTo(MauKiemKe _MauKiemKe)//add mot hang PhieuNhap_C
        //{

        //    if (this.Items.Count > 0)
        //    {
        //        byte _count = 0;
        //        _count = (byte)this.Items.Count;
        //        _MauKiemKe.OrderNumber = ++_count;
        //        //_NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        this.Add(_MauKiemKe);
        //    }
        //    else
        //    {
        //       // _NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        _MauKiemKe.OrderNumber = 1;
        //        this.Add(_MauKiemKe);
        //    }


        //    return _MauKiemKe;
        //}
        public void UpdatedTo(MauKiemKe _MauKiemKe)
        {
            _MauKiemKe.OrderNumber = this.Items[this.IndexOf(_MauKiemKe)].OrderNumber;
            this.Items[this.IndexOf(_MauKiemKe)] = _MauKiemKe;
        }
        public void RemoveTo(MauKiemKe  _DMMauKiemKe)
        {
            this.Items.Remove(_DMMauKiemKe);

        }

        private MauKiemKeList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllMauKiemKe(criteria.MaKho,
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                { 
                MauKiemKe item=new MauKiemKe(
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
