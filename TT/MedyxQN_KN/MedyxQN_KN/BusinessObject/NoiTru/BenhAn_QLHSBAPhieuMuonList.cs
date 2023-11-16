using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class BenhAn_QLHSBAPhieuMuonList : ReadOnlyListBase<BenhAn_QLHSBAPhieuMuonList, BenhAn_QLHSBAPhieuMuon>
    {
        #region Factory Methods
        public static BenhAn_QLHSBAPhieuMuonList GetAllBenhAn_QLHSBAPhieuMuon(DateTime TuNgay, DateTime DenNgay, String MaKhoa, bool Tra)
        {
            return DataPortal.Fetch<BenhAn_QLHSBAPhieuMuonList>(new Criteria(TuNgay, DenNgay, MaKhoa, Tra));
        }

        private BenhAn_QLHSBAPhieuMuonList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private DateTime _TuNgay;
            public DateTime TuNgay
            {
                get
                {
                    return _TuNgay;
                }
            }
            private DateTime _DenNgay;
            public DateTime DenNgay
            {
                get
                {
                    return _DenNgay;
                }
            }
            private String _MaKhoa;
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            private bool _Tra;
            public bool Tra
            {
                get { return _Tra; }
            }
            public Criteria(DateTime TuNgay, DateTime DenNgay, String MaKHoa, bool tra)
            {
                _TuNgay = TuNgay;
                _DenNgay = DenNgay;
                _MaKhoa = MaKHoa;
                _Tra = tra;
            }
        }
        #region CriteriaOther

        [Serializable()]
        private class CriteriaOther
        {

            private Byte _IdFind;
            public Byte IdFind
            {
                get
                {
                    return _IdFind;
                }
            }
            private string _DK;
            public string DK
            {
                get
                {
                    return _DK;
                }
            }
             private Boolean _qadmin = false ;
            public bool qadmin
            {
                get
                {
                    return _qadmin;
                }
            }
            //public Criteria(Boolean mqadmin)
            //{

            //    _qadmin = mqadmin;
            //}
            public CriteriaOther(Byte mIdFind, String mDK)
            {

                _IdFind = mIdFind;
                if (mIdFind == 1)
                    _DK = "MaPhieuGN like '%" + mDK + "'";
                else if (mIdFind == 2)
                    _DK = "ltrim(rtrim(TenKhoa)) like N'" + mDK + "%'";


            }
        }
        #endregion

        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBenhAn_QLHSBAPhieuMuon(criteria.TuNgay, criteria.DenNgay, criteria.MaKhoa,criteria.Tra)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_QLHSBAPhieuMuon item = new BenhAn_QLHSBAPhieuMuon(
     i,
     dr.GetString("MaPM"),
     dr.GetSmartDate("NgayMuon", false),
     dr.GetString("NguoiMuon"),
     dr.GetString("TenNguoiMuon"),
     dr.GetString("KhoaMuon"),
     dr.GetString("TenKhoa"),
     dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgayLap", false),
     dr.GetString("NguoiLap"),
     dr.GetString("TenNguoiLap"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("TenNguoiSD"),
     dr.GetBoolean("Tra")
         );
                    this.Add(item);
                    i += 1;

                }
                IsReadOnly = true;
            }
            // Xem lai doan code duoi
            //ArrayList arrList;
            //arrList = CBO.FillCollection(DataProvider.Instance().GetLocations(criteria.Id), typeof(LocationListInfo));
            //IsReadOnly = false;
            //foreach (LocationListInfo obj in arrList)
            //{
            //    this.Add(obj);
            //}
            //IsReadOnly = true;

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().FindBenhAn_QLHSBAPhieuMuon(criteria.DK, false)))
            {
                int i = 1;

                IsReadOnly = false;
                while (dr.Read())
                {
                    BenhAn_QLHSBAPhieuMuon item = new BenhAn_QLHSBAPhieuMuon(
     i,
     dr.GetString("MaPM"),
     dr.GetSmartDate("NgayMuon", false),
     dr.GetString("NguoiMuon"),
     dr.GetString("TenNguoiMuon"),
     dr.GetString("KhoaMuon"),
     dr.GetString("TenKhoa"),
     dr.GetString("GhiChu"),
     dr.GetString("MaMay"),
     dr.GetBoolean("Huy"),
     dr.GetSmartDate("NgayLap", false),
     dr.GetString("NguoiLap"),
     dr.GetString("TenNguoiLap"),
     dr.GetSmartDate("NgaySD", false),
     dr.GetString("NguoiSD"),
     dr.GetString("TenNguoiSD"),
     dr.GetBoolean("Tra")
         );
                    this.Add(item);
                    i += 1;

                }
                IsReadOnly = true;
            }
            

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        #endregion
    }
}
