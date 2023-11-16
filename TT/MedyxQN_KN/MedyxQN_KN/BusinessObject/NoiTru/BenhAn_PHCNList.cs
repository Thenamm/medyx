using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_PHCNList : BusinessListBase<BenhAn_PHCNList, BenhAn_PHCN>
    {
        #region Factory Methods
        public static BenhAn_PHCNList GetAllBenhAn_PHCN(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_PHCNList>(new Criteria(maBA, STTkhoa));
        }

        public void NewTo(BenhAn_PHCN _BenhAn_PHCN)
        {
            if (this.Count == 0)
                _BenhAn_PHCN.OrderNumber = 1;
            else
                _BenhAn_PHCN.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_PHCN);
        }
        public void UpdatedTo(BenhAn_PHCN _BenhAn_PHCN)
        {

            _BenhAn_PHCN.OrderNumber = this.Items[this.IndexOf(_BenhAn_PHCN)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_PHCN)] = _BenhAn_PHCN;
        }
        public void RemoveTo(BenhAn_PHCN _BenhAn_PHCN)
        {
            this.Items.Remove(_BenhAn_PHCN);

        }

        private BenhAn_PHCNList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
             private Boolean _qadmin = false ;
            private String _maBA;
            public String maBA
            {
                get
                {
                    return _maBA;
                }
            }
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }

            private Byte _STTKhoa;
            public Byte STTKhoa
            {
                get
                {
                    return _STTKhoa;
                }
            }
            public Criteria(string maBA, Byte STTKhoa)
            {

                _STTKhoa = STTKhoa;
                _maBA = maBA;



            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_PHCN(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_PHCN item = new BenhAn_PHCN(
         i,
         dr.GetString("MaBA"),
             dr.GetInt32("STT"),
             dr.GetInt32("STTKhoa"),
             dr.GetSmartDate("NgayKham", true),
             dr.GetString("BSKHAM"),
             dr.GetString("LyDoKham"),
             dr.GetString("Mach"),
             dr.GetString("ApHuyet"),
             dr.GetString("NhietDo"),
             dr.GetString("NhipTho"),
             dr.GetString("CanNang"),
             dr.GetString("ChieuCao"),

             dr.GetString("ToanThan"),
        

 dr.GetString("ToanThanCacBoPhan"),
         dr.GetString("ToanThanCacKhuyetTat"),
           dr.GetString("CQThanKinhVD"),
        dr.GetString("CQThanKinhPX"),
          dr.GetString("CQThanKinhSoNao"),
            dr.GetString("CQThanKinhCamGiac"),
          dr.GetString("CQThanKinhCoTron"),
           dr.GetString("CQThanKinhRoiLoanCN"),
         dr.GetString("CQThanKinhTiengTim"),
 dr.GetString("CQTuanHoanNhipTim"),
   dr.GetString("CQTuanHoanTiengTim"),
 dr.GetString("CQTuanHoanRoiLoanCN"),
          dr.GetString("CQHoHapLongNguc"),
     dr.GetString("CQHoHapBenhLy"),
          dr.GetString("CQHoHapTheTichKhi"),
   dr.GetString("CQHoHapLRoiLoanCN"),
          dr.GetString("CQTieuHoaBenhLy"),
           dr.GetString("CQTieuHoaRoiLoanCN"),
          dr.GetString("CQDa"),
         dr.GetString("CQKhopHinhThe"),
 dr.GetString("CQKhopTamHoatDong"),
    dr.GetString("CQKhopLucVV"),
    dr.GetString("CQCoBenhLy"),
  dr.GetString("CQCoDuocThu"),
 dr.GetString("CQCoRoiLoanCN"),
dr.GetInt32("CQCoBacThuCo"),
 dr.GetString("CQCotSongBenhLy"),
            dr.GetString("CQCotSongShober"),
    dr.GetString("CQCotSongStibor"),
              dr.GetString("CQCotSongRoiLoanCN"),
             dr.GetString("CQTietNieuSD"),
       dr.GetString("CoQuanKhac"),
     dr.GetString("MoTaTonThuong"),       
             dr.GetString("DieuTri"),
             dr.GetString("BenhSu"),
             dr.GetString("HuongDT"),
             dr.GetString("Mabenh"),
             dr.GetString("MaBenhKem"),
             dr.GetString("Machuyenkhoa"),
             dr.GetString("MaMay"),
             dr.GetBoolean("Huy"),
             dr.GetSmartDate("NgaySD", true),
             dr.GetString("NguoiSD"),
             dr.GetSmartDate("NgaySD1", true),
             dr.GetString("NguoiSD1"),
               dr.GetString("TenBenh"),
         dr.GetString("TenBenhKem"),
          dr.GetString("MaICD"),
         dr.GetString("MaICDKem"),
         dr.GetString("TenBSKham"),
         dr.GetString("TenNguoiSD")

         );
                    this.Add(item);
                    i += 1;

                }
                //IsReadOnly = true;
            }


            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
