using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{

    [Serializable()]
    public class BenhAn_TMHList : BusinessListBase<BenhAn_TMHList, BenhAn_TMH>
    {
        #region Factory Methods
        public static BenhAn_TMHList GetAllBenhAn_TMH(String maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_TMHList>(new Criteria(maBA, STTkhoa));
        }

        public void NewTo(BenhAn_TMH _BenhAn_TMH)
        {
            if (this.Count == 0)
                _BenhAn_TMH.OrderNumber = 1;
            else
                _BenhAn_TMH.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_TMH);
        }

      
        public void UpdatedTo(BenhAn_TMH _BenhAn_TMH)
        {

            _BenhAn_TMH.OrderNumber = this.Items[this.IndexOf(_BenhAn_TMH)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_TMH)] = _BenhAn_TMH;
        }

        private int IndexOf(BenhAn_TMH _BenhAn_TMH)
        {
            throw new NotImplementedException();
        }
        public void RemoveTo(BenhAn_TMH _BenhAn_TMH)
        {
            this.Items.Remove(_BenhAn_TMH);

        }

        private BenhAn_TMHList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_TMH(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_TMH item = new BenhAn_TMH(
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
             dr.GetString("BenhChuyenKhoa"),
               dr.GetString("CQTuanHoan"),
                         dr.GetString("CQHoHap"),
                             dr.GetString("CQTieuHoa"),
                              dr.GetString("CQDa"),
                                         dr.GetString("CQCoXuongKhop"),
                                           dr.GetString("CQTietNieuSD"),
                                            dr.GetString("CQTamThan"),

         dr.GetString("CoQuanKhac"),
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
