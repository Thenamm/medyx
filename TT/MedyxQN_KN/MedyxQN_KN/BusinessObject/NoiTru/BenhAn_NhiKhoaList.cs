using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_NhiKhoaList : BusinessListBase<BenhAn_NhiKhoaList, BenhAn_NhiKhoa>
    {
        #region Factory Methods
        public static BenhAn_NhiKhoaList GetAllBenhAn_NhiKhoa(string maBA, Byte STTkhoa)
        {
            return DataPortal.Fetch<BenhAn_NhiKhoaList>(new Criteria(maBA, STTkhoa));
        }

        public void NewTo(BenhAn_NhiKhoa _BenhAn_NhiKhoa)
        {
            if (this.Count == 0)
                _BenhAn_NhiKhoa.OrderNumber = 1;
            else
                _BenhAn_NhiKhoa.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BenhAn_NhiKhoa);
        }
        public void UpdatedTo(BenhAn_NhiKhoa _BenhAn_NhiKhoa)
        {

            _BenhAn_NhiKhoa.OrderNumber = this.Items[this.IndexOf(_BenhAn_NhiKhoa)].OrderNumber;
            this.Items[this.IndexOf(_BenhAn_NhiKhoa)] = _BenhAn_NhiKhoa;
        }
        public void RemoveTo(BenhAn_NhiKhoa _BenhAn_NhiKhoa)
        {
            this.Items.Remove(_BenhAn_NhiKhoa);

        }

        private BenhAn_NhiKhoaList()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_NhiKhoa(criteria.maBA, criteria.STTKhoa, criteria.qadmin)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_NhiKhoa item = new BenhAn_NhiKhoa(
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
         dr.GetString("ToanThanChieuCao"),
             dr.GetString("ToanThanVongNguc"),
                 dr.GetString("ToanThanVongDau"),

                     dr.GetString("CQTuanHoan"),
                         dr.GetString("CQHoHap"),
                             dr.GetString("CQTieuHoa"),
                                 dr.GetString("CQTietNieuSD"),
                                     dr.GetString("CQThanKinh"),
                                         dr.GetString("CQCoXuongKhop"),
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
