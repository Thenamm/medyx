using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.Duoc
{
    [Serializable()]
    public class PhieuDoiThuocList : BusinessListBase<PhieuDoiThuocList,PhieuDoiThuoc>
    {
        #region Factory Methods
        public static PhieuDoiThuocList GetAllPhieuDoiThuoc(String makho,String maNCC, DateTime tungay, DateTime denngay, String dieukienthem)
        {
            return DataPortal.Fetch<PhieuDoiThuocList>(new Criteria(makho, maNCC, tungay, denngay, dieukienthem));
        }
        public static PhieuDoiThuocList FindPhieuDoiThuoc(string dk)
        {
            return DataPortal.Fetch<PhieuDoiThuocList>(new OtherCriteria(dk));
        }
        public void NewTo(PhieuDoiThuoc _PhieuDoiThuoc)
        {
           
            _PhieuDoiThuoc.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_PhieuDoiThuoc);
        }
        public void UpdatedTo(PhieuDoiThuoc _PhieuDoiThuoc)
        {
            _PhieuDoiThuoc.OrderNumber = this.Items[this.IndexOf(_PhieuDoiThuoc)].OrderNumber;
            this.Items[this.IndexOf(_PhieuDoiThuoc)] = _PhieuDoiThuoc;
        }
        public void RemoveTo(PhieuDoiThuoc  _DMPhieuDoiThuoc)
        {
            this.Items.Remove(_DMPhieuDoiThuoc);

        }

        private PhieuDoiThuocList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhieuDoiThuoc(criteria.MaKho,criteria.MaNCC, 
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                { 
                PhieuDoiThuoc item=new PhieuDoiThuoc(
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindPhieuDoiThuoc(criteria.qadmin,criteria.DieuKienThem)))
            {
                int i = 1;
                while (dr.Read())
                {
                    PhieuDoiThuoc item = new PhieuDoiThuoc(
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
