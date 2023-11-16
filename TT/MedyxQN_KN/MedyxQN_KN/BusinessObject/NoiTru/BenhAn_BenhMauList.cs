using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//11
namespace HTC.Business.NoiTru
{

    [Serializable()]
    public class BenhAn_BenhMauList : BusinessListBase<BenhAn_BenhMauList, BenhAn_BenhMau>
    {
        #region Factory Methods
        public static BenhAn_BenhMauList GetAllBenhAn_BenhMau(String maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_BenhMauList>(new Criteria(maBA, STTkhoa));
        }

        public void NewTo(BenhAn_BenhMau _BenhAn_BenhMau)
        {
            if (this.Count == 0)
                _BenhAn_BenhMau.OrderNumber = 1;
            else
                _BenhAn_BenhMau.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_BenhMau);
        }

       
        public void UpdatedTo(BenhAn_BenhMau _BenhAn_BenhMau)
        {

            _BenhAn_BenhMau.OrderNumber = this.Items[this.IndexOf(_BenhAn_BenhMau)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_BenhMau)] = _BenhAn_BenhMau;
        }

        private int IndexOf(BenhAn_BenhMau _BenhAn_BenhMau)
        {
            throw new NotImplementedException();
        }
        public void RemoveTo(BenhAn_BenhMau _BenhAn_BenhMau)
        {
            this.Items.Remove(_BenhAn_BenhMau);

        }

        private BenhAn_BenhMauList()
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
            public Criteria(String maBA, Byte STTKhoa)
            {

                _STTKhoa = STTKhoa;
                _maBA = maBA;



            }
        }

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_BenhMau(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
              //  IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_BenhMau item = new BenhAn_BenhMau(
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
              dr.GetString("TTTinhThan"),
                              dr.GetString("TTHinhDang"),
            dr.GetString("TTDa"),
           dr.GetString("TTTrieuChungXuatHuyet"),

           dr.GetString("TTLongTocMong"),
            dr.GetString("TTTrieuChungPhu"),
            dr.GetString("TTTuyenGiap"),
             dr.GetString("CQGan"),
            dr.GetString("CQLach"),
            dr.GetString("CQHach"),
                         dr.GetString("CQHoHap"),
                             dr.GetString("CQTieuHoa"),
                              dr.GetString("CQTimMach"),
                                         dr.GetString("CQCoXuongKhop"),
                                           dr.GetString("CQTietNieuSD"),
                                            dr.GetString("CQTamThan"),
         dr.GetString("CoQuanKhac"),
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
