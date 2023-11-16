using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.NoiTru
{
    [Serializable()]
    public class BenhAn_GETsBCDICHVUListInfo : ReadOnlyListBase<BenhAn_GETsBCDICHVUListInfo, BenhAn_GETsBCDICHVUInfo>
    {
        #region Factory Methods
        public static BenhAn_GETsBCDICHVUListInfo NewList()
        {
            return DataPortal.Fetch<BenhAn_GETsBCDICHVUListInfo>(new TemCriteria());
        }
        public BenhAn_GETsBCDICHVUInfo GetTo(string maba) //
        {
            foreach (BenhAn_GETsBCDICHVUInfo obj in this)
                if (obj.MASOKHAM == maba)
                    return obj;
            return null;

        }
        public static BenhAn_GETsBCDICHVUListInfo BenhAn_GETsBCDICHVUInfo(String _maSoKham, Byte _DaTT, byte _loai, String _dK)
        {
            return DataPortal.Fetch<BenhAn_GETsBCDICHVUListInfo>(new CriteriaOther(_maSoKham, _DaTT, _loai, _dK));
        }

        private BenhAn_GETsBCDICHVUListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        [Serializable()]
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }
        private class CriteriaOther
        {
            private string _MaBA;
            public string MaBA
            {
                get
                {
                    return _MaBA;
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


            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
                }
            }

            private Byte _DaTT;
            public Byte DaTT
            {
                get
                {
                    return _DaTT;
                }
            }

            public CriteriaOther(
                   String mmaBA,

                  Byte mDaTT,
                   Byte mLoai,
                string mDK
                    )
            {
                _MaBA = mmaBA;
                _DK = mDK;

                _Loai = mLoai;
                _DaTT = mDaTT;

            }
        }

        private void DataPortal_Fetch(CriteriaOther criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().BenhAn_GETsBCDICHVUInfo(
                      criteria.MaBA,
                      criteria.DaTT,
                      criteria.Loai,
                      criteria.DK
                      )))
            {
                int i = 1;
                IsReadOnly = false;

                while (dr.Read())
                {
                    BenhAn_GETsBCDICHVUInfo item = new BenhAn_GETsBCDICHVUInfo
             (i,
            dr.GetString("madt"),
             dr.GetInt32("STTDT"),
             dr.GetString("MASOKHAM"),
             dr.GetInt32("LOAIDV"),
             dr.GetString("MaDV"),
             dr.GetString("TENDV"),
             dr.GetInt32("STT"),
             dr.GetDecimal("DONGIATT"),
             dr.GetDecimal("DONGIABH"),
             dr.GetBoolean("ADGIAUSD"),
             dr.GetDecimal("SOLUONG"),
             dr.GetString("MAKHOA"),
             dr.GetString("BSKHAM"),
             dr.GetBoolean("TINHTIEN"),
             dr.GetBoolean("BHTINHTIEN"),
             dr.GetByte("DATT"),
             dr.GetDecimal("CK"),
             dr.GetString("TENKHOA"),
             dr.GetString("TENBS"),
             dr.GetInt32("NGAYYC"),
             dr.GetInt32("NGAYLAP"),
             dr.GetString("NGUOILAP"),
             dr.GetString("NGUOISD"),
              dr.GetInt32("NGAYSD"),
              dr.GetInt32("NGAYHUY"),
             dr.GetString("NGUOIHUY"),
             dr.GetString("TENNGUOILAP"),
                 dr.GetString("TENNGUOISD"),
             dr.GetString("TENNGUOIHUY"),
             dr.GetString("SOHD"),
                 dr.GetString("SOSOHD"),
                 dr.GetInt32("TYGIA"),
                 dr.GetDecimal("GIACHENHLECH"),
                 dr.GetString("TENDVT"),
                 dr.GetString("TENDT"),
             dr.GetDecimal("BHTRA"),
             dr.GetSmartDate("NGAYVVTT", true),
             dr.GetSmartDate("NGAYKT", true),
                 dr.GetString("KQ"));

                    this.Add(item);
                    i += 1;

                }
                dr.Close(); dr.Dispose();  //IsReadOnly = true;
            }

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

        #endregion
    }
}
