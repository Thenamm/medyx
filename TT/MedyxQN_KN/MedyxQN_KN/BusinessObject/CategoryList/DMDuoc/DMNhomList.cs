using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMNhomList : ReadOnlyListBase<DMNhomList, DMNhom>
    {
        #region Factory Methods
        public static DMNhomList GetAllDMNhom(Byte _loai)
        {
            return DataPortal.Fetch<DMNhomList>(new Criteria(_loai));
        }

        private DMNhomList()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access
        #region Criteria
        [Serializable()]
        private class Criteria
        {
            //private int _id;
            //public int Id
            //{
            //    get
            //    {
            //        return _id;
            //    }
            //}
            //public Criteria(int mId)
            //{
            //    _id = mId;
            //}
            private Byte _Loai;
            public Byte Loai
            {
                get
                {
                    return _Loai;
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
            public Criteria(Byte mLoai)
            {
                _Loai = mLoai;
               
            }
        }
        #endregion
        private void DataPortal_Fetch(Criteria criteria)
        {
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMNhom(criteria.Loai ,  criteria.qadmin)))
            {
                int i = 1;
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMNhom item = new DMNhom(
     i,
     dr.GetString("MaNhom"),
     dr.GetString("MaNhomICD"),
     dr.GetString("TenNhom"),
     dr.GetByte("Cap"),
		 dr.GetString("MaMay"),
		 dr.GetBoolean ("Huy"),
     dr.GetSmartDate("NgaySD",false),
     dr.GetString("NguoiSD"), 
     dr.GetString("idparent"),
     dr.GetString("TenTa"),
     dr.GetString("hoten"),
     dr.GetByte("LOAI"),
     dr.GetString("ghichu"),
     dr.GetSmartDate("NgayLap", false) ,
     dr.GetString("NguoiLap") ,
     dr.GetSmartDate("NgayHuy", false) ,
     dr.GetString("NguoiHuy")
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
