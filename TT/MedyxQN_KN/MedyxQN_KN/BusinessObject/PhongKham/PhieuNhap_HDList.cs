using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;
//using System.Windows.Forms;


namespace HTC.Business.PhongKham
{
    [Serializable()]

    public class PhieuNhap_HDList : BusinessListBase<PhieuNhap_HDList, PhieuNhap_HD>
    {
        #region Factory Methods
        public static PhieuNhap_HDList NewList()
        {
            return DataPortal.Fetch<PhieuNhap_HDList>(new TemCriteria());
        }
        public static PhieuNhap_HDList GetAllPhieuNhap_HD(DateTime tungay, DateTime denngay,string makho, byte loai ,string   dk)
        {
            return DataPortal.Fetch<PhieuNhap_HDList>(new Criteria( tungay,  denngay, makho, loai ,   dk));
        }
      
       
        public PhieuNhap_HD NewTo() 
        {
            PhieuNhap_HD obj = PhieuNhap_HD.NewPhieuNhap_HD();
            return obj;
        }
      
       
        protected override object AddNewCore()
        {
            PhieuNhap_HD  item = PhieuNhap_HD.NewPhieuNhap_HD();
            Add(item);
            return item;
        }

      
        private PhieuNhap_HDList()
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
        private class TemCriteria
        {

        };
        private void DataPortal_Fetch(TemCriteria criteria)
        {
            this.RaiseListChangedEvents = false;
            this.RaiseListChangedEvents = true;
        }
        private class Criteria
        {
            private DateTime   _TuNgay;
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
            private byte  _Loai;
            public byte Loai
            {
                get
                {
                    return _Loai;
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
            private string _makho;
            public string makho
            {
                get
                {
                    return _makho;
                }
            }
            public Criteria(DateTime tungay, DateTime denngay, string makho,byte loai, string dk)
            {
                _TuNgay = tungay;
                _DenNgay = denngay;
                _makho = makho;
                _Loai = loai;
                _DK = dk;
                
            }
        }
      
        private void DataPortal_Fetch(Criteria criteria)
        {
            this.RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllPhieuNhap_HD(criteria.TuNgay, criteria.DenNgay, criteria.makho, criteria.Loai, criteria.DK,false)))
            {
                int i = 1;
                while (dr.Read())
                {
                    this.Add(PhieuNhap_HD.GetPhieuNhap_HD(dr,i));
                    i++;
                } dr.Close(); dr.Dispose();
            }
            this.RaiseListChangedEvents = true;
        }
    


        #endregion
    }
}
