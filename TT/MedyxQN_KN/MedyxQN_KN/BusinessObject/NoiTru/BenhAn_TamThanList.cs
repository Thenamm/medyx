using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_TamThanList : BusinessListBase<BenhAn_TamThanList, BenhAn_TamThan>
    {
        #region Factory Methods
        public static BenhAn_TamThanList GetAllBenhAn_TamThan(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_TamThanList>(new Criteria(maBA, STTkhoa));
        }

        public void NewTo(BenhAn_TamThan _BenhAn_TamThan)
        {
            if (this.Count == 0)
                _BenhAn_TamThan.OrderNumber = 1;
            else
                _BenhAn_TamThan.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_TamThan);
        }
        public void UpdatedTo(BenhAn_TamThan _BenhAn_TamThan)
        {

            _BenhAn_TamThan.OrderNumber = this.Items[this.IndexOf(_BenhAn_TamThan)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_TamThan)] = _BenhAn_TamThan;
        }
        public void RemoveTo(BenhAn_TamThan _BenhAn_TamThan)
        {
            this.Items.Remove(_BenhAn_TamThan);

        }

        private BenhAn_TamThanList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_TamThan(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_TamThan item = new BenhAn_TamThan(
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
                dr.GetString("CacCoQuan"),
            dr.GetString("KhamThanKinh"),
            dr.GetString("TRBieuHien"),
            dr.GetString("TTNangLucKhongGian"),
dr.GetString("TTNangLucThoiGian"),
        dr.GetString("TTNangLucBanThan"),
            dr.GetString("TTCacHoiChung"),
            dr.GetString("TTCamXuc"),
            dr.GetString("TTTriGiac"),
            dr.GetString("TTTuDuyHinhThuc"),
          dr.GetString("TTTuDuyNoiDung"),
          dr.GetString("TTHanhViYThuc"),
       dr.GetString("TTHanhBanNang"),
         dr.GetString("TTTriNho"),
        dr.GetString("TTTriNang"),
   dr.GetString("TTChuY"),
         dr.GetString("TonThuong"),


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
