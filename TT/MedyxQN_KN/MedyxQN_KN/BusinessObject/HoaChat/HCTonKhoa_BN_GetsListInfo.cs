using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//

namespace HTC.Business.HoaChat
{
    [Serializable()]
    public class HCTonKhoa_BN_GetsListInfo : BusinessListBase<HCTonKhoa_BN_GetsListInfo, HCTonKhoa_BN_GetsInfo>
    {
        #region Factory Methods

        public static HCTonKhoa_BN_GetsListInfo GetsHCTonKhoa_BN(DateTime tungayyclinh, DateTime denngayyclinh, string makhoa, String dk)
        {
            return DataPortal.Fetch<HCTonKhoa_BN_GetsListInfo>(new Criteria(tungayyclinh ,denngayyclinh ,makhoa,dk ));
        }

        public void NewTo(HCTonKhoa_BN_GetsInfo _HCTonKhoa_BN_GetsInfo)
        {
            _HCTonKhoa_BN_GetsInfo.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_HCTonKhoa_BN_GetsInfo);
        }
        public void UpdatedTo(HCTonKhoa_BN_GetsInfo _HCTonKhoa_BN_GetsInfo)
        {

            _HCTonKhoa_BN_GetsInfo.OrderNumber = this.Items[this.IndexOf(_HCTonKhoa_BN_GetsInfo)].OrderNumber;
            this.Items[this.IndexOf(_HCTonKhoa_BN_GetsInfo)] = _HCTonKhoa_BN_GetsInfo;
        }

        public void RemoveTo(HCTonKhoa_BN_GetsInfo _HCTonKhoa_BN_GetsInfo)
        {
            this.Items.Remove(_HCTonKhoa_BN_GetsInfo);

        }

             
        private HCTonKhoa_BN_GetsListInfo()
        {  /* Require use of factory methods */
            this.AllowNew = true;
        }

        #endregion

        #region Authorization Rules

        public static bool CanAddObject()
        {
            return true;
        }

        public static bool CanGetObject()
        {
            return true;
        }

        public static bool CanDeleteObject()
        {
            return true;
        }

        public static bool CanEditObject()
        {
            return true;
        }

        #endregion


        #region Data Access

        [Serializable()]
        private class Criteria
        {
            private DateTime _Tungayyclinh;
            private DateTime _Denngayyclinh;
            private String _DK;
            private String _MaKhoa;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
            public String MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
            public DateTime Tungayyclinh
            {
                get
                {
                    return _Tungayyclinh;
                }
            }
            public DateTime Denngayyclinh
            {
                get
                {
                    return _Denngayyclinh;
                }
            }
            public Criteria(DateTime mTungayyclinh, DateTime mDenngayyclinh, String mMakhoa, String dk)
            {
                _Tungayyclinh = mTungayyclinh ;
                _Denngayyclinh = mDenngayyclinh;
                _DK  = dk  ;
                _MaKhoa = mMakhoa;
                
            }
        }
                     
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetsHCTonKhoa_BN(criteria.Tungayyclinh, criteria.Denngayyclinh, criteria.MaKhoa, criteria.DK)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    HCTonKhoa_BN_GetsInfo item = new HCTonKhoa_BN_GetsInfo(
     i,
     dr.GetSmartDate("ngayyclinh", true) ,
     dr.GetString("HOTEN") ,
     dr.GetString("MAKHOA") ,
     dr.GetString("TENKHOA")
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
