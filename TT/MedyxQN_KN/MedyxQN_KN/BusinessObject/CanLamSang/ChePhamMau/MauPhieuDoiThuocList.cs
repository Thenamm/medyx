using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.CanLamSang
{
    [Serializable()]
    public class MauPhieuDoiThuocList : BusinessListBase<MauPhieuDoiThuocList,MauPhieuDoiThuoc>
    {
        #region Factory Methods
        public static MauPhieuDoiThuocList GetAllMauPhieuDoiThuoc(String makho,String maNCC, DateTime tungay, DateTime denngay, String dieukienthem)
        {
            return DataPortal.Fetch<MauPhieuDoiThuocList>(new Criteria(makho, maNCC, tungay, denngay, dieukienthem));
        }
        public static MauPhieuDoiThuocList FindMauPhieuDoiThuoc(string dk)
        {
            return DataPortal.Fetch<MauPhieuDoiThuocList>(new OtherCriteria(dk));
        }
        public void NewTo(MauPhieuDoiThuoc _MauPhieuDoiThuoc)
        {
            _MauPhieuDoiThuoc.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_MauPhieuDoiThuoc);
        }
        public void UpdatedTo(MauPhieuDoiThuoc _MauPhieuDoiThuoc)
        {
            _MauPhieuDoiThuoc.OrderNumber = this.Items[this.IndexOf(_MauPhieuDoiThuoc)].OrderNumber;
            this.Items[this.IndexOf(_MauPhieuDoiThuoc)] = _MauPhieuDoiThuoc;
        }
        public void RemoveTo(MauPhieuDoiThuoc  _DMMauPhieuDoiThuoc)
        {
            this.Items.Remove(_DMMauPhieuDoiThuoc);

        }

        private MauPhieuDoiThuocList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllMauPhieuDoiThuoc(criteria.MaKho,criteria.MaNCC, 
      criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem, criteria.qadmin)))
            {
                int i = 1;
                while (dr.Read())
                { 
                MauPhieuDoiThuoc item=new MauPhieuDoiThuoc(
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindMauPhieuDoiThuoc(criteria.qadmin,criteria.DieuKienThem)))
            {
                int i = 1;
                while (dr.Read())
                {
                    MauPhieuDoiThuoc item = new MauPhieuDoiThuoc(
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
