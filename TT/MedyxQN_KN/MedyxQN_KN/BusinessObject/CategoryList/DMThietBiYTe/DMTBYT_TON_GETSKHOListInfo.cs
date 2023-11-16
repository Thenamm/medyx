using System;
using System.Collections.Generic;
using System.Text;
using Csla;
using Csla.Data;

namespace HTC.Business.CategoryList
{
    [Serializable()]
    public class DMTBYT_TON_GETSKHOListInfo : ReadOnlyListBase<DMTBYT_TON_GETSKHOListInfo, DMTBYT_TON_GETSKHOInfo>
    {
        #region Factory Methods
        public static DMTBYT_TON_GETSKHOListInfo GetAllDMTBYT_TON_GETSKHO(String MaKho, DateTime Thang, String dk)
        {
            return DataPortal.Fetch<DMTBYT_TON_GETSKHOListInfo>(new Criteria( MaKho,  Thang,  dk));
        }

		public static DMTBYT_TON_GETSKHOListInfo GetAllDMTBYT_VT_TON_GETSKHO(String MaKho, DateTime Thang, String dk)
		{
			return DataPortal.Fetch<DMTBYT_TON_GETSKHOListInfo>(new Criteria1(MaKho, Thang, dk));
		}

        private DMTBYT_TON_GETSKHOListInfo()
        {  /* Require use of factory methods */ }

        #endregion

        #region Data Access

        #region Criteria
        [Serializable()]
        private class Criteria
        {
                DateTime    _Thang ;
	            
	            String _MaKho ;
                String _dk;
            Boolean _dadung;
            public DateTime Thang
            {
                get
                {
                    return _Thang;
                }
            }
           
            public string MaKho
            {
                get
                {
                    return _MaKho;
                }
            }
          
            public string dk
            {
                get
                {
                    return _dk;
                }
            }
            public bool Dadung
            {
                get
                {
                    return _dadung;
                }
            }
            public Criteria(String mMaKho,DateTime mThang, String mdk)
            {
                         _Thang = mThang ;
                         _MaKho = mMaKho ;
                         _dk = mdk ;
            }
        }

		private class Criteria1
		{
			DateTime _Thang;

			String _MaKho;
			String _dk;
			Boolean _dadung;
			public DateTime Thang
			{
				get
				{
					return _Thang;
				}
			}

			public string MaKho
			{
				get
				{
					return _MaKho;
				}
			}

			public string dk
			{
				get
				{
					return _dk;
				}
			}
			public bool Dadung
			{
				get
				{
					return _dadung;
				}
			}
			public Criteria1(String mMaKho, DateTime mThang, String mdk)
			{
				_Thang = mThang;
				_MaKho = mMaKho;
				_dk = mdk;
			}
		}

        #endregion

       

        private void DataPortal_Fetch(Criteria criteria)
        {
            int i = 1;
            RaiseListChangedEvents = false;
            using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTBYT_TON_GETSKHO(criteria.MaKho, criteria.Thang, criteria.dk)))
            {
                IsReadOnly = false;
                while (dr.Read())
                {
                    DMTBYT_TON_GETSKHOInfo item = new DMTBYT_TON_GETSKHOInfo(
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
              dr.GetInt32 ("SuDungDN"),
               dr.GetSmartDate("ngaybaoduong", true)
		
         );
                    this.Add(item);
                    i += 1;
                }
                IsReadOnly = true;
            }
           

            RaiseListChangedEvents = true; //DataProvider.Instance().CloseDB();
        }

		private void DataPortal_Fetch(Criteria1 criteria)
		{
			int i = 1;
			RaiseListChangedEvents = false;
			using (SafeDataReader dr = new SafeDataReader(DataProvider.Instance().GetAllDMTBYT_VT_TON_GETSKHO(criteria.MaKho, criteria.Thang, criteria.dk)))
			{
				IsReadOnly = false;
				while (dr.Read())
				{
					DMTBYT_TON_GETSKHOInfo item = new DMTBYT_TON_GETSKHOInfo(
			 i,
			 dr.GetString("MATB"),
			 dr.GetString("MATBC"),
			 dr.GetString("TENTB"),
			 dr.GetString("TENDVT"),
			 dr.GetDecimal("TONCK"),
			 dr.GetDecimal("TONCKDT"),
			 dr.GetDecimal("SLSUACHUA"),
			 dr.GetDecimal("SLBAODUONG"),
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
