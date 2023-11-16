using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.Duoc
{
    [Serializable()]
    public class TonKhoa_BN_GetsListInfo : BusinessListBase<TonKhoa_BN_GetsListInfo, TonKhoa_BN_GetsInfo>
    {
        #region Factory Methods

        public static TonKhoa_BN_GetsListInfo GetsTonKhoa_BN(DateTime tungayyclinh, DateTime denngayyclinh, string makhoa, String dk)
        {
            return DataPortal.Fetch<TonKhoa_BN_GetsListInfo>(new Criteria(tungayyclinh ,denngayyclinh ,makhoa,dk ));
        }

        public void NewTo(TonKhoa_BN_GetsInfo _TonKhoa_BN_GetsInfo)
        {
            _TonKhoa_BN_GetsInfo.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_TonKhoa_BN_GetsInfo);
        }
        public void UpdatedTo(TonKhoa_BN_GetsInfo _TonKhoa_BN_GetsInfo)
        {

            _TonKhoa_BN_GetsInfo.OrderNumber = this.Items[this.IndexOf(_TonKhoa_BN_GetsInfo)].OrderNumber;
            this.Items[this.IndexOf(_TonKhoa_BN_GetsInfo)] = _TonKhoa_BN_GetsInfo;
        }

        public void RemoveTo(TonKhoa_BN_GetsInfo _TonKhoa_BN_GetsInfo)
        {
            this.Items.Remove(_TonKhoa_BN_GetsInfo);

        }

             
        private TonKhoa_BN_GetsListInfo()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetsTonKhoa_BN(criteria.Tungayyclinh, criteria.Denngayyclinh, criteria.MaKhoa, criteria.DK)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    TonKhoa_BN_GetsInfo item = new TonKhoa_BN_GetsInfo(
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
