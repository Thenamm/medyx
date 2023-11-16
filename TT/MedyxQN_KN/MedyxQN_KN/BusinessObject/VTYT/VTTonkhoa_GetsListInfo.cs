using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
////

namespace HTC.Business.VTYT
{
    [Serializable()]
    public class VTTonKhoa_GetsListInfo : BusinessListBase<VTTonKhoa_GetsListInfo, VTTonKhoa_GetsInfo>
    {
        #region Factory Methods

        public static VTTonKhoa_GetsListInfo GetsVTTonKhoa(DateTime tuthang, DateTime denthang, string makhoa, String dk)
        {
            return DataPortal.Fetch<VTTonKhoa_GetsListInfo>(new Criteria(tuthang ,denthang ,makhoa,dk ));
        }

        public void NewTo(VTTonKhoa_GetsInfo _VTTonKhoa_GetsInfo)
        {
            _VTTonKhoa_GetsInfo.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_VTTonKhoa_GetsInfo);
        }
        public void UpdatedTo(VTTonKhoa_GetsInfo _VTTonKhoa_GetsInfo)
        {

            _VTTonKhoa_GetsInfo.OrderNumber = this.Items[this.IndexOf(_VTTonKhoa_GetsInfo)].OrderNumber;
            this.Items[this.IndexOf(_VTTonKhoa_GetsInfo)] = _VTTonKhoa_GetsInfo;
        }

        public void RemoveTo(VTTonKhoa_GetsInfo _VTTonKhoa_GetsInfo)
        {
            this.Items.Remove(_VTTonKhoa_GetsInfo);

        }

             
        private VTTonKhoa_GetsListInfo()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetsVTTonKhoa(criteria.TuThang, criteria.DenThang, criteria.MaKhoa, criteria.DK)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    VTTonKhoa_GetsInfo item = new VTTonKhoa_GetsInfo(
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
