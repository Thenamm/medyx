using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTBYT_TON_GETSKHOAListInfo : ReadOnlyListBase<DMTBYT_TON_GETSKHOAListInfo, DMTBYT_TON_GETSKHOAInfo>
    {
        #region Factory Methods
        public static DMTBYT_TON_GETSKHOAListInfo GetAllDMTBYT_TON_GETSKHOA(String MaKhoa, DateTime Thang, String dk)
        {
            return DataPortal.Fetch<DMTBYT_TON_GETSKHOAListInfo>(new Criteria( MaKhoa,  Thang,  dk));
        }

        private DMTBYT_TON_GETSKHOAListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
        [Serializable()]
        private class Criteria
        {
                DateTime    _Thang ;
	            
	            String _MaKhoa ;
                String _dk;
            //Boolean _dadung;
            public DateTime Thang
            {
                get
                {
                    return _Thang;
                }
            }
           
            public string MaKhoa
            {
                get
                {
                    return _MaKhoa;
                }
            }
          
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            //public bool Dadung
            //{
            //    get
            //    {
            //        return _dadung;
            //    }
            //}
            public Criteria(String mMaKhoa,DateTime mThang, String mdk)
            {
                         _Thang = mThang ;
                         _MaKhoa = mMaKhoa ;
                         _dk = mdk ;
            }
        }

        #endregion

       

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTBYT_TON_GETSKHOA(criteria.MaKhoa, criteria.Thang, criteria.dk)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTBYT_TON_GETSKHOAInfo item = new DMTBYT_TON_GETSKHOAInfo(
             i, 
             dr.GetString("MATB") ,
			 dr.GetString("MATBC") ,
			 dr.GetString("TENTB") ,
			 dr.GetString("TENDVT") ,
			 dr.GetDecimal("TONCK") ,
			 dr.GetDecimal("TONCKDT") ,
			 dr.GetDecimal("SLSUACHUA") ,
			 dr.GetDecimal("SLBAODUONG") ,
			 dr.GetDecimal("SLXINTHANHLY"),
			 dr.GetDecimal("GIANHAP"),
             dr.GetString("SerialNo"),
             dr.GetString("Model"),
               dr.GetString("CongSuatTK"),
             dr.GetInt32("SuDungDN"),
               dr.GetSmartDate("ngaybaoduong", true)
    
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
