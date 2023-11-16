using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCPhieuDoiThuocList : BusinessListBase<HCPhieuDoiThuocList,HCPhieuDoiThuoc>
    {
        #region Factory Methods
        public static HCPhieuDoiThuocList GetAllHCPhieuDoiThuoc(String makho,String maNCC, DateTime tungay, DateTime denngay, String dieukienthem)
        {
            return DataPortal.Fetch<HCPhieuDoiThuocList>(new Criteria(makho, maNCC, tungay, denngay, dieukienthem));
        }
        public static HCPhieuDoiThuocList FindHCPhieuDoiThuoc(string dk)
        {
            return DataPortal.Fetch<HCPhieuDoiThuocList>(new OtherCriteria(dk));
        }
        public void NewTo(HCPhieuDoiThuoc _HCPhieuDoiThuoc)
        {
            if (this.Count == 0)
                _HCPhieuDoiThuoc.OrderNumber = 1;
            else
            _HCPhieuDoiThuoc.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_HCPhieuDoiThuoc);
        }
        public void UpdatedTo(HCPhieuDoiThuoc _HCPhieuDoiThuoc)
        {
            _HCPhieuDoiThuoc.OrderNumber = this.Items[this.IndexOf(_HCPhieuDoiThuoc)].OrderNumber;
            this.Items[this.IndexOf(_HCPhieuDoiThuoc)] = _HCPhieuDoiThuoc;
        }
        public void RemoveTo(HCPhieuDoiThuoc  _DMHCPhieuDoiThuoc)
        {
            this.Items.Remove(_DMHCPhieuDoiThuoc);

        }

        private HCPhieuDoiThuocList()
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
            private String _MaNCC;
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
            public String MaNCC
            {
                get
                {
                    return _MaNCC;
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

            public Criteria(String makho, String mancc, DateTime tungay, DateTime denngay, String dieukienthem)
            {
                _maKho = makho;
                _MaNCC = mancc;
                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
            }
        }
        #endregion

        #region OtherCriteria
        [Serializable()]
        private class OtherCriteria
        {
             private Boolean _qadmin = false ;
            
            private String _dieuKienThem;

            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            
            public String DieuKienThem
            {
                get
                {
                    return _dieuKienThem;
                }
            }

            public OtherCriteria(String dieukienthem)
            {
                
                _dieuKienThem = dieukienthem;
            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHCPhieuDoiThuoc(criteria.MaKho,criteria.MaNCC, 
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                { 
                HCPhieuDoiThuoc item=new HCPhieuDoiThuoc(
     i,
     dr.GetString("MaDThuoc") ,
			                                dr.GetString("MaNCC") ,
			                                dr.GetString("SoCT") ,
			                                dr.GetSmartDate("NgayDThuoc", true),
			                                dr.GetString("Makho") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetSmartDate("NgaySD1", true),
			                                dr.GetString("NguoiSD1") ,
			                                dr.GetSmartDate("NgayLap", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("Ngayhuy", true) ,
			                                dr.GetString("Nguoihuy") ,
			                                dr.GetString("MaMay") ,
     dr.GetString("TenKho"),
     dr.GetString("TenNCC"),
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

        private void DataPortal_Fetch(OtherCriteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindHCPhieuDoiThuoc(criteria.qadmin,criteria.DieuKienThem)))
            {
                int i = 1;
                while (dr.Read())
                {
                    HCPhieuDoiThuoc item = new HCPhieuDoiThuoc(
         i,
         dr.GetString("MaDThuoc"),
         dr.GetString("MaNCC"),
         dr.GetString("SoCT"),
         dr.GetSmartDate("NgayDThuoc", true),
         dr.GetString("Makho"),
         dr.GetString("Ghichu"),
         dr.GetBoolean("Huy"),
         dr.GetSmartDate("NgaySD", true),
         dr.GetString("NguoiSD"),
         dr.GetSmartDate("NgaySD1", true),
         dr.GetString("NguoiSD1"),
         dr.GetSmartDate("NgayLap", true),
         dr.GetString("NguoiLap"),
         dr.GetSmartDate("Ngayhuy", true),
         dr.GetString("Nguoihuy"),
         dr.GetString("MaMay"),
         dr.GetString("TenKho"),
         dr.GetString("TenNCC"),
         dr.GetString("TenNguoiLap"),
         dr.GetString("TenNguoiSD"),
         dr.GetString("TenNguoiHuy")

                        );
                    this.Add(item);
                    i += 1;
                }
            }
            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
