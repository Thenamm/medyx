using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
 //using System.Windows.Forms;
//
 
namespace HTC.Business.KHTH
{
    [Serializable()]
    public class BC_ChuyenMonNgay_ListInfo : BusinessListBase<BC_ChuyenMonNgay_ListInfo, BC_ChuyenMonNgay_Info>
    {
        #region Factory Methods

        public static BC_ChuyenMonNgay_ListInfo GetAllMacBenh(DateTime tuthang, DateTime denthang, string makhoa, String dk)
        {
            return DataPortal.Fetch<BC_ChuyenMonNgay_ListInfo>(new Criteria(tuthang ,denthang ,makhoa,dk ));
        }

        public void NewTo(BC_ChuyenMonNgay_Info _BC_ChuyenMonNgay_Info)
        {
            _BC_ChuyenMonNgay_Info.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_BC_ChuyenMonNgay_Info);
        }
        public void UpdatedTo(BC_ChuyenMonNgay_Info _BC_ChuyenMonNgay_Info)
        {

            _BC_ChuyenMonNgay_Info.OrderNumber = this.Items[this.IndexOf(_BC_ChuyenMonNgay_Info)].OrderNumber;
            this.Items[this.IndexOf(_BC_ChuyenMonNgay_Info)] = _BC_ChuyenMonNgay_Info;
        }

        public void RemoveTo(BC_ChuyenMonNgay_Info _BC_ChuyenMonNgay_Info)
        {
            this.Items.Remove(_BC_ChuyenMonNgay_Info);

        }

             
        private BC_ChuyenMonNgay_ListInfo()
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
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllBC_ChuyenMonNgay(criteria.TuThang, criteria.DenThang, criteria.MaKhoa, criteria.DK,HTC.ShareVariables.pub_bQadmin   )))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    BC_ChuyenMonNgay_Info item = new BC_ChuyenMonNgay_Info(
     i,
     dr.GetString("TENKHOA"),
     dr.GetSmartDate("THANG", true) ,
     dr.GetString("MAKHOA") ,
     dr.GetSmartDate("NGAYSD", true) ,
     dr.GetString("tennguoisd"),
     dr.GetBoolean("Huy"),
     dr.GetString("MAMAY") 
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
