using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
using HTC.Business;


namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCXuatTraList : BusinessListBase<HCXuatTraList,HCXuatTra>
    {
        #region Factory Methods
        public static HCXuatTraList GetAllHCXuatTra(String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem)
        {
            return DataPortal.Fetch<HCXuatTraList>(new Criteria(makho, maNCC,  tungay, denngay, dieukienthem));
        }
        //public static HCXuatTraList FindHCXuatTraByKho(string TenKho)
        //{ 
        //    return DataPortal.Fetch<HCXuatTraList>()
        //}
        public void NewTo(HCXuatTra _HCXuatTra)
        {
            _HCXuatTra.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_HCXuatTra);
        }
        public void UpdatedTo(HCXuatTra _HCXuatTra)
        {
            _HCXuatTra.OrderNumber = this.Items[this.IndexOf(_HCXuatTra)].OrderNumber;
            this.Items[this.IndexOf(_HCXuatTra)] = _HCXuatTra;
        }
        public void RemoveTo(HCXuatTra  _DMHCXuatTra)
        {
            this.Items.Remove(_DMHCXuatTra);

        }

        private HCXuatTraList()
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
            private String _maNCC;
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
            public String maNCC
            {
                get
                {
                    return _maNCC;
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

            public Criteria(String makho, String maNCC, DateTime tungay, DateTime denngay, String dieukienthem)
            {
                _maKho = makho;
                _maNCC = maNCC;
                _tuNgay = tungay;
                _denNgay = denngay;
                _dieuKienThem = dieukienthem;
            }
        }
        #endregion

        //#region CriteriaOther
        //private class CriteriaOther
        //{
        //    //
        //}

        //#endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllHCXuatTra(criteria.qadmin, criteria.MaKho,
      criteria.maNCC, criteria.TuNgay,
      criteria.DenNgay, criteria.DieuKienThem)))
            {
                int i = 1;
                while (dr.Read())
                { 
                HCXuatTra item=new HCXuatTra(
     i,
     dr.GetString("MaPXT") ,
			                                dr.GetString("MaNCC") ,
			                                dr.GetString("SoCT") ,
			                                dr.GetSmartDate("NgayXT", true) ,
			                                dr.GetString("Makho") ,
			                                dr.GetBoolean("Thanhtoan") ,
			                                dr.GetSmartDate("NgayTToan", true) ,
			                                dr.GetSmartDate("NgayXuatTT", true) ,
			                                //dr.GetString("NVNhap") ,
			                                dr.GetDecimal("Tong") ,
			                                dr.GetString("Ghichu") ,
			                                dr.GetBoolean("Huy") ,
			                                dr.GetSmartDate("NgaySD", true) ,
			                                dr.GetString("NguoiSD") ,
			                                dr.GetSmartDate("NgaySD1", true) ,
			                                dr.GetString("NguoiSD1") ,
			                                dr.GetString("MaMay") ,
			                                dr.GetString("Nguoihuy") ,
			                                dr.GetSmartDate("Ngayhuy", true) ,
			                                dr.GetString("NguoiLap") ,
			                                dr.GetSmartDate("NgayLap", true) ,
			                                dr.GetString("NVXuat") ,
			                                dr.GetString("NVNhan") ,
			                                dr.GetDecimal("VAT") ,
     dr.GetString("TenNCC"),
     dr.GetString("TenKho"),
     dr.GetString("TenNVXuat"),
     dr.GetString("TenNguoiLap"),
     dr.GetString("TenNguoiSD"),
     dr.GetString("TenNguoiHuy")
     //dr.GetSmartDate("NgayXuatTT", true) 
                                  
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
