using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.PhongKham
{
    [Serializable()]
    public class HopDongKBList : BusinessListBase<HopDongKBList,HopDongKB>
    {
        #region Factory Methods
        public static HopDongKBList GetAllHopDongKB(DateTime tungay, DateTime denngay, String dieukienthem,bool qadmin )
        {
            return DataPortal.Fetch<HopDongKBList>(new Criteria(tungay, denngay, dieukienthem,qadmin));
        }
        //public static HopDongKBList FindHopDongKBByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<HopDongKBList>()
        //}
        public void NewTo(HopDongKB _HopDongKB)
        {
            _HopDongKB.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            //_HopDongKB.TenKho = HTC.Business.CategoryList.DMKho.GetDMKho(_HopDongKB.Makho).TenKho;
            this.Add(_HopDongKB);
        }
        //public HopDongKB AssignTo(HopDongKB _HopDongKB)//add mot hang PhieuNhap_C
        //{

        //    if (this.Items.Count > 0)
        //    {
        //        byte _count = 0;
        //        _count = (byte)this.Items.Count;
        //        _HopDongKB.OrderNumber = ++_count;
        //        //_NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        this.Add(_HopDongKB);
        //    }
        //    else
        //    {
        //       // _NhapTra.TenNoiNhap = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.Noinhap).TenKho;
        //        //_NhapTra.TenNoiXuat = HTC.Business.CategoryList.DMKho.GetDMKho(_NhapTra.NoiXuat).TenKho;
        //        _HopDongKB.OrderNumber = 1;
        //        this.Add(_HopDongKB);
        //    }


        //    return _HopDongKB;
        //}
        public void UpdatedTo(HopDongKB _HopDongKB)
        {
            _HopDongKB.OrderNumber = this.Items[this.IndexOf(_HopDongKB)].OrderNumber;
            this.Items[this.IndexOf(_HopDongKB)] = _HopDongKB;
        }
        public void RemoveTo(HopDongKB  _DMHopDongKB)
        {
            this.Items.Remove(_DMHopDongKB);

        }

        private HopDongKBList()
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

            public Criteria(DateTime tungay, DateTime denngay, String dieukienthem, bool qadmin)
            {
                _qadmin = qadmin;
                 
                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
            }
        }
        #endregion

        

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHopDongKB(
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                { 
                HopDongKB item=new HopDongKB(
     i,
                                            dr.GetString("MaHD") ,
                                            dr.GetByte("LoaiHD") ,
                                            dr.GetString("SoHD") ,
                                            dr.GetSmartDate("NgayKy", true),
                                            dr.GetSmartDate("TuNgay", true),
			                                dr.GetSmartDate("DenNgay", true),
			                                dr.GetString("NguoiDD") ,
                                            dr.GetString("NguoiLienHe") ,
                                            dr.GetString("DonVi") ,
                                            dr.GetString("DiaChi") ,
                                            dr.GetString("DienThoai") ,
                                            dr.GetString("Fax") ,
                                            dr.GetString("MaSoThue") ,
                                            dr.GetString("TaiKhoan") ,
                                            dr.GetString("PTTT") ,
                                            dr.GetDecimal("GiatriHD") ,
                                            dr.GetBoolean("datt") ,
                                            dr.GetSmartDate("NgayTT", true) ,
                                            dr.GetString("GhiChu") ,
                                            dr.GetString("NoiTT") ,
                                            dr.GetBoolean("Huy"),
			                                dr.GetSmartDate("Ngaylap", true) ,
                                             dr.GetString("NguoiLap"),
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
                                            dr.GetString("MaMay") ,
			                                dr.GetSmartDate("Ngayhuy", true) ,
                                            dr.GetString("Nguoihuy"),
                                            dr.GetString("tenNguoidd"),
                                            dr.GetString("madt")
          
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
