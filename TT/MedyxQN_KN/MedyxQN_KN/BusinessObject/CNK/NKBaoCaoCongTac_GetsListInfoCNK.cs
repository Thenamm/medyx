using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//using System.Windows.Forms;

namespace HTC.Business.CNK
{
    [Serializable()]
    public class NKBaoCaoCongTac_GetsListInfoCNK : BusinessListBase<NKBaoCaoCongTac_GetsListInfoCNK, NKBaoCaoCongTac_GetsInfoCNK>
    {
        #region Factory Methods

        public static NKBaoCaoCongTac_GetsListInfoCNK GetsNKBaoCaoCongTac(DateTime tuNgay, DateTime denNgay,  String dk)
        {
            return DataPortal.Fetch<NKBaoCaoCongTac_GetsListInfoCNK>(new Criteria(tuNgay, denNgay, dk));
        }

        public void NewTo(NKBaoCaoCongTac_GetsInfoCNK _NKBaoCaoCongTac_GetsInfo)
        {
            _NKBaoCaoCongTac_GetsInfo.OrderNumber = this.Items[this.Count - 1].OrderNumber + 1;
            this.Add(_NKBaoCaoCongTac_GetsInfo);
        }
        public void UpdatedTo(NKBaoCaoCongTac_GetsInfoCNK _NKBaoCaoCongTac_GetsInfo)
        {

            _NKBaoCaoCongTac_GetsInfo.OrderNumber = this.Items[this.IndexOf(_NKBaoCaoCongTac_GetsInfo)].OrderNumber;
            this.Items[this.IndexOf(_NKBaoCaoCongTac_GetsInfo)] = _NKBaoCaoCongTac_GetsInfo;
        }

        public void RemoveTo(NKBaoCaoCongTac_GetsInfoCNK _NKBaoCaoCongTac_GetsInfo)
        {
            this.Items.Remove(_NKBaoCaoCongTac_GetsInfo);

        }

             
        private NKBaoCaoCongTac_GetsListInfoCNK()
        {  /* Require use of factory methods */
           // this.AllowNew = true;
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
          
            private DateTime _tuNgay;
            private DateTime _denNgay;
            private String _DK;
            public String DK
            {
                get
                {
                    return _DK;
                }
            }
           
            public DateTime TuNgay
            {
                get
                {
                    return _tuNgay;
                }
            }
            public DateTime DenNgay
            {
                get
                {
                    return _denNgay;
                }
            }
            public Criteria(DateTime mTuTuan, DateTime mDenTuan,  String dk)
            {
                _tuNgay = mTuTuan;
                _denNgay = mDenTuan;
                _DK  = dk  ;
                
                
            }
        }
                     
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetsNKBaoCaoCongTacCNK(criteria.TuNgay, criteria.DenNgay,  criteria.DK)))
            {
                int i = 1;
                //IsReadOnly = false;
                while (dr.Read())
                {
                    NKBaoCaoCongTac_GetsInfoCNK item = new NKBaoCaoCongTac_GetsInfoCNK(
     i,
      dr.GetByte("TUAN"),
     dr.GetString("THANG") ,
    
     dr.GetSmartDate("TUNGAY", true) ,
     dr.GetSmartDate("DENNGAY") 
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
