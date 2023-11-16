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
    public class Tonkhoa_GetsListInfo : BusinessListBase<Tonkhoa_GetsListInfo, Tonkhoa_GetsInfo>
    {
        #region Factory Methods

        public static Tonkhoa_GetsListInfo GetsTonKhoa(DateTime tuthang, DateTime denthang, string makhoa, String dk)
        {
            return DataPortal.Fetch<Tonkhoa_GetsListInfo>(new Criteria(tuthang ,denthang ,makhoa,dk ));
        }

        public void NewTo(Tonkhoa_GetsInfo _Tonkhoa_GetsInfo)
        {
            _Tonkhoa_GetsInfo.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_Tonkhoa_GetsInfo);
        }
        public void UpdatedTo(Tonkhoa_GetsInfo _Tonkhoa_GetsInfo)
        {

            _Tonkhoa_GetsInfo.OrderNumber = this.Items[this.IndexOf(_Tonkhoa_GetsInfo)].OrderNumber;
            this.Items[this.IndexOf(_Tonkhoa_GetsInfo)] = _Tonkhoa_GetsInfo;
        }

        public void RemoveTo(Tonkhoa_GetsInfo _Tonkhoa_GetsInfo)
        {
            this.Items.Remove(_Tonkhoa_GetsInfo);

        }

             
        private Tonkhoa_GetsListInfo()
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
            private DateTime _TuThang;
            private DateTime _DenThang;
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
            public DateTime TuThang
            {
                get
                {
                    return _TuThang;
                }
            }
            public DateTime DenThang
            {
                get
                {
                    return _DenThang;
                }
            }
            public Criteria(DateTime mTuThang, DateTime mDenThang, String mMakhoa, String dk)
            {
                _TuThang = mTuThang ;
                _DenThang = mDenThang;
                _DK  = dk  ;
                _MaKhoa = mMakhoa;
                
            }
        }
                     
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetsTonKhoa(criteria.TuThang, criteria.DenThang, criteria.MaKhoa, criteria.DK)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    Tonkhoa_GetsInfo item = new Tonkhoa_GetsInfo(
     i,
     dr.GetSmartDate("THANG", true) ,
     dr.GetString("HOTEN") ,
     dr.GetString("MAKHOA") ,
     dr.GetSmartDate("NGAYSD", true) ,
     dr.GetString("MAMAY") ,
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
